// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> Virtual Network rule. </summary>
    public partial class VirtualNetworkRule
    {
        /// <summary> Initializes a new instance of VirtualNetworkRule. </summary>
        public VirtualNetworkRule()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkRule. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <param name="action"> The action of virtual network rule. </param>
        /// <param name="state"> Gets the state of virtual network rule. </param>
        internal VirtualNetworkRule(string virtualNetworkResourceId, string action, State? state)
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            Action = action;
            State = state;
        }

        /// <summary> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </summary>
        public string VirtualNetworkResourceId { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public string Action { get; set; } = "Allow";
        /// <summary> Gets the state of virtual network rule. </summary>
        public State? State { get; set; }
    }
}
