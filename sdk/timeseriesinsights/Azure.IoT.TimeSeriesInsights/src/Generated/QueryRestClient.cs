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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class QueryRestClient
    {
        private string environmentFqdn;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of QueryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="environmentFqdn"> Per environment FQDN, for example 10000000-0000-0000-0000-100000000109.env.timeseries.azure.com. You can obtain this domain name from the response of the Get Environments API, Azure portal, or Azure Resource Manager. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentFqdn"/> or <paramref name="apiVersion"/> is null. </exception>
        public QueryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string environmentFqdn, string apiVersion = "2020-07-31")
        {
            this.environmentFqdn = environmentFqdn ?? throw new ArgumentNullException(nameof(environmentFqdn));
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetAvailabilityRequest(string storeType, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(environmentFqdn, false);
            uri.AppendPath("/availability", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (storeType != null)
            {
                uri.AppendQuery("storeType", storeType, true);
            }
            request.Uri = uri;
            if (clientSessionId != null)
            {
                request.Headers.Add("x-ms-client-session-id", clientSessionId);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Returns the time range and distribution of event count over the event timestamp ($ts). This API can be used to provide landing experience of navigating to the environment. </summary>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AvailabilityResponse>> GetAvailabilityAsync(string storeType = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAvailabilityRequest(storeType, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvailabilityResponse.DeserializeAvailabilityResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns the time range and distribution of event count over the event timestamp ($ts). This API can be used to provide landing experience of navigating to the environment. </summary>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AvailabilityResponse> GetAvailability(string storeType = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAvailabilityRequest(storeType, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvailabilityResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvailabilityResponse.DeserializeAvailabilityResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetEventSchemaRequest(GetEventSchemaRequest parameters, string storeType, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(environmentFqdn, false);
            uri.AppendPath("/eventSchema", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (storeType != null)
            {
                uri.AppendQuery("storeType", storeType, true);
            }
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

        /// <summary> Returns environment event schema for a given search span. Event schema is a set of property definitions. Event schema may not be contain all persisted properties when there are too many properties. </summary>
        /// <param name="parameters"> Parameters to get event schema. </param>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<EventSchema>> GetEventSchemaAsync(GetEventSchemaRequest parameters, string storeType = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateGetEventSchemaRequest(parameters, storeType, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventSchema value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventSchema.DeserializeEventSchema(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Returns environment event schema for a given search span. Event schema is a set of property definitions. Event schema may not be contain all persisted properties when there are too many properties. </summary>
        /// <param name="parameters"> Parameters to get event schema. </param>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<EventSchema> GetEventSchema(GetEventSchemaRequest parameters, string storeType = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateGetEventSchemaRequest(parameters, storeType, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventSchema value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventSchema.DeserializeEventSchema(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteRequest(QueryRequest parameters, string storeType, string continuationToken, string clientSessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(environmentFqdn, false);
            uri.AppendPath("/timeseries/query", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (storeType != null)
            {
                uri.AppendQuery("storeType", storeType, true);
            }
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
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Executes Time Series Query in pages of results - Get Events, Get Series or Aggregate Series. </summary>
        /// <param name="parameters"> Time series query request body. </param>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<QueryResultPage>> ExecuteAsync(QueryRequest parameters, string storeType = null, string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteRequest(parameters, storeType, continuationToken, clientSessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResultPage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = QueryResultPage.DeserializeQueryResultPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Executes Time Series Query in pages of results - Get Events, Get Series or Aggregate Series. </summary>
        /// <param name="parameters"> Time series query request body. </param>
        /// <param name="storeType"> For the environments with warm store enabled, the query can be executed either on the &apos;WarmStore&apos; or &apos;ColdStore&apos;. This parameter in the query defines which store the query should be executed on. If not defined, the query will be executed on the cold store. </param>
        /// <param name="continuationToken"> Continuation token from previous page of results to retrieve the next page of the results in calls that support pagination. To get the first page results, specify null continuation token as parameter value. Returned continuation token is null if all results have been returned, and there is no next page of results. </param>
        /// <param name="clientSessionId"> Optional client session ID. Service records this value. Allows the service to trace a group of related operations across services, and allows the customer to contact support regarding a particular group of requests. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<QueryResultPage> Execute(QueryRequest parameters, string storeType = null, string continuationToken = null, string clientSessionId = null, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateExecuteRequest(parameters, storeType, continuationToken, clientSessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResultPage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = QueryResultPage.DeserializeQueryResultPage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
