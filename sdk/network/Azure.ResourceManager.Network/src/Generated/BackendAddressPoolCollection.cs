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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of BackendAddressPool and their operations over its parent. </summary>
    public partial class BackendAddressPoolCollection : ArmCollection, IEnumerable<BackendAddressPool>, IAsyncEnumerable<BackendAddressPool>
    {
        private readonly ClientDiagnostics _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics;
        private readonly LoadBalancerBackendAddressPoolsRestOperations _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolCollection"/> class for mocking. </summary>
        protected BackendAddressPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackendAddressPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackendAddressPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", BackendAddressPool.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(BackendAddressPool.ResourceType, out string backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
            _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient = new LoadBalancerBackendAddressPoolsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, backendAddressPoolLoadBalancerBackendAddressPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancer.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a load balancer backend address pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<BackendAddressPool>> CreateOrUpdateAsync(WaitUntil waitUntil, string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<BackendAddressPool>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a load balancer backend address pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="parameters"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<BackendAddressPool> CreateOrUpdate(WaitUntil waitUntil, string backendAddressPoolName, BackendAddressPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<BackendAddressPool>(new BackendAddressPoolOperationSource(Client), _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics, Pipeline, _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets load balancer backend address pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<Response<BackendAddressPool>> GetAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer backend address pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<BackendAddressPool> Get(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackendAddressPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer backed address pools.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools
        /// Operation Id: LoadBalancerBackendAddressPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BackendAddressPool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BackendAddressPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BackendAddressPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all the load balancer backed address pools.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools
        /// Operation Id: LoadBalancerBackendAddressPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BackendAddressPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BackendAddressPool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BackendAddressPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BackendAddressPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BackendAddressPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backendAddressPoolName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual async Task<Response<BackendAddressPool>> GetIfExistsAsync(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BackendAddressPool>(null, response.GetRawResponse());
                return Response.FromValue(new BackendAddressPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}
        /// Operation Id: LoadBalancerBackendAddressPools_Get
        /// </summary>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backendAddressPoolName"/> is null. </exception>
        public virtual Response<BackendAddressPool> GetIfExists(string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var scope = _backendAddressPoolLoadBalancerBackendAddressPoolsClientDiagnostics.CreateScope("BackendAddressPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backendAddressPoolLoadBalancerBackendAddressPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backendAddressPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BackendAddressPool>(null, response.GetRawResponse());
                return Response.FromValue(new BackendAddressPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BackendAddressPool> IEnumerable<BackendAddressPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BackendAddressPool> IAsyncEnumerable<BackendAddressPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
