// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the GremlinGraph data model. </summary>
    public partial class GremlinGraphData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="GremlinGraphData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GremlinGraphData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GremlinGraphData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"></param>
        /// <param name="options"></param>
        internal GremlinGraphData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, GremlinGraphPropertiesResource resource, GremlinGraphPropertiesOptions options) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> Gets or sets the resource. </summary>
        public GremlinGraphPropertiesResource Resource { get; set; }
        /// <summary> Gets or sets the options. </summary>
        public GremlinGraphPropertiesOptions Options { get; set; }
    }
}
