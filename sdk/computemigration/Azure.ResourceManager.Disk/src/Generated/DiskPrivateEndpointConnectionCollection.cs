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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Disk
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskPrivateEndpointConnectionResource"/> and their operations.
    /// Each <see cref="DiskPrivateEndpointConnectionResource"/> in the collection will belong to the same instance of <see cref="DiskAccessResource"/>.
    /// To get a <see cref="DiskPrivateEndpointConnectionCollection"/> instance call the GetDiskPrivateEndpointConnections method from an instance of <see cref="DiskAccessResource"/>.
    /// </summary>
    public partial class DiskPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<DiskPrivateEndpointConnectionResource>, IAsyncEnumerable<DiskPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics;
        private readonly DiskAccessesRestOperations _diskPrivateEndpointConnectionDiskAccessesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected DiskPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Disk", DiskPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskPrivateEndpointConnectionResource.ResourceType, out string diskPrivateEndpointConnectionDiskAccessesApiVersion);
            _diskPrivateEndpointConnectionDiskAccessesRestClient = new DiskAccessesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskPrivateEndpointConnectionDiskAccessesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DiskAccessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DiskAccessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject a private endpoint connection under disk access resource, this can't be used to create a new private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_UpdateAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> private endpoint connection object supplied in the body of the Put private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, DiskPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskPrivateEndpointConnectionDiskAccessesRestClient.UpdateAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DiskArmOperation<DiskPrivateEndpointConnectionResource>(new DiskPrivateEndpointConnectionOperationSource(Client), _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateUpdateAPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Approve or reject a private endpoint connection under disk access resource, this can't be used to create a new private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_UpdateAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> private endpoint connection object supplied in the body of the Put private endpoint connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiskPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, DiskPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskPrivateEndpointConnectionDiskAccessesRestClient.UpdateAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken);
                var operation = new DiskArmOperation<DiskPrivateEndpointConnectionResource>(new DiskPrivateEndpointConnectionOperationSource(Client), _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateUpdateAPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a private endpoint connection under a disk access resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<DiskPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a private endpoint connection under a disk access resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<DiskPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List information about private endpoint connections under a disk access resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_ListPrivateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPrivateEndpointConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateListPrivateEndpointConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskPrivateEndpointConnectionResource(Client, DiskPrivateEndpointConnectionData.DeserializeDiskPrivateEndpointConnectionData(e)), _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, "DiskPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List information about private endpoint connections under a disk access resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_ListPrivateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPrivateEndpointConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPrivateEndpointConnectionDiskAccessesRestClient.CreateListPrivateEndpointConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskPrivateEndpointConnectionResource(Client, DiskPrivateEndpointConnectionData.DeserializeDiskPrivateEndpointConnectionData(e)), _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics, Pipeline, "DiskPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<DiskPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DiskPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new DiskPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskAccesses/{diskAccessName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_GetAPrivateEndpointConnection</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskPrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual NullableResponse<DiskPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _diskPrivateEndpointConnectionDiskAccessesClientDiagnostics.CreateScope("DiskPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskPrivateEndpointConnectionDiskAccessesRestClient.GetAPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DiskPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new DiskPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskPrivateEndpointConnectionResource> IEnumerable<DiskPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskPrivateEndpointConnectionResource> IAsyncEnumerable<DiskPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
