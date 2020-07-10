// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> NAT rule collection resource. </summary>
    public partial class AzureFirewallNatRuleCollection : SubResource
    {
        /// <summary> Initializes a new instance of AzureFirewallNatRuleCollection. </summary>
        public AzureFirewallNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallNatRuleCollection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the Azure firewall. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the NAT rule collection resource. </param>
        /// <param name="action"> The action type of a NAT rule collection. </param>
        /// <param name="rules"> Collection of rules used by a NAT rule collection. </param>
        /// <param name="provisioningState"> The provisioning state of the NAT rule collection resource. </param>
        internal AzureFirewallNatRuleCollection(string id, string name, string etag, int? priority, AzureFirewallNatRCAction action, IList<AzureFirewallNatRule> rules, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within the Azure firewall. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Priority of the NAT rule collection resource. </summary>
        public int? Priority { get; set; }
        /// <summary> The action type of a NAT rule collection. </summary>
        public AzureFirewallNatRCAction Action { get; set; }
        /// <summary> Collection of rules used by a NAT rule collection. </summary>
        public IList<AzureFirewallNatRule> Rules { get; set; }
        /// <summary> The provisioning state of the NAT rule collection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
