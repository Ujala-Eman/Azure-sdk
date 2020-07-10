// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListExpressRouteCircuit API service call. </summary>
    public partial class ExpressRouteCircuitListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitListResult. </summary>
        internal ExpressRouteCircuitListResult()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitListResult. </summary>
        /// <param name="value"> A list of ExpressRouteCircuits in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCircuitListResult(IReadOnlyList<ExpressRouteCircuit> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of ExpressRouteCircuits in a resource group. </summary>
        public IReadOnlyList<ExpressRouteCircuit> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
