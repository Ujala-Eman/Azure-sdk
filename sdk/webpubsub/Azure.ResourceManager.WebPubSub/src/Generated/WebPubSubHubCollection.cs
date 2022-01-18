// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing collection of WebPubSubHub and their operations over its parent. </summary>
    public partial class WebPubSubHubCollection : ArmCollection, IEnumerable<WebPubSubHub>, IAsyncEnumerable<WebPubSubHub>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebPubSubHubsRestOperations _webPubSubHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebPubSubHubCollection"/> class for mocking. </summary>
        protected WebPubSubHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebPubSubHubCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WebPubSubHubCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(WebPubSubHub.ResourceType, out string apiVersion);
            _webPubSubHubsRestClient = new WebPubSubHubsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebPubSub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebPubSub.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update a hub setting. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="parameters"> The resource of WebPubSubHub and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual WebPubSubHubCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string hubName, WebPubSubHubData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webPubSubHubsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, parameters, cancellationToken);
                var operation = new WebPubSubHubCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webPubSubHubsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a hub setting. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="parameters"> The resource of WebPubSubHub and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WebPubSubHubCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string hubName, WebPubSubHubData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webPubSubHubsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubHubCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webPubSubHubsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a hub setting. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public virtual Response<WebPubSubHub> Get(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.Get");
            scope.Start();
            try
            {
                var response = _webPubSubHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebPubSubHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a hub setting. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public async virtual Task<Response<WebPubSubHub>> GetAsync(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _webPubSubHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WebPubSubHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public virtual Response<WebPubSubHub> GetIfExists(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webPubSubHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WebPubSubHub>(null, response.GetRawResponse());
                return Response.FromValue(new WebPubSubHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public async virtual Task<Response<WebPubSubHub>> GetIfExistsAsync(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webPubSubHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WebPubSubHub>(null, response.GetRawResponse());
                return Response.FromValue(new WebPubSubHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hubName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hubName"> The hub name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string hubName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(hubName))
            {
                throw new ArgumentException($"Parameter {nameof(hubName)} cannot be null or empty", nameof(hubName));
            }

            using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List hub settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebPubSubHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebPubSubHub> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WebPubSubHub> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webPubSubHubsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WebPubSubHub> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webPubSubHubsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List hub settings. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebPubSubHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebPubSubHub> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WebPubSubHub>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webPubSubHubsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WebPubSubHub>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WebPubSubHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webPubSubHubsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WebPubSubHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<WebPubSubHub> IEnumerable<WebPubSubHub>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebPubSubHub> IAsyncEnumerable<WebPubSubHub>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, WebPubSubHub, WebPubSubHubData> Construct() { }
    }
}
