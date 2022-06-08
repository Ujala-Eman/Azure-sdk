// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VpnSiteLinksRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of <see cref="VpnSiteLinksRestOperations" />. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VpnSiteLinksRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vpnSiteName, string vpnSiteLinkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnSites/", false);
            uri.AppendPath(vpnSiteName, true);
            uri.AppendPath("/vpnSiteLinks/", false);
            uri.AppendPath(vpnSiteLinkName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/> or <paramref name="vpnSiteLinkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/> or <paramref name="vpnSiteLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VpnSiteLinkData>> GetAsync(string subscriptionId, string resourceGroupName, string vpnSiteName, string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));
            Argument.AssertNotNullOrEmpty(vpnSiteLinkName, nameof(vpnSiteLinkName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vpnSiteName, vpnSiteLinkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnSiteLinkData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VpnSiteLinkData.DeserializeVpnSiteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnSiteLinkData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves the details of a VPN site link. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="vpnSiteLinkName"> The name of the VpnSiteLink being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/> or <paramref name="vpnSiteLinkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnSiteName"/> or <paramref name="vpnSiteLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VpnSiteLinkData> Get(string subscriptionId, string resourceGroupName, string vpnSiteName, string vpnSiteLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));
            Argument.AssertNotNullOrEmpty(vpnSiteLinkName, nameof(vpnSiteLinkName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vpnSiteName, vpnSiteLinkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnSiteLinkData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VpnSiteLinkData.DeserializeVpnSiteLinkData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnSiteLinkData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVpnSiteRequest(string subscriptionId, string resourceGroupName, string vpnSiteName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnSites/", false);
            uri.AppendPath(vpnSiteName, true);
            uri.AppendPath("/vpnSiteLinks", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnSiteLinksResult>> ListByVpnSiteAsync(string subscriptionId, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var message = CreateListByVpnSiteRequest(subscriptionId, resourceGroupName, vpnSiteName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnSiteLinksResult> ListByVpnSite(string subscriptionId, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var message = CreateListByVpnSiteRequest(subscriptionId, resourceGroupName, vpnSiteName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVpnSiteNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vpnSiteName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnSiteLinksResult>> ListByVpnSiteNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var message = CreateListByVpnSiteNextPageRequest(nextLink, subscriptionId, resourceGroupName, vpnSiteName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the vpnSiteLinks in a resource group for a vpn site. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnSite. </param>
        /// <param name="vpnSiteName"> The name of the VpnSite. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnSiteName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnSiteLinksResult> ListByVpnSiteNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vpnSiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnSiteName, nameof(vpnSiteName));

            using var message = CreateListByVpnSiteNextPageRequest(nextLink, subscriptionId, resourceGroupName, vpnSiteName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinksResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinksResult.DeserializeListVpnSiteLinksResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
