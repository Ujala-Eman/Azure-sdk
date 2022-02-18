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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCrossConnectionPeering and their operations over its parent. </summary>
    public partial class ExpressRouteCrossConnectionPeeringCollection : ArmCollection, IEnumerable<ExpressRouteCrossConnectionPeering>, IAsyncEnumerable<ExpressRouteCrossConnectionPeering>
    {
        private readonly ClientDiagnostics _expressRouteCrossConnectionPeeringClientDiagnostics;
        private readonly ExpressRouteCrossConnectionPeeringsRestOperations _expressRouteCrossConnectionPeeringRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringCollection"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCrossConnectionPeeringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCrossConnectionPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCrossConnectionPeering.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ExpressRouteCrossConnectionPeering.ResourceType, out string expressRouteCrossConnectionPeeringApiVersion);
            _expressRouteCrossConnectionPeeringRestClient = new ExpressRouteCrossConnectionPeeringsRestOperations(_expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, expressRouteCrossConnectionPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCrossConnection.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCrossConnection.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ExpressRouteCrossConnectionPeering>> CreateOrUpdateAsync(bool waitForCompletion, string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(peeringParameters, nameof(peeringParameters));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeering>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCrossConnectionPeering> CreateOrUpdate(bool waitForCompletion, string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(peeringParameters, nameof(peeringParameters));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeering>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _expressRouteCrossConnectionPeeringClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw _expressRouteCrossConnectionPeeringClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all peerings in a specified ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings
        /// Operation Id: ExpressRouteCrossConnectionPeerings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCrossConnectionPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCrossConnectionPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCrossConnectionPeeringRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCrossConnectionPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCrossConnectionPeeringRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all peerings in a specified ExpressRouteCrossConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings
        /// Operation Id: ExpressRouteCrossConnectionPeerings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCrossConnectionPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCrossConnectionPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCrossConnectionPeeringRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCrossConnectionPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCrossConnectionPeeringRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}
        /// Operation Id: ExpressRouteCrossConnectionPeerings_Get
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCrossConnectionPeering> IEnumerable<ExpressRouteCrossConnectionPeering>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCrossConnectionPeering> IAsyncEnumerable<ExpressRouteCrossConnectionPeering>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
