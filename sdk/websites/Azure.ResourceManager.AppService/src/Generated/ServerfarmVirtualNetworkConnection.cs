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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a ServerfarmVirtualNetworkConnection along with the instance operations that can be performed on it. </summary>
    public partial class ServerfarmVirtualNetworkConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerfarmVirtualNetworkConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlansRestClient;
        private readonly VnetInfoResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerfarmVirtualNetworkConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnection(ArmResource options, VnetInfoResourceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnection"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnection(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnection"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnection(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/virtualNetworkConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VnetInfoResourceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetFromServerFarm
        /// <summary> Description for Get a Virtual Network associated with an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerfarmVirtualNetworkConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.Get");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnection(this, response.Value), response.GetRawResponse());
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
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_ListRoutesForVnet
        /// <summary> Description for Get all routes that are associated with a Virtual Network in an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VnetRoute> GetRoutesForVnetAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VnetRoute>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = await _appServicePlansRestClient.ListRoutesForVnetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_ListRoutesForVnet
        /// <summary> Description for Get all routes that are associated with a Virtual Network in an App Service plan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VnetRoute> GetRoutesForVnet(CancellationToken cancellationToken = default)
        {
            Page<VnetRoute> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = _appServicePlansRestClient.ListRoutesForVnet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_CreateOrUpdateVnetRoute
        /// <summary> Description for Create or update a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public async virtual Task<Response<VnetRoute>> CreateOrUpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.CreateOrUpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_CreateOrUpdateVnetRoute
        /// <summary> Description for Create or update a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> CreateOrUpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.CreateOrUpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_DeleteVnetRoute
        /// <summary> Description for Delete a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response> DeleteVnetRouteAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.DeleteVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_DeleteVnetRoute
        /// <summary> Description for Delete a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response DeleteVnetRoute(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.DeleteVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetRoute
        /// <summary> Description for Create or update a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public async virtual Task<Response<VnetRoute>> UpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.UpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetRoute
        /// <summary> Description for Create or update a Virtual Network route in an App Service plan. </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> UpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnection.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.UpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region ServerfarmVirtualNetworkConnectionGateway

        /// <summary> Gets a collection of ServerfarmVirtualNetworkConnectionGateways in the ServerfarmVirtualNetworkConnection. </summary>
        /// <returns> An object representing collection of ServerfarmVirtualNetworkConnectionGateways and their operations over a ServerfarmVirtualNetworkConnection. </returns>
        public virtual ServerfarmVirtualNetworkConnectionGatewayCollection GetServerfarmVirtualNetworkConnectionGateways()
        {
            return new ServerfarmVirtualNetworkConnectionGatewayCollection(this);
        }
        #endregion
    }
}
