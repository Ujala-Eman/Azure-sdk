// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Snapshot update resource. </summary>
    public partial class SnapshotPatch
    {
        /// <summary> Initializes a new instance of <see cref="SnapshotPatch"/>. </summary>
        public SnapshotPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot. </summary>
        public SnapshotSku Sku { get; set; }
        /// <summary> the Operating System type. </summary>
        public OperatingSystemTypes? OSType { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingGroup EncryptionSettingGroup { get; set; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public DiskEncryption Encryption { get; set; }
        /// <summary> Policy for accessing the disk via network. </summary>
        public NetworkAccessPolicy? NetworkAccessPolicy { get; set; }
        /// <summary> ARM id of the DiskAccess resource for using private endpoints on disks. </summary>
        public ResourceIdentifier DiskAccessId { get; set; }
        /// <summary> Indicates the OS on a snapshot supports hibernation. </summary>
        public bool? SupportsHibernation { get; set; }
        /// <summary> Policy for controlling export on the disk. </summary>
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> List of supported capabilities (like accelerated networking) for the image from which the OS disk was created. </summary>
        internal SupportedCapabilities SupportedCapabilities { get; set; }
        /// <summary> True if the image from which the OS disk is created supports accelerated networking. </summary>
        public bool? AcceleratedNetwork
        {
            get => SupportedCapabilities is null ? default : SupportedCapabilities.AcceleratedNetwork;
            set
            {
                if (SupportedCapabilities is null)
                    SupportedCapabilities = new SupportedCapabilities();
                SupportedCapabilities.AcceleratedNetwork = value;
            }
        }
    }
}
