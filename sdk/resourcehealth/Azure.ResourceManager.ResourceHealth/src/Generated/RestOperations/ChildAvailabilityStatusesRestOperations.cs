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
    internal partial class ChildAvailabilityStatusesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ChildAvailabilityStatusesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ChildAvailabilityStatusesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetByResourceRequestUri(string resourceUri, string filter, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/childAvailabilityStatuses/current", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetByResourceRequest(string resourceUri, string filter, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/childAvailabilityStatuses/current", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<ResourceHealthAvailabilityStatus>> GetByResourceAsync(string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateGetByResourceRequest(resourceUri, filter, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatus value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets current availability status for a single resource. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<ResourceHealthAvailabilityStatus> GetByResource(string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateGetByResourceRequest(resourceUri, filter, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatus value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceHealthAvailabilityStatus.DeserializeResourceHealthAvailabilityStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceUri, string filter, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/childAvailabilityStatuses", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceUri, string filter, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/childAvailabilityStatuses", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<ResourceHealthAvailabilityStatusListResult>> ListAsync(string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri, filter, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatusListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceHealthAvailabilityStatusListResult.DeserializeResourceHealthAvailabilityStatusListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<ResourceHealthAvailabilityStatusListResult> List(string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListRequest(resourceUri, filter, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatusListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceHealthAvailabilityStatusListResult.DeserializeResourceHealthAvailabilityStatusListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceUri, string filter, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceUri, string filter, string expand)
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

        /// <summary> Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<ResourceHealthAvailabilityStatusListResult>> ListNextPageAsync(string nextLink, string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceUri, filter, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatusListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceHealthAvailabilityStatusListResult.DeserializeResourceHealthAvailabilityStatusListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the historical availability statuses for a single child resource. Use the nextLink property in the response to get the next page of availability status. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified ID of the resource, including the resource name and resource type. Currently the API only support one nesting level resource types : /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resource-provider-name}/{parentResourceType}/{parentResourceName}/{resourceType}/{resourceName}. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="expand"> Setting $expand=recommendedactions in url query expands the recommendedactions in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public Response<ResourceHealthAvailabilityStatusListResult> ListNextPage(string nextLink, string resourceUri, string filter = null, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceUri == null)
            {
                throw new ArgumentNullException(nameof(resourceUri));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceUri, filter, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthAvailabilityStatusListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceHealthAvailabilityStatusListResult.DeserializeResourceHealthAvailabilityStatusListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
