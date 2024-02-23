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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class GitHubReposRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of GitHubReposRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public GitHubReposRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/gitHubOwners/", false);
            uri.AppendPath(ownerName, true);
            uri.AppendPath("/repos", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
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
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/gitHubOwners/", false);
            uri.AppendPath(ownerName, true);
            uri.AppendPath("/repos", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a list of GitHub repositories onboarded to the connector. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GitHubRepositoryListResponse>> ListAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, securityConnectorName, ownerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubRepositoryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GitHubRepositoryListResponse.DeserializeGitHubRepositoryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of GitHub repositories onboarded to the connector. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GitHubRepositoryListResponse> List(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, securityConnectorName, ownerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubRepositoryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GitHubRepositoryListResponse.DeserializeGitHubRepositoryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, string repoName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/gitHubOwners/", false);
            uri.AppendPath(ownerName, true);
            uri.AppendPath("/repos/", false);
            uri.AppendPath(repoName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, string repoName)
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
            uri.AppendPath("/providers/Microsoft.Security/securityConnectors/", false);
            uri.AppendPath(securityConnectorName, true);
            uri.AppendPath("/devops/default/gitHubOwners/", false);
            uri.AppendPath(ownerName, true);
            uri.AppendPath("/repos/", false);
            uri.AppendPath(repoName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns a monitored GitHub repository. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="ownerName"/> or <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="ownerName"/> or <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityConnectorGitHubRepositoryData>> GetAsync(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, string repoName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, securityConnectorName, ownerName, repoName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityConnectorGitHubRepositoryData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityConnectorGitHubRepositoryData.DeserializeSecurityConnectorGitHubRepositoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityConnectorGitHubRepositoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a monitored GitHub repository. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="ownerName"/> or <paramref name="repoName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/>, <paramref name="ownerName"/> or <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityConnectorGitHubRepositoryData> Get(string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, string repoName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }
            if (repoName == null)
            {
                throw new ArgumentNullException(nameof(repoName));
            }
            if (repoName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(repoName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, securityConnectorName, ownerName, repoName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityConnectorGitHubRepositoryData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityConnectorGitHubRepositoryData.DeserializeSecurityConnectorGitHubRepositoryData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityConnectorGitHubRepositoryData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName)
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

        /// <summary> Returns a list of GitHub repositories onboarded to the connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<GitHubRepositoryListResponse>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, CancellationToken cancellationToken = default)
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
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, securityConnectorName, ownerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubRepositoryListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GitHubRepositoryListResponse.DeserializeGitHubRepositoryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns a list of GitHub repositories onboarded to the connector. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="securityConnectorName"> The security connector name. </param>
        /// <param name="ownerName"> The GitHub owner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="securityConnectorName"/> or <paramref name="ownerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<GitHubRepositoryListResponse> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string securityConnectorName, string ownerName, CancellationToken cancellationToken = default)
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
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (securityConnectorName == null)
            {
                throw new ArgumentNullException(nameof(securityConnectorName));
            }
            if (securityConnectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(securityConnectorName));
            }
            if (ownerName == null)
            {
                throw new ArgumentNullException(nameof(ownerName));
            }
            if (ownerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(ownerName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, securityConnectorName, ownerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GitHubRepositoryListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GitHubRepositoryListResponse.DeserializeGitHubRepositoryListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
