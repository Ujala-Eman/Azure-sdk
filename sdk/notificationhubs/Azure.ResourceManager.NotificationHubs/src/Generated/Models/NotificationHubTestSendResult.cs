// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub Resource. </summary>
    public partial class NotificationHubTestSendResult : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NotificationHubTestSendResult. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubTestSendResult(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of NotificationHubTestSendResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="success"> successful send. </param>
        /// <param name="failure"> send failure. </param>
        /// <param name="results"> actual failure description. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        internal NotificationHubTestSendResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, int? success, int? failure, BinaryData results, NotificationHubSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            Success = success;
            Failure = failure;
            Results = results;
            Sku = sku;
        }

        /// <summary> successful send. </summary>
        public int? Success { get; set; }
        /// <summary> send failure. </summary>
        public int? Failure { get; set; }
        /// <summary> actual failure description. </summary>
        public BinaryData Results { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
