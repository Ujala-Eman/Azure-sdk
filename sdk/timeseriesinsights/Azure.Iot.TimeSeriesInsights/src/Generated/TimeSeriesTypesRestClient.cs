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

namespace Azure.Iot.TimeSeriesInsights
{
    internal partial class TimeSeriesTypesRestClient
    {
        private string environmentFqdn;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TimeSeriesTypesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="environmentFqdn"> Per environment FQDN, for example 10000000-0000-0000-0000-100000000109.env.timeseries.azure.com. You can obtain this domain name from the response of the Get Environments API, Azure portal, or Azure Resource Manager. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentFqdn"/> or <paramref name="apiVersion"/> is null. </exception>
        public TimeSeriesTypesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string environmentFqdn, string apiVersion = "2020-07-31")
        {
            if (environmentFqdn == null)
            {
                throw new ArgumentNullException(nameof(environmentFqdn));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.environmentFqdn = environmentFqdn;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string continuationToken, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(environmentFqdn, false);
            uri.AppendPath("/timeseries/types", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (continuationToken != null)
            {
                request.Headers.Add("x-ms-continuation", continuationToken);
            }
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets time series types in pages. </summary>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<GetTypesPage>> ListAsync(string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(continuationToken, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetTypesPage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GetTypesPage.DeserializeGetTypesPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets time series types in pages. </summary>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<GetTypesPage> List(string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(continuationToken, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetTypesPage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GetTypesPage.DeserializeGetTypesPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteBatchRequest(TypesBatchRequest parameters, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(environmentFqdn, false);
            uri.AppendPath("/timeseries/types/$batch", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Executes a batch get, create, update, delete operation on multiple time series types. </summary>
        /// <param name="parameters"> Time series types batch request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<TypesBatchResponse>> ExecuteBatchAsync(TypesBatchRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteBatchRequest(parameters, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TypesBatchResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TypesBatchResponse.DeserializeTypesBatchResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes a batch get, create, update, delete operation on multiple time series types. </summary>
        /// <param name="parameters"> Time series types batch request body. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<TypesBatchResponse> ExecuteBatch(TypesBatchRequest parameters, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteBatchRequest(parameters, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TypesBatchResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TypesBatchResponse.DeserializeTypesBatchResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
