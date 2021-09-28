// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the HubRouteTable data model. </summary>
    public partial class HubRouteTableData : WritableSubResource
    {
        /// <summary> Initializes a new instance of HubRouteTableData. </summary>
        public HubRouteTableData()
        {
            Routes = new ChangeTrackingList<HubRoute>();
            Labels = new ChangeTrackingList<string>();
            AssociatedConnections = new ChangeTrackingList<string>();
            PropagatingConnections = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HubRouteTableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="routes"> List of all routes. </param>
        /// <param name="labels"> List of labels associated with this route table. </param>
        /// <param name="associatedConnections"> List of all connections associated with this route table. </param>
        /// <param name="propagatingConnections"> List of all connections that advertise to this route table. </param>
        /// <param name="provisioningState"> The provisioning state of the RouteTable resource. </param>
        internal HubRouteTableData(string id, string name, string etag, string type, IList<HubRoute> routes, IList<string> labels, IReadOnlyList<string> associatedConnections, IReadOnlyList<string> propagatingConnections, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Routes = routes;
            Labels = labels;
            AssociatedConnections = associatedConnections;
            PropagatingConnections = propagatingConnections;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> List of all routes. </summary>
        public IList<HubRoute> Routes { get; }
        /// <summary> List of labels associated with this route table. </summary>
        public IList<string> Labels { get; }
        /// <summary> List of all connections associated with this route table. </summary>
        public IReadOnlyList<string> AssociatedConnections { get; }
        /// <summary> List of all connections that advertise to this route table. </summary>
        public IReadOnlyList<string> PropagatingConnections { get; }
        /// <summary> The provisioning state of the RouteTable resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
