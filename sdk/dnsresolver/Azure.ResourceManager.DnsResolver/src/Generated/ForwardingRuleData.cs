// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary> A class representing the ForwardingRule data model. </summary>
    public partial class ForwardingRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of ForwardingRuleData. </summary>
        public ForwardingRuleData()
        {
            TargetDnsServers = new ChangeTrackingList<TargetDnsServer>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ForwardingRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> ETag of the forwarding rule. </param>
        /// <param name="domainName"> The domain name for the forwarding rule. </param>
        /// <param name="targetDnsServers"> DNS servers to forward the DNS query to. </param>
        /// <param name="metadata"> Metadata attached to the forwarding rule. </param>
        /// <param name="forwardingRuleState"> The state of forwarding rule. </param>
        /// <param name="provisioningState"> The current provisioning state of the forwarding rule. This is a read-only property and any attempt to set this value will be ignored. </param>
        internal ForwardingRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? eTag, string domainName, IList<TargetDnsServer> targetDnsServers, IDictionary<string, string> metadata, ForwardingRuleState? forwardingRuleState, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            DomainName = domainName;
            TargetDnsServers = targetDnsServers;
            Metadata = metadata;
            ForwardingRuleState = forwardingRuleState;
            ProvisioningState = provisioningState;
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
        public ForwardingRuleState? ForwardingRuleState { get; set; }
        /// <summary> The current provisioning state of the forwarding rule. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
