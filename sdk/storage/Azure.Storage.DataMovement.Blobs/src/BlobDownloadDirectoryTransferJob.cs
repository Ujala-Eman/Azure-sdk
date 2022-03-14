﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.DataMovement.Blobs.Models;
using Azure.Storage.Blobs;
using Azure.Core.Pipeline;

namespace Azure.Storage.DataMovement.Blobs
{
    /// <summary>
    /// Blob Directory Download Transfer Job
    /// </summary>
    internal class BlobDownloadDirectoryTransferJob : BlobTransferJobInternal
    {
        /// <summary>
        /// Holds Source Blob Configurations
        /// </summary>
        public BlobClientConfiguration SourceBlobConfiguration;

        /// <summary>
        /// The source blob where it's contents will be downloaded when the job is performed.
        /// </summary>
        internal BlobVirtualDirectoryClient SourceBlobDirectoryClient;

        /// <summary>
        /// Local Path to store the downloaded contents from the source blob
        /// </summary>
        private string _destinationLocalPath;

        /// <summary>
        /// Gets the local Path to store the downloaded contents from the source blob
        /// </summary>
        public string DestinationLocalPath => _destinationLocalPath;

        /// <summary>
        /// The <see cref="StorageTransferOptions"/>.
        /// </summary>
        private BlobDirectoryDownloadOptions _options;

        /// <summary>
        /// The <see cref="BlobDirectoryDownloadOptions"/>.
        /// </summary>
        protected internal BlobDirectoryDownloadOptions Options => _options;

        /// <summary>
        /// Creates Download Transfer Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="sourceClient"></param>
        /// <param name="destinationPath"></param>
        /// <param name="options"></param>
        public BlobDownloadDirectoryTransferJob(
            string jobId,
            BlobVirtualDirectoryClient sourceClient,
            string destinationPath,
            BlobDirectoryDownloadOptions options)
            : base(jobId)
        {
            // Should we worry about concurrency issue and people using the client they pass elsewhere?
            _destinationLocalPath = destinationPath;
            SourceBlobDirectoryClient = sourceClient;
            SourceBlobConfiguration = new BlobClientConfiguration()
            {
                BlobContainerName = sourceClient.BlobContainerName,
                AccountName = sourceClient.AccountName,
                Name = sourceClient.DirectoryPath
            };
            _options = options;
        }

        /// <summary>
        /// Create next TransferItem/Task to be processed.
        /// </summary>
        /// <param name="blobName">Name of the blob in the directory that will be downloaded</param>
        /// <returns>The Task to perform the Upload operation.</returns>
        public async Task<Response> GetSingleDownloadTaskAsync(string blobName)
        {
            BlockBlobClient blockBlobClient = SourceBlobDirectoryClient.GetBlockBlobClient(blobName);
            string downloadPath = Path.Combine(DestinationLocalPath, blobName);

            Directory.CreateDirectory(Path.GetDirectoryName(downloadPath));
            Response response;
            using (Stream destination = File.Create(downloadPath))
            {
                response = await blockBlobClient.DownloadToAsync(
                    downloadPath,
                    default,
                    Options.TransferOptions)
                    .ConfigureAwait(false);
            }
            return response;
        }

#pragma warning disable CA1801 // Review unused parameters
        public Action ProcessDirectoryTransfer(TaskFactory taskFactory, BlobJobTransferScheduler scheduler, bool async = true)
#pragma warning restore CA1801 // Review unused parameters
        {
            return () =>
            {
                /* TODO: move this to Core.Diagnostics Logger
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Begin enumerating files within source directory: {transferJob.SourceBlobDirectoryClient.DirectoryPath}",
                        false).EnsureCompleted();
                    */
                Pageable<BlobItem> blobs = SourceBlobDirectoryClient.GetBlobs();
                /* TODO: move this to Core.Diagnostics Logger
                transferJob.Logger.LogAsync(
                    logLevel: DataMovementLogLevel.Information,
                    message: $"Completed enumerating files within source directory: {transferJob.SourceBlobDirectoryClient.DirectoryPath}\n",
                    false).EnsureCompleted();
                */
                List<Task> fileUploadTasks = new List<Task>();
                foreach (BlobItem blob in blobs)
                {
                    Task singleDownloadTask = taskFactory.StartNew(
                        ProcessSingleDownloadTransfer(blob.Name),
                        cancellationToken: CancellationTokenSource.Token,
                        creationOptions: TaskCreationOptions.LongRunning,
                        scheduler: scheduler);
                    fileUploadTasks.Add(singleDownloadTask);
                }
                /* TODO: move this to Core.Diagnostics Logger
                transferJob.Logger.LogAsync(
                    logLevel: DataMovementLogLevel.Information,
                    message: $"Created all upload tasks for the source directory: {transferJob.SourceBlobDirectoryClient.DirectoryPath} to upload to the destination directory: {transferJob.DestinationLocalPath}",
                    false).EnsureCompleted();
                */
                // Wait for all the remaining blobs to finish upload before logging that the transfer has finished.
                Task.WhenAll(fileUploadTasks).Wait();
                /* TODO: move this to Core.Diagnostics Logger
                transferJob.Logger.LogAsync(
                    logLevel: DataMovementLogLevel.Information,
                    message: $"Completed all upload tasks for the source directory: {transferJob.SourceBlobDirectoryClient.DirectoryPath} and uploaded to the destination directory: {transferJob.DestinationLocalPath}",
                    false).EnsureCompleted();
                */
            };
        }

