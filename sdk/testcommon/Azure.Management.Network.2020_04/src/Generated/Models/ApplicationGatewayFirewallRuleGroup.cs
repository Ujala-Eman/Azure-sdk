// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Network.Models
{
    /// <summary> A web application firewall rule group. </summary>
    public partial class ApplicationGatewayFirewallRuleGroup
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRuleGroup. </summary>
        /// <param name="ruleGroupName"> The name of the web application firewall rule group. </param>
        /// <param name="rules"> The rules of the web application firewall rule group. </param>
        public ApplicationGatewayFirewallRuleGroup(string ruleGroupName, IEnumerable<ApplicationGatewayFirewallRule> rules)
        {
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            RuleGroupName = ruleGroupName;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRuleGroup. </summary>
        /// <param name="ruleGroupName"> The name of the web application firewall rule group. </param>
        /// <param name="description"> The description of the web application firewall rule group. </param>
        /// <param name="rules"> The rules of the web application firewall rule group. </param>
        internal ApplicationGatewayFirewallRuleGroup(string ruleGroupName, string description, IList<ApplicationGatewayFirewallRule> rules)
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
        }

        /// <summary> The name of the web application firewall rule group. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> The description of the web application firewall rule group. </summary>
        public string Description { get; set; }
        /// <summary> The rules of the web application firewall rule group. </summary>
        public IList<ApplicationGatewayFirewallRule> Rules { get; }
    }
}
