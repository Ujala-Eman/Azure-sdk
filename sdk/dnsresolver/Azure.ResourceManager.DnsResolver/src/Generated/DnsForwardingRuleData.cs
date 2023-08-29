// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing the DnsForwardingRule data model.
    /// Describes a forwarding rule within a DNS forwarding ruleset.
    /// </summary>
    public partial class DnsForwardingRuleData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRuleData"/>. </summary>
        /// <param name="domainName"> The domain name for the forwarding rule. </param>
        /// <param name="targetDnsServers"> DNS servers to forward the DNS query to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="targetDnsServers"/> is null. </exception>
        public DnsForwardingRuleData(string domainName, IEnumerable<TargetDnsServer> targetDnsServers)
        {
            Argument.AssertNotNull(domainName, nameof(domainName));
            Argument.AssertNotNull(targetDnsServers, nameof(targetDnsServers));

            DomainName = domainName;
            TargetDnsServers = targetDnsServers.ToList();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> ETag of the forwarding rule. </param>
        /// <param name="domainName"> The domain name for the forwarding rule. </param>
        /// <param name="targetDnsServers"> DNS servers to forward the DNS query to. </param>
        /// <param name="metadata"> Metadata attached to the forwarding rule. </param>
        /// <param name="dnsForwardingRuleState"> The state of forwarding rule. </param>
        /// <param name="provisioningState"> The current provisioning state of the forwarding rule. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsForwardingRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string domainName, IList<TargetDnsServer> targetDnsServers, IDictionary<string, string> metadata, DnsForwardingRuleState? dnsForwardingRuleState, DnsResolverProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            DomainName = domainName;
            TargetDnsServers = targetDnsServers;
            Metadata = metadata;
            DnsForwardingRuleState = dnsForwardingRuleState;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRuleData"/> for deserialization. </summary>
        internal DnsForwardingRuleData()
        {
        }

        /// <summary> ETag of the forwarding rule. </summary>
        public ETag? ETag { get; }
        /// <summary> The domain name for the forwarding rule. </summary>
        public string DomainName { get; set; }
        /// <summary> DNS servers to forward the DNS query to. </summary>
        public IList<TargetDnsServer> TargetDnsServers { get; }
        /// <summary> Metadata attached to the forwarding rule. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The state of forwarding rule. </summary>
        public DnsForwardingRuleState? DnsForwardingRuleState { get; set; }
        /// <summary> The current provisioning state of the forwarding rule. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
    }
}
