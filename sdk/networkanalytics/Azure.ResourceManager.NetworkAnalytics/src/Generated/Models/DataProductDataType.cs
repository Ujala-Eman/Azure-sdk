// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The data type resource. </summary>
    public partial class DataProductDataType : ResourceData
    {
        /// <summary> Initializes a new instance of DataProductDataType. </summary>
        public DataProductDataType()
        {
        }

        /// <summary> Initializes a new instance of DataProductDataType. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Latest provisioning state  of data product. </param>
        /// <param name="state"> State of data type. </param>
        /// <param name="stateReason"> Reason for the state of data type. </param>
        /// <param name="storageOutputRetention"> Field for storage output retention in days. </param>
        /// <param name="databaseCacheRetention"> Field for database cache retention in days. </param>
        /// <param name="databaseRetention"> Field for database data retention in days. </param>
        /// <param name="visualizationUri"> Url for data visualization. </param>
        internal DataProductDataType(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NetworkAnalyticsProvisioningState? provisioningState, DataProducDataTypeState? state, string stateReason, int? storageOutputRetention, int? databaseCacheRetention, int? databaseRetention, Uri visualizationUri) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            State = state;
            StateReason = stateReason;
            StorageOutputRetention = storageOutputRetention;
            DatabaseCacheRetention = databaseCacheRetention;
            DatabaseRetention = databaseRetention;
            VisualizationUri = visualizationUri;
        }

        /// <summary> Latest provisioning state  of data product. </summary>
        public NetworkAnalyticsProvisioningState? ProvisioningState { get; }
        /// <summary> State of data type. </summary>
        public DataProducDataTypeState? State { get; set; }
        /// <summary> Reason for the state of data type. </summary>
        public string StateReason { get; }
        /// <summary> Field for storage output retention in days. </summary>
        public int? StorageOutputRetention { get; set; }
        /// <summary> Field for database cache retention in days. </summary>
        public int? DatabaseCacheRetention { get; set; }
        /// <summary> Field for database data retention in days. </summary>
        public int? DatabaseRetention { get; set; }
        /// <summary> Url for data visualization. </summary>
        public Uri VisualizationUri { get; }
    }
}
