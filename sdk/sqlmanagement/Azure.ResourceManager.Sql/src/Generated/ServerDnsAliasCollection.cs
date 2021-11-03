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
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of ServerDnsAlias and their operations over its parent. </summary>
    public partial class ServerDnsAliasCollection : ArmCollection, IEnumerable<ServerDnsAlias>, IAsyncEnumerable<ServerDnsAlias>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerDnsAliasesRestOperations _serverDnsAliasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDnsAliasCollection"/> class for mocking. </summary>
        protected ServerDnsAliasCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerDnsAliasCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerDnsAliasCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverDnsAliasesRestClient = new ServerDnsAliasesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_CreateOrUpdate
        /// <summary> Creates a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual ServerDnsAliasCreateOrUpdateOperation CreateOrUpdate(string dnsAliasName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                var operation = new ServerDnsAliasCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_CreateOrUpdate
        /// <summary> Creates a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<ServerDnsAliasCreateOrUpdateOperation> CreateOrUpdateAsync(string dnsAliasName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                var operation = new ServerDnsAliasCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverDnsAliasesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, dnsAliasName).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_Get
        /// <summary> Gets a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<ServerDnsAlias> Get(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.Get(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDnsAlias(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases/{dnsAliasName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_Get
        /// <summary> Gets a server DNS alias. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<ServerDnsAlias>> GetAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDnsAlias(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<ServerDnsAlias> GetIfExists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDnsAliasesRestClient.Get(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerDnsAlias>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<ServerDnsAlias>> GetIfExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverDnsAliasesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerDnsAlias>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDnsAlias(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(dnsAliasName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dnsAliasName"> The name of the server dns alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsAliasName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string dnsAliasName, CancellationToken cancellationToken = default)
        {
            if (dnsAliasName == null)
            {
                throw new ArgumentNullException(nameof(dnsAliasName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dnsAliasName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_ListByServer
        /// <summary> Gets a list of server DNS aliases for a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDnsAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDnsAlias> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDnsAlias> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDnsAliasesRestClient.ListByServer(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDnsAlias> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDnsAliasesRestClient.ListByServerNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/dnsAliases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDnsAliases_ListByServer
        /// <summary> Gets a list of server DNS aliases for a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDnsAlias" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDnsAlias> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDnsAlias>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDnsAliasesRestClient.ListByServerAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDnsAlias>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDnsAliasCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDnsAliasesRestClient.ListByServerNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDnsAlias(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerDnsAlias> IEnumerable<ServerDnsAlias>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDnsAlias> IAsyncEnumerable<ServerDnsAlias>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerDnsAlias, ServerDnsAliasData> Construct() { }
    }
}
