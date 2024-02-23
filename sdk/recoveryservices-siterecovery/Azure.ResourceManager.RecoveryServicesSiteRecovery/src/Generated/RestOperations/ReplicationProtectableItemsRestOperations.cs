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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal partial class ReplicationProtectableItemsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReplicationProtectableItemsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReplicationProtectableItemsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByReplicationProtectionContainersRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter, string take, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectableItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (take != null)
            {
                uri.AppendQuery("$take", take, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByReplicationProtectionContainersRequest(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter, string take, string skipToken)
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
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectableItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (take != null)
            {
                uri.AppendQuery("$take", take, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the protectable items in a protection container. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryProtectableItemListResult>> ListByReplicationProtectionContainersAsync(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }

            using var message = CreateListByReplicationProtectionContainersRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, filter, take, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryProtectableItemListResult.DeserializeSiteRecoveryProtectableItemListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the protectable items in a protection container. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryProtectableItemListResult> ListByReplicationProtectionContainers(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }

            using var message = CreateListByReplicationProtectionContainersRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, filter, take, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryProtectableItemListResult.DeserializeSiteRecoveryProtectableItemListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectableItems/", false);
            uri.AppendPath(protectableItemName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName)
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
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectableItems/", false);
            uri.AppendPath(protectableItemName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to get the details of a protectable item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="protectableItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryProtectableItemData>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }
            if (protectableItemName == null)
            {
                throw new ArgumentNullException(nameof(protectableItemName));
            }
            if (protectableItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectableItemName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, protectableItemName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryProtectableItemData.DeserializeSiteRecoveryProtectableItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SiteRecoveryProtectableItemData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to get the details of a protectable item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="protectableItemName"> Protectable item name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="protectableItemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="protectableItemName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryProtectableItemData> Get(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string protectableItemName, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }
            if (protectableItemName == null)
            {
                throw new ArgumentNullException(nameof(protectableItemName));
            }
            if (protectableItemName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectableItemName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, protectableItemName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryProtectableItemData.DeserializeSiteRecoveryProtectableItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SiteRecoveryProtectableItemData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByReplicationProtectionContainersNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter, string take, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByReplicationProtectionContainersNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter, string take, string skipToken)
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

        /// <summary> Lists the protectable items in a protection container. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SiteRecoveryProtectableItemListResult>> ListByReplicationProtectionContainersNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }

            using var message = CreateListByReplicationProtectionContainersNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, filter, take, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SiteRecoveryProtectableItemListResult.DeserializeSiteRecoveryProtectableItemListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the protectable items in a protection container. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="filter"> OData filter options. </param>
        /// <param name="take"> take OData query parameter. </param>
        /// <param name="skipToken"> skipToken OData query parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/> or <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SiteRecoveryProtectableItemListResult> ListByReplicationProtectionContainersNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string filter = null, string take = null, string skipToken = null, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (protectionContainerName == null)
            {
                throw new ArgumentNullException(nameof(protectionContainerName));
            }
            if (protectionContainerName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(protectionContainerName));
            }

            using var message = CreateListByReplicationProtectionContainersNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, filter, take, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SiteRecoveryProtectableItemListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SiteRecoveryProtectableItemListResult.DeserializeSiteRecoveryProtectableItemListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
