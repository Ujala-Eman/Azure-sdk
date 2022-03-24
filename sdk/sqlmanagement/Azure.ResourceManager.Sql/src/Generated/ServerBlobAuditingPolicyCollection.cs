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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerBlobAuditingPolicyResource" /> and their operations.
    /// Each <see cref="ServerBlobAuditingPolicyResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="ServerBlobAuditingPolicyCollection" /> instance call the GetServerBlobAuditingPolicies method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class ServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<ServerBlobAuditingPolicyResource>, IAsyncEnumerable<ServerBlobAuditingPolicyResource>
    {
        private readonly ClientDiagnostics _serverBlobAuditingPolicyClientDiagnostics;
        private readonly ServerBlobAuditingPoliciesRestOperations _serverBlobAuditingPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected ServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverBlobAuditingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerBlobAuditingPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerBlobAuditingPolicyResource.ResourceType, out string serverBlobAuditingPolicyApiVersion);
            _serverBlobAuditingPolicyRestClient = new ServerBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverBlobAuditingPolicyApiVersion);
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
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerBlobAuditingPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, ServerBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerBlobAuditingPolicyResource>(new ServerBlobAuditingPolicyOperationSource(Client), _serverBlobAuditingPolicyClientDiagnostics, Pipeline, _serverBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServerBlobAuditingPolicyResource> CreateOrUpdate(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, ServerBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ServerBlobAuditingPolicyResource>(new ServerBlobAuditingPolicyOperationSource(Client), _serverBlobAuditingPolicyClientDiagnostics, Pipeline, _serverBlobAuditingPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerBlobAuditingPolicyResource>> GetAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicyResource> Get(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// Operation Id: ServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerBlobAuditingPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerBlobAuditingPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBlobAuditingPolicyRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerBlobAuditingPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverBlobAuditingPolicyRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// Operation Id: ServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerBlobAuditingPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerBlobAuditingPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBlobAuditingPolicyRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerBlobAuditingPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverBlobAuditingPolicyRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerBlobAuditingPolicyResource>> GetIfExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerBlobAuditingPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerBlobAuditingPolicyResource> GetIfExists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverBlobAuditingPolicyClientDiagnostics.CreateScope("ServerBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerBlobAuditingPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerBlobAuditingPolicyResource> IEnumerable<ServerBlobAuditingPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerBlobAuditingPolicyResource> IAsyncEnumerable<ServerBlobAuditingPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
