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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of TriggeredJobHistory and their operations over its parent. </summary>
    public partial class SiteTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<SiteTriggeredWebJobHistory>, IAsyncEnumerable<SiteTriggeredWebJobHistory>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected SiteTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredWebJobHistoryCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteTriggeredWebJobHistoryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteTriggeredWebJobHistory.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteTriggeredwebJob.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteTriggeredwebJob.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_GetTriggeredWebJobHistorySlot
        /// <summary> Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteTriggeredWebJobHistory> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_GetTriggeredWebJobHistorySlot
        /// <summary> Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<SiteTriggeredWebJobHistory>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteTriggeredWebJobHistory> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredWebJobHistory>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<SiteTriggeredWebJobHistory>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredWebJobHistory>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(id, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_ListTriggeredWebJobHistorySlot
        /// <summary> Description for List a triggered web job&apos;s history for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteTriggeredWebJobHistory" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteTriggeredWebJobHistory> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteTriggeredWebJobHistory> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistory(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteTriggeredWebJobHistory> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListTriggeredWebJobHistorySlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistory(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}
        /// OperationId: WebApps_ListTriggeredWebJobHistorySlot
        /// <summary> Description for List a triggered web job&apos;s history for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteTriggeredWebJobHistory" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteTriggeredWebJobHistory> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteTriggeredWebJobHistory>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistory(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteTriggeredWebJobHistory>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListTriggeredWebJobHistorySlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistory(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteTriggeredWebJobHistory> IEnumerable<SiteTriggeredWebJobHistory>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteTriggeredWebJobHistory> IAsyncEnumerable<SiteTriggeredWebJobHistory>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteTriggeredWebJobHistory, TriggeredJobHistoryData> Construct() { }
    }
}
