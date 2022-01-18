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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of CassandraKeyspace and their operations over its parent. </summary>
    public partial class CassandraKeyspaceCollection : ArmCollection, IEnumerable<CassandraKeyspace>, IAsyncEnumerable<CassandraKeyspace>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraKeyspaceCollection"/> class for mocking. </summary>
        protected CassandraKeyspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraKeyspaceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CassandraKeyspaceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CassandraKeyspace.ResourceType, out string apiVersion);
            _cassandraResourcesRestClient = new CassandraResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccount.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB Cassandra keyspace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="createUpdateCassandraKeyspaceParameters"> The parameters to provide for the current Cassandra keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="createUpdateCassandraKeyspaceParameters"/> is null. </exception>
        public virtual CassandraKeyspaceCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string keyspaceName, CassandraKeyspaceCreateUpdateOptions createUpdateCassandraKeyspaceParameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }
            if (createUpdateCassandraKeyspaceParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraKeyspaceParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.CreateUpdateCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, createUpdateCassandraKeyspaceParameters, cancellationToken);
                var operation = new CassandraKeyspaceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cassandraResourcesRestClient.CreateCreateUpdateCassandraKeyspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, createUpdateCassandraKeyspaceParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB Cassandra keyspace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="createUpdateCassandraKeyspaceParameters"> The parameters to provide for the current Cassandra keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="createUpdateCassandraKeyspaceParameters"/> is null. </exception>
        public async virtual Task<CassandraKeyspaceCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string keyspaceName, CassandraKeyspaceCreateUpdateOptions createUpdateCassandraKeyspaceParameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }
            if (createUpdateCassandraKeyspaceParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateCassandraKeyspaceParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.CreateUpdateCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, createUpdateCassandraKeyspaceParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CassandraKeyspaceCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cassandraResourcesRestClient.CreateCreateUpdateCassandraKeyspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, createUpdateCassandraKeyspaceParameters).Request, response);
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

        /// <summary> Gets the Cassandra keyspaces under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public virtual Response<CassandraKeyspace> Get(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.GetCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraKeyspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the Cassandra keyspaces under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public async virtual Task<Response<CassandraKeyspace>> GetAsync(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.GetCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CassandraKeyspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public virtual Response<CassandraKeyspace> GetIfExists(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cassandraResourcesRestClient.GetCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CassandraKeyspace>(null, response.GetRawResponse());
                return Response.FromValue(new CassandraKeyspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public async virtual Task<Response<CassandraKeyspace>> GetIfExistsAsync(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cassandraResourcesRestClient.GetCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CassandraKeyspace>(null, response.GetRawResponse());
                return Response.FromValue(new CassandraKeyspace(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(keyspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string keyspaceName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(keyspaceName))
            {
                throw new ArgumentException($"Parameter {nameof(keyspaceName)} cannot be null or empty", nameof(keyspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(keyspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the Cassandra keyspaces under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraKeyspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraKeyspace> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CassandraKeyspace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cassandraResourcesRestClient.ListCassandraKeyspaces(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraKeyspace(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the Cassandra keyspaces under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraKeyspace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraKeyspace> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CassandraKeyspace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CassandraKeyspaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cassandraResourcesRestClient.ListCassandraKeyspacesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraKeyspace(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<CassandraKeyspace> IEnumerable<CassandraKeyspace>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraKeyspace> IAsyncEnumerable<CassandraKeyspace>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CassandraKeyspace, CassandraKeyspaceData> Construct() { }
    }
}
