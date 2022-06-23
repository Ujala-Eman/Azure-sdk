// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Crops service client. </summary>
    public partial class CropsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of CropsClient for mocking. </summary>
        protected CropsClient()
        {
        }

        /// <summary> Initializes a new instance of CropsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CropsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new FarmBeatsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of CropsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public CropsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetCropAsync(string cropId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.GetCrop");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCropRequest(cropId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specified crop resource. </summary>
        /// <param name="cropId"> ID of the crop. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetCrop(string cropId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.GetCrop");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCropRequest(cropId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateAsync(string cropId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(cropId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a crop resource. </summary>
        /// <param name="cropId"> ID of the crop resource. </param>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Crop</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdate(string cropId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(cropId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> DeleteAsync(string cropId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(cropId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes Crop for given crop id. </summary>
        /// <param name="cropId"> ID of crop to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cropId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cropId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response Delete(string cropId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(cropId, nameof(cropId));

            using var scope = ClientDiagnostics.CreateScope("CropsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(cropId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>CropListResponseValue</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetCropsAsync(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            return GetCropsImplementationAsync("CropsClient.GetCrops", phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
        }

        private AsyncPageable<BinaryData> GetCropsImplementationAsync(string diagnosticsScopeName, IEnumerable<string> phenotypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetCropsRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetCropsNextPageRequest(nextLink, phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Returns a paginated list of crop resources. </summary>
        /// <param name="phenotypes"> Crop phenotypes of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>CropListResponseValue</c>:
        /// <code>{
        ///   phenotype: string, # Optional. Crop phenotype.
        ///   id: string, # Optional. Unique resource ID.
        ///   eTag: string, # Optional. The ETag value to implement optimistic concurrency.
        ///   status: string, # Optional. Status of the resource.
        ///   createdDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was created, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   modifiedDateTime: string (ISO 8601 Format), # Optional. Date-time when resource was last modified, sample format: yyyy-MM-ddTHH:mm:ssZ.
        ///   name: string, # Optional. Name to identify resource.
        ///   description: string, # Optional. Textual description of the resource.
        ///   properties: Dictionary&lt;string, AnyObject&gt;, # Optional. A collection of key value pairs that belongs to the resource.
        /// Each pair must not have a key greater than 50 characters
        /// and must not have a value greater than 150 characters.
        /// Note: A maximum of 25 key value pairs can be provided for a resource and only string and numeral values are supported.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetCrops(IEnumerable<string> phenotypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestContext context = null)
        {
            return GetCropsImplementation("CropsClient.GetCrops", phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
        }

        private Pageable<BinaryData> GetCropsImplementation(string diagnosticsScopeName, IEnumerable<string> phenotypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetCropsRequest(phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context)
                        : CreateGetCropsNextPageRequest(nextLink, phenotypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetCropsRequest(IEnumerable<string> phenotypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crops", false);
            if (phenotypes != null)
            {
                foreach (var param in phenotypes)
                {
                    uri.AppendQuery("phenotypes", param, true);
                }
            }
            if (ids != null)
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null)
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null)
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null)
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetCropRequest(string cropId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string cropId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string cropId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/crops/", false);
            uri.AppendPath(cropId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetCropsNextPageRequest(string nextLink, IEnumerable<string> phenotypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
