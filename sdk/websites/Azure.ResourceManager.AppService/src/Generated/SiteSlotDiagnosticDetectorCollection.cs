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
    /// <summary> A class representing collection of DetectorDefinitionAutoGenerated and their operations over its parent. </summary>
    public partial class SiteSlotDiagnosticDetectorCollection : ArmCollection, IEnumerable<SiteSlotDiagnosticDetector>, IAsyncEnumerable<SiteSlotDiagnosticDetector>
    {
        private readonly ClientDiagnostics _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteSlotDiagnosticDetectorDiagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticDetectorCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticDetectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotDiagnosticDetectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotDiagnosticDetector.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteSlotDiagnosticDetector.ResourceType, out string siteSlotDiagnosticDetectorDiagnosticsApiVersion);
            _siteSlotDiagnosticDetectorDiagnosticsRestClient = new DiagnosticsRestOperations(_siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotDiagnosticDetectorDiagnosticsApiVersion);
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
        /// Description for Get Detector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticDetector>> GetAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDiagnosticDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticDetector> Get(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Detectors
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnosticDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnosticDetector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDiagnosticDetector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.ListSiteDetectorsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDiagnosticDetector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.ListSiteDetectorsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get Detectors
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors
        /// Operation Id: Diagnostics_ListSiteDetectorsSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnosticDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnosticDetector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDiagnosticDetector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.ListSiteDetectorsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDiagnosticDetector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.ListSiteDetectorsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnosticDetector(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(detectorName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnosticDetector>> GetIfExistsAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnosticDetector>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetectorSlot
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteSlotDiagnosticDetector> GetIfExists(string detectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(detectorName, nameof(detectorName));

            using var scope = _siteSlotDiagnosticDetectorDiagnosticsClientDiagnostics.CreateScope("SiteSlotDiagnosticDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotDiagnosticDetectorDiagnosticsRestClient.GetSiteDetectorSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, detectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotDiagnosticDetector>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnosticDetector(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteSlotDiagnosticDetector> IEnumerable<SiteSlotDiagnosticDetector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnosticDetector> IAsyncEnumerable<SiteSlotDiagnosticDetector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
