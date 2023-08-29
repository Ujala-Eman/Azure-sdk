// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing the EventHubsCluster data model.
    /// Single Event Hubs Cluster resource in List or Get operations.
    /// </summary>
    public partial class EventHubsClusterData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        public EventHubsClusterData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of the cluster SKU. </param>
        /// <param name="createdOn"> The UTC time when the Event Hubs Cluster was created. </param>
        /// <param name="updatedOn"> The UTC time when the Event Hubs Cluster was last updated. </param>
        /// <param name="metricId"> The metric ID of the cluster resource. Provided by the service and not modifiable by the user. </param>
        /// <param name="status"> Status of the Cluster resource. </param>
        /// <param name="supportsScaling"> A value that indicates whether Scaling is Supported. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EventHubsClusterSku sku, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string metricId, string status, bool? supportsScaling, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            MetricId = metricId;
            Status = status;
            SupportsScaling = supportsScaling;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsClusterData"/> for deserialization. </summary>
        internal EventHubsClusterData()
        {
        }

        /// <summary> Properties of the cluster SKU. </summary>
        public EventHubsClusterSku Sku { get; set; }
        /// <summary> The UTC time when the Event Hubs Cluster was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The UTC time when the Event Hubs Cluster was last updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The metric ID of the cluster resource. Provided by the service and not modifiable by the user. </summary>
        public string MetricId { get; }
        /// <summary> Status of the Cluster resource. </summary>
        public string Status { get; }
        /// <summary> A value that indicates whether Scaling is Supported. </summary>
        public bool? SupportsScaling { get; set; }
    }
}
