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
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    internal partial class PrivateLinkResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateLinkResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateLinkResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-07-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByPrivateLinkScopeRequest(string subscriptionId, string resourceGroupName, string scopeName)
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
            uri.AppendPath("/providers/Microsoft.Insights/privateLinkScopes/", false);
            uri.AppendPath(scopeName, true);
            uri.AppendPath("/privateLinkResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MonitorPrivateLinkResourceListResult>> ListByPrivateLinkScopeAsync(string subscriptionId, string resourceGroupName, string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var message = CreateListByPrivateLinkScopeRequest(subscriptionId, resourceGroupName, scopeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MonitorPrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MonitorPrivateLinkResourceListResult.DeserializeMonitorPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="scopeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MonitorPrivateLinkResourceListResult> ListByPrivateLinkScope(string subscriptionId, string resourceGroupName, string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var message = CreateListByPrivateLinkScopeRequest(subscriptionId, resourceGroupName, scopeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MonitorPrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MonitorPrivateLinkResourceListResult.DeserializeMonitorPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string scopeName, string groupName)
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
            uri.AppendPath("/providers/Microsoft.Insights/privateLinkScopes/", false);
            uri.AppendPath(scopeName, true);
            uri.AppendPath("/privateLinkResources/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="scopeName"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="scopeName"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MonitorPrivateLinkResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string scopeName, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, scopeName, groupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MonitorPrivateLinkResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MonitorPrivateLinkResourceData.DeserializeMonitorPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MonitorPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scopeName"> The name of the Azure Monitor PrivateLinkScope resource. </param>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="scopeName"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="scopeName"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MonitorPrivateLinkResourceData> Get(string subscriptionId, string resourceGroupName, string scopeName, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, scopeName, groupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MonitorPrivateLinkResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MonitorPrivateLinkResourceData.DeserializeMonitorPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MonitorPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
