// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _policyTrackedResourcesClientDiagnostics;
        private PolicyTrackedResourcesRestOperations _policyTrackedResourcesRestClient;
        private ClientDiagnostics _policyEventsClientDiagnostics;
        private PolicyEventsRestOperations _policyEventsRestClient;
        private ClientDiagnostics _policyStatesClientDiagnostics;
        private PolicyStatesRestOperations _policyStatesRestClient;
        private ClientDiagnostics _policyRestrictionsClientDiagnostics;
        private PolicyRestrictionsRestOperations _policyRestrictionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics PolicyTrackedResourcesClientDiagnostics => _policyTrackedResourcesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyTrackedResourcesRestOperations PolicyTrackedResourcesRestClient => _policyTrackedResourcesRestClient ??= new PolicyTrackedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyEventsClientDiagnostics => _policyEventsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyEventsRestOperations PolicyEventsRestClient => _policyEventsRestClient ??= new PolicyEventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyStatesClientDiagnostics => _policyStatesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyStatesRestOperations PolicyStatesRestClient => _policyStatesRestClient ??= new PolicyStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics PolicyRestrictionsClientDiagnostics => _policyRestrictionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private PolicyRestrictionsRestOperations PolicyRestrictionsRestClient => _policyRestrictionsRestClient ??= new PolicyRestrictionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults
        /// Operation Id: PolicyTrackedResources_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyTrackedResourcesResource"> The name of the virtual resource under PolicyTrackedResources resource type; only &quot;default&quot; is allowed. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResultsAsync(PolicyTrackedResourceType policyTrackedResourcesResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyTrackedResourceRecord>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyTrackedResourcesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyTrackedResourcesRestClient.ListQueryResultsForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourcesResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyTrackedResourceRecord>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyTrackedResourcesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyTrackedResourcesRestClient.ListQueryResultsForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourcesResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Queries policy tracked resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyTrackedResources/{policyTrackedResourcesResource}/queryResults
        /// Operation Id: PolicyTrackedResources_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyTrackedResourcesResource"> The name of the virtual resource under PolicyTrackedResources resource type; only &quot;default&quot; is allowed. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyTrackedResourceRecord" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyTrackedResourceRecord> GetPolicyTrackedResourceQueryResults(PolicyTrackedResourceType policyTrackedResourcesResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyTrackedResourceRecord> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyTrackedResourcesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyTrackedResourcesRestClient.ListQueryResultsForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourcesResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyTrackedResourceRecord> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyTrackedResourcesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyTrackedResourceQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyTrackedResourcesRestClient.ListQueryResultsForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyTrackedResourcesResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Queries policy events for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults
        /// Operation Id: PolicyEvents_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyEventsResource"> The name of the virtual resource under PolicyEvents resource type; only &quot;default&quot; is allowed. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyEvent> GetPolicyEventQueryResultsAsync(PolicyEventType policyEventsResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyEvent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyEventsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyEventsRestClient.ListQueryResultsForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, policyEventsResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyEvent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyEventsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyEventsRestClient.ListQueryResultsForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyEventsResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Queries policy events for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyEvents/{policyEventsResource}/queryResults
        /// Operation Id: PolicyEvents_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyEventsResource"> The name of the virtual resource under PolicyEvents resource type; only &quot;default&quot; is allowed. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyEvent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyEvent> GetPolicyEventQueryResults(PolicyEventType policyEventsResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyEvent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyEventsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyEventsRestClient.ListQueryResultsForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, policyEventsResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyEvent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyEventsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyEventQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyEventsRestClient.ListQueryResultsForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyEventsResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Queries policy states for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults
        /// Operation Id: PolicyStates_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyStatesResource"> The virtual resource under PolicyStates resource type. In a given time range, &apos;latest&apos; represents the latest policy state(s), whereas &apos;default&apos; represents all policy state(s). </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyState> GetPolicyStateQueryResultsAsync(PolicyStateType policyStatesResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyState>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyStatesRestClient.ListQueryResultsForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, policyStatesResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyState>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults");
                scope.Start();
                try
                {
                    var response = await PolicyStatesRestClient.ListQueryResultsForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyStatesResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Queries policy states for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesResource}/queryResults
        /// Operation Id: PolicyStates_ListQueryResultsForResourceGroup
        /// </summary>
        /// <param name="policyStatesResource"> The virtual resource under PolicyStates resource type. In a given time range, &apos;latest&apos; represents the latest policy state(s), whereas &apos;default&apos; represents all policy state(s). </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyState" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyState> GetPolicyStateQueryResults(PolicyStateType policyStatesResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyState> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyStatesRestClient.ListQueryResultsForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, policyStatesResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyState> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetPolicyStateQueryResults");
                scope.Start();
                try
                {
                    var response = PolicyStatesRestClient.ListQueryResultsForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, policyStatesResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.ODataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize
        /// Operation Id: PolicyStates_SummarizeForResourceGroup
        /// </summary>
        /// <param name="policyStatesSummaryResource"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, &apos;latest&apos; represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicySummary> SummarizePolicyStatesAsync(PolicyStateSummaryType policyStatesSummaryResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicySummary>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.SummarizePolicyStates");
                scope.Start();
                try
                {
                    var response = await PolicyStatesRestClient.SummarizeForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, policyStatesSummaryResource, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Summarizes policy states for the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/{policyStatesSummaryResource}/summarize
        /// Operation Id: PolicyStates_SummarizeForResourceGroup
        /// </summary>
        /// <param name="policyStatesSummaryResource"> The virtual resource under PolicyStates resource type for summarize action. In a given time range, &apos;latest&apos; represents the latest policy state(s) and is the only allowed value. </param>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicySummary" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicySummary> SummarizePolicyStates(PolicyStateSummaryType policyStatesSummaryResource, PolicyQuerySettings queryOptions = null, CancellationToken cancellationToken = default)
        {
            Page<PolicySummary> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.SummarizePolicyStates");
                scope.Start();
                try
                {
                    var response = PolicyStatesRestClient.SummarizeForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, policyStatesSummaryResource, queryOptions, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Triggers a policy evaluation scan for all the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/latest/triggerEvaluation
        /// Operation Id: PolicyStates_TriggerResourceGroupEvaluation
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> TriggerPolicyStateEvaluationAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.TriggerPolicyStateEvaluation");
            scope.Start();
            try
            {
                var response = await PolicyStatesRestClient.TriggerResourceGroupEvaluationAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation(PolicyStatesClientDiagnostics, Pipeline, PolicyStatesRestClient.CreateTriggerResourceGroupEvaluationRequest(Id.SubscriptionId, Id.ResourceGroupName).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Triggers a policy evaluation scan for all the resources under the resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/policyStates/latest/triggerEvaluation
        /// Operation Id: PolicyStates_TriggerResourceGroupEvaluation
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation TriggerPolicyStateEvaluation(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyStatesClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.TriggerPolicyStateEvaluation");
            scope.Start();
            try
            {
                var response = PolicyStatesRestClient.TriggerResourceGroupEvaluation(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                var operation = new PolicyInsightsArmOperation(PolicyStatesClientDiagnostics, Pipeline, PolicyStatesRestClient.CreateTriggerResourceGroupEvaluationRequest(Id.SubscriptionId, Id.ResourceGroupName).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on a resource within a resource group. Use this when the resource group the resource will be created in is already known.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions
        /// Operation Id: PolicyRestrictions_CheckAtResourceGroupScope
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckPolicyRestrictionsResult>> CheckPolicyRestrictionsAsync(CheckPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = await PolicyRestrictionsRestClient.CheckAtResourceGroupScopeAsync(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks what restrictions Azure Policy will place on a resource within a resource group. Use this when the resource group the resource will be created in is already known.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/checkPolicyRestrictions
        /// Operation Id: PolicyRestrictions_CheckAtResourceGroupScope
        /// </summary>
        /// <param name="content"> The check policy restrictions parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckPolicyRestrictionsResult> CheckPolicyRestrictions(CheckPolicyRestrictionsContent content, CancellationToken cancellationToken = default)
        {
            using var scope = PolicyRestrictionsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.CheckPolicyRestrictions");
            scope.Start();
            try
            {
                var response = PolicyRestrictionsRestClient.CheckAtResourceGroupScope(Id.SubscriptionId, Id.ResourceGroupName, content, cancellationToken);
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
