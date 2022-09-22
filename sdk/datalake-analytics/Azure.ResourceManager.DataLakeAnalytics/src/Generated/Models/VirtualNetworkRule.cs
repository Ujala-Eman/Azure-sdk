// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> Data Lake Analytics  VirtualNetwork Rule information. </summary>
    public partial class VirtualNetworkRule : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkRule. </summary>
        internal VirtualNetworkRule()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subnetId"> The resource identifier for the subnet. </param>
        /// <param name="virtualNetworkRuleState"> The current state of the VirtualNetwork Rule. </param>
        internal VirtualNetworkRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string subnetId, VirtualNetworkRuleState? virtualNetworkRuleState) : base(id, name, resourceType, systemData)
        {
            SubnetId = subnetId;
            VirtualNetworkRuleState = virtualNetworkRuleState;
        }

        /// <summary> The resource identifier for the subnet. </summary>
        public string SubnetId { get; }
        /// <summary> The current state of the VirtualNetwork Rule. </summary>
        public VirtualNetworkRuleState? VirtualNetworkRuleState { get; }
    }
}
