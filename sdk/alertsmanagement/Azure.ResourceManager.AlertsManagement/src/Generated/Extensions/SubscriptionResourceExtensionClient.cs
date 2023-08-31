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
using Azure.ResourceManager.AlertsManagement.Models;

namespace Azure.ResourceManager.AlertsManagement
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _alertProcessingRuleClientDiagnostics;
        private AlertProcessingRulesRestOperations _alertProcessingRuleRestClient;
        private ClientDiagnostics _serviceAlertAlertsClientDiagnostics;
        private AlertsRestOperations _serviceAlertAlertsRestClient;

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

        private ClientDiagnostics AlertProcessingRuleClientDiagnostics => _alertProcessingRuleClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", AlertProcessingRuleResource.ResourceType.Namespace, Diagnostics);
        private AlertProcessingRulesRestOperations AlertProcessingRuleRestClient => _alertProcessingRuleRestClient ??= new AlertProcessingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AlertProcessingRuleResource.ResourceType));
        private ClientDiagnostics ServiceAlertAlertsClientDiagnostics => _serviceAlertAlertsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AlertsManagement", ServiceAlertResource.ResourceType.Namespace, Diagnostics);
        private AlertsRestOperations ServiceAlertAlertsRestClient => _serviceAlertAlertsRestClient ??= new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ServiceAlertResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServiceAlertResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ServiceAlertResources and their operations over a ServiceAlertResource. </returns>
        public virtual ServiceAlertCollection GetServiceAlerts()
        {
            return GetCachedClient(Client => new ServiceAlertCollection(Client, Id));
        }

        /// <summary> Gets a collection of SmartGroupResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of SmartGroupResources and their operations over a SmartGroupResource. </returns>
        public virtual SmartGroupCollection GetSmartGroups()
        {
            return GetCachedClient(Client => new SmartGroupCollection(Client, Id));
        }

        /// <summary>
        /// List all alert processing rules in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/actionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AlertProcessingRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AlertProcessingRuleResource> GetAlertProcessingRulesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AlertProcessingRuleRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AlertProcessingRuleRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AlertProcessingRuleResource(Client, AlertProcessingRuleData.DeserializeAlertProcessingRuleData(e)), AlertProcessingRuleClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAlertProcessingRules", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all alert processing rules in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/actionRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertProcessingRules_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AlertProcessingRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AlertProcessingRuleResource> GetAlertProcessingRules(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AlertProcessingRuleRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AlertProcessingRuleRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AlertProcessingRuleResource(Client, AlertProcessingRuleData.DeserializeAlertProcessingRuleData(e)), AlertProcessingRuleClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAlertProcessingRules", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a summarized count of your alerts grouped by various parameters (e.g. grouping by 'Severity' returns the count of alerts for each severity).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alertsSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSummary</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceAlertSummary>> GetServiceAlertSummaryAsync(SubscriptionResourceGetServiceAlertSummaryOptions options, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceAlertAlertsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetServiceAlertSummary");
            scope.Start();
            try
            {
                var response = await ServiceAlertAlertsRestClient.GetSummaryAsync(Id.SubscriptionId, options.Groupby, options.IncludeSmartGroupsCount, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.TimeRange, options.CustomTimeRange, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a summarized count of your alerts grouped by various parameters (e.g. grouping by 'Severity' returns the count of alerts for each severity).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AlertsManagement/alertsSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetSummary</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceAlertSummary> GetServiceAlertSummary(SubscriptionResourceGetServiceAlertSummaryOptions options, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceAlertAlertsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetServiceAlertSummary");
            scope.Start();
            try
            {
                var response = ServiceAlertAlertsRestClient.GetSummary(Id.SubscriptionId, options.Groupby, options.IncludeSmartGroupsCount, options.TargetResource, options.TargetResourceType, options.TargetResourceGroup, options.MonitorService, options.MonitorCondition, options.Severity, options.AlertState, options.AlertRule, options.TimeRange, options.CustomTimeRange, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
