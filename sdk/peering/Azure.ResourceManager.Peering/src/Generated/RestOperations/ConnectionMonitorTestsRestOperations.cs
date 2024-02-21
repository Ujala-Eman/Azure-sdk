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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    internal partial class ConnectionMonitorTestsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConnectionMonitorTestsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConnectionMonitorTestsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/connectionMonitorTests/", false);
            uri.AppendPath(connectionMonitorTestName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectionMonitorTestData>> GetAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectionMonitorTestData.DeserializeConnectionMonitorTestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConnectionMonitorTestData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectionMonitorTestData> Get(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectionMonitorTestData.DeserializeConnectionMonitorTestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConnectionMonitorTestData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, ConnectionMonitorTestData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/connectionMonitorTests/", false);
            uri.AppendPath(connectionMonitorTestName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="data"> The properties needed to create a connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/>, <paramref name="connectionMonitorTestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectionMonitorTestData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, ConnectionMonitorTestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ConnectionMonitorTestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectionMonitorTestData.DeserializeConnectionMonitorTestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="data"> The properties needed to create a connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/>, <paramref name="connectionMonitorTestName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectionMonitorTestData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, ConnectionMonitorTestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ConnectionMonitorTestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectionMonitorTestData.DeserializeConnectionMonitorTestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/connectionMonitorTests/", false);
            uri.AppendPath(connectionMonitorTestName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an existing connection monitor test with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="connectionMonitorTestName"> The name of the connection monitor test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="connectionMonitorTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string peeringServiceName, string connectionMonitorTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(connectionMonitorTestName, nameof(connectionMonitorTestName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, peeringServiceName, connectionMonitorTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPeeringServiceRequest(string subscriptionId, string resourceGroupName, string peeringServiceName)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/connectionMonitorTests", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all connection monitor tests under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectionMonitorTestListResult>> ListByPeeringServiceAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceRequest(subscriptionId, resourceGroupName, peeringServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectionMonitorTestListResult.DeserializeConnectionMonitorTestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all connection monitor tests under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectionMonitorTestListResult> ListByPeeringService(string subscriptionId, string resourceGroupName, string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceRequest(subscriptionId, resourceGroupName, peeringServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectionMonitorTestListResult.DeserializeConnectionMonitorTestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPeeringServiceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName)
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

        /// <summary> Lists all connection monitor tests under the given subscription, resource group and peering service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConnectionMonitorTestListResult>> ListByPeeringServiceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConnectionMonitorTestListResult.DeserializeConnectionMonitorTestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all connection monitor tests under the given subscription, resource group and peering service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConnectionMonitorTestListResult> ListByPeeringServiceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConnectionMonitorTestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConnectionMonitorTestListResult.DeserializeConnectionMonitorTestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
