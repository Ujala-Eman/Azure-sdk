// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the NetworkFunction data model.
    /// Network function resource response.
    /// </summary>
    public partial class NetworkFunctionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFunctionData. </summary>
        /// <param name="location"> The location. </param>
        public NetworkFunctionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of NetworkFunctionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Network function properties. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The managed identity of the network function. </param>
        internal NetworkFunctionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NetworkFunctionPropertiesFormat properties, ETag? etag, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            ETag = etag;
            Identity = identity;
        }

        /// <summary> Network function properties. </summary>
        public NetworkFunctionPropertiesFormat Properties { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The managed identity of the network function. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
