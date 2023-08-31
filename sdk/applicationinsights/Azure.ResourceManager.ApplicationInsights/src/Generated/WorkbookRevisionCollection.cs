// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkbookRevisionResource" /> and their operations.
    /// Each <see cref="WorkbookRevisionResource" /> in the collection will belong to the same instance of <see cref="WorkbookResource" />.
    /// To get a <see cref="WorkbookRevisionCollection" /> instance call the GetWorkbookRevisions method from an instance of <see cref="WorkbookResource" />.
    /// </summary>
    public partial class WorkbookRevisionCollection : ArmCollection, IEnumerable<WorkbookRevisionResource>, IAsyncEnumerable<WorkbookRevisionResource>
    {
        private readonly ClientDiagnostics _workbookRevisionWorkbooksClientDiagnostics;
        private readonly WorkbooksRestOperations _workbookRevisionWorkbooksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkbookRevisionCollection"/> class for mocking. </summary>
        protected WorkbookRevisionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkbookRevisionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkbookRevisionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workbookRevisionWorkbooksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApplicationInsights", WorkbookRevisionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkbookRevisionResource.ResourceType, out string workbookRevisionWorkbooksApiVersion);
            _workbookRevisionWorkbooksRestClient = new WorkbooksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workbookRevisionWorkbooksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkbookResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkbookResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a single workbook revision defined by its revisionId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions/{revisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionGet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionId"> The id of the workbook's revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionId"/> is null. </exception>
        public virtual async Task<Response<WorkbookRevisionResource>> GetAsync(string revisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionId, nameof(revisionId));

            using var scope = _workbookRevisionWorkbooksClientDiagnostics.CreateScope("WorkbookRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = await _workbookRevisionWorkbooksRestClient.RevisionGetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkbookRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a single workbook revision defined by its revisionId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions/{revisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionGet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionId"> The id of the workbook's revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionId"/> is null. </exception>
        public virtual Response<WorkbookRevisionResource> Get(string revisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionId, nameof(revisionId));

            using var scope = _workbookRevisionWorkbooksClientDiagnostics.CreateScope("WorkbookRevisionCollection.Get");
            scope.Start();
            try
            {
                var response = _workbookRevisionWorkbooksRestClient.RevisionGet(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkbookRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the revisions for the workbook defined by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionsList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkbookRevisionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkbookRevisionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workbookRevisionWorkbooksRestClient.CreateRevisionsListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workbookRevisionWorkbooksRestClient.CreateRevisionsListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkbookRevisionResource(Client, WorkbookData.DeserializeWorkbookData(e)), _workbookRevisionWorkbooksClientDiagnostics, Pipeline, "WorkbookRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the revisions for the workbook defined by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionsList</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkbookRevisionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkbookRevisionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workbookRevisionWorkbooksRestClient.CreateRevisionsListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workbookRevisionWorkbooksRestClient.CreateRevisionsListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkbookRevisionResource(Client, WorkbookData.DeserializeWorkbookData(e)), _workbookRevisionWorkbooksClientDiagnostics, Pipeline, "WorkbookRevisionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions/{revisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionGet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionId"> The id of the workbook's revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string revisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionId, nameof(revisionId));

            using var scope = _workbookRevisionWorkbooksClientDiagnostics.CreateScope("WorkbookRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workbookRevisionWorkbooksRestClient.RevisionGetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}/revisions/{revisionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_RevisionGet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="revisionId"> The id of the workbook's revision. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="revisionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="revisionId"/> is null. </exception>
        public virtual Response<bool> Exists(string revisionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(revisionId, nameof(revisionId));

            using var scope = _workbookRevisionWorkbooksClientDiagnostics.CreateScope("WorkbookRevisionCollection.Exists");
            scope.Start();
            try
            {
                var response = _workbookRevisionWorkbooksRestClient.RevisionGet(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, revisionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkbookRevisionResource> IEnumerable<WorkbookRevisionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkbookRevisionResource> IAsyncEnumerable<WorkbookRevisionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
