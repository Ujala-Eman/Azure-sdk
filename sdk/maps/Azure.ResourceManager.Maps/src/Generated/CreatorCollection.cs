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

namespace Azure.ResourceManager.Maps
{
    /// <summary>
    /// A class representing a collection of <see cref="CreatorResource" /> and their operations.
    /// Each <see cref="CreatorResource" /> in the collection will belong to the same instance of <see cref="MapsAccountResource" />.
    /// To get a <see cref="CreatorCollection" /> instance call the GetCreators method from an instance of <see cref="MapsAccountResource" />.
    /// </summary>
    public partial class CreatorCollection : ArmCollection, IEnumerable<CreatorResource>, IAsyncEnumerable<CreatorResource>
    {
        private readonly ClientDiagnostics _creatorClientDiagnostics;
        private readonly CreatorsRestOperations _creatorRestClient;

        /// <summary> Initializes a new instance of the <see cref="CreatorCollection"/> class for mocking. </summary>
        protected CreatorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CreatorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CreatorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _creatorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Maps", CreatorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CreatorResource.ResourceType, out string creatorApiVersion);
            _creatorRestClient = new CreatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, creatorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MapsAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MapsAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Maps Creator resource. Creator resource will manage Azure resources required to populate a custom set of mapping data. It requires an account to exist before it can be created.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="data"> The new or updated parameters for the Creator resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CreatorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string creatorName, CreatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _creatorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MapsArmOperation<CreatorResource>(Response.FromValue(new CreatorResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Maps Creator resource. Creator resource will manage Azure resources required to populate a custom set of mapping data. It requires an account to exist before it can be created.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="data"> The new or updated parameters for the Creator resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CreatorResource> CreateOrUpdate(WaitUntil waitUntil, string creatorName, CreatorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _creatorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, data, cancellationToken);
                var operation = new MapsArmOperation<CreatorResource>(Response.FromValue(new CreatorResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Maps Creator resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_Get
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual async Task<Response<CreatorResource>> GetAsync(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.Get");
            scope.Start();
            try
            {
                var response = await _creatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CreatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Maps Creator resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_Get
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual Response<CreatorResource> Get(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.Get");
            scope.Start();
            try
            {
                var response = _creatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CreatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Creator instances for an Azure Maps Account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators
        /// Operation Id: Creators_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CreatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CreatorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CreatorResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _creatorRestClient.ListByAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CreatorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CreatorResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _creatorRestClient.ListByAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CreatorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get all Creator instances for an Azure Maps Account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators
        /// Operation Id: Creators_ListByAccount
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CreatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CreatorResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CreatorResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _creatorRestClient.ListByAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CreatorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CreatorResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _creatorRestClient.ListByAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CreatorResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_Get
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _creatorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Maps/accounts/{accountName}/creators/{creatorName}
        /// Operation Id: Creators_Get
        /// </summary>
        /// <param name="creatorName"> The name of the Maps Creator instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="creatorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="creatorName"/> is null. </exception>
        public virtual Response<bool> Exists(string creatorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(creatorName, nameof(creatorName));

            using var scope = _creatorClientDiagnostics.CreateScope("CreatorCollection.Exists");
            scope.Start();
            try
            {
                var response = _creatorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, creatorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CreatorResource> IEnumerable<CreatorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CreatorResource> IAsyncEnumerable<CreatorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
