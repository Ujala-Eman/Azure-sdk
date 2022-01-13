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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of HubVirtualNetworkConnection and their operations over its parent. </summary>
    public partial class HubVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<HubVirtualNetworkConnection>, IAsyncEnumerable<HubVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HubVirtualNetworkConnectionsRestOperations _hubVirtualNetworkConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected HubVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of HubVirtualNetworkConnectionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HubVirtualNetworkConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _hubVirtualNetworkConnectionsRestClient = new HubVirtualNetworkConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHub.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public virtual HubVirtualNetworkConnectionCreateOrUpdateOperation CreateOrUpdate(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken);
                var operation = new HubVirtualNetworkConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _hubVirtualNetworkConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
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

        /// <summary> Creates a hub virtual network connection if it doesn&apos;t exist else updates the existing one. </summary>
        /// <param name="connectionName"> The name of the HubVirtualNetworkConnection. </param>
        /// <param name="hubVirtualNetworkConnectionParameters"> Parameters supplied to create or update a hub virtual network connection. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="hubVirtualNetworkConnectionParameters"/> is null. </exception>
        public async virtual Task<HubVirtualNetworkConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(string connectionName, HubVirtualNetworkConnectionData hubVirtualNetworkConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (hubVirtualNetworkConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(hubVirtualNetworkConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new HubVirtualNetworkConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _hubVirtualNetworkConnectionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, hubVirtualNetworkConnectionParameters).Request, response);
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

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a HubVirtualNetworkConnection. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HubVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<HubVirtualNetworkConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hubVirtualNetworkConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HubVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<HubVirtualNetworkConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _hubVirtualNetworkConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HubVirtualNetworkConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new HubVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HubVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubVirtualNetworkConnectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HubVirtualNetworkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hubVirtualNetworkConnectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all HubVirtualNetworkConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HubVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubVirtualNetworkConnectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HubVirtualNetworkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HubVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hubVirtualNetworkConnectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HubVirtualNetworkConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<HubVirtualNetworkConnection> IEnumerable<HubVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubVirtualNetworkConnection> IAsyncEnumerable<HubVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, HubVirtualNetworkConnection, HubVirtualNetworkConnectionData> Construct() { }
    }
}
