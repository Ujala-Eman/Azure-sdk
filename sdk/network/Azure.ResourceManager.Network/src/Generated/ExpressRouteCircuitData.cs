// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuit data model. </summary>
    public partial class ExpressRouteCircuitData : Resource
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitData. </summary>
        public ExpressRouteCircuitData()
        {
            Authorizations = new ChangeTrackingList<ExpressRouteCircuitAuthorizationData>();
            Peerings = new ChangeTrackingList<ExpressRouteCircuitPeeringData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The SKU. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="allowClassicOperations"> Allow classic operations. </param>
        /// <param name="circuitProvisioningState"> The CircuitProvisioningState state of the resource. </param>
        /// <param name="serviceProviderProvisioningState"> The ServiceProviderProvisioningState state of the resource. </param>
        /// <param name="authorizations"> The list of authorizations. </param>
        /// <param name="peerings"> The list of peerings. </param>
        /// <param name="serviceKey"> The ServiceKey. </param>
        /// <param name="serviceProviderNotes"> The ServiceProviderNotes. </param>
        /// <param name="serviceProviderProperties"> The ServiceProviderProperties. </param>
        /// <param name="expressRoutePort"> The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource. </param>
        /// <param name="bandwidthInGbps"> The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource. </param>
        /// <param name="stag"> The identifier of the circuit traffic. Outer tag for QinQ encapsulation. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit resource. </param>
        /// <param name="gatewayManagerEtag"> The GatewayManager Etag. </param>
        /// <param name="globalReachEnabled"> Flag denoting global reach status. </param>
        internal ExpressRouteCircuitData(string id, string name, string type, string location, IDictionary<string, string> tags, ExpressRouteCircuitSku sku, string etag, bool? allowClassicOperations, string circuitProvisioningState, ServiceProviderProvisioningState? serviceProviderProvisioningState, IList<ExpressRouteCircuitAuthorizationData> authorizations, IList<ExpressRouteCircuitPeeringData> peerings, string serviceKey, string serviceProviderNotes, ExpressRouteCircuitServiceProviderProperties serviceProviderProperties, SubResource expressRoutePort, float? bandwidthInGbps, int? stag, ProvisioningState? provisioningState, string gatewayManagerEtag, bool? globalReachEnabled) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Etag = etag;
            AllowClassicOperations = allowClassicOperations;
            CircuitProvisioningState = circuitProvisioningState;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            Authorizations = authorizations;
            Peerings = peerings;
            ServiceKey = serviceKey;
            ServiceProviderNotes = serviceProviderNotes;
            ServiceProviderProperties = serviceProviderProperties;
            ExpressRoutePort = expressRoutePort;
            BandwidthInGbps = bandwidthInGbps;
            Stag = stag;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            GlobalReachEnabled = globalReachEnabled;
        }

        /// <summary> The SKU. </summary>
        public ExpressRouteCircuitSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Allow classic operations. </summary>
        public bool? AllowClassicOperations { get; set; }
        /// <summary> The CircuitProvisioningState state of the resource. </summary>
        public string CircuitProvisioningState { get; set; }
        /// <summary> The ServiceProviderProvisioningState state of the resource. </summary>
        public ServiceProviderProvisioningState? ServiceProviderProvisioningState { get; set; }
        /// <summary> The list of authorizations. </summary>
        public IList<ExpressRouteCircuitAuthorizationData> Authorizations { get; }
        /// <summary> The list of peerings. </summary>
        public IList<ExpressRouteCircuitPeeringData> Peerings { get; }
        /// <summary> The ServiceKey. </summary>
        public string ServiceKey { get; set; }
        /// <summary> The ServiceProviderNotes. </summary>
        public string ServiceProviderNotes { get; set; }
        /// <summary> The ServiceProviderProperties. </summary>
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties { get; set; }
        /// <summary> The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource. </summary>
        public SubResource ExpressRoutePort { get; set; }
        /// <summary> The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource. </summary>
        public float? BandwidthInGbps { get; set; }
        /// <summary> The identifier of the circuit traffic. Outer tag for QinQ encapsulation. </summary>
        public int? Stag { get; }
        /// <summary> The provisioning state of the express route circuit resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The GatewayManager Etag. </summary>
        public string GatewayManagerEtag { get; set; }
        /// <summary> Flag denoting global reach status. </summary>
        public bool? GlobalReachEnabled { get; set; }
    }
}
