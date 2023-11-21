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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary>
    /// A class representing a collection of <see cref="RedisEnterpriseClusterResource"/> and their operations.
    /// Each <see cref="RedisEnterpriseClusterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="RedisEnterpriseClusterCollection"/> instance call the GetRedisEnterpriseClusters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class RedisEnterpriseClusterCollection : ArmCollection, IEnumerable<RedisEnterpriseClusterResource>, IAsyncEnumerable<RedisEnterpriseClusterResource>
    {
        private readonly ClientDiagnostics _redisEnterpriseClusterRedisEnterpriseClientDiagnostics;
        private readonly RedisEnterpriseRestOperations _redisEnterpriseClusterRedisEnterpriseRestClient;

        /// <summary> Initializes a new instance of the <see cref="RedisEnterpriseClusterCollection"/> class for mocking. </summary>
        protected RedisEnterpriseClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RedisEnterpriseClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RedisEnterpriseClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisEnterpriseClusterRedisEnterpriseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RedisEnterprise", RedisEnterpriseClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RedisEnterpriseClusterResource.ResourceType, out string redisEnterpriseClusterRedisEnterpriseApiVersion);
            _redisEnterpriseClusterRedisEnterpriseRestClient = new RedisEnterpriseRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisEnterpriseClusterRedisEnterpriseApiVersion);
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
        /// Creates or updates an existing (overwrite/recreate, with potential downtime) cache cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="data"> Parameters supplied to the Create RedisEnterprise operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisEnterpriseClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterName, RedisEnterpriseClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _redisEnterpriseClusterRedisEnterpriseRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RedisEnterpriseArmOperation<RedisEnterpriseClusterResource>(new RedisEnterpriseClusterOperationSource(Client), _redisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, _redisEnterpriseClusterRedisEnterpriseRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Creates or updates an existing (overwrite/recreate, with potential downtime) cache cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="data"> Parameters supplied to the Create RedisEnterprise operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RedisEnterpriseClusterResource> CreateOrUpdate(WaitUntil waitUntil, string clusterName, RedisEnterpriseClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _redisEnterpriseClusterRedisEnterpriseRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken);
                var operation = new RedisEnterpriseArmOperation<RedisEnterpriseClusterResource>(new RedisEnterpriseClusterOperationSource(Client), _redisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, _redisEnterpriseClusterRedisEnterpriseRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Gets information about a RedisEnterprise cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<RedisEnterpriseClusterResource>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _redisEnterpriseClusterRedisEnterpriseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisEnterpriseClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a RedisEnterprise cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<RedisEnterpriseClusterResource> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _redisEnterpriseClusterRedisEnterpriseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisEnterpriseClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all RedisEnterprise clusters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisEnterpriseClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisEnterpriseClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisEnterpriseClusterRedisEnterpriseRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisEnterpriseClusterRedisEnterpriseRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisEnterpriseClusterResource(Client, RedisEnterpriseClusterData.DeserializeRedisEnterpriseClusterData(e)), _redisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, "RedisEnterpriseClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all RedisEnterprise clusters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisEnterpriseClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisEnterpriseClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisEnterpriseClusterRedisEnterpriseRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisEnterpriseClusterRedisEnterpriseRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisEnterpriseClusterResource(Client, RedisEnterpriseClusterData.DeserializeRedisEnterpriseClusterData(e)), _redisEnterpriseClusterRedisEnterpriseClientDiagnostics, Pipeline, "RedisEnterpriseClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _redisEnterpriseClusterRedisEnterpriseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _redisEnterpriseClusterRedisEnterpriseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<NullableResponse<RedisEnterpriseClusterResource>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _redisEnterpriseClusterRedisEnterpriseRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RedisEnterpriseClusterResource>(response.GetRawResponse());
                return Response.FromValue(new RedisEnterpriseClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redisEnterprise/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RedisEnterprise_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the RedisEnterprise cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual NullableResponse<RedisEnterpriseClusterResource> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _redisEnterpriseClusterRedisEnterpriseClientDiagnostics.CreateScope("RedisEnterpriseClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _redisEnterpriseClusterRedisEnterpriseRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RedisEnterpriseClusterResource>(response.GetRawResponse());
                return Response.FromValue(new RedisEnterpriseClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RedisEnterpriseClusterResource> IEnumerable<RedisEnterpriseClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RedisEnterpriseClusterResource> IAsyncEnumerable<RedisEnterpriseClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
