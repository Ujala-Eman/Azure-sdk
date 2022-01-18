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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetInfoResource and their operations over its parent. </summary>
    public partial class ServerfarmVirtualNetworkConnectionCollection : ArmCollection, IEnumerable<ServerfarmVirtualNetworkConnection>, IAsyncEnumerable<ServerfarmVirtualNetworkConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerfarmVirtualNetworkConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppServicePlan.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppServicePlan.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> Get(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnection> GetIfExists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetIfExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vnetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnection>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public virtual Response<bool> Exists(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
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
        /// <param name="vnetName"> Name of the Virtual Network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vnetName, CancellationToken cancellationToken = default)
        {
            if (vnetName == null)
            {
                throw new ArgumentNullException(nameof(vnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.Exists");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_ListVnets
        /// <summary> Description for Get all Virtual Networks associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerfarmVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerfarmVirtualNetworkConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerfarmVirtualNetworkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServicePlansRestClient.ListVnets(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
        /// OperationId: AppServicePlans_ListVnets
        /// <summary> Description for Get all Virtual Networks associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerfarmVirtualNetworkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerfarmVirtualNetworkConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerfarmVirtualNetworkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServicePlansRestClient.ListVnetsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Select(value => new ServerfarmVirtualNetworkConnection(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<ServerfarmVirtualNetworkConnection> IEnumerable<ServerfarmVirtualNetworkConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerfarmVirtualNetworkConnection> IAsyncEnumerable<ServerfarmVirtualNetworkConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerfarmVirtualNetworkConnection, VnetInfoResourceData> Construct() { }
    }
}
