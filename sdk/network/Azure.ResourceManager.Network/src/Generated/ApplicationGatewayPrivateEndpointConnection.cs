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

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ApplicationGatewayPrivateEndpointConnection along with the instance operations that can be performed on it. </summary>
    public partial class ApplicationGatewayPrivateEndpointConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApplicationGatewayPrivateEndpointConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string applicationGatewayName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _applicationGatewayPrivateEndpointConnectionClientDiagnostics;
        private readonly ApplicationGatewayPrivateEndpointConnectionsRestOperations _applicationGatewayPrivateEndpointConnectionRestClient;
        private readonly ApplicationGatewayPrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayPrivateEndpointConnection"/> class for mocking. </summary>
        protected ApplicationGatewayPrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApplicationGatewayPrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApplicationGatewayPrivateEndpointConnection(ArmClient client, ApplicationGatewayPrivateEndpointConnectionData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayPrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGatewayPrivateEndpointConnection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationGatewayPrivateEndpointConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string applicationGatewayPrivateEndpointConnectionApiVersion);
            _applicationGatewayPrivateEndpointConnectionRestClient = new ApplicationGatewayPrivateEndpointConnectionsRestOperations(_applicationGatewayPrivateEndpointConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, applicationGatewayPrivateEndpointConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/applicationGateways/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApplicationGatewayPrivateEndpointConnectionData Data
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
        /// Gets the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ApplicationGatewayPrivateEndpointConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewayPrivateEndpointConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGatewayPrivateEndpointConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewayPrivateEndpointConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayPrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = await _applicationGatewayPrivateEndpointConnectionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_applicationGatewayPrivateEndpointConnectionClientDiagnostics, Pipeline, _applicationGatewayPrivateEndpointConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Deletes the specified private endpoint connection on application gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/privateEndpointConnections/{connectionName}
        /// Operation Id: ApplicationGatewayPrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayPrivateEndpointConnectionClientDiagnostics.CreateScope("ApplicationGatewayPrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = _applicationGatewayPrivateEndpointConnectionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_applicationGatewayPrivateEndpointConnectionClientDiagnostics, Pipeline, _applicationGatewayPrivateEndpointConnectionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
