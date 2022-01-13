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
    /// <summary> A Class representing a VirtualWAN along with the instance operations that can be performed on it. </summary>
    public partial class VirtualWAN : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualWAN"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualWANName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWANName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualWansRestOperations _virtualWansRestClient;
        private readonly NetworkManagementRestOperations _restClient;
        private readonly VpnSitesConfigurationRestOperations _vpnSitesConfigurationRestClient;
        private readonly VpnServerConfigurationsAssociatedWithVirtualWanRestOperations _vpnServerConfigurationsAssociatedWithVirtualWanRestClient;
        private readonly VirtualWANData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualWAN"/> class for mocking. </summary>
        protected VirtualWAN()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualWAN"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualWAN(ArmResource options, VirtualWANData resource) : base(options, new ResourceIdentifier(resource.Id))
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualWansRestClient = new VirtualWansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _restClient = new NetworkManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnSitesConfigurationRestClient = new VpnSitesConfigurationRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnServerConfigurationsAssociatedWithVirtualWanRestClient = new VpnServerConfigurationsAssociatedWithVirtualWanRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWAN"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualWAN(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualWansRestClient = new VirtualWansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _restClient = new NetworkManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnSitesConfigurationRestClient = new VpnSitesConfigurationRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnServerConfigurationsAssociatedWithVirtualWanRestClient = new VpnServerConfigurationsAssociatedWithVirtualWanRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWAN"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualWAN(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualWansRestClient = new VirtualWansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _restClient = new NetworkManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnSitesConfigurationRestClient = new VpnSitesConfigurationRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _vpnServerConfigurationsAssociatedWithVirtualWanRestClient = new VpnServerConfigurationsAssociatedWithVirtualWanRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualWans";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualWANData Data
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

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualWAN>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Get");
            scope.Start();
            try
            {
                var response = await _virtualWansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWAN> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Get");
            scope.Start();
            try
            {
                var response = _virtualWansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualWanDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Delete");
            scope.Start();
            try
            {
                var response = await _virtualWansRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualWanDeleteOperation(_clientDiagnostics, Pipeline, _virtualWansRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualWanDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Delete");
            scope.Start();
            try
            {
                var response = _virtualWansRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VirtualWanDeleteOperation(_clientDiagnostics, Pipeline, _virtualWansRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="wANParameters"> Parameters supplied to Update VirtualWAN tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="wANParameters"/> is null. </exception>
        public async virtual Task<Response<VirtualWAN>> UpdateAsync(TagsObject wANParameters, CancellationToken cancellationToken = default)
        {
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Update");
            scope.Start();
            try
            {
                var response = await _virtualWansRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, wANParameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="wANParameters"> Parameters supplied to Update VirtualWAN tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="wANParameters"/> is null. </exception>
        public virtual Response<VirtualWAN> Update(TagsObject wANParameters, CancellationToken cancellationToken = default)
        {
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Update");
            scope.Start();
            try
            {
                var response = _virtualWansRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, wANParameters, cancellationToken);
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualWanSecurityProviders>> SupportedSecurityProvidersAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.SupportedSecurityProviders");
            scope.Start();
            try
            {
                var response = await _restClient.SupportedSecurityProvidersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWanSecurityProviders> SupportedSecurityProviders(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.SupportedSecurityProviders");
            scope.Start();
            try
            {
                var response = _restClient.SupportedSecurityProviders(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnClientParams"/> is null. </exception>
        public async virtual Task<NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation> GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(VirtualWanVpnProfileParameters vpnClientParams, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Generatevirtualwanvpnserverconfigurationvpnprofile");
            scope.Start();
            try
            {
                var response = await _restClient.GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnClientParams, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation(_clientDiagnostics, Pipeline, _restClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnClientParams).Request, response);
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

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="vpnClientParams"> Parameters supplied to the generate VirtualWan VPN profile generation operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vpnClientParams"/> is null. </exception>
        public virtual NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation Generatevirtualwanvpnserverconfigurationvpnprofile(VirtualWanVpnProfileParameters vpnClientParams, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (vpnClientParams == null)
            {
                throw new ArgumentNullException(nameof(vpnClientParams));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.Generatevirtualwanvpnserverconfigurationvpnprofile");
            scope.Start();
            try
            {
                var response = _restClient.Generatevirtualwanvpnserverconfigurationvpnprofile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnClientParams, cancellationToken);
                var operation = new NetworkManagementGeneratevirtualwanvpnserverconfigurationvpnprofileOperation(_clientDiagnostics, Pipeline, _restClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vpnClientParams).Request, response);
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

        /// <summary> Gives the sas-url to download the configurations for vpn-sites in a resource group. </summary>
        /// <param name="request"> Parameters supplied to download vpn-sites configuration. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public async virtual Task<VpnSitesConfigurationDownloadOperation> DownloadVpnSitesConfigurationAsync(GetVpnSitesConfigurationRequest request, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.DownloadVpnSitesConfiguration");
            scope.Start();
            try
            {
                var response = await _vpnSitesConfigurationRestClient.DownloadAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, request, cancellationToken).ConfigureAwait(false);
                var operation = new VpnSitesConfigurationDownloadOperation(_clientDiagnostics, Pipeline, _vpnSitesConfigurationRestClient.CreateDownloadRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, request).Request, response);
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

        /// <summary> Gives the sas-url to download the configurations for vpn-sites in a resource group. </summary>
        /// <param name="request"> Parameters supplied to download vpn-sites configuration. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public virtual VpnSitesConfigurationDownloadOperation DownloadVpnSitesConfiguration(GetVpnSitesConfigurationRequest request, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.DownloadVpnSitesConfiguration");
            scope.Start();
            try
            {
                var response = _vpnSitesConfigurationRestClient.Download(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, request, cancellationToken);
                var operation = new VpnSitesConfigurationDownloadOperation(_clientDiagnostics, Pipeline, _vpnSitesConfigurationRestClient.CreateDownloadRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, request).Request, response);
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

        /// <summary> Gives the list of VpnServerConfigurations associated with Virtual Wan in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnServerConfigurationsAssociatedWithVirtualWanListOperation> GetVpnServerConfigurationsAssociatedWithVirtualWanAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.GetVpnServerConfigurationsAssociatedWithVirtualWan");
            scope.Start();
            try
            {
                var response = await _vpnServerConfigurationsAssociatedWithVirtualWanRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new VpnServerConfigurationsAssociatedWithVirtualWanListOperation(_clientDiagnostics, Pipeline, _vpnServerConfigurationsAssociatedWithVirtualWanRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Gives the list of VpnServerConfigurations associated with Virtual Wan in a resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnServerConfigurationsAssociatedWithVirtualWanListOperation GetVpnServerConfigurationsAssociatedWithVirtualWan(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWAN.GetVpnServerConfigurationsAssociatedWithVirtualWan");
            scope.Start();
            try
            {
                var response = _vpnServerConfigurationsAssociatedWithVirtualWanRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new VpnServerConfigurationsAssociatedWithVirtualWanListOperation(_clientDiagnostics, Pipeline, _vpnServerConfigurationsAssociatedWithVirtualWanRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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
    }
}
