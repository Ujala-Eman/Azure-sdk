﻿using Microsoft.Azure.Batch.Conventions.Files.Utilities;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Batch.Conventions.Files
{
    // Represents a storage path within Azure Storage - that is, either job storage
    // ({container}) or task storage ({container}/{taskId}). Private derived classes
    // represent the two kinds of path.
    internal abstract class StoragePath
    {
        private readonly CloudBlobContainer _jobOutputContainer;

        protected StoragePath(CloudBlobContainer jobOutputContainer)
        {
            if (jobOutputContainer == null)
            {
                throw new ArgumentNullException(nameof(jobOutputContainer));
            }

            _jobOutputContainer = jobOutputContainer;
        }

        // Uploads a file to blob storage.
        public async Task SaveAsync(
            IOutputKind kind,
            DirectoryInfo baseFolder,
            string relativePath,
            CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            Debug.Assert(baseFolder != null);

            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Validate.IsNotNullOrEmpty(relativePath, nameof(relativePath));

            if (Path.IsPathRooted(relativePath))
            {
                throw new ArgumentException($"{nameof(relativePath)} must not be a relative path", nameof(relativePath));
            }

            string sourcePath = Path.Combine(baseFolder.FullName, relativePath);
            string destinationPath = GetDestinationBlobPath(relativePath);

            await SaveAsync(kind, sourcePath, destinationPath, cancellationToken);
        }

        // Uploads a file to blob storage.
        public async Task SaveAsync(
            IOutputKind kind,
            string sourcePath,
            string destinationRelativePath,
            CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Validate.IsNotNullOrEmpty(sourcePath, nameof(sourcePath));
            Validate.IsNotNullOrEmpty(destinationRelativePath, nameof(destinationRelativePath));

            var blobName = BlobName(kind, destinationRelativePath);
            var blob = _jobOutputContainer.GetBlockBlobReference(blobName);
            await blob.UploadFromFileAsync(sourcePath, FileMode.Open, cancellationToken);
        }

        // Uploads text to blob storage.
        public async Task SaveTextAsync(
            IOutputKind kind,
            string text,
            string destinationRelativePath,
            CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Validate.IsNotNullOrEmpty(destinationRelativePath, nameof(destinationRelativePath));

            var blobName = BlobName(kind, destinationRelativePath);
            var blob = _jobOutputContainer.GetBlockBlobReference(blobName);
            await blob.UploadTextAsync(text, cancellationToken);
        }

        // Uploads a file and tracks appends to that file. The implementation creates an append blob to
        // contain the file contents, then creates a file tracking object which runs a background operation
        // to upload the file to the append blob, then track appends to the file and append them to the blob.
        public async Task<TrackedFile> SaveTrackedAsync(IOutputKind kind, string relativePath, TimeSpan flushInterval)
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Validate.IsNotNullOrEmpty(relativePath, nameof(relativePath));

            if (Path.IsPathRooted(relativePath))
            {
                throw new ArgumentException($"{nameof(relativePath)} must not be a relative path", nameof(relativePath));
            }

            var destinationPath = GetDestinationBlobPath(relativePath);
            return await SaveTrackedAsync(kind, relativePath, destinationPath, flushInterval);
        }

        // Uploads a file and tracks appends to that file. The implementation creates an append blob to
        // contain the file contents, then creates a file tracking object which runs a background operation
        // to upload the file to the append blob, then track appends to the file and append them to the blob.
        public async Task<TrackedFile> SaveTrackedAsync(IOutputKind kind, string sourcePath, string destinationRelativePath, TimeSpan flushInterval)
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Validate.IsNotNullOrEmpty(sourcePath, nameof(sourcePath));
            Validate.IsNotNullOrEmpty(destinationRelativePath, nameof(destinationRelativePath));

            var blobName = BlobName(kind, destinationRelativePath);
            var blob = _jobOutputContainer.GetAppendBlobReference(blobName);
            await blob.EnsureExistsAsync();
            return new TrackedFile(sourcePath, blob, flushInterval);
        }

        public IEnumerable<OutputFileReference> List(IOutputKind kind)
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            return _jobOutputContainer.ListBlobs(BlobNamePrefix(kind), useFlatBlobListing: true)
                                      .OfType<ICloudBlob>()
                                      .Select(b => new OutputFileReference(b));
        }

        public async Task<OutputFileReference> GetOutputAsync(IOutputKind kind, string filePath, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }

            Validate.IsNotNullOrEmpty(filePath, nameof(filePath));

            var blob = await _jobOutputContainer.GetBlobReferenceFromServerAsync(BlobName(kind, filePath), cancellationToken);

            return new OutputFileReference(blob);
        }

        // Gets the string that should be prefixed to a blob name to locate it correctly
        // in the container. This is the equivalent of a file system directory path - for
        // example a prefix might be "$JobOutput/" or "MyTask/$TaskOutput" - but Azure
        // Storage does not have the notion of directories under a container, only of prefixes.
        internal abstract string BlobNamePrefix(IOutputKind kind);

        internal string BlobName(IOutputKind kind, string relativePath)
            => $"{BlobNamePrefix(kind)}{relativePath}";

        private static string GetDestinationBlobPath(string relativeSourcePath)
        {
            const string up = "../";

            var destinationPath = relativeSourcePath.Replace('\\', '/');

            // If we are given a path that traverses up from the working directory,
            // treat it as though it were rooted at the working directory for blob naming
            // purposes. This is intended to support files such as ..\stdout.txt, which
            // is stored above the task working directory.
            //
            // A user can intentionally try to defeat this simple flattening by using a path
            // such as "temp\..\..\stdout.txt" - this may result in the file being
            // stored in the 'wrong' part of the job container, but they can't write
            // outside the job container this way, so the only damage they can do is
            // to themselves.
            while (destinationPath.StartsWith(up))
            {
                destinationPath = relativeSourcePath.Substring(up.Length);
            }

            return destinationPath;
        }

        internal sealed class JobStoragePath : StoragePath
        {
            internal JobStoragePath(CloudBlobContainer jobOutputContainer)
                : base(jobOutputContainer)
            {
            }

            internal override string BlobNamePrefix(IOutputKind kind)
                => $"${kind.Text}/";
        }

        internal sealed class TaskStoragePath : StoragePath
        {
            private readonly string _taskId;

            internal TaskStoragePath(CloudBlobContainer jobOutputContainer, string taskId)
                : base(jobOutputContainer)
            {
                Debug.Assert(taskId != null);
                _taskId = taskId;
            }

            internal override string BlobNamePrefix(IOutputKind kind)
                => $"{_taskId}/${kind.Text}/";
        }
    }
}
