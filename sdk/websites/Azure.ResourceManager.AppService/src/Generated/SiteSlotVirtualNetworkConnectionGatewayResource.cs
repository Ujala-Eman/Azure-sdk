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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotVirtualNetworkConnectionGateway along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotVirtualNetworkConnectionGatewayResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotVirtualNetworkConnectionGatewayResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotVirtualNetworkConnectionResource" /> using the GetSiteSlotVirtualNetworkConnectionGateway method.
    /// </summary>
    public partial class SiteSlotVirtualNetworkConnectionGatewayResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotVirtualNetworkConnectionGatewayResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="vnetName"> The vnetName. </param>
        /// <param name="gatewayName"> The gatewayName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string vnetName, string gatewayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient;
        private readonly AppServiceVirtualNetworkGatewayData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionGatewayResource"/> class for mocking. </summary>
        protected SiteSlotVirtualNetworkConnectionGatewayResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotVirtualNetworkConnectionGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotVirtualNetworkConnectionGatewayResource(ArmClient client, AppServiceVirtualNetworkGatewayData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotVirtualNetworkConnectionGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotVirtualNetworkConnectionGatewayResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotVirtualNetworkConnectionGatewayWebAppsApiVersion);
            _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotVirtualNetworkConnectionGatewayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/virtualNetworkConnections/gateways";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppServiceVirtualNetworkGatewayData Data
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
        /// Description for Gets an app's Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGatewaySlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionGatewayResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionGatewayResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGatewaySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an app's Virtual Network gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetVnetConnectionGatewaySlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotVirtualNetworkConnectionGatewayResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionGatewayResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGatewaySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateVnetConnectionGatewaySlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SiteSlotVirtualNetworkConnectionGatewayResource>> UpdateAsync(AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionGatewayResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient.UpdateVnetConnectionGatewaySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateVnetConnectionGatewaySlot</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SiteSlotVirtualNetworkConnectionGatewayResource> Update(AppServiceVirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteSlotVirtualNetworkConnectionGatewayResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotVirtualNetworkConnectionGatewayWebAppsRestClient.UpdateVnetConnectionGatewaySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new SiteSlotVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
