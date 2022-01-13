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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ElasticPool and their operations over its parent. </summary>
    public partial class ElasticPoolCollection : ArmCollection, IEnumerable<ElasticPool>, IAsyncEnumerable<ElasticPool>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ElasticPoolsRestOperations _elasticPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class for mocking. </summary>
        protected ElasticPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of ElasticPoolCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ElasticPoolCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _elasticPoolsRestClient = new ElasticPoolsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_CreateOrUpdate
        /// <summary> Creates or updates an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ElasticPoolCreateOrUpdateOperation CreateOrUpdate(string elasticPoolName, ElasticPoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticPoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken);
                var operation = new ElasticPoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _elasticPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_CreateOrUpdate
        /// <summary> Creates or updates an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ElasticPoolCreateOrUpdateOperation> CreateOrUpdateAsync(string elasticPoolName, ElasticPoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticPoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ElasticPoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _elasticPoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Gets an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPool> Get(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Gets an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<ElasticPool>> GetAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ElasticPool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPool> GetIfExists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _elasticPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ElasticPool>(null, response.GetRawResponse())
                    : Response.FromValue(new ElasticPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<ElasticPool>> GetIfExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _elasticPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ElasticPool>(null, response.GetRawResponse())
                    : Response.FromValue(new ElasticPool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(elasticPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            if (elasticPoolName == null)
            {
                throw new ArgumentNullException(nameof(elasticPoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_ListByServer
        /// <summary> Gets all elastic pools in a server. </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticPool> GetAll(int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ElasticPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ElasticPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_ListByServer
        /// <summary> Gets all elastic pools in a server. </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticPool> GetAllAsync(int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ElasticPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ElasticPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ElasticPool> IEnumerable<ElasticPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticPool> IAsyncEnumerable<ElasticPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ElasticPool, ElasticPoolData> Construct() { }
    }
}
