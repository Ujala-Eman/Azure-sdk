// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> disk encryption set update resource. </summary>
    public partial class DiskEncryptionSetPatch
    {
        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetPatch"/>. </summary>
        public DiskEncryptionSetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public DiskEncryptionSetType? EncryptionType { get; set; }
        /// <summary> Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots. </summary>
        public KeyForDiskEncryptionSet ActiveKey { get; set; }
        /// <summary> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </summary>
        public bool? RotationToLatestKeyVersionEnabled { get; set; }
    }
}
