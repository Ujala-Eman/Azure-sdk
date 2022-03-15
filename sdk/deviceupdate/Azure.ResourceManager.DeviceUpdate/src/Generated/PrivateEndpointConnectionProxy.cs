// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A Class representing a PrivateEndpointConnectionProxy along with the instance operations that can be performed on it. </summary>
    public partial class PrivateEndpointConnectionProxy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateEndpointConnectionProxy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string privateEndpointConnectionProxyId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateEndpointConnectionProxyClientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _privateEndpointConnectionProxyRestClient;
        private readonly PrivateEndpointConnectionProxyData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxy"/> class for mocking. </summary>
        protected PrivateEndpointConnectionProxy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateEndpointConnectionProxy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateEndpointConnectionProxy(ArmClient client, PrivateEndpointConnectionProxyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateEndpointConnectionProxy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionProxyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string privateEndpointConnectionProxyApiVersion);
            _privateEndpointConnectionProxyRestClient = new PrivateEndpointConnectionProxiesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateEndpointConnectionProxyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DeviceUpdate/accounts/privateEndpointConnectionProxies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateEndpointConnectionProxyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnectionProxy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnectionProxy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Delete");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation(_privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Deletes the specified private endpoint connection proxy associated with the device update account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}
        /// Operation Id: PrivateEndpointConnectionProxies_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Delete");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DeviceUpdateArmOperation(_privateEndpointConnectionProxyClientDiagnostics, Pipeline, _privateEndpointConnectionProxyRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate
        /// Operation Id: PrivateEndpointConnectionProxies_Validate
        /// </summary>
        /// <param name="privateEndpointConnectionProxy"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxy"/> is null. </exception>
        public virtual async Task<Response> ValidateAsync(PrivateEndpointConnectionProxyData privateEndpointConnectionProxy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointConnectionProxy, nameof(privateEndpointConnectionProxy));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Validate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxyRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionProxy, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// (INTERNAL - DO NOT USE) Validates a private endpoint connection proxy object.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}/privateEndpointConnectionProxies/{privateEndpointConnectionProxyId}/validate
        /// Operation Id: PrivateEndpointConnectionProxies_Validate
        /// </summary>
        /// <param name="privateEndpointConnectionProxy"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxy"/> is null. </exception>
        public virtual Response Validate(PrivateEndpointConnectionProxyData privateEndpointConnectionProxy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(privateEndpointConnectionProxy, nameof(privateEndpointConnectionProxy));

            using var scope = _privateEndpointConnectionProxyClientDiagnostics.CreateScope("PrivateEndpointConnectionProxy.Validate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxyRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, privateEndpointConnectionProxy, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
