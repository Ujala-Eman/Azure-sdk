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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class PacketCapturesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of PacketCapturesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public PacketCapturesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-02-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCaptureInput parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures/", false);
            uri.AppendPath(packetCaptureName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, <paramref name="packetCaptureName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create and start a packet capture on the specified VM. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="parameters"> Parameters that define the create packet capture operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, <paramref name="packetCaptureName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, PacketCaptureInput parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures/", false);
            uri.AppendPath(packetCaptureName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public async Task<Response<PacketCaptureData>> GetAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCaptureData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCaptureData.DeserializePacketCaptureData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PacketCaptureData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a packet capture session by name. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public Response<PacketCaptureData> Get(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCaptureData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCaptureData.DeserializePacketCaptureData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PacketCaptureData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures/", false);
            uri.AppendPath(packetCaptureName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopRequest(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures/", false);
            uri.AppendPath(packetCaptureName, true);
            uri.AppendPath("/stop", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public async Task<Response> StopAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateStopRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Stops a specified packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="packetCaptureName"> The name of the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public Response Stop(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateStopRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStatusRequest(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures/", false);
            uri.AppendPath(packetCaptureName, true);
            uri.AppendPath("/queryStatus", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="packetCaptureName"> The name given to the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public async Task<Response> GetStatusAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateGetStatusRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Query the status of a running packet capture session. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="packetCaptureName"> The name given to the packet capture session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkWatcherName"/>, or <paramref name="packetCaptureName"/> is null. </exception>
        public Response GetStatus(string subscriptionId, string resourceGroupName, string networkWatcherName, string packetCaptureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (packetCaptureName == null)
            {
                throw new ArgumentNullException(nameof(packetCaptureName));
            }

            using var message = CreateGetStatusRequest(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string networkWatcherName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkWatchers/", false);
            uri.AppendPath(networkWatcherName, true);
            uri.AppendPath("/packetCaptures", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="networkWatcherName"/> is null. </exception>
        public async Task<Response<PacketCaptureListResult>> ListAsync(string subscriptionId, string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, networkWatcherName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCaptureListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCaptureListResult.DeserializePacketCaptureListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all packet capture sessions within the specified resource group. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkWatcherName"> The name of the Network Watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="networkWatcherName"/> is null. </exception>
        public Response<PacketCaptureListResult> List(string subscriptionId, string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, networkWatcherName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCaptureListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCaptureListResult.DeserializePacketCaptureListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
