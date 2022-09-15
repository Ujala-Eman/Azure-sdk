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
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private AzureReservationAPIRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Reservations", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzureReservationAPIRestOperations DefaultRestClient => _defaultRestClient ??= new AzureReservationAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ReservationQuotumResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <returns> An object representing collection of ReservationQuotumResources and their operations over a ReservationQuotumResource. </returns>
        public virtual ReservationQuotumCollection GetReservationQuota(string providerId, AzureLocation location)
        {
            return new ReservationQuotumCollection(Client, Id, providerId, location);
        }

        /// <summary> Gets a collection of QuotaRequestDetailResources in the SubscriptionResource. </summary>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <returns> An object representing collection of QuotaRequestDetailResources and their operations over a QuotaRequestDetailResource. </returns>
        public virtual QuotaRequestDetailCollection GetQuotaRequestDetails(string providerId, AzureLocation location)
        {
            return new QuotaRequestDetailCollection(Client, Id, providerId, location);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs
        /// Operation Id: GetCatalog
        /// </summary>
        /// <param name="reservedResourceType"> The type of the resource for which the skus should be provided. </param>
        /// <param name="location"> Filters the skus based on the location specified in this parameter. This can be an azure region or global. </param>
        /// <param name="publisherId"> Publisher id used to get the third party products. </param>
        /// <param name="offerId"> Offer id used to get the third party products. </param>
        /// <param name="planId"> Plan id used to get the third party products. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationCatalog" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationCatalog> GetCatalogAsync(string reservedResourceType = null, AzureLocation? location = null, string publisherId = null, string offerId = null, string planId = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ReservationCatalog>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCatalog");
                scope.Start();
                try
                {
                    var response = await DefaultRestClient.GetCatalogAsync(Id.SubscriptionId, reservedResourceType, location, publisherId, offerId, planId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the specified Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/catalogs
        /// Operation Id: GetCatalog
        /// </summary>
        /// <param name="reservedResourceType"> The type of the resource for which the skus should be provided. </param>
        /// <param name="location"> Filters the skus based on the location specified in this parameter. This can be an azure region or global. </param>
        /// <param name="publisherId"> Publisher id used to get the third party products. </param>
        /// <param name="offerId"> Offer id used to get the third party products. </param>
        /// <param name="planId"> Plan id used to get the third party products. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationCatalog" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationCatalog> GetCatalog(string reservedResourceType = null, AzureLocation? location = null, string publisherId = null, string offerId = null, string planId = null, CancellationToken cancellationToken = default)
        {
            Page<ReservationCatalog> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCatalog");
                scope.Start();
                try
                {
                    var response = DefaultRestClient.GetCatalog(Id.SubscriptionId, reservedResourceType, location, publisherId, offerId, planId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations
        /// Operation Id: GetAppliedReservationList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppliedReservationsData>> GetAppliedReservationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.GetAppliedReservationListAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get applicable `Reservation`s that are applied to this subscription or a resource group under this subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Capacity/appliedReservations
        /// Operation Id: GetAppliedReservationList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppliedReservationsData> GetAppliedReservations(CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetAppliedReservations");
            scope.Start();
            try
            {
                var response = DefaultRestClient.GetAppliedReservationList(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
