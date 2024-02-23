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
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    internal partial class SecurityAdvisoryImpactedResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SecurityAdvisoryImpactedResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SecurityAdvisoryImpactedResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListBySubscriptionIdAndEventIdRequestUri(string subscriptionId, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/listSecurityAdvisoryImpactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListBySubscriptionIdAndEventIdRequest(string subscriptionId, string eventTrackingId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/listSecurityAdvisoryImpactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists impacted resources in the subscription by an event (Security Advisory). </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListBySubscriptionIdAndEventIdAsync(string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListBySubscriptionIdAndEventIdRequest(subscriptionId, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the subscription by an event (Security Advisory). </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListBySubscriptionIdAndEventId(string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListBySubscriptionIdAndEventIdRequest(subscriptionId, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByTenantIdAndEventIdRequestUri(string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/listSecurityAdvisoryImpactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByTenantIdAndEventIdRequest(string eventTrackingId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/listSecurityAdvisoryImpactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists impacted resources in the tenant by an event (Security Advisory). </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListByTenantIdAndEventIdAsync(string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListByTenantIdAndEventIdRequest(eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the tenant by an event (Security Advisory). </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListByTenantIdAndEventId(string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListByTenantIdAndEventIdRequest(eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListBySubscriptionIdAndEventIdNextPageRequestUri(string nextLink, string subscriptionId, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListBySubscriptionIdAndEventIdNextPageRequest(string nextLink, string subscriptionId, string eventTrackingId, string filter)
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

        /// <summary> Lists impacted resources in the subscription by an event (Security Advisory). </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListBySubscriptionIdAndEventIdNextPageAsync(string nextLink, string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, subscriptionId, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the subscription by an event (Security Advisory). </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListBySubscriptionIdAndEventIdNextPage(string nextLink, string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, subscriptionId, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByTenantIdAndEventIdNextPageRequestUri(string nextLink, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByTenantIdAndEventIdNextPageRequest(string nextLink, string eventTrackingId, string filter)
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

        /// <summary> Lists impacted resources in the tenant by an event (Security Advisory). </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListByTenantIdAndEventIdNextPageAsync(string nextLink, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListByTenantIdAndEventIdNextPageRequest(nextLink, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the tenant by an event (Security Advisory). </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListByTenantIdAndEventIdNextPage(string nextLink, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (eventTrackingId == null)
            {
                throw new ArgumentNullException(nameof(eventTrackingId));
            }
            if (eventTrackingId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(eventTrackingId));
            }

            using var message = CreateListByTenantIdAndEventIdNextPageRequest(nextLink, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
