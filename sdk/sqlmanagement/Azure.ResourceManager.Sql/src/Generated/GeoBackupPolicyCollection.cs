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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of GeoBackupPolicy and their operations over its parent. </summary>
    public partial class GeoBackupPolicyCollection : ArmCollection, IEnumerable<GeoBackupPolicy>, IAsyncEnumerable<GeoBackupPolicy>
    {
        private readonly ClientDiagnostics _geoBackupPolicyClientDiagnostics;
        private readonly GeoBackupPoliciesRestOperations _geoBackupPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="GeoBackupPolicyCollection"/> class for mocking. </summary>
        protected GeoBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GeoBackupPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GeoBackupPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _geoBackupPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", GeoBackupPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(GeoBackupPolicy.ResourceType, out string geoBackupPolicyApiVersion);
            _geoBackupPolicyRestClient = new GeoBackupPoliciesRestOperations(_geoBackupPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, geoBackupPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_CreateOrUpdate
        /// <summary> Updates a database geo backup policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<GeoBackupPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new GeoBackupPolicyCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_CreateOrUpdate
        /// <summary> Updates a database geo backup policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual GeoBackupPolicyCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken);
                var operation = new GeoBackupPolicyCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Gets a geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<GeoBackupPolicy>> GetAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _geoBackupPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GeoBackupPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Gets a geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicy> Get(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _geoBackupPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_ListByDatabase
        /// <summary> Returns a list of geo backup policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GeoBackupPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GeoBackupPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GeoBackupPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _geoBackupPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_ListByDatabase
        /// <summary> Returns a list of geo backup policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GeoBackupPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GeoBackupPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GeoBackupPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _geoBackupPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicy(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(geoBackupPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<GeoBackupPolicy>> GetIfExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _geoBackupPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GeoBackupPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicy> GetIfExists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _geoBackupPolicyClientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _geoBackupPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GeoBackupPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GeoBackupPolicy> IEnumerable<GeoBackupPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GeoBackupPolicy> IAsyncEnumerable<GeoBackupPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
