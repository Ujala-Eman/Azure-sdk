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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class InboundNatRulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of InboundNatRulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public InboundNatRulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string loadBalancerName)
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
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/inboundNatRules", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public async Task<Response<InboundNatRuleListResult>> ListAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListRequest(resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InboundNatRuleListResult.DeserializeInboundNatRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        public Response<InboundNatRuleListResult> List(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListRequest(resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InboundNatRuleListResult.DeserializeInboundNatRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string loadBalancerName, string inboundNatRuleName)
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
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/inboundNatRules/", false);
            uri.AppendPath(inboundNatRuleName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes the specified load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="inboundNatRuleName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, loadBalancerName, inboundNatRuleName);
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

        /// <summary> Deletes the specified load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="inboundNatRuleName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, loadBalancerName, inboundNatRuleName);
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

        internal HttpMessage CreateGetRequest(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, string expand)
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
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/inboundNatRules/", false);
            uri.AppendPath(inboundNatRuleName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="inboundNatRuleName"/> is null. </exception>
        public async Task<Response<InboundNatRule>> GetAsync(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, loadBalancerName, inboundNatRuleName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRule value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InboundNatRule.DeserializeInboundNatRule(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, or <paramref name="inboundNatRuleName"/> is null. </exception>
        public Response<InboundNatRule> Get(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, loadBalancerName, inboundNatRuleName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRule value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InboundNatRule.DeserializeInboundNatRule(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, InboundNatRule inboundNatRuleParameters)
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
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/inboundNatRules/", false);
            uri.AppendPath(inboundNatRuleName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(inboundNatRuleParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, <paramref name="inboundNatRuleName"/>, or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, InboundNatRule inboundNatRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, loadBalancerName, inboundNatRuleName, inboundNatRuleParameters);
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

        /// <summary> Creates or updates a load balancer inbound nat rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="inboundNatRuleName"> The name of the inbound nat rule. </param>
        /// <param name="inboundNatRuleParameters"> Parameters supplied to the create or update inbound nat rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, <paramref name="inboundNatRuleName"/>, or <paramref name="inboundNatRuleParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string loadBalancerName, string inboundNatRuleName, InboundNatRule inboundNatRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }
            if (inboundNatRuleName == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleName));
            }
            if (inboundNatRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(inboundNatRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, loadBalancerName, inboundNatRuleName, inboundNatRuleParameters);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string loadBalancerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="loadBalancerName"/> is null. </exception>
        public async Task<Response<InboundNatRuleListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = InboundNatRuleListResult.DeserializeInboundNatRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the inbound nat rules in a load balancer. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="loadBalancerName"/> is null. </exception>
        public Response<InboundNatRuleListResult> ListNextPage(string nextLink, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (loadBalancerName == null)
            {
                throw new ArgumentNullException(nameof(loadBalancerName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        InboundNatRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = InboundNatRuleListResult.DeserializeInboundNatRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
