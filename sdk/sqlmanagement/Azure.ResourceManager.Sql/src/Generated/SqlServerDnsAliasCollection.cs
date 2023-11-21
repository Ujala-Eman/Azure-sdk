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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerDnsAliasResource"/> and their operations.
    /// Each <see cref="SqlServerDnsAliasResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerDnsAliasCollection"/> instance call the GetSqlServerDnsAliases method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerDnsAliasCollection : ArmCollection, IEnumerable<SqlServerDnsAliasResource>, IAsyncEnumerable<SqlServerDnsAliasResource>
    {
        private readonly ClientDiagnostics _sqlServerDnsAliasServerDnsAliasesClientDiagnostics;
        private readonly ServerDnsAliasesRestOperations _sqlServerDnsAliasServerDnsAliasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerDnsAliasCollection"/> class for mocking. </summary>
        protected SqlServerDnsAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerDnsAliasCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerDnsAliasCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerDnsAliasServerDnsAliasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerDnsAliasResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerDnsAliasResource.ResourceType, out string sqlServerDnsAliasServerDnsAliasesApiVersion);
            _sqlServerDnsAliasServerDnsAliasesRestClient = new ServerDnsAliasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerDnsAliasServerDnsAliasesApiVersion);
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
        /// Creates a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerDnsAliasResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerDnsAliasServerDnsAliasesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerDnsAliasResource>(new SqlServerDnsAliasOperationSource(Client), _sqlServerDnsAliasServerDnsAliasesClientDiagnostics, Pipeline, _sqlServerDnsAliasServerDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual ArmOperation<SqlServerDnsAliasResource> CreateOrUpdate(WaitUntil waitUntil, string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerDnsAliasServerDnsAliasesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                var operation = new SqlArmOperation<SqlServerDnsAliasResource>(new SqlServerDnsAliasOperationSource(Client), _sqlServerDnsAliasServerDnsAliasesClientDiagnostics, Pipeline, _sqlServerDnsAliasServerDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<Response<SqlServerDnsAliasResource>> GetAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerDnsAliasServerDnsAliasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<SqlServerDnsAliasResource> Get(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerDnsAliasServerDnsAliasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server DNS aliases for a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerDnsAliasResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerDnsAliasResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDnsAliasServerDnsAliasesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDnsAliasServerDnsAliasesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerDnsAliasResource(Client, SqlServerDnsAliasData.DeserializeSqlServerDnsAliasData(e)), _sqlServerDnsAliasServerDnsAliasesClientDiagnostics, Pipeline, "SqlServerDnsAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of server DNS aliases for a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerDnsAliasResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerDnsAliasResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDnsAliasServerDnsAliasesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDnsAliasServerDnsAliasesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SqlServerDnsAliasResource(Client, SqlServerDnsAliasData.DeserializeSqlServerDnsAliasData(e)), _sqlServerDnsAliasServerDnsAliasesClientDiagnostics, Pipeline, "SqlServerDnsAliasCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerDnsAliasServerDnsAliasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerDnsAliasServerDnsAliasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerDnsAliasResource>> GetIfExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerDnsAliasServerDnsAliasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDnsAliasResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual NullableResponse<SqlServerDnsAliasResource> GetIfExists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsAliasName, nameof(dnsAliasName));

            using var scope = _sqlServerDnsAliasServerDnsAliasesClientDiagnostics.CreateScope("SqlServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerDnsAliasServerDnsAliasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDnsAliasResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerDnsAliasResource> IEnumerable<SqlServerDnsAliasResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerDnsAliasResource> IAsyncEnumerable<SqlServerDnsAliasResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
