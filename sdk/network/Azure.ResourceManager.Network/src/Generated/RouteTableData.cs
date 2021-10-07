// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the RouteTable data model. </summary>
    public partial class RouteTableData : Resource
    {
        /// <summary> Initializes a new instance of RouteTableData. </summary>
        public RouteTableData()
        {
            Routes = new ChangeTrackingList<RouteData>();
            Subnets = new ChangeTrackingList<SubnetData>();
        }

        /// <summary> Initializes a new instance of RouteTableData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routes"> Collection of routes contained within a route table. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="disableBgpRoutePropagation"> Whether to disable the routes learned by BGP on that route table. True means disable. </param>
        /// <param name="provisioningState"> The provisioning state of the route table resource. </param>
        /// <param name="resourceGuid"> The resource GUID property of the route table. </param>
        internal RouteTableData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<RouteData> routes, IReadOnlyList<SubnetData> subnets, bool? disableBgpRoutePropagation, ProvisioningState? provisioningState, string resourceGuid) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Routes = routes;
            Subnets = subnets;
            DisableBgpRoutePropagation = disableBgpRoutePropagation;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Collection of routes contained within a route table. </summary>
        public IList<RouteData> Routes { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<SubnetData> Subnets { get; }
        /// <summary> Whether to disable the routes learned by BGP on that route table. True means disable. </summary>
        public bool? DisableBgpRoutePropagation { get; set; }
        /// <summary> The provisioning state of the route table resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resource GUID property of the route table. </summary>
        public string ResourceGuid { get; }
    }
}
