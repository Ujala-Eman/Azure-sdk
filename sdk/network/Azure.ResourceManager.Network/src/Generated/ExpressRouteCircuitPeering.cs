// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a ExpressRouteCircuitPeering along with the instance operations that can be performed on it. </summary>
    public partial class ExpressRouteCircuitPeering : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteCircuitPeering"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string circuitName, string peeringName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{circuitName}/peerings/{peeringName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRouteCircuitPeeringsRestOperations _expressRouteCircuitPeeringsRestClient;
        private readonly ExpressRouteCircuitsRestOperations _expressRouteCircuitsRestClient;
        private readonly ExpressRouteCircuitPeeringData _data;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeering"/> class for mocking. </summary>
        protected ExpressRouteCircuitPeering()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ExpressRouteCircuitPeering"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteCircuitPeering(ArmResource options, ExpressRouteCircuitPeeringData data) : base(options, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _expressRouteCircuitPeeringsRestClient = new ExpressRouteCircuitPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _expressRouteCircuitsRestClient = new ExpressRouteCircuitsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeering"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCircuitPeering(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _expressRouteCircuitPeeringsRestClient = new ExpressRouteCircuitPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _expressRouteCircuitsRestClient = new ExpressRouteCircuitsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeering"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteCircuitPeering(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _expressRouteCircuitPeeringsRestClient = new ExpressRouteCircuitPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _expressRouteCircuitsRestClient = new ExpressRouteCircuitsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCircuits/peerings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteCircuitPeeringData Data
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

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitPeering>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified peering for the express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitPeering> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCircuitPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteCircuitPeeringDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.Delete");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitPeeringsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitPeeringDeleteOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitPeeringsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteCircuitPeeringDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.Delete");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitPeeringsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ExpressRouteCircuitPeeringDeleteOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitPeeringsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public async virtual Task<ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation> GetArpTableExpressRouteCircuitAsync(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetArpTableExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.ListArpTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListArpTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public virtual ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation GetArpTableExpressRouteCircuit(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetArpTableExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.ListArpTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new ExpressRouteCircuitPeeringGetArpTableExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListArpTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets the currently advertised routes table associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public async virtual Task<ExpressRouteCircuitPeeringGetRoutesTableExpressRouteCircuitOperation> GetRoutesTableExpressRouteCircuitAsync(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetRoutesTableExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.ListRoutesTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitPeeringGetRoutesTableExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListRoutesTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets the currently advertised routes table associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public virtual ExpressRouteCircuitPeeringGetRoutesTableExpressRouteCircuitOperation GetRoutesTableExpressRouteCircuit(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetRoutesTableExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.ListRoutesTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new ExpressRouteCircuitPeeringGetRoutesTableExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListRoutesTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public async virtual Task<ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation> GetRoutesTableSummaryExpressRouteCircuitAsync(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetRoutesTableSummaryExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.ListRoutesTableSummaryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListRoutesTableSummaryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devicePath"/> is null or empty. </exception>
        public virtual ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation GetRoutesTableSummaryExpressRouteCircuit(bool waitForCompletion, string devicePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(devicePath))
            {
                throw new ArgumentException($"Parameter {nameof(devicePath)} cannot be null or empty", nameof(devicePath));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetRoutesTableSummaryExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.ListRoutesTableSummary(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath, cancellationToken);
                var operation = new ExpressRouteCircuitPeeringGetRoutesTableSummaryExpressRouteCircuitOperation(_clientDiagnostics, Pipeline, _expressRouteCircuitsRestClient.CreateListRoutesTableSummaryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, devicePath).Request, response);
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

        /// <summary> Gets all stats from an express route circuit in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteCircuitStats>> GetPeeringStatsExpressRouteCircuitAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetPeeringStatsExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = await _expressRouteCircuitsRestClient.GetPeeringStatsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all stats from an express route circuit in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitStats> GetPeeringStatsExpressRouteCircuit(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeering.GetPeeringStatsExpressRouteCircuit");
            scope.Start();
            try
            {
                var response = _expressRouteCircuitsRestClient.GetPeeringStats(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region ExpressRouteCircuitConnection

        /// <summary> Gets a collection of ExpressRouteCircuitConnections in the ExpressRouteCircuitPeering. </summary>
        /// <returns> An object representing collection of ExpressRouteCircuitConnections and their operations over a ExpressRouteCircuitPeering. </returns>
        public virtual ExpressRouteCircuitConnectionCollection GetExpressRouteCircuitConnections()
        {
            return new ExpressRouteCircuitConnectionCollection(this);
        }
        #endregion

        #region PeerExpressRouteCircuitConnection

        /// <summary> Gets a collection of PeerExpressRouteCircuitConnections in the ExpressRouteCircuitPeering. </summary>
        /// <returns> An object representing collection of PeerExpressRouteCircuitConnections and their operations over a ExpressRouteCircuitPeering. </returns>
        public virtual PeerExpressRouteCircuitConnectionCollection GetPeerExpressRouteCircuitConnections()
        {
            return new PeerExpressRouteCircuitConnectionCollection(this);
        }
        #endregion
    }
}
