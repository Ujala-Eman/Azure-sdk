// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Storage information about the data disks present in the custom image. </summary>
    public partial class DevTestLabDataDiskStorageTypeInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabDataDiskStorageTypeInfo"/>. </summary>
        public DevTestLabDataDiskStorageTypeInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabDataDiskStorageTypeInfo"/>. </summary>
        /// <param name="lun"> Disk Lun. </param>
        /// <param name="storageType"> Disk Storage Type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabDataDiskStorageTypeInfo(string lun, DevTestLabStorageType? storageType, Dictionary<string, BinaryData> rawData)
        {
            Lun = lun;
            StorageType = storageType;
            _rawData = rawData;
        }

        /// <summary> Disk Lun. </summary>
        public string Lun { get; set; }
        /// <summary> Disk Storage Type. </summary>
        public DevTestLabStorageType? StorageType { get; set; }
    }
}
