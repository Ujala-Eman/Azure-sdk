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
    /// <summary> A class representing collection of RemotePrivateEndpointConnectionARMResource and their operations over its parent. </summary>
    public partial class SitePrivateEndpointConnectionCollection : ArmCollection, IEnumerable<SitePrivateEndpointConnection>, IAsyncEnumerable<SitePrivateEndpointConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected SitePrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SitePrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SitePrivateEndpointConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SitePrivateEndpointConnection.ResourceType, out string apiVersion);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ApproveOrRejectPrivateEndpointConnection
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointWrapper"/> is null. </exception>
        public virtual SitePrivateEndpointConnectionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.ApproveOrRejectPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken);
                var operation = new SitePrivateEndpointConnectionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ApproveOrRejectPrivateEndpointConnection
        /// <summary> Description for Approves or rejects a private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="privateEndpointWrapper"> The PrivateLinkConnectionApprovalRequestResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointWrapper"/> is null. </exception>
        public async virtual Task<SitePrivateEndpointConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string privateEndpointConnectionName, PrivateLinkConnectionApprovalRequestResource privateEndpointWrapper, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }
            if (privateEndpointWrapper == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointWrapper));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.ApproveOrRejectPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper, cancellationToken).ConfigureAwait(false);
                var operation = new SitePrivateEndpointConnectionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateApproveOrRejectPrivateEndpointConnectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, privateEndpointWrapper).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPrivateEndpointConnection
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public virtual Response<SitePrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SitePrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections/{privateEndpointConnectionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPrivateEndpointConnection
        /// <summary> Description for Gets a private endpoint connection. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public async virtual Task<Response<SitePrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SitePrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public virtual Response<SitePrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetPrivateEndpointConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SitePrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SitePrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public async virtual Task<Response<SitePrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetPrivateEndpointConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SitePrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new SitePrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(privateEndpointConnectionName))
            {
                throw new ArgumentException($"Parameter {nameof(privateEndpointConnectionName)} cannot be null or empty", nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPrivateEndpointConnectionList
        /// <summary> Description for Gets the list of private endpoint connections associated with a site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SitePrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SitePrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SitePrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetPrivateEndpointConnectionList(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePrivateEndpointConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SitePrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetPrivateEndpointConnectionListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePrivateEndpointConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/privateEndpointConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetPrivateEndpointConnectionList
        /// <summary> Description for Gets the list of private endpoint connections associated with a site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SitePrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SitePrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SitePrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetPrivateEndpointConnectionListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePrivateEndpointConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SitePrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SitePrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetPrivateEndpointConnectionListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SitePrivateEndpointConnection(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SitePrivateEndpointConnection> IEnumerable<SitePrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SitePrivateEndpointConnection> IAsyncEnumerable<SitePrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SitePrivateEndpointConnection, RemotePrivateEndpointConnectionARMResourceData> Construct() { }
    }
}
