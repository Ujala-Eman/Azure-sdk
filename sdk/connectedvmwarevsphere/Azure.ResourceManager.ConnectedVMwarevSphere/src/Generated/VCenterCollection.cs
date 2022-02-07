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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VCenter and their operations over its parent. </summary>
    public partial class VCenterCollection : ArmCollection, IEnumerable<VCenter>, IAsyncEnumerable<VCenter>
    {
        private readonly ClientDiagnostics _vCenterClientDiagnostics;
        private readonly VCentersRestOperations _vCenterRestClient;

        /// <summary> Initializes a new instance of the <see cref="VCenterCollection"/> class for mocking. </summary>
        protected VCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VCenterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VCenterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vCenterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VCenter.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VCenter.ResourceType, out string vCenterApiVersion);
            _vCenterRestClient = new VCentersRestOperations(_vCenterClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vCenterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Create
        /// <summary> Create Or Update vCenter. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<ArmOperation<VCenter>> CreateOrUpdateAsync(bool waitForCompletion, string vcenterName, VCenterData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vCenterRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VCenter>(new VCenterSource(Client), _vCenterClientDiagnostics, Pipeline, _vCenterRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Create
        /// <summary> Create Or Update vCenter. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual ArmOperation<VCenter> CreateOrUpdate(bool waitForCompletion, string vcenterName, VCenterData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vCenterRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VCenter>(new VCenterSource(Client), _vCenterClientDiagnostics, Pipeline, _vCenterRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Implements vCenter GET method. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<VCenter>> GetAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _vCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vCenterClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VCenter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Implements vCenter GET method. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<VCenter> Get(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _vCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken);
                if (response.Value == null)
                    throw _vCenterClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VCenter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_ListByResourceGroup
        /// <summary> List of vCenters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VCenter" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VCenter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VCenter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCenterRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VCenter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCenterRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_ListByResourceGroup
        /// <summary> List of vCenters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VCenter" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VCenter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VCenter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCenterRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VCenter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCenterRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vcenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vcenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public async virtual Task<Response<VCenter>> GetIfExistsAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VCenter>(null, response.GetRawResponse());
                return Response.FromValue(new VCenter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: VCenters_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<VCenter> GetIfExists(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterClientDiagnostics.CreateScope("VCenterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vcenterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VCenter>(null, response.GetRawResponse());
                return Response.FromValue(new VCenter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VCenter> IEnumerable<VCenter>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VCenter> IAsyncEnumerable<VCenter>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
