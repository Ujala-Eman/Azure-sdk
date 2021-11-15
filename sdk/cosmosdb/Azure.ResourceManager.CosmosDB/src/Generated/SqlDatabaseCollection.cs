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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlDatabase and their operations over its parent. </summary>
    public partial class SqlDatabaseCollection : ArmCollection, IEnumerable<SqlDatabase>, IAsyncEnumerable<SqlDatabase>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseCollection"/> class for mocking. </summary>
        protected SqlDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of SqlDatabaseCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlDatabaseCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DatabaseAccount.ResourceType;

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB SQL database. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateSqlDatabaseParameters"> The parameters to provide for the current SQL database. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateSqlDatabaseParameters"/> is null. </exception>
        public virtual SqlResourceCreateUpdateSqlDatabaseOperation CreateOrUpdate(string databaseName, SqlDatabaseCreateUpdateParameters createUpdateSqlDatabaseParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (createUpdateSqlDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlDatabaseParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.CreateUpdateSqlDatabase(Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters, cancellationToken);
                var operation = new SqlResourceCreateUpdateSqlDatabaseOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlDatabaseRequest(Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB SQL database. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateSqlDatabaseParameters"> The parameters to provide for the current SQL database. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateSqlDatabaseParameters"/> is null. </exception>
        public async virtual Task<SqlResourceCreateUpdateSqlDatabaseOperation> CreateOrUpdateAsync(string databaseName, SqlDatabaseCreateUpdateParameters createUpdateSqlDatabaseParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (createUpdateSqlDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlDatabaseParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.CreateUpdateSqlDatabaseAsync(Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlResourceCreateUpdateSqlDatabaseOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlDatabaseRequest(Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters).Request, response);
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

        /// <summary> Gets the SQL database under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlDatabase(Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL database under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlDatabaseAsync(Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlDatabase(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlDatabase(Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SqlDatabase>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlDatabaseAsync(Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SqlDatabase>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(databaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlDatabase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlResourcesRestClient.ListSqlDatabases(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlDatabase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlResourcesRestClient.ListSqlDatabasesAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SqlDatabase> IEnumerable<SqlDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlDatabase> IAsyncEnumerable<SqlDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SqlDatabase, SqlDatabaseData> Construct() { }
    }
}
