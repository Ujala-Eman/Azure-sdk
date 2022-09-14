// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Restore payload for Single File Snapshot Restore. </summary>
    public partial class NetAppVolumeSnapshotRestoreFilesContent
    {
        /// <summary> Initializes a new instance of NetAppVolumeSnapshotRestoreFilesContent. </summary>
        /// <param name="filePaths"> List of files to be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePaths"/> is null. </exception>
        public NetAppVolumeSnapshotRestoreFilesContent(IEnumerable<string> filePaths)
        {
            if (filePaths == null)
            {
                throw new ArgumentNullException(nameof(filePaths));
            }

            FilePaths = filePaths.ToList();
        }

        /// <summary> List of files to be restored. </summary>
        public IList<string> FilePaths { get; }
        /// <summary> Destination folder where the files will be restored. </summary>
        public string DestinationPath { get; set; }
    }
}
