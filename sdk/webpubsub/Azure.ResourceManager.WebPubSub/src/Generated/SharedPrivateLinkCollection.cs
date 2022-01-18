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
    /// <summary> A class representing collection of SharedPrivateLink and their operations over its parent. </summary>
    public partial class SharedPrivateLinkCollection : ArmCollection, IEnumerable<SharedPrivateLink>, IAsyncEnumerable<SharedPrivateLink>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SharedPrivateLinksRestOperations _sharedPrivateLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkCollection"/> class for mocking. </summary>
        protected SharedPrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SharedPrivateLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SharedPrivateLink.ResourceType, out string apiVersion);
            _sharedPrivateLinksRestClient = new SharedPrivateLinksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Create or update a shared private link resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="parameters"> The shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual SharedPrivateLinkCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string sharedPrivateLinkName, SharedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters, cancellationToken);
                var operation = new SharedPrivateLinkCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _sharedPrivateLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters).Request, response);
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

        /// <summary> Create or update a shared private link resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="parameters"> The shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SharedPrivateLinkCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string sharedPrivateLinkName, SharedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SharedPrivateLinkCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _sharedPrivateLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, parameters).Request, response);
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

        /// <summary> Get the specified shared private link resource. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public virtual Response<SharedPrivateLink> Get(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified shared private link resource. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public async virtual Task<Response<SharedPrivateLink>> GetAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SharedPrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public virtual Response<SharedPrivateLink> GetIfExists(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SharedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public async virtual Task<Response<SharedPrivateLink>> GetIfExistsAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SharedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sharedPrivateLinkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sharedPrivateLinkName"> The name of the shared private link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string sharedPrivateLinkName, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(sharedPrivateLinkName))
            {
                throw new ArgumentException($"Parameter {nameof(sharedPrivateLinkName)} cannot be null or empty", nameof(sharedPrivateLinkName));
            }

            using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sharedPrivateLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List shared private link resources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedPrivateLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SharedPrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinksRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedPrivateLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinksRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List shared private link resources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedPrivateLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedPrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinksRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedPrivateLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SharedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinksRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLink(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SharedPrivateLink> IEnumerable<SharedPrivateLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedPrivateLink> IAsyncEnumerable<SharedPrivateLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SharedPrivateLink, SharedPrivateLinkData> Construct() { }
    }
}
