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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppVolumeResource"/> and their operations.
    /// Each <see cref="NetAppVolumeResource"/> in the collection will belong to the same instance of <see cref="CapacityPoolResource"/>.
    /// To get a <see cref="NetAppVolumeCollection"/> instance call the GetNetAppVolumes method from an instance of <see cref="CapacityPoolResource"/>.
    /// </summary>
    public partial class NetAppVolumeCollection : ArmCollection, IEnumerable<NetAppVolumeResource>, IAsyncEnumerable<NetAppVolumeResource>
    {
        private readonly ClientDiagnostics _netAppVolumeVolumesClientDiagnostics;
        private readonly VolumesRestOperations _netAppVolumeVolumesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeCollection"/> class for mocking. </summary>
        protected NetAppVolumeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppVolumeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppVolumeVolumesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppVolumeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppVolumeResource.ResourceType, out string netAppVolumeVolumesApiVersion);
            _netAppVolumeVolumesRestClient = new VolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeVolumesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CapacityPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CapacityPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the specified volume within the capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> Volume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppVolumeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeName, NetAppVolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppVolumeVolumesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppVolumeResource>(new NetAppVolumeOperationSource(Client), _netAppVolumeVolumesClientDiagnostics, Pipeline, _netAppVolumeVolumesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update the specified volume within the capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> Volume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppVolumeResource> CreateOrUpdate(WaitUntil waitUntil, string volumeName, NetAppVolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppVolumeVolumesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppVolumeResource>(new NetAppVolumeOperationSource(Client), _netAppVolumeVolumesClientDiagnostics, Pipeline, _netAppVolumeVolumesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the details of the specified volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<NetAppVolumeResource>> GetAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the specified volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<NetAppVolumeResource> Get(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all volumes within the capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppVolumeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppVolumeVolumesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppVolumeVolumesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetAppVolumeResource(Client, NetAppVolumeData.DeserializeNetAppVolumeData(e)), _netAppVolumeVolumesClientDiagnostics, Pipeline, "NetAppVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all volumes within the capacity pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppVolumeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppVolumeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppVolumeVolumesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _netAppVolumeVolumesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetAppVolumeResource(Client, NetAppVolumeData.DeserializeNetAppVolumeData(e)), _netAppVolumeVolumesClientDiagnostics, Pipeline, "NetAppVolumeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetAppVolumeResource>> GetIfExistsAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _netAppVolumeVolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetAppVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Volumes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetAppVolumeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual NullableResponse<NetAppVolumeResource> GetIfExists(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _netAppVolumeVolumesClientDiagnostics.CreateScope("NetAppVolumeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _netAppVolumeVolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetAppVolumeResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppVolumeResource> IEnumerable<NetAppVolumeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppVolumeResource> IAsyncEnumerable<NetAppVolumeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
