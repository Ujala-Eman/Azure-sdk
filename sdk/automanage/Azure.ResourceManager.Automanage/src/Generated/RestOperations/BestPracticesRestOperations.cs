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
using Azure.ResourceManager.Automanage.Models;

namespace Azure.ResourceManager.Automanage
{
    internal partial class BestPracticesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BestPracticesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BestPracticesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-05-04";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string bestPracticeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Automanage/bestPractices/", false);
            uri.AppendPath(bestPracticeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get information about a Automanage best practice. </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BestPracticeData>> GetAsync(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var message = CreateGetRequest(bestPracticeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BestPracticeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BestPracticeData.DeserializeBestPracticeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BestPracticeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get information about a Automanage best practice. </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BestPracticeData> Get(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var message = CreateGetRequest(bestPracticeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BestPracticeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BestPracticeData.DeserializeBestPracticeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BestPracticeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByTenantRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Automanage/bestPractices", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of Automanage best practices. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<BestPracticeList>> ListByTenantAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListByTenantRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BestPracticeList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BestPracticeList.DeserializeBestPracticeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of Automanage best practices. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<BestPracticeList> ListByTenant(CancellationToken cancellationToken = default)
        {
            using var message = CreateListByTenantRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BestPracticeList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BestPracticeList.DeserializeBestPracticeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
