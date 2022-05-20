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
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="DataVersionBaseDataResource" /> and their operations.
    /// Each <see cref="DataVersionBaseDataResource" /> in the collection will belong to the same instance of <see cref="DataContainerDataResource" />.
    /// To get a <see cref="DataVersionBaseDataCollection" /> instance call the GetDataVersionBaseData method from an instance of <see cref="DataContainerDataResource" />.
    /// </summary>
    public partial class DataVersionBaseDataCollection : ArmCollection, IEnumerable<DataVersionBaseDataResource>, IAsyncEnumerable<DataVersionBaseDataResource>
    {
        private readonly ClientDiagnostics _dataVersionBaseDataDataVersionsClientDiagnostics;
        private readonly DataVersionsRestOperations _dataVersionBaseDataDataVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataVersionBaseDataCollection"/> class for mocking. </summary>
        protected DataVersionBaseDataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataVersionBaseDataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataVersionBaseDataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataVersionBaseDataDataVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", DataVersionBaseDataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataVersionBaseDataResource.ResourceType, out string dataVersionBaseDataDataVersionsApiVersion);
            _dataVersionBaseDataDataVersionsRestClient = new DataVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataVersionBaseDataDataVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataContainerDataResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataContainerDataResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataVersionBaseDataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, DataVersionBaseDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataVersionBaseDataDataVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<DataVersionBaseDataResource>(Response.FromValue(new DataVersionBaseDataResource(Client, response), response.GetRawResponse()));
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
        /// Create or update version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataVersionBaseDataResource> CreateOrUpdate(WaitUntil waitUntil, string version, DataVersionBaseDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataVersionBaseDataDataVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<DataVersionBaseDataResource>(Response.FromValue(new DataVersionBaseDataResource(Client, response), response.GetRawResponse()));
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
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<DataVersionBaseDataResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataVersionBaseDataDataVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataVersionBaseDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<DataVersionBaseDataResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.Get");
            scope.Start();
            try
            {
                var response = _dataVersionBaseDataDataVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataVersionBaseDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List data versions in the data container
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions
        /// Operation Id: DataVersions_List
        /// </summary>
        /// <param name="orderBy"> Please choose OrderBy value from [&apos;createdtime&apos;, &apos;modifiedtime&apos;]. </param>
        /// <param name="top">
        /// Top count of results, top count cannot be greater than the page size.
        ///                               If topCount &gt; page size, results with be default page size count will be returned
        /// </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="listViewType"> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataVersionBaseDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataVersionBaseDataResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, string tags = null, ListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DataVersionBaseDataResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataVersionBaseDataDataVersionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataVersionBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataVersionBaseDataResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataVersionBaseDataDataVersionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataVersionBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List data versions in the data container
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions
        /// Operation Id: DataVersions_List
        /// </summary>
        /// <param name="orderBy"> Please choose OrderBy value from [&apos;createdtime&apos;, &apos;modifiedtime&apos;]. </param>
        /// <param name="top">
        /// Top count of results, top count cannot be greater than the page size.
        ///                               If topCount &gt; page size, results with be default page size count will be returned
        /// </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="listViewType"> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataVersionBaseDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataVersionBaseDataResource> GetAll(string orderBy = null, int? top = null, string skip = null, string tags = null, ListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            Page<DataVersionBaseDataResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataVersionBaseDataDataVersionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataVersionBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataVersionBaseDataResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataVersionBaseDataDataVersionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, tags, listViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataVersionBaseDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataVersionBaseDataDataVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/data/{name}/versions/{version}
        /// Operation Id: DataVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _dataVersionBaseDataDataVersionsClientDiagnostics.CreateScope("DataVersionBaseDataCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataVersionBaseDataDataVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataVersionBaseDataResource> IEnumerable<DataVersionBaseDataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataVersionBaseDataResource> IAsyncEnumerable<DataVersionBaseDataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
