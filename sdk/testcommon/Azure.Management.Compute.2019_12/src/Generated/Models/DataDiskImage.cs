// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> Contains the data disk images information. </summary>
    public partial class DataDiskImage
    {
        /// <summary> Initializes a new instance of DataDiskImage. </summary>
        public DataDiskImage()
        {
        }

        /// <summary> Initializes a new instance of DataDiskImage. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        internal DataDiskImage(int? lun)
        {
            Lun = lun;
        }

        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </summary>
        public int? Lun { get; }
    }
}
