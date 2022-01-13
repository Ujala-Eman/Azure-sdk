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
    /// <summary> A class representing collection of SqlUserDefinedFunction and their operations over its parent. </summary>
    public partial class SqlUserDefinedFunctionCollection : ArmCollection, IEnumerable<SqlUserDefinedFunction>, IAsyncEnumerable<SqlUserDefinedFunction>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlUserDefinedFunctionCollection"/> class for mocking. </summary>
        protected SqlUserDefinedFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of SqlUserDefinedFunctionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlUserDefinedFunctionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlContainer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlContainer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB SQL userDefinedFunction. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="createUpdateSqlUserDefinedFunctionParameters"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="createUpdateSqlUserDefinedFunctionParameters"/> is null. </exception>
        public virtual SqlResourceCreateUpdateSqlUserDefinedFunctionOperation CreateOrUpdate(string userDefinedFunctionName, SqlUserDefinedFunctionCreateUpdateOptions createUpdateSqlUserDefinedFunctionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }
            if (createUpdateSqlUserDefinedFunctionParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlUserDefinedFunctionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.CreateUpdateSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, createUpdateSqlUserDefinedFunctionParameters, cancellationToken);
                var operation = new SqlResourceCreateUpdateSqlUserDefinedFunctionOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, createUpdateSqlUserDefinedFunctionParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB SQL userDefinedFunction. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="createUpdateSqlUserDefinedFunctionParameters"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="createUpdateSqlUserDefinedFunctionParameters"/> is null. </exception>
        public async virtual Task<SqlResourceCreateUpdateSqlUserDefinedFunctionOperation> CreateOrUpdateAsync(string userDefinedFunctionName, SqlUserDefinedFunctionCreateUpdateOptions createUpdateSqlUserDefinedFunctionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }
            if (createUpdateSqlUserDefinedFunctionParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlUserDefinedFunctionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.CreateUpdateSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, createUpdateSqlUserDefinedFunctionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlResourceCreateUpdateSqlUserDefinedFunctionOperation(Parent, _clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, createUpdateSqlUserDefinedFunctionParameters).Request, response);
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

        /// <summary> Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<SqlUserDefinedFunction> Get(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlUserDefinedFunction(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public async virtual Task<Response<SqlUserDefinedFunction>> GetAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlUserDefinedFunction(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<SqlUserDefinedFunction> GetIfExists(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SqlUserDefinedFunction>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlUserDefinedFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public async virtual Task<Response<SqlUserDefinedFunction>> GetIfExistsAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SqlUserDefinedFunction>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlUserDefinedFunction(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<bool> Exists(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(userDefinedFunctionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            if (userDefinedFunctionName == null)
            {
                throw new ArgumentNullException(nameof(userDefinedFunctionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(userDefinedFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlUserDefinedFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlUserDefinedFunction> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlUserDefinedFunction> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlResourcesRestClient.ListSqlUserDefinedFunctions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlUserDefinedFunction(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlUserDefinedFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlUserDefinedFunction> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlUserDefinedFunction>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlResourcesRestClient.ListSqlUserDefinedFunctionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlUserDefinedFunction(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SqlUserDefinedFunction> IEnumerable<SqlUserDefinedFunction>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlUserDefinedFunction> IAsyncEnumerable<SqlUserDefinedFunction>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SqlUserDefinedFunction, SqlUserDefinedFunctionData> Construct() { }
    }
}
