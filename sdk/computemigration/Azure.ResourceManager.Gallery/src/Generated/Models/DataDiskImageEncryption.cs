// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Gallery.Models
{
    /// <summary> Contains encryption settings for a data disk image. </summary>
    public partial class DataDiskImageEncryption : DiskImageEncryption
    {
        /// <summary> Initializes a new instance of <see cref="DataDiskImageEncryption"/>. </summary>
        /// <param name="lun"> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </param>
        public DataDiskImageEncryption(int lun)
        {
            Lun = lun;
        }

        /// <summary> Initializes a new instance of <see cref="DataDiskImageEncryption"/>. </summary>
        /// <param name="diskEncryptionSetId"> A relative URI containing the resource ID of the disk encryption set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="lun"> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </param>
        internal DataDiskImageEncryption(ResourceIdentifier diskEncryptionSetId, IDictionary<string, BinaryData> serializedAdditionalRawData, int lun) : base(diskEncryptionSetId, serializedAdditionalRawData)
        {
            Lun = lun;
        }

        /// <summary> Initializes a new instance of <see cref="DataDiskImageEncryption"/> for deserialization. </summary>
        internal DataDiskImageEncryption()
        {
        }

        /// <summary> This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine. </summary>
        public int Lun { get; set; }
    }
}
