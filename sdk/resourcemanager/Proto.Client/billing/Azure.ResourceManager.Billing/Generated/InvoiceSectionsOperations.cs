// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary> The InvoiceSections service client. </summary>
    public partial class InvoiceSectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InvoiceSectionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of InvoiceSectionsOperations for mocking. </summary>
        protected InvoiceSectionsOperations()
        {
        }

        /// <summary> Initializes a new instance of InvoiceSectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal InvoiceSectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new InvoiceSectionsRestOperations(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets an invoice section by its ID. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="invoiceSectionName"> The ID that uniquely identifies an invoice section. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<InvoiceSection>> GetAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(billingAccountName, billingProfileName, invoiceSectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an invoice section by its ID. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="invoiceSectionName"> The ID that uniquely identifies an invoice section. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<InvoiceSection> Get(string billingAccountName, string billingProfileName, string invoiceSectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(billingAccountName, billingProfileName, invoiceSectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the invoice sections that a user has access to. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="billingProfileName"/> is null. </exception>
        public virtual AsyncPageable<InvoiceSection> ListByBillingProfileAsync(string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }

            async Task<Page<InvoiceSection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingProfileAsync(billingAccountName, billingProfileName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InvoiceSection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByBillingProfileNextPageAsync(nextLink, billingAccountName, billingProfileName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the invoice sections that a user has access to. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="billingProfileName"/> is null. </exception>
        public virtual Pageable<InvoiceSection> ListByBillingProfile(string billingAccountName, string billingProfileName, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }

            Page<InvoiceSection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingProfile(billingAccountName, billingProfileName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InvoiceSection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.ListByBillingProfile");
                scope.Start();
                try
                {
                    var response = RestClient.ListByBillingProfileNextPage(nextLink, billingAccountName, billingProfileName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates an invoice section. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="invoiceSectionName"> The ID that uniquely identifies an invoice section. </param>
        /// <param name="parameters"> The new or updated invoice section. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/>, <paramref name="invoiceSectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<InvoiceSectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }
            if (invoiceSectionName == null)
            {
                throw new ArgumentNullException(nameof(invoiceSectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(billingAccountName, billingProfileName, invoiceSectionName, parameters, cancellationToken).ConfigureAwait(false);
                return new InvoiceSectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(billingAccountName, billingProfileName, invoiceSectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an invoice section. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="invoiceSectionName"> The ID that uniquely identifies an invoice section. </param>
        /// <param name="parameters"> The new or updated invoice section. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/>, <paramref name="billingProfileName"/>, <paramref name="invoiceSectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual InvoiceSectionsCreateOrUpdateOperation StartCreateOrUpdate(string billingAccountName, string billingProfileName, string invoiceSectionName, InvoiceSection parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (billingProfileName == null)
            {
                throw new ArgumentNullException(nameof(billingProfileName));
            }
            if (invoiceSectionName == null)
            {
                throw new ArgumentNullException(nameof(invoiceSectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InvoiceSectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(billingAccountName, billingProfileName, invoiceSectionName, parameters, cancellationToken);
                return new InvoiceSectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(billingAccountName, billingProfileName, invoiceSectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
