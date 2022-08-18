// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.PolicyInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="RemediationResource" /> and their operations.
    /// Each <see cref="RemediationResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RemediationCollection" /> instance call the GetRemediations method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RemediationCollection : ArmCollection, IEnumerable<ManagementGroupRemediationResource>, IAsyncEnumerable<ManagementGroupRemediationResource>
    {
        private readonly ClientDiagnostics _remediationClientDiagnostics;
        private readonly RemediationsRestOperations _remediationRestClient;
        private readonly ClientDiagnostics _managementGroupRemediationRemediationsClientDiagnostics;
        private readonly RemediationsRestOperations _managementGroupRemediationRemediationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RemediationCollection"/> class for mocking. </summary>
        protected RemediationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RemediationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RemediationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _remediationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", RemediationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RemediationResource.ResourceType, out string remediationApiVersion);
            _remediationRestClient = new RemediationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, remediationApiVersion);
            _managementGroupRemediationRemediationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ManagementGroupRemediationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagementGroupRemediationResource.ResourceType, out string managementGroupRemediationRemediationsApiVersion);
            _managementGroupRemediationRemediationsRestClient = new RemediationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managementGroupRemediationRemediationsApiVersion);
        }

        /// <summary>
        /// Creates or updates a remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RemediationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string remediationName, RemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _remediationRestClient.CreateOrUpdateAtResourceAsync(Id, remediationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<RemediationResource>(Response.FromValue(new RemediationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_CreateOrUpdateAtResource
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RemediationResource> CreateOrUpdate(WaitUntil waitUntil, string remediationName, RemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _remediationRestClient.CreateOrUpdateAtResource(Id, remediationName, data, cancellationToken);
                var operation = new PolicyInsightsArmOperation<RemediationResource>(Response.FromValue(new RemediationResource(Client, response), response.GetRawResponse()));
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
        /// Gets an existing remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual async Task<Response<RemediationResource>> GetAsync(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.Get");
            scope.Start();
            try
            {
                var response = await _remediationRestClient.GetAtResourceAsync(Id, remediationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual Response<RemediationResource> Get(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.Get");
            scope.Start();
            try
            {
                var response = _remediationRestClient.GetAtResource(Id, remediationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all remediations for the management group.
        /// Request Path: /providers/{managementGroupsNamespace}/managementGroups/{managementGroupId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForManagementGroup
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForSubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResourceGroup
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResource
        /// </summary>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupRemediationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupRemediationResource> GetAllAsync(QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ManagementGroupResource.ResourceType)
            {
                async Task<Page<ManagementGroupRemediationResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _managementGroupRemediationRemediationsRestClient.ListForManagementGroupAsync(Id.Name, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagementGroupRemediationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _managementGroupRemediationRemediationsRestClient.ListForManagementGroupNextPageAsync(nextLink, Id.Name, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                async Task<Page<ManagementGroupRemediationResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _subscriptionRemediationRemediationsRestClient.ListForSubscriptionAsync(Id.SubscriptionId, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagementGroupRemediationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _subscriptionRemediationRemediationsRestClient.ListForSubscriptionNextPageAsync(nextLink, Id.SubscriptionId, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                async Task<Page<ManagementGroupRemediationResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _resourceGroupRemediationRemediationsRestClient.ListForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagementGroupRemediationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _resourceGroupRemediationRemediationsRestClient.ListForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == "")
            {
                async Task<Page<ManagementGroupRemediationResource>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _remediationRestClient.ListForResourceAsync(Id, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagementGroupRemediationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _remediationRestClient.ListForResourceNextPageAsync(nextLink, Id, queryOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// Gets all remediations for the management group.
        /// Request Path: /providers/{managementGroupsNamespace}/managementGroups/{managementGroupId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForManagementGroup
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForSubscription
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResourceGroup
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations
        /// Operation Id: Remediations_ListForResource
        /// </summary>
        /// <param name="queryOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupRemediationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupRemediationResource> GetAll(QueryOptions queryOptions = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == ManagementGroupResource.ResourceType)
            {
                Page<ManagementGroupRemediationResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _managementGroupRemediationRemediationsRestClient.ListForManagementGroup(Id.Name, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagementGroupRemediationResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _managementGroupRemediationRemediationsRestClient.ListForManagementGroupNextPage(nextLink, Id.Name, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == SubscriptionResource.ResourceType)
            {
                Page<ManagementGroupRemediationResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _subscriptionRemediationRemediationsRestClient.ListForSubscription(Id.SubscriptionId, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagementGroupRemediationResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _subscriptionRemediationRemediationsRestClient.ListForSubscriptionNextPage(nextLink, Id.SubscriptionId, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ResourceGroupResource.ResourceType)
            {
                Page<ManagementGroupRemediationResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _resourceGroupRemediationRemediationsRestClient.ListForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagementGroupRemediationResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _resourceGroupRemediationRemediationsRestClient.ListForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == "")
            {
                Page<ManagementGroupRemediationResource> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _remediationRestClient.ListForResource(Id, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagementGroupRemediationResource> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _managementGroupRemediationRemediationsClientDiagnostics.CreateScope("RemediationCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _remediationRestClient.ListForResourceNextPage(nextLink, Id, queryOptions, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupRemediationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                throw new InvalidOperationException($"{Id.ResourceType} is not supported here");
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _remediationRestClient.GetAtResourceAsync(Id, remediationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}
        /// Operation Id: Remediations_GetAtResource
        /// </summary>
        /// <param name="remediationName"> The name of the remediation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="remediationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="remediationName"/> is null. </exception>
        public virtual Response<bool> Exists(string remediationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(remediationName, nameof(remediationName));

            using var scope = _remediationClientDiagnostics.CreateScope("RemediationCollection.Exists");
            scope.Start();
            try
            {
                var response = _remediationRestClient.GetAtResource(Id, remediationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagementGroupRemediationResource> IEnumerable<ManagementGroupRemediationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupRemediationResource> IAsyncEnumerable<ManagementGroupRemediationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
