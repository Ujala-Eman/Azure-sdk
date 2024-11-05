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
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    internal partial class VirtualMachinesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VirtualMachinesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualMachinesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List VirtualMachine resources by Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualMachinesList>> ListAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VirtualMachine resources by Cluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualMachinesList> List(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId)
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
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a VirtualMachine. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="virtualMachineId"> ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AvsPrivateCloudClusterVirtualMachineData>> GetAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName, virtualMachineId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsPrivateCloudClusterVirtualMachineData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AvsPrivateCloudClusterVirtualMachineData.DeserializeAvsPrivateCloudClusterVirtualMachineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AvsPrivateCloudClusterVirtualMachineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a VirtualMachine. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="virtualMachineId"> ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AvsPrivateCloudClusterVirtualMachineData> Get(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName, virtualMachineId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AvsPrivateCloudClusterVirtualMachineData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AvsPrivateCloudClusterVirtualMachineData.DeserializeAvsPrivateCloudClusterVirtualMachineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AvsPrivateCloudClusterVirtualMachineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateRestrictMovementRequestUri(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendPath("/restrictMovement", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateRestrictMovementRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(virtualMachineId, true);
            uri.AppendPath("/restrictMovement", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(restrictMovement, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Enable or disable DRS-driven VM movement restriction. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="virtualMachineId"> ID of the virtual machine. </param>
        /// <param name="restrictMovement"> The body type of the operation request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, <paramref name="virtualMachineId"/> or <paramref name="restrictMovement"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> RestrictMovementAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));
            Argument.AssertNotNull(restrictMovement, nameof(restrictMovement));

            using var message = CreateRestrictMovementRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Enable or disable DRS-driven VM movement restriction. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="virtualMachineId"> ID of the virtual machine. </param>
        /// <param name="restrictMovement"> The body type of the operation request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/>, <paramref name="virtualMachineId"/> or <paramref name="restrictMovement"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="clusterName"/> or <paramref name="virtualMachineId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response RestrictMovement(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, AvsPrivateCloudClusterVirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(virtualMachineId, nameof(virtualMachineId));
            Argument.AssertNotNull(restrictMovement, nameof(restrictMovement));

            using var message = CreateRestrictMovementRequest(subscriptionId, resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName)
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

        /// <summary> List VirtualMachine resources by Cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualMachinesList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VirtualMachine resources by Cluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualMachinesList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachinesList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachinesList.DeserializeVirtualMachinesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
