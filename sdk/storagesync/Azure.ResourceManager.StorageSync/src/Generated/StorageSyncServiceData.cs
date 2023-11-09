// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing the StorageSyncService data model.
    /// Storage Sync Service object.
    /// </summary>
    public partial class StorageSyncServiceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSyncServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public StorageSyncServiceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<StorageSyncPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="incomingTrafficPolicy"> Incoming Traffic Policy. </param>
        /// <param name="storageSyncServiceStatus"> Storage Sync service status. </param>
        /// <param name="storageSyncServiceUid"> Storage Sync service Uid. </param>
        /// <param name="provisioningState"> StorageSyncService Provisioning State. </param>
        /// <param name="lastWorkflowId"> StorageSyncService lastWorkflowId. </param>
        /// <param name="lastOperationName"> Resource Last Operation Name. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection associated with the specified storage sync service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSyncServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IncomingTrafficPolicy? incomingTrafficPolicy, int? storageSyncServiceStatus, Guid? storageSyncServiceUid, string provisioningState, string lastWorkflowId, string lastOperationName, IReadOnlyList<StorageSyncPrivateEndpointConnectionData> privateEndpointConnections, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            IncomingTrafficPolicy = incomingTrafficPolicy;
            StorageSyncServiceStatus = storageSyncServiceStatus;
            StorageSyncServiceUid = storageSyncServiceUid;
            ProvisioningState = provisioningState;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServiceData"/> for deserialization. </summary>
        internal StorageSyncServiceData()
        {
        }

        /// <summary> Incoming Traffic Policy. </summary>
        public IncomingTrafficPolicy? IncomingTrafficPolicy { get; set; }
        /// <summary> Storage Sync service status. </summary>
        public int? StorageSyncServiceStatus { get; }
        /// <summary> Storage Sync service Uid. </summary>
        public Guid? StorageSyncServiceUid { get; }
        /// <summary> StorageSyncService Provisioning State. </summary>
        public string ProvisioningState { get; }
        /// <summary> StorageSyncService lastWorkflowId. </summary>
        public string LastWorkflowId { get; }
        /// <summary> Resource Last Operation Name. </summary>
        public string LastOperationName { get; }
        /// <summary> List of private endpoint connection associated with the specified storage sync service. </summary>
        public IReadOnlyList<StorageSyncPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
