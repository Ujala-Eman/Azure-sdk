// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input details. </summary>
    public partial class InMageAzureV2DiskDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2DiskDetails"/>. </summary>
        public InMageAzureV2DiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2DiskDetails"/>. </summary>
        /// <param name="diskId"> The DiskId. </param>
        /// <param name="logStorageAccountId"> The LogStorageAccountId. </param>
        /// <param name="diskType"> The DiskType. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2DiskDetails(string diskId, ResourceIdentifier logStorageAccountId, SiteRecoveryDiskAccountType? diskType, ResourceIdentifier diskEncryptionSetId, Dictionary<string, BinaryData> rawData)
        {
            DiskId = diskId;
            LogStorageAccountId = logStorageAccountId;
            DiskType = diskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            _rawData = rawData;
        }

        /// <summary> The DiskId. </summary>
        public string DiskId { get; set; }
        /// <summary> The LogStorageAccountId. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
        /// <summary> The DiskType. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> The DiskEncryptionSet ARM ID. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
