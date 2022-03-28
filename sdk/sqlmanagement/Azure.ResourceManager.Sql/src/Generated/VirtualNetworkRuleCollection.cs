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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkRuleResource" /> and their operations.
    /// Each <see cref="VirtualNetworkRuleResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="VirtualNetworkRuleCollection" /> instance call the GetVirtualNetworkRules method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class VirtualNetworkRuleCollection : ArmCollection, IEnumerable<VirtualNetworkRuleResource>, IAsyncEnumerable<VirtualNetworkRuleResource>
    {
        private readonly ClientDiagnostics _virtualNetworkRuleClientDiagnostics;
        private readonly VirtualNetworkRulesRestOperations _virtualNetworkRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkRuleCollection"/> class for mocking. </summary>
        protected VirtualNetworkRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", VirtualNetworkRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkRuleResource.ResourceType, out string virtualNetworkRuleApiVersion);
            _virtualNetworkRuleRestClient = new VirtualNetworkRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkRuleName, VirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<VirtualNetworkRuleResource>(new VirtualNetworkRuleOperationSource(Client), _virtualNetworkRuleClientDiagnostics, Pipeline, _virtualNetworkRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkRuleResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkRuleName, VirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken);
                var operation = new SqlArmOperation<VirtualNetworkRuleResource>(new VirtualNetworkRuleOperationSource(Client), _virtualNetworkRuleClientDiagnostics, Pipeline, _virtualNetworkRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkRuleResource>> GetAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkRuleResource> Get(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of virtual network rules in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules
        /// Operation Id: VirtualNetworkRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRuleRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRuleRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of virtual network rules in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules
        /// Operation Id: VirtualNetworkRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRuleRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRuleRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkRuleResource>> GetIfExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkRuleResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkRuleResource> GetIfExists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _virtualNetworkRuleClientDiagnostics.CreateScope("VirtualNetworkRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkRuleResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkRuleResource> IEnumerable<VirtualNetworkRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkRuleResource> IAsyncEnumerable<VirtualNetworkRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
