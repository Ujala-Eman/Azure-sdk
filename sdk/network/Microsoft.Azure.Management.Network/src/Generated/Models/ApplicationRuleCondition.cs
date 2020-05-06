// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Rule condition of type application.
    /// </summary>
    public partial class ApplicationRuleCondition : FirewallPolicyRuleCondition
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationRuleCondition class.
        /// </summary>
        public ApplicationRuleCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationRuleCondition class.
        /// </summary>
        /// <param name="name">Name of the rule condition.</param>
        /// <param name="description">Description of the rule
        /// condition.</param>
        /// <param name="sourceAddresses">List of source IP addresses for this
        /// rule.</param>
        /// <param name="destinationAddresses">List of destination IP addresses
        /// or Service Tags.</param>
        /// <param name="protocols">Array of Application Protocols.</param>
        /// <param name="targetUrls">List of Urls for this rule
        /// condition.</param>
        /// <param name="targetFqdns">List of FQDNs for this rule
        /// condition.</param>
        /// <param name="fqdnTags">List of FQDN Tags for this rule
        /// condition.</param>
        /// <param name="sourceIpGroups">List of source IpGroups for this
        /// rule.</param>
        public ApplicationRuleCondition(string name = default(string), string description = default(string), IList<string> sourceAddresses = default(IList<string>), IList<string> destinationAddresses = default(IList<string>), IList<FirewallPolicyRuleConditionApplicationProtocol> protocols = default(IList<FirewallPolicyRuleConditionApplicationProtocol>), IList<string> targetUrls = default(IList<string>), IList<string> targetFqdns = default(IList<string>), IList<string> fqdnTags = default(IList<string>), IList<string> sourceIpGroups = default(IList<string>))
            : base(name, description)
        {
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            Protocols = protocols;
            TargetUrls = targetUrls;
            TargetFqdns = targetFqdns;
            FqdnTags = fqdnTags;
            SourceIpGroups = sourceIpGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of source IP addresses for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of destination IP addresses or Service Tags.
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddresses")]
        public IList<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Gets or sets array of Application Protocols.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<FirewallPolicyRuleConditionApplicationProtocol> Protocols { get; set; }

        /// <summary>
        /// Gets or sets list of Urls for this rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "targetUrls")]
        public IList<string> TargetUrls { get; set; }

        /// <summary>
        /// Gets or sets list of FQDNs for this rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "targetFqdns")]
        public IList<string> TargetFqdns { get; set; }

        /// <summary>
        /// Gets or sets list of FQDN Tags for this rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "fqdnTags")]
        public IList<string> FqdnTags { get; set; }

        /// <summary>
        /// Gets or sets list of source IpGroups for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

    }
}
