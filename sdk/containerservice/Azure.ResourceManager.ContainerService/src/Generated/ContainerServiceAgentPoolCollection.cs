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

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceAgentPoolResource" /> and their operations.
    /// Each <see cref="ContainerServiceAgentPoolResource" /> in the collection will belong to the same instance of <see cref="ContainerServiceManagedClusterResource" />.
    /// To get a <see cref="ContainerServiceAgentPoolCollection" /> instance call the GetContainerServiceAgentPools method from an instance of <see cref="ContainerServiceManagedClusterResource" />.
    /// </summary>
    public partial class ContainerServiceAgentPoolCollection : ArmCollection, IEnumerable<ContainerServiceAgentPoolResource>, IAsyncEnumerable<ContainerServiceAgentPoolResource>
    {
        private readonly ClientDiagnostics _containerServiceAgentPoolAgentPoolsClientDiagnostics;
        private readonly AgentPoolsRestOperations _containerServiceAgentPoolAgentPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceAgentPoolCollection"/> class for mocking. </summary>
        protected ContainerServiceAgentPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceAgentPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceAgentPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceAgentPoolAgentPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ContainerServiceAgentPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceAgentPoolResource.ResourceType, out string containerServiceAgentPoolAgentPoolsApiVersion);
            _containerServiceAgentPoolAgentPoolsRestClient = new AgentPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceAgentPoolAgentPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerServiceManagedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerServiceManagedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an agent pool in the specified managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="data"> The agent pool to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceAgentPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentPoolName, ContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerServiceAgentPoolAgentPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation<ContainerServiceAgentPoolResource>(new ContainerServiceAgentPoolOperationSource(Client), _containerServiceAgentPoolAgentPoolsClientDiagnostics, Pipeline, _containerServiceAgentPoolAgentPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an agent pool in the specified managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="data"> The agent pool to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceAgentPoolResource> CreateOrUpdate(WaitUntil waitUntil, string agentPoolName, ContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerServiceAgentPoolAgentPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken);
                var operation = new ContainerServiceArmOperation<ContainerServiceAgentPoolResource>(new ContainerServiceAgentPoolOperationSource(Client), _containerServiceAgentPoolAgentPoolsClientDiagnostics, Pipeline, _containerServiceAgentPoolAgentPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the specified managed cluster agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceAgentPoolResource>> GetAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceAgentPoolAgentPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified managed cluster agent pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<ContainerServiceAgentPoolResource> Get(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceAgentPoolAgentPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of agent pools in the specified managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools
        /// Operation Id: AgentPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceAgentPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ContainerServiceAgentPoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerServiceAgentPoolAgentPoolsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ContainerServiceAgentPoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerServiceAgentPoolAgentPoolsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of agent pools in the specified managed cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools
        /// Operation Id: AgentPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceAgentPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ContainerServiceAgentPoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerServiceAgentPoolAgentPoolsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ContainerServiceAgentPoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerServiceAgentPoolAgentPoolsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerServiceAgentPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceAgentPoolAgentPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
        /// Operation Id: AgentPools_Get
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerServiceAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerServiceAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceAgentPoolAgentPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceAgentPoolResource> IEnumerable<ContainerServiceAgentPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceAgentPoolResource> IAsyncEnumerable<ContainerServiceAgentPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