        /// <summary>
        /// Process Single Download Transfer
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="async"></param>
        /// <returns></returns>
#pragma warning disable CA1801 // Review unused parameters
        public Action ProcessSingleDownloadTransfer(string blobName, bool async = true)
#pragma warning restore CA1801 // Review unused parameters
        {
            return () =>
            {
                BlobClient blobClient = SourceBlobDirectoryClient.GetBlobClient(blobName);
                string downloadPath = Path.Combine(DestinationLocalPath, blobName);

                // TODO: make logging messages similar to the errors class where we only take in params
                // so we dont have magic strings hanging out here

                /* TODO: replace with Azure.Core.Diagnotiscs logger
                Logger.LogAsync(DataMovementLogLevel.Information,
                    $"Processing Download Directory Transfer source: {SourceBlobDirectoryClient.Uri.AbsoluteUri}; destination: {DestinationLocalPath}",
                    async).EnsureCompleted();
                */
                // Do only blockblob upload for now for now

                BlobDownloadToOptions blobDownloadOptions = new BlobDownloadToOptions()
                {
                    TransferOptions = Options.TransferOptions,
                    TransactionalHashingOptions = Options.TransactionalHashingOptions,
                };

                try
                {
                    Response response = blobClient.DownloadTo(
                        path: downloadPath,
                        options: blobDownloadOptions,
                        CancellationTokenSource.Token);
                    if (response != null)
                    {
                        /* TODO: replace with Azure.Core.Diagnotiscs logger
                        Logger.LogAsync(DataMovementLogLevel.Information,
                            $"Transfer succeeded on from source:{SourceBlobDirectoryClient.Uri.AbsoluteUri} to destination:{DestinationLocalPath}",
                            async).EnsureCompleted();
                        */
                    }
                    else
                    {
                        /* TODO: replace with Azure.Core.Diagnotiscs logger
                        Logger.LogAsync(DataMovementLogLevel.Error,
                            $"Download Directory Transfer Failed due to unknown reasons. Download Directory Transfer returned null results",
                            async).EnsureCompleted();
                        */
                    }
                }
                //TODO: catch other type of exceptions and handle gracefully
#pragma warning disable CS0168 // Variable is declared but never used
                catch (RequestFailedException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    /* TODO: replace with Azure.Core.Diagnotiscs logger
                    Logger.LogAsync(DataMovementLogLevel.Error, $"Download Directory Transfer Failed due to the following: {ex.ErrorCode}: {ex.Message}", async).EnsureCompleted();
                    */
                    // Progress Handling is already done by the upload call
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    /* TODO: replace with Azure.Core.Diagnotiscs logger
                    Logger.LogAsync(DataMovementLogLevel.Error, $"Download Directory Transfer Failed due to the following: {ex.Message}", async).EnsureCompleted();
                    */
                    // Progress Handling is already done by the upload call
                }
            };
        }

        /// <summary>
        /// Translates job details
        /// </summary>
        public override BlobTransferJobProperties GetJobDetails()
        {
            return this.ToBlobTransferJobDetails();
        }

        /// <summary>
        /// Resumes respective job
        /// </summary>
        /// <param name="taskFactory"></param>
        /// <param name="scheduler"></param>
        /// <param name="credential"></param>
        /// <returns></returns>
        public override Action ProcessResumeTransfer(
            TaskFactory taskFactory,
            BlobJobTransferScheduler scheduler,
            ResumeTransferCredentials credential = default)
        {
            if (credential?.SourceTransferCredential != default)
            {
                if (!string.IsNullOrEmpty(credential.SourceTransferCredential.ConnectionString))
                {
                    // Check if an endpoint was passed in the connection string and if that matches the original source uri
                    StorageConnectionString parsedConnectionString = StorageConnectionString.Parse(credential.SourceTransferCredential.ConnectionString);
                    BlobUriBuilder sourceUriBuilder = new BlobUriBuilder(SourceBlobDirectoryClient.Uri);

                    if (parsedConnectionString.BlobEndpoint.Host == sourceUriBuilder.Host)
                    {
                        SourceBlobDirectoryClient = new BlobVirtualDirectoryClient(
                            credential.SourceTransferCredential.ConnectionString,
                            SourceBlobConfiguration.BlobContainerName,
                            SourceBlobConfiguration.Name,
                            BlobVirtualDirectoryClientInternals.GetClientOptions(SourceBlobDirectoryClient));
                    }
                    else
                    {
                        // Mismatch in storage account host in the URL
                        throw Errors.InvalidConnectionString();
                    }
                }
                else if (credential.SourceTransferCredential.SasCredential != default)
                {
                    SourceBlobDirectoryClient = new BlobVirtualDirectoryClient(
                        SourceBlobConfiguration.Uri,
                        credential.SourceTransferCredential.SasCredential,
                        BlobVirtualDirectoryClientInternals.GetClientOptions(SourceBlobDirectoryClient));
                }
                else if (credential.SourceTransferCredential.SharedKeyCredential != default)
                {
                    SourceBlobDirectoryClient = new BlobVirtualDirectoryClient(
                        SourceBlobConfiguration.Uri,
                        credential.SourceTransferCredential.SharedKeyCredential,
                        BlobVirtualDirectoryClientInternals.GetClientOptions(SourceBlobDirectoryClient));
                }
                else if (credential.SourceTransferCredential.TokenCredential != default)
                {
                    SourceBlobDirectoryClient = new BlobVirtualDirectoryClient(
                        SourceBlobConfiguration.Uri,
                        credential.SourceTransferCredential.TokenCredential,
                        BlobVirtualDirectoryClientInternals.GetClientOptions(SourceBlobDirectoryClient));
                }
                else
                {
                    throw Errors.InvalidArgument(nameof(credential));
                }
            }
            // TODO: do we throw an error if they specify the destination?
            // Read in Job Plan File
            // JobPlanReader.Read(file)
            return ProcessDirectoryTransfer(taskFactory, scheduler);
        }
    }
}
