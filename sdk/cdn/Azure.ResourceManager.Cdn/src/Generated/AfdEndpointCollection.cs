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
    /// <summary> A class representing collection of AfdEndpoint and their operations over its parent. </summary>
    public partial class AfdEndpointCollection : ArmCollection, IEnumerable<AfdEndpoint>, IAsyncEnumerable<AfdEndpoint>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdEndpointsRestOperations _afdEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdEndpointCollection"/> class for mocking. </summary>
        protected AfdEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of AfdEndpointCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdEndpointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _afdEndpointsRestClient = new AfdEndpointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
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

        /// <summary> Creates a new AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="endpointInput"> Endpoint properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="endpointInput"/> is null. </exception>
        public virtual AfdEndpointCreateOperation CreateOrUpdate(string endpointName, AfdEndpointData endpointInput, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (endpointInput == null)
            {
                throw new ArgumentNullException(nameof(endpointInput));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdEndpointsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput, cancellationToken);
                var operation = new AfdEndpointCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput).Request, response);
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

        /// <summary> Creates a new AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="endpointInput"> Endpoint properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="endpointInput"/> is null. </exception>
        public async virtual Task<AfdEndpointCreateOperation> CreateOrUpdateAsync(string endpointName, AfdEndpointData endpointInput, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (endpointInput == null)
            {
                throw new ArgumentNullException(nameof(endpointInput));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdEndpointsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput, cancellationToken).ConfigureAwait(false);
                var operation = new AfdEndpointCreateOperation(Parent, _clientDiagnostics, Pipeline, _afdEndpointsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, endpointInput).Request, response);
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

        /// <summary> Gets an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<AfdEndpoint> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _afdEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdEndpoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<AfdEndpoint>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdEndpoint(Parent, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<AfdEndpoint> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AfdEndpoint>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdEndpoint(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<AfdEndpoint>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _afdEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AfdEndpoint>(null, response.GetRawResponse())
                    : Response.FromValue(new AfdEndpoint(this, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.Exists");
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
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.ExistsAsync");
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

        /// <summary> Lists existing AzureFrontDoor endpoints. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdEndpoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdEndpointsRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdEndpointsRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists existing AzureFrontDoor endpoints. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdEndpoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdEndpointsRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdEndpointsRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdEndpoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdEndpoint> IEnumerable<AfdEndpoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdEndpoint> IAsyncEnumerable<AfdEndpoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AfdEndpoint, AfdEndpointData> Construct() { }
    }
}
