// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListSubnets API service call. Retrieves all subnets that belong to a virtual network. </summary>
    public partial class VirtualNetworkPeeringListResult
    {
        /// <summary> Initializes a new instance of VirtualNetworkPeeringListResult. </summary>
        internal VirtualNetworkPeeringListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkPeering>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkPeeringListResult. </summary>
        /// <param name="value"> The peerings in a virtual network. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal VirtualNetworkPeeringListResult(IReadOnlyList<VirtualNetworkPeering> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The peerings in a virtual network. </summary>
        public IReadOnlyList<VirtualNetworkPeering> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
