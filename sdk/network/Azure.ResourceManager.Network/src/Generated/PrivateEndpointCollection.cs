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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PrivateEndpoint and their operations over its parent. </summary>
    public partial class PrivateEndpointCollection : ArmCollection, IEnumerable<PrivateEndpoint>, IAsyncEnumerable<PrivateEndpoint>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PrivateEndpointsRestOperations _privateEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointCollection"/> class for mocking. </summary>
        protected PrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateEndpointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(PrivateEndpoint.ResourceType, out string apiVersion);
            _privateEndpointsRestClient = new PrivateEndpointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates an private endpoint in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private endpoint operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PrivateEndpointCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string privateEndpointName, PrivateEndpointData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, parameters, cancellationToken);
                var operation = new PrivateEndpointCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _privateEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, parameters).Request, response);
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

        /// <summary> Creates or updates an private endpoint in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="parameters"> Parameters supplied to the create or update private endpoint operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PrivateEndpointCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string privateEndpointName, PrivateEndpointData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateEndpointCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _privateEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, parameters).Request, response);
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

        /// <summary> Gets the specified private endpoint by resource group. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<PrivateEndpoint> Get(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified private endpoint by resource group. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public async virtual Task<Response<PrivateEndpoint>> GetAsync(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<PrivateEndpoint> GetIfExists(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public async virtual Task<Response<PrivateEndpoint>> GetIfExistsAsync(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all private endpoints in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all private endpoints in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpoint(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PrivateEndpoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpoint.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PrivateEndpoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpoint.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpoint> IEnumerable<PrivateEndpoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpoint> IAsyncEnumerable<PrivateEndpoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, PrivateEndpoint, PrivateEndpointData> Construct() { }
    }
}
