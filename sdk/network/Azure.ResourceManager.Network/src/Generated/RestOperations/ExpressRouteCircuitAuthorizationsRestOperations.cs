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
    internal partial class ExpressRouteCircuitAuthorizationsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of ExpressRouteCircuitAuthorizationsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExpressRouteCircuitAuthorizationsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string circuitName, string authorizationName)
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
            uri.AppendPath("/providers/Microsoft.Network/expressRouteCircuits/", false);
            uri.AppendPath(circuitName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified authorization from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, or <paramref name="authorizationName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string circuitName, string authorizationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, circuitName, authorizationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified authorization from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, or <paramref name="authorizationName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string circuitName, string authorizationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, circuitName, authorizationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string circuitName, string authorizationName)
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
            uri.AppendPath("/providers/Microsoft.Network/expressRouteCircuits/", false);
            uri.AppendPath(circuitName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified authorization from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, or <paramref name="authorizationName"/> is null. </exception>
        public async Task<Response<ExpressRouteCircuitAuthorizationData>> GetAsync(string resourceGroupName, string circuitName, string authorizationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }

            using var message = CreateGetRequest(resourceGroupName, circuitName, authorizationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteCircuitAuthorizationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExpressRouteCircuitAuthorizationData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified authorization from the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, or <paramref name="authorizationName"/> is null. </exception>
        public Response<ExpressRouteCircuitAuthorizationData> Get(string resourceGroupName, string circuitName, string authorizationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }

            using var message = CreateGetRequest(resourceGroupName, circuitName, authorizationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressRouteCircuitAuthorizationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExpressRouteCircuitAuthorizationData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string circuitName, string authorizationName, ExpressRouteCircuitAuthorizationData authorizationParameters)
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
            uri.AppendPath("/providers/Microsoft.Network/expressRouteCircuits/", false);
            uri.AppendPath(circuitName, true);
            uri.AppendPath("/authorizations/", false);
            uri.AppendPath(authorizationName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(authorizationParameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates or updates an authorization in the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="authorizationParameters"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, <paramref name="authorizationName"/>, or <paramref name="authorizationParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string circuitName, string authorizationName, ExpressRouteCircuitAuthorizationData authorizationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }
            if (authorizationParameters == null)
            {
                throw new ArgumentNullException(nameof(authorizationParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, circuitName, authorizationName, authorizationParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates an authorization in the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="authorizationName"> The name of the authorization. </param>
        /// <param name="authorizationParameters"> Parameters supplied to the create or update express route circuit authorization operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="circuitName"/>, <paramref name="authorizationName"/>, or <paramref name="authorizationParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string circuitName, string authorizationName, ExpressRouteCircuitAuthorizationData authorizationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (authorizationName == null)
            {
                throw new ArgumentNullException(nameof(authorizationName));
            }
            if (authorizationParameters == null)
            {
                throw new ArgumentNullException(nameof(authorizationParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, circuitName, authorizationName, authorizationParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string circuitName)
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
            uri.AppendPath("/providers/Microsoft.Network/expressRouteCircuits/", false);
            uri.AppendPath(circuitName, true);
            uri.AppendPath("/authorizations", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all authorizations in an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="circuitName"/> is null. </exception>
        public async Task<Response<AuthorizationListResult>> ListAsync(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var message = CreateListRequest(resourceGroupName, circuitName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AuthorizationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AuthorizationListResult.DeserializeAuthorizationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all authorizations in an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="circuitName"/> is null. </exception>
        public Response<AuthorizationListResult> List(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var message = CreateListRequest(resourceGroupName, circuitName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AuthorizationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AuthorizationListResult.DeserializeAuthorizationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string circuitName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all authorizations in an express route circuit. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="circuitName"/> is null. </exception>
        public async Task<Response<AuthorizationListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, circuitName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AuthorizationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AuthorizationListResult.DeserializeAuthorizationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all authorizations in an express route circuit. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="circuitName"/> is null. </exception>
        public Response<AuthorizationListResult> ListNextPage(string nextLink, string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, circuitName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AuthorizationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AuthorizationListResult.DeserializeAuthorizationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
