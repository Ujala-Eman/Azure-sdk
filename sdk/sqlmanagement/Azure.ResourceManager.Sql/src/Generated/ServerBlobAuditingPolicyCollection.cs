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
    /// <summary> A class representing collection of ServerBlobAuditingPolicy and their operations over its parent. </summary>
    public partial class ServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<ServerBlobAuditingPolicy>, IAsyncEnumerable<ServerBlobAuditingPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerBlobAuditingPoliciesRestOperations _serverBlobAuditingPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected ServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerBlobAuditingPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerBlobAuditingPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverBlobAuditingPoliciesRestClient = new ServerBlobAuditingPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of blob auditing policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ServerBlobAuditingPolicyCreateOrUpdateOperation CreateOrUpdate(Enum5 blobAuditingPolicyName, ServerBlobAuditingPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken);
                var operation = new ServerBlobAuditingPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of blob auditing policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerBlobAuditingPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(Enum5 blobAuditingPolicyName, ServerBlobAuditingPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerBlobAuditingPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serverBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_Get
        /// <summary> Gets a server&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicy> Get(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPoliciesRestClient.Get(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_Get
        /// <summary> Gets a server&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerBlobAuditingPolicy>> GetAsync(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerBlobAuditingPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicy> GetIfExists(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPoliciesRestClient.Get(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerBlobAuditingPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerBlobAuditingPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerBlobAuditingPolicy>> GetIfExistsAsync(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerBlobAuditingPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerBlobAuditingPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobAuditingPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(Enum5 blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_ListByServer
        /// <summary> Lists auditing settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerBlobAuditingPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerBlobAuditingPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBlobAuditingPoliciesRestClient.ListByServer(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerBlobAuditingPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBlobAuditingPoliciesRestClient.ListByServerNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerBlobAuditingPolicies_ListByServer
        /// <summary> Lists auditing settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerBlobAuditingPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerBlobAuditingPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBlobAuditingPoliciesRestClient.ListByServerAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerBlobAuditingPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBlobAuditingPoliciesRestClient.ListByServerNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerBlobAuditingPolicy> IEnumerable<ServerBlobAuditingPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerBlobAuditingPolicy> IAsyncEnumerable<ServerBlobAuditingPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerBlobAuditingPolicy, ServerBlobAuditingPolicyData> Construct() { }
    }
}
