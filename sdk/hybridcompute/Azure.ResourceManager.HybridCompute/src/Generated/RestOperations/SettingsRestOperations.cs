// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridCompute.Models;

namespace Azure.ResourceManager.HybridCompute
{
    internal partial class SettingsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SettingsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SettingsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-07-31-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string subscriptionId, string resourceGroupName, string baseProvider, string baseResourceType, string baseResourceName, string settingsResourceName, Settings settings)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/", false);
            uri.AppendPath(baseProvider, true);
            uri.AppendPath("/", false);
            uri.AppendPath(baseResourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(baseResourceName, true);
            uri.AppendPath("/providers/Microsoft.HybridCompute/settings/", false);
            uri.AppendPath(settingsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string baseProvider, string baseResourceType, string baseResourceName, string settingsResourceName, Settings settings)
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
            uri.AppendPath("/providers/", false);
            uri.AppendPath(baseProvider, true);
            uri.AppendPath("/", false);
            uri.AppendPath(baseResourceType, true);
            uri.AppendPath("/", false);
            uri.AppendPath(baseResourceName, true);
            uri.AppendPath("/providers/Microsoft.HybridCompute/settings/", false);
            uri.AppendPath(settingsResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(settings, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates the base Settings of the target resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="baseProvider"> The name of the base Resource Provider. </param>
        /// <param name="baseResourceType"> The name of the base Resource Type. </param>
        /// <param name="baseResourceName"> The name of the base resource. </param>
        /// <param name="settingsResourceName"> The name of the settings resource. </param>
        /// <param name="settings"> Settings details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="baseProvider"/>, <paramref name="baseResourceType"/>, <paramref name="baseResourceName"/>, <paramref name="settingsResourceName"/> or <paramref name="settings"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="baseProvider"/>, <paramref name="baseResourceType"/>, <paramref name="baseResourceName"/> or <paramref name="settingsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Settings>> UpdateAsync(string subscriptionId, string resourceGroupName, string baseProvider, string baseResourceType, string baseResourceName, string settingsResourceName, Settings settings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(baseProvider, nameof(baseProvider));
            Argument.AssertNotNullOrEmpty(baseResourceType, nameof(baseResourceType));
            Argument.AssertNotNullOrEmpty(baseResourceName, nameof(baseResourceName));
            Argument.AssertNotNullOrEmpty(settingsResourceName, nameof(settingsResourceName));
            Argument.AssertNotNull(settings, nameof(settings));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, baseProvider, baseResourceType, baseResourceName, settingsResourceName, settings);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        Settings value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Settings.DeserializeSettings(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the base Settings of the target resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="baseProvider"> The name of the base Resource Provider. </param>
        /// <param name="baseResourceType"> The name of the base Resource Type. </param>
        /// <param name="baseResourceName"> The name of the base resource. </param>
        /// <param name="settingsResourceName"> The name of the settings resource. </param>
        /// <param name="settings"> Settings details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="baseProvider"/>, <paramref name="baseResourceType"/>, <paramref name="baseResourceName"/>, <paramref name="settingsResourceName"/> or <paramref name="settings"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="baseProvider"/>, <paramref name="baseResourceType"/>, <paramref name="baseResourceName"/> or <paramref name="settingsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Settings> Update(string subscriptionId, string resourceGroupName, string baseProvider, string baseResourceType, string baseResourceName, string settingsResourceName, Settings settings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(baseProvider, nameof(baseProvider));
            Argument.AssertNotNullOrEmpty(baseResourceType, nameof(baseResourceType));
            Argument.AssertNotNullOrEmpty(baseResourceName, nameof(baseResourceName));
            Argument.AssertNotNullOrEmpty(settingsResourceName, nameof(settingsResourceName));
            Argument.AssertNotNull(settings, nameof(settings));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, baseProvider, baseResourceType, baseResourceName, settingsResourceName, settings);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        Settings value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Settings.DeserializeSettings(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
