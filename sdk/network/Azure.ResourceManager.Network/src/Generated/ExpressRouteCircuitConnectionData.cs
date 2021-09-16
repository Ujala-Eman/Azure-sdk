// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuitConnection data model. </summary>
    public partial class ExpressRouteCircuitConnectionData : WritableSubResource
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionData. </summary>
        public ExpressRouteCircuitConnectionData()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="ipv6CircuitConnectionConfig"> IPv6 Address PrefixProperties of the express route circuit connection. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit connection state. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit connection resource. </param>
        internal ExpressRouteCircuitConnectionData(string id, string name, string etag, string type, Models.SubResource expressRouteCircuitPeering, Models.SubResource peerExpressRouteCircuitPeering, string addressPrefix, string authorizationKey, Ipv6CircuitConnectionConfig ipv6CircuitConnectionConfig, CircuitConnectionStatus? circuitConnectionStatus, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            Ipv6CircuitConnectionConfig = ipv6CircuitConnectionConfig;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </summary>
        public Models.SubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        public Models.SubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> IPv6 Address PrefixProperties of the express route circuit connection. </summary>
        public Ipv6CircuitConnectionConfig Ipv6CircuitConnectionConfig { get; set; }
        /// <summary> Express Route Circuit connection state. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> The provisioning state of the express route circuit connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
