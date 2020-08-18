// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
    public partial class FirewallPolicyThreatIntelWhitelist
    {
        /// <summary> Initializes a new instance of FirewallPolicyThreatIntelWhitelist. </summary>
        public FirewallPolicyThreatIntelWhitelist()
        {
            IpAddresses = new ChangeTrackingList<string>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of FirewallPolicyThreatIntelWhitelist. </summary>
        /// <param name="ipAddresses"> List of IP addresses for the ThreatIntel Whitelist. </param>
        /// <param name="fqdns"> List of FQDNs for the ThreatIntel Whitelist. </param>
        internal FirewallPolicyThreatIntelWhitelist(IList<string> ipAddresses, IList<string> fqdns)
        {
            IpAddresses = ipAddresses;
            Fqdns = fqdns;
        }

        /// <summary> List of IP addresses for the ThreatIntel Whitelist. </summary>
        public IList<string> IpAddresses { get; }
        /// <summary> List of FQDNs for the ThreatIntel Whitelist. </summary>
        public IList<string> Fqdns { get; }
    }
}
