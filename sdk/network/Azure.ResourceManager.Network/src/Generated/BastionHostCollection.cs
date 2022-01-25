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
    /// <summary> A class representing collection of BastionHost and their operations over its parent. </summary>
    public partial class BastionHostCollection : ArmCollection, IEnumerable<BastionHost>, IAsyncEnumerable<BastionHost>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BastionHostsRestOperations _bastionHostsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class for mocking. </summary>
        protected BastionHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BastionHostCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BastionHostCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(BastionHost.ResourceType, out string apiVersion);
            _bastionHostsRestClient = new BastionHostsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates or updates the specified Bastion Host. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual BastionHostCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string bastionHostName, BastionHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bastionHostsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters, cancellationToken);
                var operation = new BastionHostCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _bastionHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified Bastion Host. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Bastion Host operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<BastionHostCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string bastionHostName, BastionHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bastionHostsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new BastionHostCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _bastionHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, parameters).Request, response);
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

        /// <summary> Gets the specified Bastion Host. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<BastionHost> Get(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = _bastionHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BastionHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Bastion Host. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public async virtual Task<Response<BastionHost>> GetAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _bastionHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BastionHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<BastionHost> GetIfExists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _bastionHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BastionHost>(null, response.GetRawResponse());
                return Response.FromValue(new BastionHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public async virtual Task<Response<BastionHost>> GetIfExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _bastionHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BastionHost>(null, response.GetRawResponse());
                return Response.FromValue(new BastionHost(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(bastionHostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bastionHostName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bastionHostName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string bastionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bastionHostName, nameof(bastionHostName));

            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(bastionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Bastion Hosts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BastionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BastionHost> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BastionHost> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bastionHostsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BastionHost> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bastionHostsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Bastion Hosts in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BastionHost" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BastionHost> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BastionHost>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bastionHostsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BastionHost>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bastionHostsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BastionHost(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="BastionHost" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BastionHost.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BastionHost" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BastionHostCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BastionHost.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BastionHost> IEnumerable<BastionHost>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BastionHost> IAsyncEnumerable<BastionHost>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, BastionHost, BastionHostData> Construct() { }
    }
}
