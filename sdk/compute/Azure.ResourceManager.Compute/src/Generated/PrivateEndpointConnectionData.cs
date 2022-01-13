// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the PrivateEndpointConnection data model. </summary>
    public partial class PrivateEndpointConnectionData : Resource
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        public PrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between DiskAccess and Virtual Network. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal PrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType type, Resources.Models.SubResource privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState, PrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, type)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        public Resources.Models.SubResource PrivateEndpoint { get; }
        /// <summary> A collection of information about the state of the connection between DiskAccess and Virtual Network. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public PrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
