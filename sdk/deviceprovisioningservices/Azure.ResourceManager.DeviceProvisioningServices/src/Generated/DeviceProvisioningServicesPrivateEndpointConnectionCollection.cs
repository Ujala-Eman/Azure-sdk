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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A class representing a collection of <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="DeviceProvisioningServiceResource" />.
    /// To get a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionCollection" /> instance call the GetDeviceProvisioningServicesPrivateEndpointConnections method from an instance of <see cref="DeviceProvisioningServiceResource" />.
    /// </summary>
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<DeviceProvisioningServicesPrivateEndpointConnectionResource>, IAsyncEnumerable<DeviceProvisioningServicesPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics;
        private readonly IotDpsResourceRestOperations _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected DeviceProvisioningServicesPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceProvisioningServicesPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", DeviceProvisioningServicesPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeviceProvisioningServicesPrivateEndpointConnectionResource.ResourceType, out string deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceApiVersion);
            _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient = new IotDpsResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DeviceProvisioningServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DeviceProvisioningServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the status of a private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> The private endpoint connection with updated properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, DeviceProvisioningServicesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateOrUpdatePrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateCreateOrUpdatePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the status of a private endpoint connection with the specified name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_CreateOrUpdatePrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="data"> The private endpoint connection with updated properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, DeviceProvisioningServicesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateOrUpdatePrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data, cancellationToken);
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource>(new DeviceProvisioningServicesPrivateEndpointConnectionOperationSource(Client), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateCreateOrUpdatePrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServicesPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<DeviceProvisioningServicesPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListPrivateEndpointConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceProvisioningServicesPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, DeviceProvisioningServicesPrivateEndpointConnectionData.DeserializeDeviceProvisioningServicesPrivateEndpointConnectionData(e)), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServicesPrivateEndpointConnectionCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// List private endpoint connection properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_ListPrivateEndpointConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceProvisioningServicesPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceProvisioningServicesPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.CreateListPrivateEndpointConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new DeviceProvisioningServicesPrivateEndpointConnectionResource(Client, DeviceProvisioningServicesPrivateEndpointConnectionData.DeserializeDeviceProvisioningServicesPrivateEndpointConnectionData(e)), _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics, Pipeline, "DeviceProvisioningServicesPrivateEndpointConnectionCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
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

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotDpsResource_GetPrivateEndpointConnection</description>
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

            using var scope = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceClientDiagnostics.CreateScope("DeviceProvisioningServicesPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesPrivateEndpointConnectionIotDpsResourceRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceProvisioningServicesPrivateEndpointConnectionResource> IEnumerable<DeviceProvisioningServicesPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceProvisioningServicesPrivateEndpointConnectionResource> IAsyncEnumerable<DeviceProvisioningServicesPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
