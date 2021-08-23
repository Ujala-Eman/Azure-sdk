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
    internal partial class TemplateSpecVersionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of TemplateSpecVersionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public TemplateSpecVersionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
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

        internal Core.HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersion templateSpecVersionModel)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", "2021-05-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(templateSpecVersionModel);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionModel"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/>, or <paramref name="templateSpecVersionModel"/> is null. </exception>
        public async Task<Response<TemplateSpecVersion>> CreateOrUpdateAsync(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersion templateSpecVersionModel, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersionModel == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersionModel));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, templateSpecName, templateSpecVersion, templateSpecVersionModel);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TemplateSpecVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionModel"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/>, or <paramref name="templateSpecVersionModel"/> is null. </exception>
        public Response<TemplateSpecVersion> CreateOrUpdate(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersion templateSpecVersionModel, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }
            if (templateSpecVersionModel == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersionModel));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, templateSpecName, templateSpecVersion, templateSpecVersionModel);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TemplateSpecVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateUpdateRequest(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionUpdateModel templateSpecVersionUpdateModel)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", "2021-05-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (templateSpecVersionUpdateModel != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(templateSpecVersionUpdateModel);
                request.Content = content;
            }
            return message;
        }

        /// <summary> Updates Template Spec Version tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionUpdateModel"> Template Spec Version resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public async Task<Response<TemplateSpecVersion>> UpdateAsync(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionUpdateModel templateSpecVersionUpdateModel = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, templateSpecName, templateSpecVersion, templateSpecVersionUpdateModel);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates Template Spec Version tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="templateSpecVersionUpdateModel"> Template Spec Version resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public Response<TemplateSpecVersion> Update(string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionUpdateModel templateSpecVersionUpdateModel = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateUpdateRequest(resourceGroupName, templateSpecName, templateSpecVersion, templateSpecVersionUpdateModel);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateGetRequest(string resourceGroupName, string templateSpecName, string templateSpecVersion)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", "2021-05-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public async Task<Response<TemplateSpecVersion>> GetAsync(string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateGetRequest(resourceGroupName, templateSpecName, templateSpecVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public Response<TemplateSpecVersion> Get(string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateGetRequest(resourceGroupName, templateSpecName, templateSpecVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersion.DeserializeTemplateSpecVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateDeleteRequest(string resourceGroupName, string templateSpecName, string templateSpecVersion)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", "2021-05-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a specific version from a Template Spec. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateDeleteRequest(resourceGroupName, templateSpecName, templateSpecVersion);
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

        /// <summary> Deletes a specific version from a Template Spec. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, or <paramref name="templateSpecVersion"/> is null. </exception>
        public Response Delete(string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }
            if (templateSpecVersion == null)
            {
                throw new ArgumentNullException(nameof(templateSpecVersion));
            }

            using var message = CreateDeleteRequest(resourceGroupName, templateSpecName, templateSpecVersion);
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

        internal Core.HttpMessage CreateListRequest(string resourceGroupName, string templateSpecName)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", "2021-05-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        public async Task<Response<TemplateSpecVersionsListResult>> ListAsync(string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }

            using var message = CreateListRequest(resourceGroupName, templateSpecName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        public Response<TemplateSpecVersionsListResult> List(string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }

            using var message = CreateListRequest(resourceGroupName, templateSpecName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName, string templateSpecName)
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

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="templateSpecName"/> is null. </exception>
        public async Task<Response<TemplateSpecVersionsListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, templateSpecName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="templateSpecName"/> is null. </exception>
        public Response<TemplateSpecVersionsListResult> ListNextPage(string nextLink, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (templateSpecName == null)
            {
                throw new ArgumentNullException(nameof(templateSpecName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName, templateSpecName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
