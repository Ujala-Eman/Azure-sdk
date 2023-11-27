// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Topic update. </summary>
    public partial class EventGridTopicPatch
    {
        /// <summary> Initializes a new instance of <see cref="EventGridTopicPatch"/>. </summary>
        public EventGridTopicPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Tags of the Topic resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Topic resource identity information. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Sku pricing tier for the topic. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> The Sku name of the resource. The possible values are: Basic or Premium. </summary>
        public EventGridSku? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new ResourceSku();
                Sku.Name = value;
            }
        }

        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref="P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.TopicUpdateParameterProperties.InboundIpRules" /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> Minimum TLS version of the publisher allowed to publish to this domain. </summary>
        public TlsVersion? MinimumTlsVersionAllowed { get; set; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the topic. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary> The data residency boundary for the topic. </summary>
        public DataResidencyBoundary? DataResidencyBoundary { get; set; }
        /// <summary> The eventTypeInfo for the topic. </summary>
        public PartnerTopicEventTypeInfo EventTypeInfo { get; set; }
    }
}
