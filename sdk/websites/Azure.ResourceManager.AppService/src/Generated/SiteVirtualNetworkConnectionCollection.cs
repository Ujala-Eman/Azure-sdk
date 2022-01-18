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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetInfoResource and their operations over its parent. </summary>
    public partial class SiteVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<SiteVirtualNetworkConnection>, IAsyncEnumerable<SiteVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteVirtualNetworkConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteVirtualNetworkConnection.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateVnetConnection
        /// <summary> Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual SiteVirtualNetworkConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string vnetName, VnetInfoResourceData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, connectionEnvelope, cancellationToken);
                var operation = new SiteVirtualNetworkConnectionCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateOrUpdateVnetConnection
        /// <summary> Description for Adds a Virtual Network connection to an app or slot (PUT) or updates the connection properties (PATCH). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vnetName"> Name of an existing Virtual Network. </param>
        /// <param name="connectionEnvelope"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<SiteVirtualNetworkConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string vnetName, VnetInfoResourceData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteVirtualNetworkConnectionCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Description for Gets a virtual network the app (or deployment slot) is connected to by name. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public virtual Response<SiteVirtualNetworkConnection> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetVnetConnection
        /// <summary> Description for Gets a virtual network the app (or deployment slot) is connected to by name. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnection>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public virtual Response<SiteVirtualNetworkConnection> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetVnetConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetVnetConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vnetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vnetName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(vnetName))
            {
                throw new ArgumentException($"Parameter {nameof(vnetName)} cannot be null or empty", nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListVnetConnections
        /// <summary> Description for Gets the virtual networks the app (or deployment slot) is connected to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListVnetConnections(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new SiteVirtualNetworkConnection(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListVnetConnections
        /// <summary> Description for Gets the virtual networks the app (or deployment slot) is connected to. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListVnetConnectionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new SiteVirtualNetworkConnection(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SiteVirtualNetworkConnection> IEnumerable<SiteVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteVirtualNetworkConnection> IAsyncEnumerable<SiteVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteVirtualNetworkConnection, VnetInfoResourceData> Construct() { }
    }
}
