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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of ProximityPlacementGroup and their operations over its parent. </summary>
    public partial class ProximityPlacementGroupCollection : ArmCollection, IEnumerable<ProximityPlacementGroup>, IAsyncEnumerable<ProximityPlacementGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ProximityPlacementGroupsRestOperations _proximityPlacementGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProximityPlacementGroupCollection"/> class for mocking. </summary>
        protected ProximityPlacementGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProximityPlacementGroupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ProximityPlacementGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ProximityPlacementGroup.ResourceType, out string apiVersion);
            _proximityPlacementGroupsRestClient = new ProximityPlacementGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Create or update a proximity placement group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Proximity Placement Group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ProximityPlacementGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string proximityPlacementGroupName, ProximityPlacementGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _proximityPlacementGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, parameters, cancellationToken);
                var operation = new ProximityPlacementGroupCreateOrUpdateOperation(this, response);
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

        /// <summary> Create or update a proximity placement group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Proximity Placement Group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ProximityPlacementGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string proximityPlacementGroupName, ProximityPlacementGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _proximityPlacementGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ProximityPlacementGroupCreateOrUpdateOperation(this, response);
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

        /// <summary> Retrieves information about a proximity placement group . </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public virtual Response<ProximityPlacementGroup> Get(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _proximityPlacementGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a proximity placement group . </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<ProximityPlacementGroup>> GetAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _proximityPlacementGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public virtual Response<ProximityPlacementGroup> GetIfExists(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _proximityPlacementGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ProximityPlacementGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<ProximityPlacementGroup>> GetIfExistsAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _proximityPlacementGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ProximityPlacementGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proximityPlacementGroupName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(proximityPlacementGroupName))
            {
                throw new ArgumentException($"Parameter {nameof(proximityPlacementGroupName)} cannot be null or empty", nameof(proximityPlacementGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all proximity placement groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProximityPlacementGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProximityPlacementGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ProximityPlacementGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _proximityPlacementGroupsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProximityPlacementGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _proximityPlacementGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all proximity placement groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProximityPlacementGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProximityPlacementGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProximityPlacementGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _proximityPlacementGroupsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProximityPlacementGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _proximityPlacementGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ProximityPlacementGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ProximityPlacementGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ProximityPlacementGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ProximityPlacementGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProximityPlacementGroup> IEnumerable<ProximityPlacementGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProximityPlacementGroup> IAsyncEnumerable<ProximityPlacementGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ProximityPlacementGroup, ProximityPlacementGroupData> Construct() { }
    }
}
