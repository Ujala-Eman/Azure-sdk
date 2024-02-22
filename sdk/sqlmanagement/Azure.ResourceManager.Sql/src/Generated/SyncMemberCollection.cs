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
    /// A class representing a collection of <see cref="SyncMemberResource"/> and their operations.
    /// Each <see cref="SyncMemberResource"/> in the collection will belong to the same instance of <see cref="SyncGroupResource"/>.
    /// To get a <see cref="SyncMemberCollection"/> instance call the GetSyncMembers method from an instance of <see cref="SyncGroupResource"/>.
    /// </summary>
    public partial class SyncMemberCollection : ArmCollection, IEnumerable<SyncMemberResource>, IAsyncEnumerable<SyncMemberResource>
    {
        private readonly ClientDiagnostics _syncMemberClientDiagnostics;
        private readonly SyncMembersRestOperations _syncMemberRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncMemberCollection"/> class for mocking. </summary>
        protected SyncMemberCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncMemberCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SyncMemberCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncMemberClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SyncMemberResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SyncMemberResource.ResourceType, out string syncMemberApiVersion);
            _syncMemberRestClient = new SyncMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncMemberApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SyncGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SyncGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="data"> The requested sync member resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncMemberResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string syncMemberName, SyncMemberData data, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncMemberResource>(new SyncMemberOperationSource(Client), _syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="data"> The requested sync member resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SyncMemberResource> CreateOrUpdate(WaitUntil waitUntil, string syncMemberName, SyncMemberData data, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, data, cancellationToken);
                var operation = new SqlArmOperation<SyncMemberResource>(new SyncMemberOperationSource(Client), _syncMemberClientDiagnostics, Pipeline, _syncMemberRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual async Task<Response<SyncMemberResource>> GetAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync member.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual Response<SyncMemberResource> Get(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.Get");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists sync members in the given sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncMemberResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncMemberResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncMemberRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncMemberRestClient.CreateListBySyncGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SyncMemberResource(Client, SyncMemberData.DeserializeSyncMemberData(e)), _syncMemberClientDiagnostics, Pipeline, "SyncMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists sync members in the given sync group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncMemberResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncMemberResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _syncMemberRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _syncMemberRestClient.CreateListBySyncGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SyncMemberResource(Client, SyncMemberData.DeserializeSyncMemberData(e)), _syncMemberClientDiagnostics, Pipeline, "SyncMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual async Task<NullableResponse<SyncMemberResource>> GetIfExistsAsync(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _syncMemberRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SyncMemberResource>(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/syncGroups/{syncGroupName}/syncMembers/{syncMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SyncMembers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SyncMemberResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="syncMemberName"> The name of the sync member. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncMemberName"/> is null. </exception>
        public virtual NullableResponse<SyncMemberResource> GetIfExists(string syncMemberName, CancellationToken cancellationToken = default)
        {
            if (syncMemberName == null)
            {
                throw new ArgumentNullException(nameof(syncMemberName));
            }
            if (syncMemberName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(syncMemberName));
            }

            using var scope = _syncMemberClientDiagnostics.CreateScope("SyncMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncMemberRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, syncMemberName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SyncMemberResource>(response.GetRawResponse());
                return Response.FromValue(new SyncMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SyncMemberResource> IEnumerable<SyncMemberResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncMemberResource> IAsyncEnumerable<SyncMemberResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
