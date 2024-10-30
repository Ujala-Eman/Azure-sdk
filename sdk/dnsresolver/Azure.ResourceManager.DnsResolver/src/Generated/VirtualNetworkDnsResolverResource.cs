// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Text.Json;
using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class extending from the VirtualNetworkResource in Azure.ResourceManager.DnsResolver along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="VirtualNetworkDnsResolverResource"/> from a <see cref="ResourceIdentifier"/> with a resource type of Microsoft.Network/virtualNetworks.
    /// </summary>
    public partial class VirtualNetworkDnsResolverResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualNetworkDnsResolverResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="virtualNetworkName"> The virtualNetworkName. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualNetworkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dnsResolverClientDiagnostics;
        private readonly DnsResolversRestOperations _dnsResolverRestClient;
        private readonly ClientDiagnostics _dnsForwardingRulesetClientDiagnostics;
        private readonly DnsForwardingRulesetsRestOperations _dnsForwardingRulesetRestClient;
        private readonly ClientDiagnostics _dnsResolverPolicyClientDiagnostics;
        private readonly DnsResolverPoliciesRestOperations _dnsResolverPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkDnsResolverResource"/> class for mocking. </summary>
        protected VirtualNetworkDnsResolverResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkDnsResolverResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualNetworkDnsResolverResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsResolverClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverResource.ResourceType, out string dnsResolverApiVersion);
            _dnsResolverRestClient = new DnsResolversRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverApiVersion);
            _dnsForwardingRulesetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsForwardingRulesetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsForwardingRulesetResource.ResourceType, out string dnsForwardingRulesetApiVersion);
            _dnsForwardingRulesetRestClient = new DnsForwardingRulesetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsForwardingRulesetApiVersion);
            _dnsResolverPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverPolicyResource.ResourceType, out string dnsResolverPolicyApiVersion);
            _dnsResolverPolicyRestClient = new DnsResolverPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualNetworks";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Lists DNS resolver resource IDs linked to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WritableSubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WritableSubResource> GetDnsResolversAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => JsonSerializer.Deserialize<WritableSubResource>(e.GetRawText()), _dnsResolverClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsResolvers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS resolver resource IDs linked to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolvers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolvers_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WritableSubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WritableSubResource> GetDnsResolvers(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => JsonSerializer.Deserialize<WritableSubResource>(e.GetRawText()), _dnsResolverClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsResolvers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS forwarding ruleset resource IDs attached to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsForwardingRulesets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkDnsForwardingRuleset"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkDnsForwardingRuleset> GetDnsForwardingRulesetsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => VirtualNetworkDnsForwardingRuleset.DeserializeVirtualNetworkDnsForwardingRuleset(e), _dnsForwardingRulesetClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsForwardingRulesets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS forwarding ruleset resource IDs attached to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsForwardingRulesets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsForwardingRulesets_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsForwardingRulesetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkDnsForwardingRuleset"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkDnsForwardingRuleset> GetDnsForwardingRulesets(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsForwardingRulesetRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsForwardingRulesetRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => VirtualNetworkDnsForwardingRuleset.DeserializeVirtualNetworkDnsForwardingRuleset(e), _dnsForwardingRulesetClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsForwardingRulesets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS resolver policy resource IDs linked to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolverPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolverPolicies_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WritableSubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WritableSubResource> GetDnsResolverPoliciesByVirtualNetworkAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverPolicyRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverPolicyRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => JsonSerializer.Deserialize<WritableSubResource>(e.GetRawText()), _dnsResolverPolicyClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsResolverPoliciesByVirtualNetwork", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists DNS resolver policy resource IDs linked to a virtual network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolverPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsResolverPolicies_ListByVirtualNetwork</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsResolverPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WritableSubResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WritableSubResource> GetDnsResolverPoliciesByVirtualNetwork(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dnsResolverPolicyRestClient.CreateListByVirtualNetworkRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dnsResolverPolicyRestClient.CreateListByVirtualNetworkNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => JsonSerializer.Deserialize<WritableSubResource>(e.GetRawText()), _dnsResolverPolicyClientDiagnostics, Pipeline, "VirtualNetworkDnsResolverResource.GetDnsResolverPoliciesByVirtualNetwork", "value", "nextLink", cancellationToken);
        }
    }
}
