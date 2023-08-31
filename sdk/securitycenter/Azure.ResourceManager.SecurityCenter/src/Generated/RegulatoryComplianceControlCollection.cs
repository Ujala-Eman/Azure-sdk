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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="RegulatoryComplianceControlResource" /> and their operations.
    /// Each <see cref="RegulatoryComplianceControlResource" /> in the collection will belong to the same instance of <see cref="RegulatoryComplianceStandardResource" />.
    /// To get a <see cref="RegulatoryComplianceControlCollection" /> instance call the GetRegulatoryComplianceControls method from an instance of <see cref="RegulatoryComplianceStandardResource" />.
    /// </summary>
    public partial class RegulatoryComplianceControlCollection : ArmCollection, IEnumerable<RegulatoryComplianceControlResource>, IAsyncEnumerable<RegulatoryComplianceControlResource>
    {
        private readonly ClientDiagnostics _regulatoryComplianceControlClientDiagnostics;
        private readonly RegulatoryComplianceControlsRestOperations _regulatoryComplianceControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceControlCollection"/> class for mocking. </summary>
        protected RegulatoryComplianceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RegulatoryComplianceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RegulatoryComplianceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _regulatoryComplianceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", RegulatoryComplianceControlResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RegulatoryComplianceControlResource.ResourceType, out string regulatoryComplianceControlApiVersion);
            _regulatoryComplianceControlRestClient = new RegulatoryComplianceControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, regulatoryComplianceControlApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RegulatoryComplianceStandardResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RegulatoryComplianceStandardResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        public virtual async Task<Response<RegulatoryComplianceControlResource>> GetAsync(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceControlName, nameof(regulatoryComplianceControlName));

            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceControlRestClient.GetAsync(Id.SubscriptionId, Id.Name, regulatoryComplianceControlName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Selected regulatory compliance control details and state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        public virtual Response<RegulatoryComplianceControlResource> Get(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceControlName, nameof(regulatoryComplianceControlName));

            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceControlRestClient.Get(Id.SubscriptionId, Id.Name, regulatoryComplianceControlName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RegulatoryComplianceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// All supported regulatory compliance controls details and state for selected standard
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegulatoryComplianceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RegulatoryComplianceControlResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regulatoryComplianceControlRestClient.CreateListRequest(Id.SubscriptionId, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regulatoryComplianceControlRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RegulatoryComplianceControlResource(Client, RegulatoryComplianceControlData.DeserializeRegulatoryComplianceControlData(e)), _regulatoryComplianceControlClientDiagnostics, Pipeline, "RegulatoryComplianceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// All supported regulatory compliance controls details and state for selected standard
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegulatoryComplianceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RegulatoryComplianceControlResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _regulatoryComplianceControlRestClient.CreateListRequest(Id.SubscriptionId, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _regulatoryComplianceControlRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RegulatoryComplianceControlResource(Client, RegulatoryComplianceControlData.DeserializeRegulatoryComplianceControlData(e)), _regulatoryComplianceControlClientDiagnostics, Pipeline, "RegulatoryComplianceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceControlName, nameof(regulatoryComplianceControlName));

            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await _regulatoryComplianceControlRestClient.GetAsync(Id.SubscriptionId, Id.Name, regulatoryComplianceControlName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/regulatoryComplianceStandards/{regulatoryComplianceStandardName}/regulatoryComplianceControls/{regulatoryComplianceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegulatoryComplianceControls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="regulatoryComplianceControlName"> Name of the regulatory compliance control object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="regulatoryComplianceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="regulatoryComplianceControlName"/> is null. </exception>
        public virtual Response<bool> Exists(string regulatoryComplianceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(regulatoryComplianceControlName, nameof(regulatoryComplianceControlName));

            using var scope = _regulatoryComplianceControlClientDiagnostics.CreateScope("RegulatoryComplianceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = _regulatoryComplianceControlRestClient.Get(Id.SubscriptionId, Id.Name, regulatoryComplianceControlName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RegulatoryComplianceControlResource> IEnumerable<RegulatoryComplianceControlResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RegulatoryComplianceControlResource> IAsyncEnumerable<RegulatoryComplianceControlResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
