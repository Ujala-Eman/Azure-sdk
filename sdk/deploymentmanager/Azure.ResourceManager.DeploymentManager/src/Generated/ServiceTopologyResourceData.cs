// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary>
    /// A class representing the ServiceTopologyResource data model.
    /// The resource representation of a service topology.
    /// </summary>
    public partial class ServiceTopologyResourceData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceTopologyResourceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ServiceTopologyResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTopologyResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="artifactSourceId"> The resource Id of the artifact source that contains the artifacts that can be referenced in the service units. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceTopologyResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string artifactSourceId, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ArtifactSourceId = artifactSourceId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTopologyResourceData"/> for deserialization. </summary>
        internal ServiceTopologyResourceData()
        {
        }

        /// <summary> The resource Id of the artifact source that contains the artifacts that can be referenced in the service units. </summary>
        public string ArtifactSourceId { get; set; }
    }
}
