// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the HubRouteTable data model. </summary>
    public partial class HubRouteTableData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HubRouteTableData"/>. </summary>
        public HubRouteTableData()
        {
            Routes = new ChangeTrackingList<HubRoute>();
            Labels = new ChangeTrackingList<string>();
            AssociatedConnections = new ChangeTrackingList<string>();
            PropagatingConnections = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HubRouteTableData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routes"> List of all routes. </param>
        /// <param name="labels"> List of labels associated with this route table. </param>
        /// <param name="associatedConnections"> List of all connections associated with this route table. </param>
        /// <param name="propagatingConnections"> List of all connections that advertise to this route table. </param>
        /// <param name="provisioningState"> The provisioning state of the RouteTable resource. </param>
        internal HubRouteTableData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IList<HubRoute> routes, IList<string> labels, IReadOnlyList<string> associatedConnections, IReadOnlyList<string> propagatingConnections, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            Routes = routes;
            Labels = labels;
            AssociatedConnections = associatedConnections;
            PropagatingConnections = propagatingConnections;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> List of all routes. </summary>
        public IList<HubRoute> Routes { get; }
        /// <summary> List of labels associated with this route table. </summary>
        public IList<string> Labels { get; }
        /// <summary> List of all connections associated with this route table. </summary>
        public IReadOnlyList<string> AssociatedConnections { get; }
        /// <summary> List of all connections that advertise to this route table. </summary>
        public IReadOnlyList<string> PropagatingConnections { get; }
        /// <summary> The provisioning state of the RouteTable resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
