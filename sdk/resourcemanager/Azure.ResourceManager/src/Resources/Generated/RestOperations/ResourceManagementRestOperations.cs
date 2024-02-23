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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class ResourceManagementRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ResourceManagementRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ResourceManagementRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCheckResourceNameRequestUri(ResourceNameValidationContent content)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Resources/checkResourceName", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCheckResourceNameRequest(ResourceNameValidationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Resources/checkResourceName", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (content != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content0 = new Utf8JsonRequestContent();
                content0.JsonWriter.WriteObjectValue(content);
                request.Content = content0;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> A resource name is valid if it is not a reserved word, does not contains a reserved word and does not start with a reserved word. </summary>
        /// <param name="content"> Resource object with values for resource name and resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ResourceNameValidationResult>> CheckResourceNameAsync(ResourceNameValidationContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCheckResourceNameRequest(content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceNameValidationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceNameValidationResult.DeserializeResourceNameValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> A resource name is valid if it is not a reserved word, does not contains a reserved word and does not start with a reserved word. </summary>
        /// <param name="content"> Resource object with values for resource name and resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ResourceNameValidationResult> CheckResourceName(ResourceNameValidationContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCheckResourceNameRequest(content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceNameValidationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceNameValidationResult.DeserializeResourceNameValidationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
