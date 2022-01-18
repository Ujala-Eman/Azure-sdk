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
    /// <summary> A class representing collection of AppServiceDetector and their operations over its parent. </summary>
    public partial class SiteDetectorCollection : ArmCollection, IEnumerable<SiteDetector>, IAsyncEnumerable<SiteDetector>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticsRestOperations _diagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDetectorCollection"/> class for mocking. </summary>
        protected SiteDetectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDetectorCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteDetectorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteDetector.ResourceType, out string apiVersion);
            _diagnosticsRestClient = new DiagnosticsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_GetSiteDetectorResponse
        /// <summary> Description for Get site detector response. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public virtual Response<SiteDetector> Get(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors/{detectorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_GetSiteDetectorResponse
        /// <summary> Description for Get site detector response. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteDetector>> GetAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public virtual Response<SiteDetector> GetIfExists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDetectorResponse(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteDetector>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public async virtual Task<Response<SiteDetector>> GetIfExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDetectorResponseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteDetector>(null, response.GetRawResponse());
                return Response.FromValue(new SiteDetector(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public virtual Response<bool> Exists(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="detectorName"> Detector Resource Name. </param>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is null or empty. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(detectorName))
            {
                throw new ArgumentException($"Parameter {nameof(detectorName)} cannot be null or empty", nameof(detectorName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(detectorName, startTime, endTime, timeGrain, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_ListSiteDetectorResponses
        /// <summary> Description for List Site Detector Responses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDetector> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteDetector> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDetectorResponses(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetector(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteDetector> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDetectorResponsesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetector(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/detectors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: Diagnostics_ListSiteDetectorResponses
        /// <summary> Description for List Site Detector Responses. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDetector" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDetector> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteDetector>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDetectorResponsesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetector(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteDetector>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteDetectorCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDetectorResponsesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteDetector(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteDetector> IEnumerable<SiteDetector>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDetector> IAsyncEnumerable<SiteDetector>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteDetector, AppServiceDetectorData> Construct() { }
    }
}
