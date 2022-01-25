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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of CdnEndpoint and their operations over its parent. </summary>
    public partial class CdnEndpointCollection : ArmCollection, IEnumerable<CdnEndpoint>, IAsyncEnumerable<CdnEndpoint>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CdnEndpointsRestOperations _cdnEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnEndpointCollection"/> class for mocking. </summary>
        protected CdnEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnEndpointCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CdnEndpointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CdnEndpoint.ResourceType, out string apiVersion);
            _cdnEndpointsRestClient = new CdnEndpointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="endpointInput"> Endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="endpointInput"/> is null. </exception>
        public virtual CdnEndpointCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string endpointName, CdnEndpointData endpointInput, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            if (endpointInput == null)
            {
                throw new ArgumentNullException(nameof(endpointInput));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnEndpointsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput, cancellationToken);
                var operation = new CdnEndpointCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput).Request, response);
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

        /// <summary> Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="endpointInput"> Endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="endpointInput"/> is null. </exception>
        public async virtual Task<CdnEndpointCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string endpointName, CdnEndpointData endpointInput, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            if (endpointInput == null)
            {
                throw new ArgumentNullException(nameof(endpointInput));
            }

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnEndpointsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput, cancellationToken).ConfigureAwait(false);
                var operation = new CdnEndpointCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _cdnEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput).Request, response);
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

        /// <summary> Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<CdnEndpoint> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<CdnEndpoint>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CdnEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<CdnEndpoint> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CdnEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new CdnEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<CdnEndpoint>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CdnEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new CdnEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists existing CDN endpoints. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnEndpoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CdnEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnEndpointsRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cdnEndpointsRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing CDN endpoints. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnEndpoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnEndpointsRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CdnEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cdnEndpointsRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CdnEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CdnEndpoint> IEnumerable<CdnEndpoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnEndpoint> IAsyncEnumerable<CdnEndpoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CdnEndpoint, CdnEndpointData> Construct() { }
    }
}
