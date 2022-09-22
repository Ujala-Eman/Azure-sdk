// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="ScheduledQueryRuleResource" /> and their operations.
    /// Each <see cref="ScheduledQueryRuleResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScheduledQueryRuleCollection" /> instance call the GetScheduledQueryRules method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScheduledQueryRuleCollection : ArmCollection, IEnumerable<ScheduledQueryRuleResource>, IAsyncEnumerable<ScheduledQueryRuleResource>
    {
        private readonly ClientDiagnostics _scheduledQueryRuleClientDiagnostics;
        private readonly ScheduledQueryRulesRestOperations _scheduledQueryRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScheduledQueryRuleCollection"/> class for mocking. </summary>
        protected ScheduledQueryRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScheduledQueryRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScheduledQueryRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scheduledQueryRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ScheduledQueryRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScheduledQueryRuleResource.ResourceType, out string scheduledQueryRuleApiVersion);
            _scheduledQueryRuleRestClient = new ScheduledQueryRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scheduledQueryRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a scheduled query rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScheduledQueryRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleName, ScheduledQueryRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<ScheduledQueryRuleResource>(Response.FromValue(new ScheduledQueryRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a scheduled query rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The parameters of the rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScheduledQueryRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleName, ScheduledQueryRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ruleName, data, cancellationToken);
                var operation = new MonitorArmOperation<ScheduledQueryRuleResource>(Response.FromValue(new ScheduledQueryRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve an scheduled query rule definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_Get
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<ScheduledQueryRuleResource>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve an scheduled query rule definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_Get
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<ScheduledQueryRuleResource> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScheduledQueryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve scheduled query rule definitions in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules
        /// Operation Id: ScheduledQueryRules_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScheduledQueryRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScheduledQueryRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScheduledQueryRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scheduledQueryRuleRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScheduledQueryRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ScheduledQueryRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scheduledQueryRuleRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScheduledQueryRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieve scheduled query rule definitions in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules
        /// Operation Id: ScheduledQueryRules_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScheduledQueryRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScheduledQueryRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ScheduledQueryRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scheduledQueryRuleRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScheduledQueryRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ScheduledQueryRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scheduledQueryRuleRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScheduledQueryRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_Get
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scheduledQueryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/scheduledQueryRules/{ruleName}
        /// Operation Id: ScheduledQueryRules_Get
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _scheduledQueryRuleClientDiagnostics.CreateScope("ScheduledQueryRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _scheduledQueryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ruleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScheduledQueryRuleResource> IEnumerable<ScheduledQueryRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScheduledQueryRuleResource> IAsyncEnumerable<ScheduledQueryRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
