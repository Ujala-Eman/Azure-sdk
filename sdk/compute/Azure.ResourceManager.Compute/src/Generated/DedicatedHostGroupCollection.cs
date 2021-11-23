// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
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
    /// <summary> A class representing collection of DedicatedHostGroup and their operations over its parent. </summary>
    public partial class DedicatedHostGroupCollection : ArmCollection, IEnumerable<DedicatedHostGroup>, IAsyncEnumerable<DedicatedHostGroup>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DedicatedHostGroupsRestOperations _dedicatedHostGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupCollection"/> class for mocking. </summary>
        protected DedicatedHostGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DedicatedHostGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _dedicatedHostGroupsRestClient = new DedicatedHostGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DedicatedHostGroupCreateOrUpdateOperation CreateOrUpdate(string hostGroupName, DedicatedHostGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupsRestClient.CreateOrUpdate(Id.ResourceGroupName, hostGroupName, parameters, cancellationToken);
                var operation = new DedicatedHostGroupCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update a dedicated host group. For details of Dedicated Host and Dedicated Host Groups please see [Dedicated Host Documentation] (https://go.microsoft.com/fwlink/?linkid=2082596). </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host Group. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DedicatedHostGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string hostGroupName, DedicatedHostGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, hostGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DedicatedHostGroupCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Retrieves information about a dedicated host group. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<DedicatedHostGroup> Get(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupsRestClient.Get(Id.ResourceGroupName, hostGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHostGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about a dedicated host group. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHostGroup>> GetAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupsRestClient.GetAsync(Id.ResourceGroupName, hostGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHostGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<DedicatedHostGroup> GetIfExists(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dedicatedHostGroupsRestClient.Get(Id.ResourceGroupName, hostGroupName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<DedicatedHostGroup>> GetIfExistsAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _dedicatedHostGroupsRestClient.GetAsync(Id.ResourceGroupName, hostGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DedicatedHostGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostGroupName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the dedicated hosts under the dedicated host group. &apos;UserData&apos; is not supported for dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string hostGroupName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (hostGroupName == null)
            {
                throw new ArgumentNullException(nameof(hostGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the dedicated host groups in the specified resource group. Use the nextLink property in the response to get the next page of dedicated host groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHostGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHostGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedHostGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostGroupsRestClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DedicatedHostGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the dedicated host groups in the specified resource group. Use the nextLink property in the response to get the next page of dedicated host groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHostGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHostGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedHostGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostGroupsRestClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DedicatedHostGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DedicatedHostGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DedicatedHostGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DedicatedHostGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DedicatedHostGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DedicatedHostGroup> IEnumerable<DedicatedHostGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedHostGroup> IAsyncEnumerable<DedicatedHostGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, DedicatedHostGroup, DedicatedHostGroupData> Construct() { }
    }
}
