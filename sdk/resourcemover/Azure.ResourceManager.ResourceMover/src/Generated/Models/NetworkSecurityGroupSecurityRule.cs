// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Security Rule data model for Network Security Groups. </summary>
    public partial class NetworkSecurityGroupSecurityRule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupSecurityRule"/>. </summary>
        public NetworkSecurityGroupSecurityRule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupSecurityRule"/>. </summary>
        /// <param name="name"> Gets or sets the Security rule name. </param>
        /// <param name="access">
        /// Gets or sets whether network traffic is allowed or denied.
        /// Possible values are “Allow” and “Deny”.
        /// </param>
        /// <param name="description"> Gets or sets a description for this rule. Restricted to 140 chars. </param>
        /// <param name="destinationAddressPrefix">
        /// Gets or sets destination address prefix. CIDR or source IP range.
        ///  A “*” can also be used to match all source IPs. Default tags such
        /// as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and ‘Internet’ can also be used.
        /// </param>
        /// <param name="destinationPortRange">
        /// Gets or sets Destination Port or Range. Integer or range between
        /// 0 and 65535. A “*” can also be used to match all ports.
        /// </param>
        /// <param name="direction">
        /// Gets or sets the direction of the rule.InBound or Outbound. The
        /// direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </param>
        /// <param name="priority">
        /// Gets or sets the priority of the rule. The value can be between
        /// 100 and 4096. The priority number must be unique for each rule in the collection.
        /// The lower the priority number, the higher the priority of the rule.
        /// </param>
        /// <param name="protocol"> Gets or sets Network protocol this rule applies to. Can be Tcp, Udp or All(*). </param>
        /// <param name="sourceAddressPrefix">
        /// Gets or sets source address prefix. CIDR or source IP range. A
        /// “*” can also be used to match all source IPs.  Default tags such as ‘VirtualNetwork’,
        /// ‘AzureLoadBalancer’ and ‘Internet’ can also be used. If this is an ingress
        /// rule, specifies where network traffic originates from.
        /// </param>
        /// <param name="sourcePortRange">
        /// Gets or sets Source Port or Range. Integer or range between 0 and
        /// 65535. A “*” can also be used to match all ports.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityGroupSecurityRule(string name, string access, string description, string destinationAddressPrefix, string destinationPortRange, string direction, int? priority, string protocol, string sourceAddressPrefix, string sourcePortRange, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Access = access;
            Description = description;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationPortRange = destinationPortRange;
            Direction = direction;
            Priority = priority;
            Protocol = protocol;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRange = sourcePortRange;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the Security rule name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets whether network traffic is allowed or denied.
        /// Possible values are “Allow” and “Deny”.
        /// </summary>
        public string Access { get; set; }
        /// <summary> Gets or sets a description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets destination address prefix. CIDR or source IP range.
        ///  A “*” can also be used to match all source IPs. Default tags such
        /// as ‘VirtualNetwork’, ‘AzureLoadBalancer’ and ‘Internet’ can also be used.
        /// </summary>
        public string DestinationAddressPrefix { get; set; }
        /// <summary>
        /// Gets or sets Destination Port or Range. Integer or range between
        /// 0 and 65535. A “*” can also be used to match all ports.
        /// </summary>
        public string DestinationPortRange { get; set; }
        /// <summary>
        /// Gets or sets the direction of the rule.InBound or Outbound. The
        /// direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </summary>
        public string Direction { get; set; }
        /// <summary>
        /// Gets or sets the priority of the rule. The value can be between
        /// 100 and 4096. The priority number must be unique for each rule in the collection.
        /// The lower the priority number, the higher the priority of the rule.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary> Gets or sets Network protocol this rule applies to. Can be Tcp, Udp or All(*). </summary>
        public string Protocol { get; set; }
        /// <summary>
        /// Gets or sets source address prefix. CIDR or source IP range. A
        /// “*” can also be used to match all source IPs.  Default tags such as ‘VirtualNetwork’,
        /// ‘AzureLoadBalancer’ and ‘Internet’ can also be used. If this is an ingress
        /// rule, specifies where network traffic originates from.
        /// </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary>
        /// Gets or sets Source Port or Range. Integer or range between 0 and
        /// 65535. A “*” can also be used to match all ports.
        /// </summary>
        public string SourcePortRange { get; set; }
    }
}
