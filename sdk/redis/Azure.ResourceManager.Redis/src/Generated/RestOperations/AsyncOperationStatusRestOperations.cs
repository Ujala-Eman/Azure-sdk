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
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    internal partial class AsyncOperationStatusRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AsyncOperationStatusRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AsyncOperationStatusRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, AzureLocation location, string operationId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Cache/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/asyncOperations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation location, string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Cache/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/asyncOperations/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> For checking the ongoing status of an operation. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RedisOperationStatus>> GetAsync(string subscriptionId, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (operationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(operationId));
            }

            using var message = CreateGetRequest(subscriptionId, location, operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisOperationStatus value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RedisOperationStatus.DeserializeRedisOperationStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> For checking the ongoing status of an operation. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RedisOperationStatus> Get(string subscriptionId, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (operationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(operationId));
            }

            using var message = CreateGetRequest(subscriptionId, location, operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RedisOperationStatus value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RedisOperationStatus.DeserializeRedisOperationStatus(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
