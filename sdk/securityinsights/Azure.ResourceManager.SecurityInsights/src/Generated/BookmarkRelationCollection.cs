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

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="BookmarkRelationResource" /> and their operations.
    /// Each <see cref="BookmarkRelationResource" /> in the collection will belong to the same instance of <see cref="BookmarkResource" />.
    /// To get a <see cref="BookmarkRelationCollection" /> instance call the GetBookmarkRelations method from an instance of <see cref="BookmarkResource" />.
    /// </summary>
    public partial class BookmarkRelationCollection : ArmCollection, IEnumerable<BookmarkRelationResource>, IAsyncEnumerable<BookmarkRelationResource>
    {
        private readonly ClientDiagnostics _bookmarkRelationClientDiagnostics;
        private readonly BookmarkRelationsRestOperations _bookmarkRelationRestClient;

        /// <summary> Initializes a new instance of the <see cref="BookmarkRelationCollection"/> class for mocking. </summary>
        protected BookmarkRelationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BookmarkRelationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BookmarkRelationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bookmarkRelationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", BookmarkRelationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BookmarkRelationResource.ResourceType, out string bookmarkRelationApiVersion);
            _bookmarkRelationRestClient = new BookmarkRelationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bookmarkRelationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BookmarkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BookmarkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates the bookmark relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BookmarkRelationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string relationName, RelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _bookmarkRelationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<BookmarkRelationResource>(Response.FromValue(new BookmarkRelationResource(Client, response), response.GetRawResponse()));
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
        /// Creates the bookmark relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="data"> The relation model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BookmarkRelationResource> CreateOrUpdate(WaitUntil waitUntil, string relationName, RelationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _bookmarkRelationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<BookmarkRelationResource>(Response.FromValue(new BookmarkRelationResource(Client, response), response.GetRawResponse()));
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
        /// Gets a bookmark relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<BookmarkRelationResource>> GetAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.Get");
            scope.Start();
            try
            {
                var response = await _bookmarkRelationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BookmarkRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a bookmark relation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<BookmarkRelationResource> Get(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.Get");
            scope.Start();
            try
            {
                var response = _bookmarkRelationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BookmarkRelationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all bookmark relations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations
        /// Operation Id: BookmarkRelations_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BookmarkRelationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BookmarkRelationResource> GetAllAsync(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BookmarkRelationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bookmarkRelationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BookmarkRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BookmarkRelationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _bookmarkRelationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BookmarkRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all bookmark relations.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations
        /// Operation Id: BookmarkRelations_List
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="orderby"> Sorts the results. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BookmarkRelationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BookmarkRelationResource> GetAll(string filter = null, string orderby = null, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<BookmarkRelationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bookmarkRelationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BookmarkRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BookmarkRelationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _bookmarkRelationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, orderby, top, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BookmarkRelationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _bookmarkRelationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/bookmarks/{bookmarkId}/relations/{relationName}
        /// Operation Id: BookmarkRelations_Get
        /// </summary>
        /// <param name="relationName"> Relation Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="relationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="relationName"/> is null. </exception>
        public virtual Response<bool> Exists(string relationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(relationName, nameof(relationName));

            using var scope = _bookmarkRelationClientDiagnostics.CreateScope("BookmarkRelationCollection.Exists");
            scope.Start();
            try
            {
                var response = _bookmarkRelationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, relationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BookmarkRelationResource> IEnumerable<BookmarkRelationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BookmarkRelationResource> IAsyncEnumerable<BookmarkRelationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
