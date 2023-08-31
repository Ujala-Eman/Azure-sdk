// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An ExpressRoute Circuit. </summary>
    public partial class ExpressRouteCircuit
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuit"/>. </summary>
        public ExpressRouteCircuit()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuit"/>. </summary>
        /// <param name="primarySubnet"> CIDR of primary subnet. </param>
        /// <param name="secondarySubnet"> CIDR of secondary subnet. </param>
        /// <param name="expressRouteId"> Identifier of the ExpressRoute Circuit (Microsoft Colo only). </param>
        /// <param name="expressRoutePrivatePeeringId"> ExpressRoute Circuit private peering identifier. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuit(string primarySubnet, string secondarySubnet, ResourceIdentifier expressRouteId, ResourceIdentifier expressRoutePrivatePeeringId, Dictionary<string, BinaryData> rawData)
        {
            PrimarySubnet = primarySubnet;
            SecondarySubnet = secondarySubnet;
            ExpressRouteId = expressRouteId;
            ExpressRoutePrivatePeeringId = expressRoutePrivatePeeringId;
            _rawData = rawData;
        }

        /// <summary> CIDR of primary subnet. </summary>
        public string PrimarySubnet { get; }
        /// <summary> CIDR of secondary subnet. </summary>
        public string SecondarySubnet { get; }
        /// <summary> Identifier of the ExpressRoute Circuit (Microsoft Colo only). </summary>
        public ResourceIdentifier ExpressRouteId { get; }
        /// <summary> ExpressRoute Circuit private peering identifier. </summary>
        public ResourceIdentifier ExpressRoutePrivatePeeringId { get; }
    }
}
