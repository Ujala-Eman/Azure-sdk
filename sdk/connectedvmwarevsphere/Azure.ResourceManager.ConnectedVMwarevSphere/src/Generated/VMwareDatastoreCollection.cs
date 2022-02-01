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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of VMwareDatastore and their operations over its parent. </summary>
    public partial class VMwareDatastoreCollection : ArmCollection, IEnumerable<VMwareDatastore>, IAsyncEnumerable<VMwareDatastore>
    {
        private readonly ClientDiagnostics _vMwareDatastoreDatastoresClientDiagnostics;
        private readonly DatastoresRestOperations _vMwareDatastoreDatastoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastoreCollection"/> class for mocking. </summary>
        protected VMwareDatastoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareDatastoreCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VMwareDatastoreCollection(ArmResource parent) : base(parent)
        {
            _vMwareDatastoreDatastoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareDatastore.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(VMwareDatastore.ResourceType, out string vMwareDatastoreDatastoresApiVersion);
            _vMwareDatastoreDatastoresRestClient = new DatastoresRestOperations(_vMwareDatastoreDatastoresClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, vMwareDatastoreDatastoresApiVersion);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_Create
        /// <summary> Create Or Update datastore. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual VMwareDatastoreCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string datastoreName, VMwareDatastoreData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, body, cancellationToken);
                var operation = new VMwareDatastoreCreateOrUpdateOperation(ArmClient, _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_Create
        /// <summary> Create Or Update datastore. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public async virtual Task<VMwareDatastoreCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string datastoreName, VMwareDatastoreData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, body, cancellationToken).ConfigureAwait(false);
                var operation = new VMwareDatastoreCreateOrUpdateOperation(ArmClient, _vMwareDatastoreDatastoresClientDiagnostics, Pipeline, _vMwareDatastoreDatastoresRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_Get
        /// <summary> Implements datastore GET method. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<VMwareDatastore> Get(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken);
                if (response.Value == null)
                    throw _vMwareDatastoreDatastoresClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareDatastore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_Get
        /// <summary> Implements datastore GET method. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public async virtual Task<Response<VMwareDatastore>> GetAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _vMwareDatastoreDatastoresClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VMwareDatastore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<VMwareDatastore> GetIfExists(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareDatastoreDatastoresRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VMwareDatastore>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareDatastore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public async virtual Task<Response<VMwareDatastore>> GetIfExistsAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareDatastoreDatastoresRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, datastoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VMwareDatastore>(null, response.GetRawResponse());
                return Response.FromValue(new VMwareDatastore(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(datastoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(datastoreName, nameof(datastoreName));

            using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(datastoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_ListByResourceGroup
        /// <summary> List of datastores in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareDatastore" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareDatastore> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VMwareDatastore> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareDatastoreDatastoresRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareDatastore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VMwareDatastore> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vMwareDatastoreDatastoresRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareDatastore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Datastores_ListByResourceGroup
        /// <summary> List of datastores in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareDatastore" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareDatastore> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VMwareDatastore>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareDatastoreDatastoresRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareDatastore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VMwareDatastore>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vMwareDatastoreDatastoresClientDiagnostics.CreateScope("VMwareDatastoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vMwareDatastoreDatastoresRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VMwareDatastore(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VMwareDatastore> IEnumerable<VMwareDatastore>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareDatastore> IAsyncEnumerable<VMwareDatastore>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
