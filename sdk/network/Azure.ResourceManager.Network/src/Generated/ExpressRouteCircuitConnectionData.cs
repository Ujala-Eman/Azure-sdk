// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuitConnection data model. </summary>
    public partial class ExpressRouteCircuitConnectionData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitConnectionData"/>. </summary>
        public ExpressRouteCircuitConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitConnectionData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="iPv6CircuitConnectionConfig"> IPv6 Address PrefixProperties of the express route circuit connection. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit connection state. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit connection resource. </param>
        internal ExpressRouteCircuitConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource expressRouteCircuitPeering, WritableSubResource peerExpressRouteCircuitPeering, string addressPrefix, string authorizationKey, IPv6CircuitConnectionConfig iPv6CircuitConnectionConfig, CircuitConnectionStatus? circuitConnectionStatus, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            IPv6CircuitConnectionConfig = iPv6CircuitConnectionConfig;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </summary>
        internal WritableSubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ExpressRouteCircuitPeeringId
        {
            get => ExpressRouteCircuitPeering is null ? default : ExpressRouteCircuitPeering.Id;
            set
            {
                if (ExpressRouteCircuitPeering is null)
                    ExpressRouteCircuitPeering = new WritableSubResource();
                ExpressRouteCircuitPeering.Id = value;
            }
        }

        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        internal WritableSubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerExpressRouteCircuitPeeringId
        {
            get => PeerExpressRouteCircuitPeering is null ? default : PeerExpressRouteCircuitPeering.Id;
            set
            {
                if (PeerExpressRouteCircuitPeering is null)
                    PeerExpressRouteCircuitPeering = new WritableSubResource();
                PeerExpressRouteCircuitPeering.Id = value;
            }
        }

        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> IPv6 Address PrefixProperties of the express route circuit connection. </summary>
        public IPv6CircuitConnectionConfig IPv6CircuitConnectionConfig { get; set; }
        /// <summary> Express Route Circuit connection state. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> The provisioning state of the express route circuit connection resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
