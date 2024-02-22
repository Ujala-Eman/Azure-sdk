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
    internal partial class DeploymentRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DeploymentRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DeploymentRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal Core.HttpMessage CreateGetAtScopeRequest(string scope, string deploymentName, string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Resources/deployments/", false);
            uri.AppendPath(deploymentName, true);
            uri.AppendPath("/operations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a deployments operation. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="deploymentName"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArmDeploymentOperation>> GetAtScopeAsync(string scope, string deploymentName, string operationId, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (operationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(operationId));
            }

            using var message = CreateGetAtScopeRequest(scope, deploymentName, operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperation value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArmDeploymentOperation.DeserializeArmDeploymentOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a deployments operation. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="operationId"> The ID of the operation to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="deploymentName"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArmDeploymentOperation> GetAtScope(string scope, string deploymentName, string operationId, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (operationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(operationId));
            }

            using var message = CreateGetAtScopeRequest(scope, deploymentName, operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperation value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArmDeploymentOperation.DeserializeArmDeploymentOperation(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListAtScopeRequest(string scope, string deploymentName, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Resources/deployments/", false);
            uri.AppendPath(deploymentName, true);
            uri.AppendPath("/operations", false);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArmDeploymentOperationsListResult>> ListAtScopeAsync(string scope, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }

            using var message = CreateListAtScopeRequest(scope, deploymentName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArmDeploymentOperationsListResult.DeserializeArmDeploymentOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArmDeploymentOperationsListResult> ListAtScope(string scope, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }

            using var message = CreateListAtScopeRequest(scope, deploymentName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArmDeploymentOperationsListResult.DeserializeArmDeploymentOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListAtScopeNextPageRequest(string nextLink, string scope, string deploymentName, int? top)
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

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scope"/> or <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ArmDeploymentOperationsListResult>> ListAtScopeNextPageAsync(string nextLink, string scope, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }

            using var message = CreateListAtScopeNextPageRequest(nextLink, scope, deploymentName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ArmDeploymentOperationsListResult.DeserializeArmDeploymentOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all deployments operations for a deployment. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The resource scope. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="scope"/> or <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ArmDeploymentOperationsListResult> ListAtScopeNextPage(string nextLink, string scope, string deploymentName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (deploymentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(deploymentName));
            }

            using var message = CreateListAtScopeNextPageRequest(nextLink, scope, deploymentName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ArmDeploymentOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ArmDeploymentOperationsListResult.DeserializeArmDeploymentOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
