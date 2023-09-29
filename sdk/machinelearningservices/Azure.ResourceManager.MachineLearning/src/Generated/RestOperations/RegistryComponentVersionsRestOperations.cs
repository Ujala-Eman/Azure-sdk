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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal partial class RegistryComponentVersionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RegistryComponentVersionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RegistryComponentVersionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy, int? top, string skip, string stage)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (orderBy != null)
            {
                uri.AppendQuery("$orderBy", orderBy, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip, true);
            }
            if (stage != null)
            {
                uri.AppendQuery("stage", stage, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List versions. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="stage"> Component stage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ComponentVersionResourceArmPaginatedResult>> ListAsync(string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy = null, int? top = null, string skip = null, string stage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, registryName, componentName, orderBy, top, skip, stage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComponentVersionResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ComponentVersionResourceArmPaginatedResult.DeserializeComponentVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List versions. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="stage"> Component stage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ComponentVersionResourceArmPaginatedResult> List(string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy = null, int? top = null, string skip = null, string stage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, registryName, componentName, orderBy, top, skip, stage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComponentVersionResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ComponentVersionResourceArmPaginatedResult.DeserializeComponentVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, registryName, componentName, version);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, registryName, componentName, version);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MachineLearningComponentVersionData>> GetAsync(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, registryName, componentName, version);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningComponentVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MachineLearningComponentVersionData.DeserializeMachineLearningComponentVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningComponentVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MachineLearningComponentVersionData> Get(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, registryName, componentName, version);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningComponentVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MachineLearningComponentVersionData.DeserializeMachineLearningComponentVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningComponentVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, MachineLearningComponentVersionData data)
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
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/registries/", false);
            uri.AppendPath(registryName, true);
            uri.AppendPath("/components/", false);
            uri.AppendPath(componentName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/>, <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, MachineLearningComponentVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, registryName, componentName, version, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update version. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/>, <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/>, <paramref name="componentName"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string registryName, string componentName, string version, MachineLearningComponentVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, registryName, componentName, version, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy, int? top, string skip, string stage)
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

        /// <summary> List versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="stage"> Component stage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ComponentVersionResourceArmPaginatedResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy = null, int? top = null, string skip = null, string stage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, registryName, componentName, orderBy, top, skip, stage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComponentVersionResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ComponentVersionResourceArmPaginatedResult.DeserializeComponentVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="registryName"> Name of Azure Machine Learning registry. This is case-insensitive. </param>
        /// <param name="componentName"> Container name. </param>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="stage"> Component stage. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="registryName"/> or <paramref name="componentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ComponentVersionResourceArmPaginatedResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string registryName, string componentName, string orderBy = null, int? top = null, string skip = null, string stage = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(registryName, nameof(registryName));
            Argument.AssertNotNullOrEmpty(componentName, nameof(componentName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, registryName, componentName, orderBy, top, skip, stage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ComponentVersionResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ComponentVersionResourceArmPaginatedResult.DeserializeComponentVersionResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
