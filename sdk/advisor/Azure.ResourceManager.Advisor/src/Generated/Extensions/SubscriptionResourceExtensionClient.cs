// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Advisor.Models;

namespace Azure.ResourceManager.Advisor
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _configurationsClientDiagnostics;
        private ConfigurationsRestOperations _configurationsRestClient;
        private ClientDiagnostics _resourceRecommendationBaseRecommendationsClientDiagnostics;
        private RecommendationsRestOperations _resourceRecommendationBaseRecommendationsRestClient;
        private ClientDiagnostics _suppressionContractSuppressionsClientDiagnostics;
        private SuppressionsRestOperations _suppressionContractSuppressionsRestClient;

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

        private ClientDiagnostics ConfigurationsClientDiagnostics => _configurationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Advisor", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ConfigurationsRestOperations ConfigurationsRestClient => _configurationsRestClient ??= new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ResourceRecommendationBaseRecommendationsClientDiagnostics => _resourceRecommendationBaseRecommendationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Advisor", ResourceRecommendationBaseResource.ResourceType.Namespace, Diagnostics);
        private RecommendationsRestOperations ResourceRecommendationBaseRecommendationsRestClient => _resourceRecommendationBaseRecommendationsRestClient ??= new RecommendationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResourceRecommendationBaseResource.ResourceType));
        private ClientDiagnostics SuppressionContractSuppressionsClientDiagnostics => _suppressionContractSuppressionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Advisor", SuppressionContractResource.ResourceType.Namespace, Diagnostics);
        private SuppressionsRestOperations SuppressionContractSuppressionsRestClient => _suppressionContractSuppressionsRestClient ??= new SuppressionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SuppressionContractResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations and also retrieve configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigData> GetConfigurationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfigurationsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfigurationsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ConfigData.DeserializeConfigData, ConfigurationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve Azure Advisor configurations and also retrieve configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigData> GetConfigurations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfigurationsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfigurationsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ConfigData.DeserializeConfigData, ConfigurationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetConfigurations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration and also delete all configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConfigData>> CreateConfigurationAsync(ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            using var scope = ConfigurationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CreateConfiguration");
            scope.Start();
            try
            {
                var response = await ConfigurationsRestClient.CreateInSubscriptionAsync(Id.SubscriptionId, configurationName, data, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create/Overwrite Azure Advisor configuration and also delete all configurations of contained resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/configurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Configurations_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Advisor configuration name. Value must be 'default'. </param>
        /// <param name="data"> The Azure Advisor configuration data structure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConfigData> CreateConfiguration(ConfigurationName configurationName, ConfigData data, CancellationToken cancellationToken = default)
        {
            using var scope = ConfigurationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CreateConfiguration");
            scope.Start();
            try
            {
                var response = ConfigurationsRestClient.CreateInSubscription(Id.SubscriptionId, configurationName, data, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Initiates the recommendation generation or computation process for a subscription. This operation is asynchronous. The generated recommendations are stored in a cache in the Advisor service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Generate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GenerateRecommendationAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ResourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GenerateRecommendation");
            scope.Start();
            try
            {
                var response = await ResourceRecommendationBaseRecommendationsRestClient.GenerateAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Initiates the recommendation generation or computation process for a subscription. This operation is asynchronous. The generated recommendations are stored in a cache in the Advisor service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_Generate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GenerateRecommendation(CancellationToken cancellationToken = default)
        {
            using var scope = ResourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GenerateRecommendation");
            scope.Start();
            try
            {
                var response = ResourceRecommendationBaseRecommendationsRestClient.Generate(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the status of the recommendation computation or generation process. Invoke this API after calling the generation recommendation. The URI of this API is returned in the Location field of the response header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetGenerateStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> The operation ID, which can be found from the Location field in the generate recommendation response header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetGenerateStatusRecommendationAsync(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = ResourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGenerateStatusRecommendation");
            scope.Start();
            try
            {
                var response = await ResourceRecommendationBaseRecommendationsRestClient.GetGenerateStatusAsync(Id.SubscriptionId, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the status of the recommendation computation or generation process. Invoke this API after calling the generation recommendation. The URI of this API is returned in the Location field of the response header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/generateRecommendations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Recommendations_GetGenerateStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationId"> The operation ID, which can be found from the Location field in the generate recommendation response header. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetGenerateStatusRecommendation(Guid operationId, CancellationToken cancellationToken = default)
        {
            using var scope = ResourceRecommendationBaseRecommendationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGenerateStatusRecommendation");
            scope.Start();
            try
            {
                var response = ResourceRecommendationBaseRecommendationsRestClient.GetGenerateStatus(Id.SubscriptionId, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a subscription. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/suppressions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of suppressions per page if a paged version of this API is being used. </param>
        /// <param name="skipToken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SuppressionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SuppressionContractResource> GetSuppressionContractsAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SuppressionContractSuppressionsRestClient.CreateListRequest(Id.SubscriptionId, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SuppressionContractSuppressionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SuppressionContractResource(Client, SuppressionContractData.DeserializeSuppressionContractData(e)), SuppressionContractSuppressionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSuppressionContracts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the list of snoozed or dismissed suppressions for a subscription. The snoozed or dismissed attribute of a recommendation is referred to as a suppression.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Advisor/suppressions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Suppressions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of suppressions per page if a paged version of this API is being used. </param>
        /// <param name="skipToken"> The page-continuation token to use with a paged version of this API. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SuppressionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SuppressionContractResource> GetSuppressionContracts(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SuppressionContractSuppressionsRestClient.CreateListRequest(Id.SubscriptionId, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SuppressionContractSuppressionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SuppressionContractResource(Client, SuppressionContractData.DeserializeSuppressionContractData(e)), SuppressionContractSuppressionsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSuppressionContracts", "value", "nextLink", cancellationToken);
        }
    }
}
