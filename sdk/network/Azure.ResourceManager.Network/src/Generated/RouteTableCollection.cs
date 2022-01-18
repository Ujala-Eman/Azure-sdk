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
    /// <summary> A class representing collection of RouteTable and their operations over its parent. </summary>
    public partial class RouteTableCollection : ArmCollection, IEnumerable<RouteTable>, IAsyncEnumerable<RouteTable>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RouteTablesRestOperations _routeTablesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteTableCollection"/> class for mocking. </summary>
        protected RouteTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteTableCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteTableCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(RouteTable.ResourceType, out string apiVersion);
            _routeTablesRestClient = new RouteTablesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual RouteTableCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string routeTableName, RouteTableData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeTablesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters, cancellationToken);
                var operation = new RouteTableCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _routeTablesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters).Request, response);
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

        /// <summary> Create or updates a route table in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="parameters"> Parameters supplied to the create or update route table operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RouteTableCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string routeTableName, RouteTableData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeTablesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteTableCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _routeTablesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, parameters).Request, response);
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

        /// <summary> Gets the specified route table. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public virtual Response<RouteTable> Get(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = _routeTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route table. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public async virtual Task<Response<RouteTable>> GetAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RouteTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public virtual Response<RouteTable> GetIfExists(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RouteTable>(null, response.GetRawResponse());
                return Response.FromValue(new RouteTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public async virtual Task<Response<RouteTable>> GetIfExistsAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routeTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeTableName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RouteTable>(null, response.GetRawResponse());
                return Response.FromValue(new RouteTable(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeTableName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeTableName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(routeTableName))
            {
                throw new ArgumentException($"Parameter {nameof(routeTableName)} cannot be null or empty", nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeTableName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteTable> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RouteTable> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeTablesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteTable> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeTablesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all route tables in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteTable" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteTable> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteTable>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeTablesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteTable>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeTablesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteTable(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="RouteTable" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteTable.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="RouteTable" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteTableCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(RouteTable.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteTable> IEnumerable<RouteTable>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteTable> IAsyncEnumerable<RouteTable>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RouteTable, RouteTableData> Construct() { }
    }
}
