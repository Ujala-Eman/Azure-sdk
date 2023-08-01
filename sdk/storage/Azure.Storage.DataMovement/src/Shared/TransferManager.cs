﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.DataMovement.JobPlan;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// The main class for starting and controlling all types of transfers.
    /// </summary>
    public class TransferManager : IAsyncDisposable
    {
        // Indicates whether the current thread is processing Jobs.
        private static Task _currentTaskIsProcessingJob;

        // Indicates whether the current thread is processing Jobs Parts.
        private static Task _currentTaskIsProcessingJobPart;

        // Indicates whether the current thread is processing Jobs Chunks.
        private static Task _currentTaskIsProcessingJobChunk;

        /// <summary>
        /// Channel of Jobs waiting to divided into job parts/files.
        ///
        /// Limit 1 task to convert jobs to job parts.
        /// </summary>
        private Channel<TransferJobInternal> _jobsToProcessChannel { get; set; }

        /// <summary>
        /// Channel of Job parts / files to be divided into chunks / requests
        ///
        /// Limit 64 tasks to convert job parts to chunks.
        /// </summary>
        private Channel<JobPartInternal> _partsToProcessChannel { get; set; }

        /// <summary>
        /// Channel of Job chunks / requests to send to the service.
        ///
        /// Limit 4-300/Max amount of tasks allowed to process chunks.
        /// </summary>
        private Channel<Func<Task>> _chunksToProcessChannel { get; set; }

        /// <summary>
        /// This value can fluctuate depending on if we've reached max capacity
        /// Future capability for it to fluctuate based on throttling and bandwidth.
        /// </summary>
        internal int _maxJobChunkTasks;

        /// <summary>
        /// Ongoing transfers indexed at the transfer id.
        /// </summary>
        internal IDictionary<string, DataTransfer> _dataTransfers;

        /// <summary>
        /// Designated checkpointer for the respective transfer manager.
        ///
        /// If unspecified will default to LocalTransferCheckpointer at {currentpath}/.azstoragedml
        /// </summary>
        internal TransferCheckpointer _checkpointer;
        private TransferCheckpointerOptions _checkpointerOptions;

        /// <summary>
        /// Defines the error handling method to follow when an error is seen. Defaults to
        /// <see cref="ErrorHandlingBehavior.StopOnAllFailures"/>.
        ///
        /// See <see cref="ErrorHandlingBehavior"/>.
        /// </summary>
        internal ErrorHandlingBehavior _errorHandling;

        /// <summary>
        /// Cancels the channels operations when disposing.
        /// </summary>
        private CancellationTokenSource _channelCancellationTokenSource;
        private CancellationToken _cancellationToken => _channelCancellationTokenSource.Token;

        /// <summary>
        /// Array pools for reading from streams to upload
        /// </summary>
        internal ArrayPool<byte> UploadArrayPool => _arrayPool;
        private ArrayPool<byte> _arrayPool;

        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary>
        /// Protected constructor for mocking.
        /// </summary>
        protected TransferManager()
        { }

        /// <summary>
        /// Constructor to create a TransferManager.
        /// </summary>
        /// <param name="options">Options that will apply to all transfers started by this TransferManager.</param>
        public TransferManager(TransferManagerOptions options = default)
        {
            _channelCancellationTokenSource = new CancellationTokenSource();
            _jobsToProcessChannel = Channel.CreateUnbounded<TransferJobInternal>(
                new UnboundedChannelOptions()
                {
                    AllowSynchronousContinuations = true,
                    SingleReader = true, // To limit the task of processing one job at a time.
                    // Allow single writers
                });
            _partsToProcessChannel = Channel.CreateUnbounded<JobPartInternal>(
                new UnboundedChannelOptions()
                {
                    AllowSynchronousContinuations = true,
                });
            _chunksToProcessChannel = Channel.CreateUnbounded<Func<Task>>(
                new UnboundedChannelOptions()
                {
                    AllowSynchronousContinuations = true,
                });
            _currentTaskIsProcessingJob = Task.Run(() => NotifyOfPendingJobProcessing());
            _currentTaskIsProcessingJobPart = Task.Run(() => NotifyOfPendingJobPartProcessing());
            _currentTaskIsProcessingJobChunk = Task.Run(() => NotifyOfPendingJobChunkProcessing());
            _maxJobChunkTasks = options?.MaximumConcurrency ?? DataMovementConstants.MaxJobChunkTasks;
            _checkpointerOptions = options?.CheckpointerOptions != default ? new TransferCheckpointerOptions(options.CheckpointerOptions) : default;
            _checkpointer = _checkpointerOptions != default ? _checkpointerOptions.GetCheckpointer() : CreateDefaultCheckpointer();
            _dataTransfers = new Dictionary<string, DataTransfer>();
            _arrayPool = ArrayPool<byte>.Shared;
            _errorHandling = options?.ErrorHandling != default ? options.ErrorHandling : ErrorHandlingBehavior.StopOnAllFailures;
            ClientDiagnostics = new ClientDiagnostics(options?.ClientOptions ?? ClientOptions.Default);
        }

        #region Job Channel Management
        internal async Task QueueJobAsync(TransferJobInternal job)
        {
            await _jobsToProcessChannel.Writer.WriteAsync(
                job,
                cancellationToken: _cancellationToken).ConfigureAwait(false);
        }

        // Inform the Reader that there's work to be executed for this Channel.
        private async Task NotifyOfPendingJobProcessing()
        {
            // Process all available items in the queue.
            while (await _jobsToProcessChannel.Reader.WaitToReadAsync(_cancellationToken).ConfigureAwait(false))
            {
                TransferJobInternal item = await _jobsToProcessChannel.Reader.ReadAsync(_cancellationToken).ConfigureAwait(false);
                // Execute the task we pulled out of the queue
                await foreach (JobPartInternal partItem in item.ProcessJobToJobPartAsync().ConfigureAwait(false))
                {
                    item.QueueJobPart();
                    await QueueJobPartAsync(partItem).ConfigureAwait(false);
                }
            }
        }
        #endregion Job Channel Management

        #region Job Part Channel Management
        internal async Task QueueJobPartAsync(JobPartInternal part)
        {
            await _partsToProcessChannel.Writer.WriteAsync(part).ConfigureAwait(false);
        }

        // Inform the Reader that there's work to be executed for this Channel.
        private async Task NotifyOfPendingJobPartProcessing()
        {
            List<Task> chunkRunners = new List<Task>(DataMovementConstants.MaxJobPartReaders);
            while (await _partsToProcessChannel.Reader.WaitToReadAsync(_cancellationToken).ConfigureAwait(false))
            {
                JobPartInternal item = await _partsToProcessChannel.Reader.ReadAsync(_cancellationToken).ConfigureAwait(false);
                if (chunkRunners.Count >= DataMovementConstants.MaxJobPartReaders)
                {
                    // Clear any completed blocks from the task list
                    int removedRunners = chunkRunners.RemoveAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted);
                    // If no runners have finished..
                    if (removedRunners == 0)
                    {
                        // Wait for at least one runner to finish
                        await Task.WhenAny(chunkRunners).ConfigureAwait(false);
                        chunkRunners.RemoveAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted);
                    }
                }
                // Execute the task we pulled out of the queue
                item.SetQueueChunkDelegate(async (item) => await QueueJobChunkAsync(item).ConfigureAwait(false));
                Task task = item.ProcessPartToChunkAsync();

                // Add task to Chunk Runner to keep track of how many are running
                chunkRunners.Add(task);
            }
        }
        #endregion Job Part Channel Management

        #region Job Chunk Management
        internal async Task QueueJobChunkAsync(Func<Task> item)
        {
            await _chunksToProcessChannel.Writer.WriteAsync(item).ConfigureAwait(false);
        }

        private async Task NotifyOfPendingJobChunkProcessing()
        {
            List<Task> _currentChunkTasks = new List<Task>(DataMovementConstants.MaxJobChunkTasks);
            while (await _chunksToProcessChannel.Reader.WaitToReadAsync(_cancellationToken).ConfigureAwait(false))
            {
                Func<Task> item = await _chunksToProcessChannel.Reader.ReadAsync(_cancellationToken).ConfigureAwait(false);
                // If we run out of workers
                if (_currentChunkTasks.Count >= _maxJobChunkTasks)
                {
                    if (_currentChunkTasks.Exists(x => x.IsCompleted || x.IsCanceled || x.IsFaulted))
                    {
                        // Clear any completed blocks from the task list
                        _currentChunkTasks.RemoveAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted);
                    }
                    else
                    {
                        await Task.WhenAny(_currentChunkTasks).ConfigureAwait(false);
                        _currentChunkTasks.RemoveAll(x => x.IsCompleted || x.IsCanceled || x.IsFaulted);
                    }
                }

                // Execute the task we pulled out of the queue
                Task task = Task.Run(item);
                _currentChunkTasks.Add(task);
            }
        }
        #endregion Job Chunk Management

        #region Transfer Job Management
        /// <summary>
        /// Attempts to pause the transfer of the respective id.
        /// </summary>
        /// <param name="transferId">The id of the transfer to pause.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be canceled.
        /// </param>
        /// <returns>
        /// Return true once the transfer has been successfully paused or false if the transfer
        /// was already completed.
        /// </returns>
        public virtual async Task PauseTransferIfRunningAsync(string transferId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(transferId, nameof(transferId));
            if (!_dataTransfers.TryGetValue(transferId, out DataTransfer transfer))
            {
                throw Errors.InvalidTransferId(nameof(PauseTransferIfRunningAsync), transferId);
            }
            await transfer.PauseIfRunningAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the current transfers stored in the <see cref="TransferManager"/>.
        /// </summary>
        /// <param name="filterByStatus">
        /// If specified, the returned list of transfers will have only have the transfers
        /// of which match the status specified.
        ///
        /// If not specified or specified to <see cref="StorageTransferStatus.None"/>,
        /// all transfers will be returned regardless of status.
        /// </param>
        /// <returns></returns>
        public virtual async IAsyncEnumerable<DataTransfer> GetTransfersAsync(
            params StorageTransferStatus[] filterByStatus)
        {
            await SetDataTransfers().ConfigureAwait(false);
            IEnumerable<DataTransfer> totalTransfers;
            if (filterByStatus == default || filterByStatus.Length == 0)
            {
                totalTransfers = _dataTransfers.Select(d => d.Value);
            }
            else
            {
                totalTransfers = _dataTransfers
                    .Select(d => d.Value)
                    .Where(x => filterByStatus.Contains(x.TransferStatus)).ToList();
            }
            foreach (DataTransfer transfer in totalTransfers)
            {
                yield return transfer;
            }
        }

        /// <summary>
        /// Lists all the transfers stored in the checkpointer that can be resumed.
        /// </summary>
        /// <returns>
        /// List of <see cref="DataTransferProperties"/> objects that can be used to rebuild resources
        /// to resume with.
        /// </returns>
        public virtual async IAsyncEnumerable<DataTransferProperties> GetResumableTransfersAsync()
        {
            List<string> storedTransfers = await _checkpointer.GetStoredTransfersAsync().ConfigureAwait(false);
            foreach (string transferId in storedTransfers)
            {
                StorageTransferStatus jobStatus = (StorageTransferStatus) await _checkpointer.GetByteValue(
                    transferId,
                    DataMovementConstants.PlanFile.AtomicJobStatusIndex,
                    _cancellationToken).ConfigureAwait(false);

                // Transfers marked as fully completed are not resumable
                if (jobStatus == StorageTransferStatus.Completed)
                {
                    continue;
                }

                (string sourceResourceId, string destResourceId) = await _checkpointer.GetResourceIdsAsync(
                    transferId,
                    _cancellationToken).ConfigureAwait(false);

                (string sourcePath, string destPath) = await _checkpointer.GetResourcePathsAsync(
                    transferId,
                    _cancellationToken).ConfigureAwait(false);

                bool isContainer =
                    (await _checkpointer.CurrentJobPartCountAsync(transferId, _cancellationToken).ConfigureAwait(false)) > 1;

                yield return new DataTransferProperties
                {
                    TransferId = transferId,
                    SourceTypeId = sourceResourceId,
                    SourcePath = sourcePath,
                    DestinationTypeId = destResourceId,
                    DestinationPath = destPath,
                    IsContainer = isContainer,
                    Checkpointer = _checkpointerOptions,
                };
            }
        }

        /// <summary>
        /// Resumes a transfer that has been paused or is in a completed state with failed or skipped transfers.
        /// </summary>
        /// <param name="transferId">The transfer ID of the transfer attempting to be resumed.</param>
        /// <param name="sourceResource">A <see cref="StorageResource"/> representing the source.</param>
        /// <param name="destinationResource">A <see cref="StorageResource"/> representing the destination.</param>
        /// <param name="transferOptions">Options specific to this transfer.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>Returns a <see cref="DataTransfer"/> for tracking this transfer.</returns>
        public virtual async Task<DataTransfer> ResumeTransferAsync(
            string transferId,
            StorageResource sourceResource,
            StorageResource destinationResource,
            TransferOptions transferOptions = default,
            CancellationToken cancellationToken = default)
        {
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
            Argument.AssertNotNullOrWhiteSpace(transferId, nameof(transferId));
            Argument.AssertNotNull(sourceResource, nameof(sourceResource));
            Argument.AssertNotNull(destinationResource, nameof(destinationResource));

            transferOptions ??= new TransferOptions();

            if (_dataTransfers.ContainsKey(transferId))
            {
                // Remove the stale DataTransfer so we can pass a new DataTransfer object
                // to the user and also track the transfer from the DataTransfer object
                _dataTransfers.Remove(transferId);
            }

            DataTransfer dataTransfer = await BuildAndAddTransferJobAsync(
                sourceResource,
                destinationResource,
                transferOptions,
                transferId,
                true,
                cancellationToken).ConfigureAwait(false);

            return dataTransfer;
        }

        /// <summary>
        /// Attempts to pause all the ongoing transfers.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal virtual async Task PauseAllRunningTransfersAsync(CancellationToken cancellationToken = default)
        {
            await Task.WhenAll(_dataTransfers.Values
                .Where(transfer => transfer.CanPause())
                .Select(transfer => transfer.PauseIfRunningAsync(cancellationToken)))
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Attempts to remove the transfer of the respective id. Will remove it does exist and has not completed.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal virtual Task<bool> TryRemoveTransferAsync(string id)
        {
            throw new NotImplementedException();
        }
        #endregion Transfer Job Management

        #region Start Transfer
        /// <summary>
        /// Starts a transfer from the given source resource to the given destination resource.
        /// </summary>
        /// <param name="sourceResource">A <see cref="StorageResource"/> representing the source.</param>
        /// <param name="destinationResource">A <see cref="StorageResource"/> representing the destination.</param>
        /// <param name="transferOptions">Options specific to this transfer.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>Returns a <see cref="DataTransfer"/> for tracking this transfer.</returns>
        public virtual async Task<DataTransfer> StartTransferAsync(
            StorageResource sourceResource,
            StorageResource destinationResource,
            TransferOptions transferOptions = default,
            CancellationToken cancellationToken = default)
        {
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
            Argument.AssertNotNull(sourceResource, nameof(sourceResource));
            Argument.AssertNotNull(destinationResource, nameof(destinationResource));

            transferOptions ??= new TransferOptions();

            string transferId = Guid.NewGuid().ToString();
            await _checkpointer.AddNewJobAsync(transferId, _cancellationToken).ConfigureAwait(false);

            DataTransfer dataTransfer = await BuildAndAddTransferJobAsync(
                sourceResource,
                destinationResource,
                transferOptions,
                transferId,
                false,
                cancellationToken).ConfigureAwait(false);

            return dataTransfer;
        }

        private async Task<DataTransfer> BuildAndAddTransferJobAsync(
            StorageResource sourceResource,
            StorageResource destinationResource,
            TransferOptions transferOptions,
            string transferId,
            bool resumeJob,
            CancellationToken cancellationToken)
        {
            DataTransfer dataTransfer = new DataTransfer(id: transferId, transferManager: this);
            _dataTransfers.Add(dataTransfer.Id, dataTransfer);

            TransferJobInternal transferJobInternal;

            // Single transfer
            if (sourceResource is StorageResourceSingle &&
                destinationResource is StorageResourceSingle)
            {
                transferJobInternal = await BuildSingleTransferJob(
                    (StorageResourceSingle)sourceResource,
                    (StorageResourceSingle)destinationResource,
                    transferOptions,
                    dataTransfer,
                    resumeJob).ConfigureAwait(false);
            }
            // Container transfer
            else if (sourceResource is StorageResourceContainer &&
                destinationResource is StorageResourceContainer)
            {
                transferJobInternal = await BuildContainerTransferJob(
                    (StorageResourceContainer)sourceResource,
                    (StorageResourceContainer)destinationResource,
                    transferOptions,
                    dataTransfer,
                    resumeJob).ConfigureAwait(false);
            }
            // Invalid transfer
            else
            {
                throw Errors.InvalidTransferResourceTypes();
            }
            // Queue Job
            await QueueJobAsync(transferJobInternal).ConfigureAwait(false);

            return dataTransfer;
        }

        private async Task<TransferJobInternal> BuildSingleTransferJob(
            StorageResourceSingle sourceResource,
            StorageResourceSingle destinationResource,
            TransferOptions transferOptions,
            DataTransfer dataTransfer,
            bool resumeJob)
        {
            // If the resource cannot produce a Uri, it means it can only produce a local path
            // From here we only support an upload job
            if (!sourceResource.CanProduceUri)
            {
                if (destinationResource.CanProduceUri)
                {
                    // Stream to Uri job (Upload Job)
                    StreamToUriTransferJob streamToUriJob = new StreamToUriTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        checkpointer: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        using (Stream stream = await _checkpointer.ReadableStreamAsync(
                            transferId: dataTransfer.Id,
                            partNumber: 0,
                            offset: 0,
                            readSize: 0,
                            cancellationToken: _cancellationToken).ConfigureAwait(false))
                        {
                            streamToUriJob.AppendJobPart(
                                await streamToUriJob.ToJobPartAsync(
                                    stream,
                                    sourceResource,
                                    destinationResource).ConfigureAwait(false));
                        }
                    }
                    return streamToUriJob;
                }
                else // Invalid argument that both resources do not produce a Uri
                {
                    throw Errors.InvalidSourceDestinationParams();
                }
            }
            else
            {
                // Source is remote
                if (destinationResource.CanProduceUri)
                {
                    // Service to Service Job (Copy job)
                    ServiceToServiceTransferJob serviceToServiceJob = new ServiceToServiceTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        CheckPointFolderPath: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        using (Stream stream = await _checkpointer.ReadableStreamAsync(
                            transferId: dataTransfer.Id,
                            partNumber: 0,
                            offset: 0,
                            readSize: 0,
                            cancellationToken: _cancellationToken).ConfigureAwait(false))
                        {
                            serviceToServiceJob.AppendJobPart(
                                await serviceToServiceJob.ToJobPartAsync(
                                    stream,
                                    sourceResource,
                                    destinationResource).ConfigureAwait(false));
                        }
                    }
                    return serviceToServiceJob;
                }
                else
                {
                    // Download to local operation
                    // Service to Local job (Download Job)
                    UriToStreamTransferJob uriToStreamJob = new UriToStreamTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        checkpointer: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        using (Stream stream = await _checkpointer.ReadableStreamAsync(
                            transferId: dataTransfer.Id,
                            partNumber: 0,
                            offset: 0,
                            readSize: 0,
                            cancellationToken: _cancellationToken).ConfigureAwait(false))
                        {
                            uriToStreamJob.AppendJobPart(
                                await uriToStreamJob.ToJobPartAsync(
                                    stream,
                                    sourceResource,
                                    destinationResource).ConfigureAwait(false));
                        }
                    }
                    return uriToStreamJob;
                }
            }
        }

        private async Task<TransferJobInternal> BuildContainerTransferJob(
            StorageResourceContainer sourceResource,
            StorageResourceContainer destinationResource,
            TransferOptions transferOptions,
            DataTransfer dataTransfer,
            bool resumeJob)
        {
            // If the resource cannot produce a Uri, it means it can only produce a local path
            // From here we only support an upload job
            if (!sourceResource.CanProduceUri)
            {
                if (destinationResource.CanProduceUri)
                {
                    // Stream to Uri job (Upload Job)
                    StreamToUriTransferJob streamToUriJob = new StreamToUriTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        checkpointer: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        // Iterate through all job parts and append to the job
                        int jobPartCount = await _checkpointer.CurrentJobPartCountAsync(
                            transferId: dataTransfer.Id,
                            cancellationToken: _cancellationToken).ConfigureAwait(false);
                        for (var currentJobPart = 0; currentJobPart < jobPartCount; currentJobPart++)
                        {
                            using (Stream stream = await _checkpointer.ReadableStreamAsync(
                                transferId: dataTransfer.Id,
                                partNumber: currentJobPart,
                                offset: 0,
                                readSize: 0,
                                cancellationToken: _cancellationToken).ConfigureAwait(false))
                            {
                                streamToUriJob.AppendJobPart(
                                    await streamToUriJob.ToJobPartAsync(
                                        stream,
                                        sourceResource,
                                        destinationResource).ConfigureAwait(false));
                            }
                        }
                    }
                    return streamToUriJob;
                }
                else // Invalid argument that both resources do not produce a Uri
                {
                    throw Errors.InvalidSourceDestinationParams();
                }
            }
            else
            {
                // Source is remote
                if (destinationResource.CanProduceUri)
                {
                    // Service to Service Job (Copy job)
                    ServiceToServiceTransferJob serviceToServiceJob = new ServiceToServiceTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        checkpointer: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        // Iterate through all job parts and append to the job
                        int jobPartCount = await _checkpointer.CurrentJobPartCountAsync(
                            transferId: dataTransfer.Id,
                            cancellationToken: _cancellationToken).ConfigureAwait(false);
                        for (var currentJobPart = 0; currentJobPart < jobPartCount; currentJobPart++)
                        {
                            using (Stream stream = await _checkpointer.ReadableStreamAsync(
                                transferId: dataTransfer.Id,
                                partNumber: currentJobPart,
                                offset: 0,
                                readSize: 0,
                                cancellationToken: _cancellationToken).ConfigureAwait(false))
                            {
                                serviceToServiceJob.AppendJobPart(
                                    await serviceToServiceJob.ToJobPartAsync(
                                    stream,
                                    sourceResource,
                                    destinationResource).ConfigureAwait(false));
                            }
                        }
                    }
                    return serviceToServiceJob;
                }
                else
                {
                    // Download to local operation
                    // Service to Local job (Download Job)
                    UriToStreamTransferJob uriToStreamJob = new UriToStreamTransferJob(
                        dataTransfer: dataTransfer,
                        sourceResource: sourceResource,
                        destinationResource: destinationResource,
                        transferOptions: transferOptions,
                        queueChunkTask: QueueJobChunkAsync,
                        checkpointer: _checkpointer,
                        errorHandling: _errorHandling,
                        arrayPool: _arrayPool,
                        clientDiagnostics: ClientDiagnostics);

                    if (resumeJob)
                    {
                        // Iterate through all job parts and append to the job
                        int jobPartCount = await _checkpointer.CurrentJobPartCountAsync(
                            transferId: dataTransfer.Id,
                            cancellationToken: _cancellationToken).ConfigureAwait(false);
                        for (var currentJobPart = 0; currentJobPart < jobPartCount; currentJobPart++)
                        {
                            using (Stream stream = await _checkpointer.ReadableStreamAsync(
                                transferId: dataTransfer.Id,
                                partNumber: currentJobPart,
                                offset: 0,
                                readSize: 0,
                                cancellationToken: _cancellationToken).ConfigureAwait(false))
                            {
                                uriToStreamJob.AppendJobPart(
                                    await uriToStreamJob.ToJobPartAsync(
                                    stream,
                                    sourceResource,
                                    destinationResource).ConfigureAwait(false));
                            }
                        }
                    }
                    return uriToStreamJob;
                }
            }
        }
        #endregion

        /// <summary>
        /// Returns a default checkpointer if not specified by the user already.
        ///
        /// By default a local folder will be used to store the job transfer files.
        /// </summary>
        /// <returns>
        /// A <see cref="LocalTransferCheckpointer"/> using the folder
        /// where the application is stored with and making a new folder called
        /// .azstoragedml to store all the job plan files.
        /// </returns>
        private static LocalTransferCheckpointer CreateDefaultCheckpointer()
        {
            // Return checkpointer
            return new LocalTransferCheckpointer(default);
        }

        private async Task SetDataTransfers()
        {
            _dataTransfers.Clear();
            List<string> storedTransfers = await _checkpointer.GetStoredTransfersAsync().ConfigureAwait(false);
            foreach (string transferId in storedTransfers)
            {
                int jobPartCount = await _checkpointer.CurrentJobPartCountAsync(
                            transferId: transferId,
                            cancellationToken: _cancellationToken).ConfigureAwait(false);

                JobPartPlanHeader header;
                using (Stream stream = await _checkpointer.ReadableStreamAsync(
                            transferId: transferId,
                            partNumber: 0,
                            offset: 0,
                            readSize: 0,
                            cancellationToken: _cancellationToken).ConfigureAwait(false))
                {
                    // Convert stream to job plan header
                    header = JobPartPlanHeader.Deserialize(stream);
                }

                // Verify the contents of the header
                // Check transfer id
                if (!header.TransferId.Equals(transferId))
                {
                    throw Errors.MismatchTransferId(transferId, header.TransferId);
                }

                _dataTransfers.Add(transferId, new DataTransfer(
                    id: transferId,
                    transferManager: this,
                    status: header.AtomicJobStatus));
            }
        }

        /// <summary>
        /// Disposes.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/> of disposing the <see cref="TransferManager"/>.</returns>
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (!_channelCancellationTokenSource.IsCancellationRequested)
            {
                _channelCancellationTokenSource.Cancel();
            }
            GC.SuppressFinalize(this);
            return default;
        }
    }
}
