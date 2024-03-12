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
using Azure.ResourceManager.BillingBenefits.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    internal partial class SavingsPlanOrderRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SavingsPlanOrderRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SavingsPlanOrderRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string savingsPlanOrderId, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrders/", false);
            uri.AppendPath(savingsPlanOrderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a savings plan order. </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingBenefitsSavingsPlanOrderData>> GetAsync(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var message = CreateGetRequest(savingsPlanOrderId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsSavingsPlanOrderData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BillingBenefitsSavingsPlanOrderData.DeserializeBillingBenefitsSavingsPlanOrderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingBenefitsSavingsPlanOrderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a savings plan order. </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingBenefitsSavingsPlanOrderData> Get(string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var message = CreateGetRequest(savingsPlanOrderId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsSavingsPlanOrderData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BillingBenefitsSavingsPlanOrderData.DeserializeBillingBenefitsSavingsPlanOrderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingBenefitsSavingsPlanOrderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateElevateRequest(string savingsPlanOrderId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrders/", false);
            uri.AppendPath(savingsPlanOrderId, true);
            uri.AppendPath("/elevate", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Elevate as owner on savings plan order based on billing permissions. </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingBenefitsRoleAssignmentEntity>> ElevateAsync(string savingsPlanOrderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var message = CreateElevateRequest(savingsPlanOrderId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsRoleAssignmentEntity value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BillingBenefitsRoleAssignmentEntity.DeserializeBillingBenefitsRoleAssignmentEntity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Elevate as owner on savings plan order based on billing permissions. </summary>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingBenefitsRoleAssignmentEntity> Elevate(string savingsPlanOrderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savingsPlanOrderId, nameof(savingsPlanOrderId));

            using var message = CreateElevateRequest(savingsPlanOrderId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingBenefitsRoleAssignmentEntity value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BillingBenefitsRoleAssignmentEntity.DeserializeBillingBenefitsRoleAssignmentEntity(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.BillingBenefits/savingsPlanOrders", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all Savings plan orders. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SavingsPlanOrderModelList>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SavingsPlanOrderModelList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SavingsPlanOrderModelList.DeserializeSavingsPlanOrderModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all Savings plan orders. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SavingsPlanOrderModelList> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SavingsPlanOrderModelList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SavingsPlanOrderModelList.DeserializeSavingsPlanOrderModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
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

        /// <summary> List all Savings plan orders. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<SavingsPlanOrderModelList>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SavingsPlanOrderModelList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SavingsPlanOrderModelList.DeserializeSavingsPlanOrderModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all Savings plan orders. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<SavingsPlanOrderModelList> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SavingsPlanOrderModelList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SavingsPlanOrderModelList.DeserializeSavingsPlanOrderModelList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
