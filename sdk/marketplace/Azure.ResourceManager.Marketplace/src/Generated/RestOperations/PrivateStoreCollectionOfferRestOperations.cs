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
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    internal partial class PrivateStoreCollectionOfferRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateStoreCollectionOfferRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateStoreCollectionOfferRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a list of all private offers in the given private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OfferListResponse>> ListAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OfferListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OfferListResponse.DeserializeOfferListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of all private offers in the given private store and collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OfferListResponse> List(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OfferListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OfferListResponse.DeserializeOfferListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByContextsRequest(Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/mapOffersToContexts", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (payload != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(payload);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a list of all offers in the given collection according to the required contexts. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The CollectionOffersByAllContextsPayload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CollectionOffersByContextList>> ListByContextsAsync(Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListByContextsRequest(privateStoreId, collectionId, payload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionOffersByContextList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectionOffersByContextList.DeserializeCollectionOffersByContextList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of all offers in the given collection according to the required contexts. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The CollectionOffersByAllContextsPayload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CollectionOffersByContextList> ListByContexts(Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListByContextsRequest(privateStoreId, collectionId, payload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionOffersByContextList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectionOffersByContextList.DeserializeCollectionOffersByContextList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(Guid privateStoreId, Guid collectionId, string offerId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about a specific offer. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PrivateStoreOfferData>> GetAsync(Guid privateStoreId, Guid collectionId, string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateGetRequest(privateStoreId, collectionId, offerId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateStoreOfferData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about a specific offer. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PrivateStoreOfferData> Get(Guid privateStoreId, Guid collectionId, string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateGetRequest(privateStoreId, collectionId, offerId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateStoreOfferData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOfferData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
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

        /// <summary> Update or add an offer to a specific collection of the private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The PrivateStoreOffer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PrivateStoreOfferData>> CreateOrUpdateAsync(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(privateStoreId, collectionId, offerId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update or add an offer to a specific collection of the private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="data"> The PrivateStoreOffer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PrivateStoreOfferData> CreateOrUpdate(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(privateStoreId, collectionId, offerId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(Guid privateStoreId, Guid collectionId, string offerId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an offer from the given collection of private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(Guid privateStoreId, Guid collectionId, string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateDeleteRequest(privateStoreId, collectionId, offerId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an offer from the given collection of private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(Guid privateStoreId, Guid collectionId, string offerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateDeleteRequest(privateStoreId, collectionId, offerId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostRequest(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOperation? payload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (payload != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteStringValue(payload.Value.ToString());
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete Private store offer. This is a workaround. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> PostAsync(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreatePostRequest(privateStoreId, collectionId, offerId, payload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete Private store offer. This is a workaround. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Post(Guid privateStoreId, Guid collectionId, string offerId, PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreatePostRequest(privateStoreId, collectionId, offerId, payload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpsertOfferWithMultiContextRequest(Guid privateStoreId, Guid collectionId, string offerId, MultiContextAndPlansContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/offers/", false);
            uri.AppendPath(offerId, true);
            uri.AppendPath("/upsertOfferWithMultiContext", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (content != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content0 = new Utf8JsonRequestContent();
                content0.JsonWriter.WriteObjectValue(content);
                request.Content = content0;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Upsert an offer with multiple context details. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="content"> The MultiContextAndPlansContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PrivateStoreOfferData>> UpsertOfferWithMultiContextAsync(Guid privateStoreId, Guid collectionId, string offerId, MultiContextAndPlansContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateUpsertOfferWithMultiContextRequest(privateStoreId, collectionId, offerId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Upsert an offer with multiple context details. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="offerId"> The offer ID to update or delete. </param>
        /// <param name="content"> The MultiContextAndPlansContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="offerId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PrivateStoreOfferData> UpsertOfferWithMultiContext(Guid privateStoreId, Guid collectionId, string offerId, MultiContextAndPlansContent content = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(offerId, nameof(offerId));

            using var message = CreateUpsertOfferWithMultiContextRequest(privateStoreId, collectionId, offerId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreOfferData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreOfferData.DeserializePrivateStoreOfferData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, Guid privateStoreId, Guid collectionId)
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

        /// <summary> Get a list of all private offers in the given private store and collection. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<OfferListResponse>> ListNextPageAsync(string nextLink, Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OfferListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OfferListResponse.DeserializeOfferListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of all private offers in the given private store and collection. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<OfferListResponse> ListNextPage(string nextLink, Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OfferListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OfferListResponse.DeserializeOfferListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByContextsNextPageRequest(string nextLink, Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload)
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

        /// <summary> Get a list of all offers in the given collection according to the required contexts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The CollectionOffersByAllContextsPayload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<CollectionOffersByContextList>> ListByContextsNextPageAsync(string nextLink, Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListByContextsNextPageRequest(nextLink, privateStoreId, collectionId, payload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionOffersByContextList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectionOffersByContextList.DeserializeCollectionOffersByContextList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a list of all offers in the given collection according to the required contexts. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The CollectionOffersByAllContextsPayload to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<CollectionOffersByContextList> ListByContextsNextPage(string nextLink, Guid privateStoreId, Guid collectionId, CollectionOffersByAllContextsPayload payload = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListByContextsNextPageRequest(nextLink, privateStoreId, collectionId, payload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionOffersByContextList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectionOffersByContextList.DeserializeCollectionOffersByContextList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
