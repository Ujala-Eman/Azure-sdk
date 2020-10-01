// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListPeering API service call retrieves all peerings that belong to an ExpressRouteCrossConnection. </summary>
    public partial class ExpressRouteCrossConnectionPeeringList
    {
        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringList. </summary>
        internal ExpressRouteCrossConnectionPeeringList()
        {
            Value = new ChangeTrackingList<ExpressRouteCrossConnectionPeering>();
        }

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringList. </summary>
        /// <param name="value"> The peerings in an express route cross connection. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCrossConnectionPeeringList(IReadOnlyList<ExpressRouteCrossConnectionPeering> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The peerings in an express route cross connection. </summary>
        public IReadOnlyList<ExpressRouteCrossConnectionPeering> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
