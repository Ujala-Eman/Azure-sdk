﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Azure.Storage.DataMovement.Models;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Defines the local directory to transfer to or from
    /// </summary>
    public class LocalDirectoryStorageResourceContainer : StorageResourceContainer
    {
        private string _path;

        /// <summary>
        /// Gets the path
        /// </summary>
        /// <returns></returns>
        public override string Path => _path;

        /// <summary>
        /// Cannot produce Uri
        /// </summary>
        /// <returns></returns>
        public override ProduceUriType CanProduceUri => ProduceUriType.NoUri;

        /// <summary>
        /// Cannot get Uri
        /// </summary>
        /// <returns><see cref="NotImplementedException"/></returns>
        public override Uri Uri => throw new NotSupportedException();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path"></param>
        public LocalDirectoryStorageResourceContainer(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Gets the storage Resource
        /// </summary>
        /// <param name="childPath"></param>
        /// <returns></returns>
        public override StorageResource GetChildStorageResource(string childPath)
        {
            string concatPath = string.Concat(_path, "/", childPath);
            return new LocalFileStorageResource(concatPath);
        }

        /// <summary>
        /// Gets the parent directory path by one level.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override StorageResourceContainer GetParentStorageResourceContainer()
        {
            return new LocalDirectoryStorageResourceContainer(_path.Substring(0, _path.LastIndexOf('/')));
        }

        /// <summary>
        /// Lists storage resource in the filesystem.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async IAsyncEnumerable<StorageResource> GetStorageResources(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            PathScanner scanner = new PathScanner(_path);
            foreach (FileSystemInfo fileSystemInfo in scanner.Scan(false))
            {
                yield return GetChildStorageResource(fileSystemInfo.FullName);
            }
        }
    }
}
