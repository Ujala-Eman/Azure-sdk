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
    /// <summary> A class representing the MachineLearningPrivateEndpointConnection data model. </summary>
    public partial class MachineLearningPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointConnectionData"/>. </summary>
        public MachineLearningPrivateEndpointConnectionData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal MachineLearningPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedServiceIdentity identity, AzureLocation? location, IDictionary<string, string> tags, MachineLearningSku sku, PrivateEndpoint privateEndpoint, MachineLearningPrivateLinkServiceConnectionState connectionState, MachineLearningPrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Sku = sku;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Specifies the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Contains resource tags defined as key/value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public MachineLearningSku Sku { get; set; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public MachineLearningPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public MachineLearningPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
