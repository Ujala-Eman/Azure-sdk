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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AnalysisDefinition and their operations over its parent. </summary>
    public partial class SiteSlotDiagnosticAnalysisCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticAnalysis>, IAsyncEnumerable<SiteSlotDiagnosticAnalysis>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticAnalysisDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticAnalysisCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticAnalysisCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticAnalysisCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnosticAnalysis.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteSlotDiagnosticAnalysis.ResourceType, out string siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
            _siteSlotDiagnosticAnalysisDiagnosticsRestClient = new DiagnosticsRestOperations(_siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotDiagnosticAnalysisDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotDiagnostic.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotDiagnostic.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticAnalysis>> GetAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticAnalysis> Get(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analyses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses
        /// Operation Id: Diagnostics_ListSiteAnalysesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticAnalysis" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticAnalysis> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDiagnosticAnalysis>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ListSiteAnalysesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticAnalysis(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDiagnosticAnalysis>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ListSiteAnalysesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticAnalysis(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get Site Analyses
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses
        /// Operation Id: Diagnostics_ListSiteAnalysesSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticAnalysis" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticAnalysis> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDiagnosticAnalysis> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ListSiteAnalysesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticAnalysis(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDiagnosticAnalysis> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.ListSiteAnalysesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticAnalysis(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<bool> Exists(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(analysisName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticAnalysis>> GetIfExistsAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnosticAnalysis>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysisSlot
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticAnalysis> GetIfExists(string analysisName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(analysisName, nameof(analysisName));

            using var scope = _siteSlotDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticAnalysisCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, analysisName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnosticAnalysis>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnosticAnalysis> IEnumerable<SiteSlotDiagnosticAnalysis>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticAnalysis> IAsyncEnumerable<SiteSlotDiagnosticAnalysis>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
