// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MarketplaceOrdering.Mocking;
using Azure.ResourceManager.MarketplaceOrdering.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MarketplaceOrdering. </summary>
    public static partial class MarketplaceOrderingExtensions
    {
        private static MarketplaceOrderingArmClientMockingExtension GetMarketplaceOrderingArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new MarketplaceOrderingArmClientMockingExtension(client);
            });
        }

        private static MarketplaceOrderingSubscriptionMockingExtension GetMarketplaceOrderingSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new MarketplaceOrderingSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="MarketplaceAgreementTermResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MarketplaceAgreementTermResource.CreateResourceIdentifier" /> to create a <see cref="MarketplaceAgreementTermResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MarketplaceAgreementTermResource" /> object. </returns>
        public static MarketplaceAgreementTermResource GetMarketplaceAgreementTermResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMarketplaceOrderingArmClientMockingExtension(client).GetMarketplaceAgreementTermResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MarketplaceAgreementResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MarketplaceAgreementResource.CreateResourceIdentifier" /> to create a <see cref="MarketplaceAgreementResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MarketplaceAgreementResource" /> object. </returns>
        public static MarketplaceAgreementResource GetMarketplaceAgreementResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMarketplaceOrderingArmClientMockingExtension(client).GetMarketplaceAgreementResource(id);
        }

        /// <summary> Gets a collection of MarketplaceAgreementTermResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MarketplaceAgreementTermResources and their operations over a MarketplaceAgreementTermResource. </returns>
        public static MarketplaceAgreementTermCollection GetMarketplaceAgreementTerms(this SubscriptionResource subscriptionResource)
        {
            return GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreementTerms();
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MarketplaceAgreementTermResource>> GetMarketplaceAgreementTermAsync(this SubscriptionResource subscriptionResource, AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return await GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreementTermAsync(offerType, publisherId, offerId, planId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MarketplaceAgreementTermResource> GetMarketplaceAgreementTerm(this SubscriptionResource subscriptionResource, AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreementTerm(offerType, publisherId, offerId, planId, cancellationToken);
        }

        /// <summary> Gets a collection of MarketplaceAgreementResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MarketplaceAgreementResources and their operations over a MarketplaceAgreementResource. </returns>
        public static MarketplaceAgreementCollection GetMarketplaceAgreements(this SubscriptionResource subscriptionResource)
        {
            return GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreements();
        }

        /// <summary>
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MarketplaceAgreementResource>> GetMarketplaceAgreementAsync(this SubscriptionResource subscriptionResource, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return await GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreementAsync(publisherId, offerId, planId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MarketplaceAgreementResource> GetMarketplaceAgreement(this SubscriptionResource subscriptionResource, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return GetMarketplaceOrderingSubscriptionMockingExtension(subscriptionResource).GetMarketplaceAgreement(publisherId, offerId, planId, cancellationToken);
        }
    }
}
