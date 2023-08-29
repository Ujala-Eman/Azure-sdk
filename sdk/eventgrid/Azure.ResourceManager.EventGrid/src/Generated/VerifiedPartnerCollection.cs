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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="VerifiedPartnerResource" /> and their operations.
    /// Each <see cref="VerifiedPartnerResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="VerifiedPartnerCollection" /> instance call the GetVerifiedPartners method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class VerifiedPartnerCollection : ArmCollection, IEnumerable<VerifiedPartnerResource>, IAsyncEnumerable<VerifiedPartnerResource>
    {
        private readonly ClientDiagnostics _verifiedPartnerClientDiagnostics;
        private readonly VerifiedPartnersRestOperations _verifiedPartnerRestClient;

        /// <summary> Initializes a new instance of the <see cref="VerifiedPartnerCollection"/> class for mocking. </summary>
        protected VerifiedPartnerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VerifiedPartnerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VerifiedPartnerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _verifiedPartnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", VerifiedPartnerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VerifiedPartnerResource.ResourceType, out string verifiedPartnerApiVersion);
            _verifiedPartnerRestClient = new VerifiedPartnersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, verifiedPartnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of a verified partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        public virtual async Task<Response<VerifiedPartnerResource>> GetAsync(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(verifiedPartnerName, nameof(verifiedPartnerName));

            using var scope = _verifiedPartnerClientDiagnostics.CreateScope("VerifiedPartnerCollection.Get");
            scope.Start();
            try
            {
                var response = await _verifiedPartnerRestClient.GetAsync(verifiedPartnerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VerifiedPartnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a verified partner.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        public virtual Response<VerifiedPartnerResource> Get(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(verifiedPartnerName, nameof(verifiedPartnerName));

            using var scope = _verifiedPartnerClientDiagnostics.CreateScope("VerifiedPartnerCollection.Get");
            scope.Start();
            try
            {
                var response = _verifiedPartnerRestClient.Get(verifiedPartnerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VerifiedPartnerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all verified partners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VerifiedPartnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VerifiedPartnerResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _verifiedPartnerRestClient.CreateListRequest(filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _verifiedPartnerRestClient.CreateListNextPageRequest(nextLink, filter, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VerifiedPartnerResource(Client, VerifiedPartnerData.DeserializeVerifiedPartnerData(e)), _verifiedPartnerClientDiagnostics, Pipeline, "VerifiedPartnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all verified partners.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VerifiedPartnerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VerifiedPartnerResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _verifiedPartnerRestClient.CreateListRequest(filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _verifiedPartnerRestClient.CreateListNextPageRequest(nextLink, filter, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VerifiedPartnerResource(Client, VerifiedPartnerData.DeserializeVerifiedPartnerData(e)), _verifiedPartnerClientDiagnostics, Pipeline, "VerifiedPartnerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(verifiedPartnerName, nameof(verifiedPartnerName));

            using var scope = _verifiedPartnerClientDiagnostics.CreateScope("VerifiedPartnerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _verifiedPartnerRestClient.GetAsync(verifiedPartnerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.EventGrid/verifiedPartners/{verifiedPartnerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VerifiedPartners_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="verifiedPartnerName"> Name of the verified partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="verifiedPartnerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="verifiedPartnerName"/> is null. </exception>
        public virtual Response<bool> Exists(string verifiedPartnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(verifiedPartnerName, nameof(verifiedPartnerName));

            using var scope = _verifiedPartnerClientDiagnostics.CreateScope("VerifiedPartnerCollection.Exists");
            scope.Start();
            try
            {
                var response = _verifiedPartnerRestClient.Get(verifiedPartnerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VerifiedPartnerResource> IEnumerable<VerifiedPartnerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VerifiedPartnerResource> IAsyncEnumerable<VerifiedPartnerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
