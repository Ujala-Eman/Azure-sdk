// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the OnlineEndpointTrackedResource data model. </summary>
    public partial class OnlineEndpointTrackedResourceData : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public OnlineEndpointTrackedResourceData(LocationData location, OnlineEndpoint properties) : base(location)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of OnlineEndpointTrackedResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="identity"> Service identity associated with a resource. </param>
        /// <param name="kind"> . </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal OnlineEndpointTrackedResourceData(ResourceGroupResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, ResourceIdentity identity, string kind, OnlineEndpoint properties, SystemData systemData) : base(id, name, type, location, tags)
        {
            Identity = identity;
            Kind = kind;
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Service identity associated with a resource. </summary>
        public ResourceIdentity Identity { get; set; }
        public string Kind { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public OnlineEndpoint Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}
