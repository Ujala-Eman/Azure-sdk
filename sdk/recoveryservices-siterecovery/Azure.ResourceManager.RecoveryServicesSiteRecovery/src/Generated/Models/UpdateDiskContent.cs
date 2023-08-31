// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input for update. </summary>
    public partial class UpdateDiskContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public UpdateDiskContent(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="targetDiskName"> The target disk name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateDiskContent(string diskId, string targetDiskName, Dictionary<string, BinaryData> rawData)
        {
            DiskId = diskId;
            TargetDiskName = targetDiskName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/> for deserialization. </summary>
        internal UpdateDiskContent()
        {
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The target disk name. </summary>
        public string TargetDiskName { get; set; }
    }
}
