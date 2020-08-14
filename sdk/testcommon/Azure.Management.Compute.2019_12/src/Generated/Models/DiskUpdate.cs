// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Disk update resource. </summary>
    public partial class DiskUpdate
    {
        /// <summary> Initializes a new instance of DiskUpdate. </summary>
        public DiskUpdate()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS. </summary>
        public DiskSku Sku { get; set; }
        /// <summary> the Operating System type. </summary>
        public OperatingSystemTypes? OsType { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        /// <summary> The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadWrite { get; set; }
        /// <summary> The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadWrite { get; set; }
        /// <summary> The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes. </summary>
        public long? DiskIopsReadOnly { get; set; }
        /// <summary> The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10. </summary>
        public long? DiskMBpsReadOnly { get; set; }
        /// <summary> The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time. </summary>
        public int? MaxShares { get; set; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public Encryption Encryption { get; set; }
    }
}
