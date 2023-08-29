// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The properties of a private endpoint connection. </summary>
    public partial class DigitalTwinsPrivateEndpointConnectionProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateEndpointConnectionProperties"/>. </summary>
        public DigitalTwinsPrivateEndpointConnectionProperties()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="privateEndpoint"> The private endpoint. </param>
        /// <param name="groupIds"> The list of group ids for the private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> The connection state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsPrivateEndpointConnectionProperties(DigitalTwinsPrivateLinkResourceProvisioningState? provisioningState, SubResource privateEndpoint, IList<string> groupIds, DigitalTwinsPrivateLinkServiceConnectionState privateLinkServiceConnectionState, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            _rawData = rawData;
        }

        /// <summary> The provisioning state. </summary>
        public DigitalTwinsPrivateLinkResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The private endpoint. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> The list of group ids for the private endpoint connection. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> The connection state. </summary>
        public DigitalTwinsPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}
