// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A web application firewall rule group.
    /// </summary>
    public partial class ApplicationGatewayFirewallRuleGroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFirewallRuleGroup class.
        /// </summary>
        public ApplicationGatewayFirewallRuleGroup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFirewallRuleGroup class.
        /// </summary>
        /// <param name="ruleGroupName">The name of the web application
        /// firewall rule group.</param>
        /// <param name="rules">The rules of the web application firewall rule
        /// group.</param>
        /// <param name="description">The description of the web application
        /// firewall rule group.</param>
        public ApplicationGatewayFirewallRuleGroup(string ruleGroupName, IList<ApplicationGatewayFirewallRule> rules, string description = default(string))
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the web application firewall rule group.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Gets or sets the description of the web application firewall rule
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the rules of the web application firewall rule group.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ApplicationGatewayFirewallRule> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleGroupName");
            }
            if (Rules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rules");
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
