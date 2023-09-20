// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _configurationGroupValueconfigurationGroupValuesClientDiagnostics;
        private ConfigurationGroupValuesRestOperations _configurationGroupValueconfigurationGroupValuesRestClient;
        private ClientDiagnostics _networkFunctionClientDiagnostics;
        private NetworkFunctionsRestOperations _networkFunctionRestClient;
        private ClientDiagnostics _publisherClientDiagnostics;
        private PublishersRestOperations _publisherRestClient;
        private ClientDiagnostics _siteClientDiagnostics;
        private SitesRestOperations _siteRestClient;
        private ClientDiagnostics _siteNetworkServiceClientDiagnostics;
        private SiteNetworkServicesRestOperations _siteNetworkServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ConfigurationGroupValueconfigurationGroupValuesClientDiagnostics => _configurationGroupValueconfigurationGroupValuesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", ConfigurationGroupValueResource.ResourceType.Namespace, Diagnostics);
        private ConfigurationGroupValuesRestOperations ConfigurationGroupValueconfigurationGroupValuesRestClient => _configurationGroupValueconfigurationGroupValuesRestClient ??= new ConfigurationGroupValuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ConfigurationGroupValueResource.ResourceType));
        private ClientDiagnostics NetworkFunctionClientDiagnostics => _networkFunctionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkFunctionResource.ResourceType.Namespace, Diagnostics);
        private NetworkFunctionsRestOperations NetworkFunctionRestClient => _networkFunctionRestClient ??= new NetworkFunctionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NetworkFunctionResource.ResourceType));
        private ClientDiagnostics PublisherClientDiagnostics => _publisherClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", PublisherResource.ResourceType.Namespace, Diagnostics);
        private PublishersRestOperations PublisherRestClient => _publisherRestClient ??= new PublishersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PublisherResource.ResourceType));
        private ClientDiagnostics SiteClientDiagnostics => _siteClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", SiteResource.ResourceType.Namespace, Diagnostics);
        private SitesRestOperations SiteRestClient => _siteRestClient ??= new SitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SiteResource.ResourceType));
        private ClientDiagnostics SiteNetworkServiceClientDiagnostics => _siteNetworkServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", SiteNetworkServiceResource.ResourceType.Namespace, Diagnostics);
        private SiteNetworkServicesRestOperations SiteNetworkServiceRestClient => _siteNetworkServiceRestClient ??= new SiteNetworkServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SiteNetworkServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all sites in the configuration group value in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/configurationGroupValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>configurationGroupValues_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationGroupValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationGroupValueResource> GetConfigurationGroupValuesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfigurationGroupValueconfigurationGroupValuesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfigurationGroupValueconfigurationGroupValuesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ConfigurationGroupValueResource(Client, ConfigurationGroupValueData.DeserializeConfigurationGroupValueData(e)), ConfigurationGroupValueconfigurationGroupValuesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurationGroupValues", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the configuration group value in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/configurationGroupValues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>configurationGroupValues_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationGroupValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationGroupValueResource> GetConfigurationGroupValues(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfigurationGroupValueconfigurationGroupValuesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfigurationGroupValueconfigurationGroupValuesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ConfigurationGroupValueResource(Client, ConfigurationGroupValueData.DeserializeConfigurationGroupValueData(e)), ConfigurationGroupValueconfigurationGroupValuesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurationGroupValues", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the network functions in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/networkFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFunctionResource> GetNetworkFunctionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetworkFunctionRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetworkFunctionRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionResource(Client, NetworkFunctionData.DeserializeNetworkFunctionData(e)), NetworkFunctionClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetworkFunctions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the network functions in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/networkFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFunctions_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFunctionResource> GetNetworkFunctions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NetworkFunctionRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NetworkFunctionRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionResource(Client, NetworkFunctionData.DeserializeNetworkFunctionData(e)), NetworkFunctionClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetNetworkFunctions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the publishers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublisherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublisherResource> GetPublishersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PublisherRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PublisherRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), PublisherClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetPublishers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the publishers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublisherResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublisherResource> GetPublishers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PublisherRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => PublisherRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), PublisherClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetPublishers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the network service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteResource> GetSitesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SiteRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SiteRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteResource(Client, SiteData.DeserializeSiteData(e)), SiteClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSites", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the network service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/sites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteResource> GetSites(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SiteRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SiteRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteResource(Client, SiteData.DeserializeSiteData(e)), SiteClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSites", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the network service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/siteNetworkServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SiteNetworkServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteNetworkServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteNetworkServiceResource> GetSiteNetworkServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SiteNetworkServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SiteNetworkServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteNetworkServiceResource(Client, SiteNetworkServiceData.DeserializeSiteNetworkServiceData(e)), SiteNetworkServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSiteNetworkServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all sites in the network service in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/siteNetworkServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SiteNetworkServices_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteNetworkServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteNetworkServiceResource> GetSiteNetworkServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SiteNetworkServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SiteNetworkServiceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteNetworkServiceResource(Client, SiteNetworkServiceData.DeserializeSiteNetworkServiceData(e)), SiteNetworkServiceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSiteNetworkServices", "value", "nextLink", cancellationToken);
        }
    }
}
