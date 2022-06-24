// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing the ManagedHsmPrivateEndpointConnection data model. </summary>
    public partial class ManagedHsmPrivateEndpointConnectionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedHsmPrivateEndpointConnectionData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedHsmPrivateEndpointConnectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedHsmPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpoint"> Properties of the private endpoint object. </param>
        /// <param name="privateLinkServiceConnectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <param name="sku"> SKU details. </param>
        internal ManagedHsmPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, SubResource privateEndpoint, ManagedHsmPrivateLinkServiceConnectionState privateLinkServiceConnectionState, KeyVaultPrivateEndpointConnectionProvisioningState? provisioningState, ManagedHsmSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            Etag = etag;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            Sku = sku;
        }

        /// <summary> Modified whenever there is a change in the state of private endpoint connection. </summary>
        public ETag? Etag { get; set; }
        /// <summary> Properties of the private endpoint object. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> Approval state of the private link connection. </summary>
        public ManagedHsmPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public KeyVaultPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> SKU details. </summary>
        public ManagedHsmSku Sku { get; set; }
    }
}
