// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Managed data disk description. </summary>
    public partial class NodeTypeVmssDataDisk
    {
        /// <summary> Initializes a new instance of NodeTypeVmssDataDisk. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk. </param>
        /// <param name="diskSizeInGB"> Disk size for each vm in the node type in GBs. </param>
        /// <param name="diskType"> Managed data disk type. Specifies the storage account type for the managed disk. </param>
        /// <param name="diskLetter"> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskLetter"/> is null. </exception>
        public NodeTypeVmssDataDisk(int lun, int diskSizeInGB, ServiceFabricManagedDataDiskType diskType, string diskLetter)
        {
            if (diskLetter == null)
            {
                throw new ArgumentNullException(nameof(diskLetter));
            }

            Lun = lun;
            DiskSizeInGB = diskSizeInGB;
            DiskType = diskType;
            DiskLetter = diskLetter;
        }

        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. Lun 0 is reserved for the service fabric data disk. </summary>
        public int Lun { get; set; }
        /// <summary> Disk size for each vm in the node type in GBs. </summary>
        public int DiskSizeInGB { get; set; }
        /// <summary> Managed data disk type. Specifies the storage account type for the managed disk. </summary>
        public ServiceFabricManagedDataDiskType DiskType { get; set; }
        /// <summary> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </summary>
        public string DiskLetter { get; set; }
    }
}
