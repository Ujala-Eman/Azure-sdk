// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware/Physical specific Disk Details. </summary>
    public partial class InMageDiskDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="InMageDiskDetails"/>. </summary>
        internal InMageDiskDetails()
        {
            VolumeList = new ChangeTrackingList<SiteRecoveryDiskVolumeDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="diskSizeInMB"> The disk size in MB. </param>
        /// <param name="diskType"> Whether disk is system disk or data disk. </param>
        /// <param name="diskConfiguration"> Whether disk is dynamic disk or basic disk. </param>
        /// <param name="volumeList"> Volumes of the disk. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageDiskDetails(string diskId, string diskName, string diskSizeInMB, string diskType, string diskConfiguration, IReadOnlyList<SiteRecoveryDiskVolumeDetails> volumeList, Dictionary<string, BinaryData> rawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            DiskSizeInMB = diskSizeInMB;
            DiskType = diskType;
            DiskConfiguration = diskConfiguration;
            VolumeList = volumeList;
            _rawData = rawData;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The disk size in MB. </summary>
        public string DiskSizeInMB { get; }
        /// <summary> Whether disk is system disk or data disk. </summary>
        public string DiskType { get; }
        /// <summary> Whether disk is dynamic disk or basic disk. </summary>
        public string DiskConfiguration { get; }
        /// <summary> Volumes of the disk. </summary>
        public IReadOnlyList<SiteRecoveryDiskVolumeDetails> VolumeList { get; }
    }
}
