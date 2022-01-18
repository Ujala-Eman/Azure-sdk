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
    /// <summary> A class representing collection of VirtualRouterPeering and their operations over its parent. </summary>
    public partial class VirtualRouterPeeringCollection : ArmCollection, IEnumerable<VirtualRouterPeering>, IAsyncEnumerable<VirtualRouterPeering>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualRouterPeeringsRestOperations _virtualRouterPeeringsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterPeeringCollection"/> class for mocking. </summary>
        protected VirtualRouterPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualRouterPeeringCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualRouterPeeringCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualRouterPeering.ResourceType, out string apiVersion);
            _virtualRouterPeeringsRestClient = new VirtualRouterPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualRouter.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualRouter.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual VirtualRouterPeeringCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, parameters, cancellationToken);
                var operation = new VirtualRouterPeeringCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualRouterPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified Virtual Router Peering. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Virtual Router Peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualRouterPeeringCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string peeringName, VirtualRouterPeeringData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualRouterPeeringCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualRouterPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, parameters).Request, response);
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

        /// <summary> Gets the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public virtual Response<VirtualRouterPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Virtual Router Peering. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public async virtual Task<Response<VirtualRouterPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public virtual Response<VirtualRouterPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualRouterPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualRouterPeering>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public async virtual Task<Response<VirtualRouterPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualRouterPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualRouterPeering>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualRouterPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(peeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the Virtual Router Peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(peeringName))
            {
                throw new ArgumentException($"Parameter {nameof(peeringName)} cannot be null or empty", nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualRouterPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualRouterPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualRouterPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualRouterPeeringsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualRouterPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualRouterPeeringsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Virtual Router Peerings in a Virtual Router resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualRouterPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualRouterPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualRouterPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualRouterPeeringsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualRouterPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualRouterPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualRouterPeeringsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualRouterPeering(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualRouterPeering> IEnumerable<VirtualRouterPeering>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualRouterPeering> IAsyncEnumerable<VirtualRouterPeering>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualRouterPeering, VirtualRouterPeeringData> Construct() { }
    }
}
