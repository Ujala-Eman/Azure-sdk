// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResponse>> CheckDeviceUpdateNameAvailabilityAsync(this Subscription subscription, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return await GetExtensionClient(subscription).CheckDeviceUpdateNameAvailabilityAsync(request, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        public static Response<CheckNameAvailabilityResponse> CheckDeviceUpdateNameAvailability(this Subscription subscription, CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(request, nameof(request));

            return GetExtensionClient(subscription).CheckDeviceUpdateNameAvailability(request, cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccount" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeviceUpdateAccount> GetDeviceUpdateAccountsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeviceUpdateAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccount" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeviceUpdateAccount> GetDeviceUpdateAccounts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetDeviceUpdateAccounts(cancellationToken);
        }
    }
}
