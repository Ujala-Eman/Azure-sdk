// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when creating a server endpoint. </summary>
    public partial class StorageSyncServerEndpointCreateOrUpdateContent : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSyncServerEndpointCreateOrUpdateContent"/>. </summary>
        public StorageSyncServerEndpointCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServerEndpointCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverLocalPath"> Server Local path. </param>
        /// <param name="cloudTiering"> Cloud Tiering. </param>
        /// <param name="volumeFreeSpacePercent"> Level of free space to be maintained by Cloud Tiering if it is enabled. </param>
        /// <param name="tierFilesOlderThanDays"> Tier files older than days. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        /// <param name="serverResourceId"> Server Resource Id. </param>
        /// <param name="offlineDataTransfer"> Offline data transfer. </param>
        /// <param name="offlineDataTransferShareName"> Offline data transfer share name. </param>
        /// <param name="initialDownloadPolicy"> Policy for how namespace and files are recalled during FastDr. </param>
        /// <param name="localCacheMode"> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </param>
        /// <param name="initialUploadPolicy"> Policy for how the initial upload sync session is performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSyncServerEndpointCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string serverLocalPath, StorageSyncFeatureStatus? cloudTiering, int? volumeFreeSpacePercent, int? tierFilesOlderThanDays, string friendlyName, ResourceIdentifier serverResourceId, StorageSyncFeatureStatus? offlineDataTransfer, string offlineDataTransferShareName, InitialDownloadPolicy? initialDownloadPolicy, LocalCacheMode? localCacheMode, InitialUploadPolicy? initialUploadPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ServerLocalPath = serverLocalPath;
            CloudTiering = cloudTiering;
            VolumeFreeSpacePercent = volumeFreeSpacePercent;
            TierFilesOlderThanDays = tierFilesOlderThanDays;
            FriendlyName = friendlyName;
            ServerResourceId = serverResourceId;
            OfflineDataTransfer = offlineDataTransfer;
            OfflineDataTransferShareName = offlineDataTransferShareName;
            InitialDownloadPolicy = initialDownloadPolicy;
            LocalCacheMode = localCacheMode;
            InitialUploadPolicy = initialUploadPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Server Local path. </summary>
        public string ServerLocalPath { get; set; }
        /// <summary> Cloud Tiering. </summary>
        public StorageSyncFeatureStatus? CloudTiering { get; set; }
        /// <summary> Level of free space to be maintained by Cloud Tiering if it is enabled. </summary>
        public int? VolumeFreeSpacePercent { get; set; }
        /// <summary> Tier files older than days. </summary>
        public int? TierFilesOlderThanDays { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Server Resource Id. </summary>
        public ResourceIdentifier ServerResourceId { get; set; }
        /// <summary> Offline data transfer. </summary>
        public StorageSyncFeatureStatus? OfflineDataTransfer { get; set; }
        /// <summary> Offline data transfer share name. </summary>
        public string OfflineDataTransferShareName { get; set; }
        /// <summary> Policy for how namespace and files are recalled during FastDr. </summary>
        public InitialDownloadPolicy? InitialDownloadPolicy { get; set; }
        /// <summary> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </summary>
        public LocalCacheMode? LocalCacheMode { get; set; }
        /// <summary> Policy for how the initial upload sync session is performed. </summary>
        public InitialUploadPolicy? InitialUploadPolicy { get; set; }
    }
}
