// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary> A class representing the EventHubConsumerGroupInfo data model. </summary>
    public partial class EventHubConsumerGroupInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubConsumerGroupInfoData. </summary>
        internal EventHubConsumerGroupInfoData()
        {
            Properties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of EventHubConsumerGroupInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The tags. </param>
        /// <param name="etag"> The etag. </param>
        internal EventHubConsumerGroupInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyDictionary<string, BinaryData> properties, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = etag;
        }

        /// <summary> The tags. </summary>
        public IReadOnlyDictionary<string, BinaryData> Properties { get; }
        /// <summary> The etag. </summary>
        public ETag? ETag { get; }
    }
}
