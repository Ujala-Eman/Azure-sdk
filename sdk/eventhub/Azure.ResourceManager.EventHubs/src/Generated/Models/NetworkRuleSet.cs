// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Description of topic resource. </summary>
    public partial class NetworkRuleSet : Resource
    {
        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        public NetworkRuleSet()
        {
            VirtualNetworkRules = new ChangeTrackingList<NWRuleSetVirtualNetworkRules>();
            IpRules = new ChangeTrackingList<NWRuleSetIpRules>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        internal NetworkRuleSet(string id, string name, string type, DefaultAction? defaultAction, IList<NWRuleSetVirtualNetworkRules> virtualNetworkRules, IList<NWRuleSetIpRules> ipRules) : base(id, name, type)
        {
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IpRules = ipRules;
        }

        /// <summary> Default Action for Network Rule Set. </summary>
        public DefaultAction? DefaultAction { get; set; }
        /// <summary> List VirtualNetwork Rules. </summary>
        public IList<NWRuleSetVirtualNetworkRules> VirtualNetworkRules { get; }
        /// <summary> List of IpRules. </summary>
        public IList<NWRuleSetIpRules> IpRules { get; }
    }
}
