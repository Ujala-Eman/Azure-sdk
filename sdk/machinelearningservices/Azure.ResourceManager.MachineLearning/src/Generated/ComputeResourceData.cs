// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A class representing the ComputeResource data model. </summary>
    public partial class ComputeResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of ComputeResourceData. </summary>
        public ComputeResourceData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ComputeResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="properties"> Compute properties. </param>
        internal ComputeResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, string location, IDictionary<string, string> tags, MachineLearningSku sku, Compute properties) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Sku = sku;
            Properties = properties;
        }

        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Specifies the location of the resource. </summary>
        public string Location { get; set; }
        /// <summary> Contains resource tags defined as key/value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> Compute properties. </summary>
        public Compute Properties { get; set; }
    }
}
