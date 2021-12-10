// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Purview.Administration.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Administration
{
    internal partial class ResourceSetRulesRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ResourceSetRulesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The account endpoint of your Purview account. Example: https://{accountName}.purview.azure.com/account/. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ResourceSetRulesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetResourceSetRuleRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", "2019-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ResourceSetRuleConfig>> GetResourceSetRuleAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetResourceSetRuleRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceSetRuleConfig value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceSetRuleConfig.DeserializeResourceSetRuleConfig(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ResourceSetRuleConfig> GetResourceSetRule(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetResourceSetRuleRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceSetRuleConfig value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceSetRuleConfig.DeserializeResourceSetRuleConfig(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateResourceSetRuleRequest(ResourceSetRuleConfig resourceSetRuleConfig)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", "2019-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(resourceSetRuleConfig);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="resourceSetRuleConfig"> The ResourceSetRuleConfig to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceSetRuleConfig"/> is null. </exception>
        public async Task<Response<ResourceSetRuleConfig>> CreateOrUpdateResourceSetRuleAsync(ResourceSetRuleConfig resourceSetRuleConfig, CancellationToken cancellationToken = default)
        {
            if (resourceSetRuleConfig == null)
            {
                throw new ArgumentNullException(nameof(resourceSetRuleConfig));
            }

            using var message = CreateCreateOrUpdateResourceSetRuleRequest(resourceSetRuleConfig);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceSetRuleConfig value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceSetRuleConfig.DeserializeResourceSetRuleConfig(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="resourceSetRuleConfig"> The ResourceSetRuleConfig to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceSetRuleConfig"/> is null. </exception>
        public Response<ResourceSetRuleConfig> CreateOrUpdateResourceSetRule(ResourceSetRuleConfig resourceSetRuleConfig, CancellationToken cancellationToken = default)
        {
            if (resourceSetRuleConfig == null)
            {
                throw new ArgumentNullException(nameof(resourceSetRuleConfig));
            }

            using var message = CreateCreateOrUpdateResourceSetRuleRequest(resourceSetRuleConfig);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceSetRuleConfig value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceSetRuleConfig.DeserializeResourceSetRuleConfig(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteResourceSetRuleRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", "2019-11-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteResourceSetRuleAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteResourceSetRuleRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteResourceSetRule(CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteResourceSetRuleRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
