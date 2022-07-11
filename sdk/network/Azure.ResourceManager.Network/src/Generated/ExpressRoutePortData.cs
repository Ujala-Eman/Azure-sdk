// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRoutePort data model. </summary>
    public partial class ExpressRoutePortData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of ExpressRoutePortData. </summary>
        public ExpressRoutePortData()
        {
            Links = new ChangeTrackingList<ExpressRouteLinkData>();
            Circuits = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of ExpressRoutePortData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The identity of ExpressRoutePort, if configured. </param>
        /// <param name="peeringLocation"> The name of the peering location that the ExpressRoutePort is mapped to physically. </param>
        /// <param name="bandwidthInGbps"> Bandwidth of procured ports in Gbps. </param>
        /// <param name="provisionedBandwidthInGbps"> Aggregate Gbps of associated circuit bandwidths. </param>
        /// <param name="mtu"> Maximum transmission unit of the physical port pair(s). </param>
        /// <param name="encapsulation"> Encapsulation method on physical ports. </param>
        /// <param name="etherType"> Ether type of the physical port. </param>
        /// <param name="allocationDate"> Date of the physical port allocation to be used in Letter of Authorization. </param>
        /// <param name="links"> The set of physical links of the ExpressRoutePort resource. </param>
        /// <param name="circuits"> Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource. </param>
        /// <param name="provisioningState"> The provisioning state of the express route port resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the express route port resource. </param>
        internal ExpressRoutePortData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, ManagedServiceIdentity identity, string peeringLocation, int? bandwidthInGbps, float? provisionedBandwidthInGbps, string mtu, ExpressRoutePortsEncapsulation? encapsulation, string etherType, string allocationDate, IList<ExpressRouteLinkData> links, IReadOnlyList<WritableSubResource> circuits, NetworkProvisioningState? provisioningState, Guid? resourceGuid) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            Identity = identity;
            PeeringLocation = peeringLocation;
            BandwidthInGbps = bandwidthInGbps;
            ProvisionedBandwidthInGbps = provisionedBandwidthInGbps;
            Mtu = mtu;
            Encapsulation = encapsulation;
            EtherType = etherType;
            AllocationDate = allocationDate;
            Links = links;
            Circuits = circuits;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The identity of ExpressRoutePort, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The name of the peering location that the ExpressRoutePort is mapped to physically. </summary>
        public string PeeringLocation { get; set; }
        /// <summary> Bandwidth of procured ports in Gbps. </summary>
        public int? BandwidthInGbps { get; set; }
        /// <summary> Aggregate Gbps of associated circuit bandwidths. </summary>
        public float? ProvisionedBandwidthInGbps { get; }
        /// <summary> Maximum transmission unit of the physical port pair(s). </summary>
        public string Mtu { get; }
        /// <summary> Encapsulation method on physical ports. </summary>
        public ExpressRoutePortsEncapsulation? Encapsulation { get; set; }
        /// <summary> Ether type of the physical port. </summary>
        public string EtherType { get; }
        /// <summary> Date of the physical port allocation to be used in Letter of Authorization. </summary>
        public string AllocationDate { get; }
        /// <summary> The set of physical links of the ExpressRoutePort resource. </summary>
        public IList<ExpressRouteLinkData> Links { get; }
        /// <summary> Reference the ExpressRoute circuit(s) that are provisioned on this ExpressRoutePort resource. </summary>
        public IReadOnlyList<WritableSubResource> Circuits { get; }
        /// <summary> The provisioning state of the express route port resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The resource GUID property of the express route port resource. </summary>
        public Guid? ResourceGuid { get; }
    }
}
