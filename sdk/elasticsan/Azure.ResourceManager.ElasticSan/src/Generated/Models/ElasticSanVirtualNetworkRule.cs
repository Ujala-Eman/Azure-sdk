// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Virtual Network rule. </summary>
    public partial class ElasticSanVirtualNetworkRule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRule"/>. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkResourceId"/> is null. </exception>
        public ElasticSanVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId)
        {
            Argument.AssertNotNull(virtualNetworkResourceId, nameof(virtualNetworkResourceId));

            VirtualNetworkResourceId = virtualNetworkResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRule"/>. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <param name="action"> The action of virtual network rule. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId, ElasticSanVirtualNetworkRuleAction? action, ElasticSanVirtualNetworkRuleState? state, Dictionary<string, BinaryData> rawData)
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            Action = action;
            State = state;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRule"/> for deserialization. </summary>
        internal ElasticSanVirtualNetworkRule()
        {
        }

        /// <summary> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </summary>
        public ResourceIdentifier VirtualNetworkResourceId { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public ElasticSanVirtualNetworkRuleAction? Action { get; set; }
        /// <summary> Gets the state of virtual network rule. </summary>
        public ElasticSanVirtualNetworkRuleState? State { get; }
    }
}
