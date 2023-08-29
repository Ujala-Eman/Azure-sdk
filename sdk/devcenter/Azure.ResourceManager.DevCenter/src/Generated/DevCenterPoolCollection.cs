// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterPoolResource" /> and their operations.
    /// Each <see cref="DevCenterPoolResource" /> in the collection will belong to the same instance of <see cref="DevCenterProjectResource" />.
    /// To get a <see cref="DevCenterPoolCollection" /> instance call the GetDevCenterPools method from an instance of <see cref="DevCenterProjectResource" />.
    /// </summary>
    public partial class DevCenterPoolCollection : ArmCollection, IEnumerable<DevCenterPoolResource>, IAsyncEnumerable<DevCenterPoolResource>
    {
        private readonly ClientDiagnostics _devCenterPoolPoolsClientDiagnostics;
        private readonly PoolsRestOperations _devCenterPoolPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterPoolCollection"/> class for mocking. </summary>
        protected DevCenterPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterPoolPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterPoolResource.ResourceType, out string devCenterPoolPoolsApiVersion);
            _devCenterPoolPoolsRestClient = new PoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterPoolPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a machine pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="data"> Represents a machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, DevCenterPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterPoolPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterPoolResource>(new DevCenterPoolOperationSource(Client), _devCenterPoolPoolsClientDiagnostics, Pipeline, _devCenterPoolPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a machine pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="data"> Represents a machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterPoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, DevCenterPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterPoolPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterPoolResource>(new DevCenterPoolOperationSource(Client), _devCenterPoolPoolsClientDiagnostics, Pipeline, _devCenterPoolPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a machine pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<DevCenterPoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a machine pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<DevCenterPoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists pools for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_ListByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterPoolResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterPoolPoolsRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterPoolPoolsRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterPoolResource(Client, DevCenterPoolData.DeserializeDevCenterPoolData(e)), _devCenterPoolPoolsClientDiagnostics, Pipeline, "DevCenterPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists pools for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_ListByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterPoolResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterPoolPoolsRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterPoolPoolsRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterPoolResource(Client, DevCenterPoolData.DeserializeDevCenterPoolData(e)), _devCenterPoolPoolsClientDiagnostics, Pipeline, "DevCenterPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterPoolPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _devCenterPoolPoolsClientDiagnostics.CreateScope("DevCenterPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterPoolPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterPoolResource> IEnumerable<DevCenterPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterPoolResource> IAsyncEnumerable<DevCenterPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
