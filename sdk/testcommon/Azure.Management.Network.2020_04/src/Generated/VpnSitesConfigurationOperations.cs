// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The VpnSitesConfiguration service client. </summary>
    public partial class VpnSitesConfigurationOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnSitesConfigurationRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VpnSitesConfigurationOperations for mocking. </summary>
        protected VpnSitesConfigurationOperations()
        {
        }
        /// <summary> Initializes a new instance of VpnSitesConfigurationOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VpnSitesConfigurationOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VpnSitesConfigurationRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gives the sas-url to download the configurations for vpn-sites in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="request"> Parameters supplied to download vpn-sites configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="request"/> is null. </exception>
        public virtual async Task<VpnSitesConfigurationDownloadOperation> StartDownloadAsync(string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesConfigurationOperations.StartDownload");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DownloadAsync(resourceGroupName, virtualWANName, request, cancellationToken).ConfigureAwait(false);
                return new VpnSitesConfigurationDownloadOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadRequest(resourceGroupName, virtualWANName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the sas-url to download the configurations for vpn-sites in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="request"> Parameters supplied to download vpn-sites configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="virtualWANName"/>, or <paramref name="request"/> is null. </exception>
        public virtual VpnSitesConfigurationDownloadOperation StartDownload(string resourceGroupName, string virtualWANName, GetVpnSitesConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnSitesConfigurationOperations.StartDownload");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Download(resourceGroupName, virtualWANName, request, cancellationToken);
                return new VpnSitesConfigurationDownloadOperation(_clientDiagnostics, _pipeline, RestClient.CreateDownloadRequest(resourceGroupName, virtualWANName, request).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
