// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionsOperations.
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Get the list of subscriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IEnumerable<Subscription> List(this ISubscriptionsOperations operations, ODataQuery<Subscription> odataQuery = default(ODataQuery<Subscription>))
            {
                return operations.ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of subscriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Subscription>> ListAsync(this ISubscriptionsOperations operations, ODataQuery<Subscription> odataQuery = default(ODataQuery<Subscription>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of subscriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nameAvailabilityDefinition'>
            /// Check name availability parameter
            /// </param>
            public static CheckNameAvailabilityResponse CheckNameAvailability(this ISubscriptionsOperations operations, CheckNameAvailabilityDefinition nameAvailabilityDefinition)
            {
                return operations.CheckNameAvailabilityAsync(nameAvailabilityDefinition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of subscriptions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nameAvailabilityDefinition'>
            /// Check name availability parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResponse> CheckNameAvailabilityAsync(this ISubscriptionsOperations operations, CheckNameAvailabilityDefinition nameAvailabilityDefinition, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(nameAvailabilityDefinition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            public static Subscription Get(this ISubscriptionsOperations operations, string subscription)
            {
                return operations.GetAsync(subscription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subscription> GetAsync(this ISubscriptionsOperations operations, string subscription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(subscription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            /// <param name='newSubscription'>
            /// Subscription parameter.
            /// </param>
            public static Subscription CreateOrUpdate(this ISubscriptionsOperations operations, string subscription, Subscription newSubscription)
            {
                return operations.CreateOrUpdateAsync(subscription, newSubscription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            /// <param name='newSubscription'>
            /// Subscription parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Subscription> CreateOrUpdateAsync(this ISubscriptionsOperations operations, string subscription, Subscription newSubscription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(subscription, newSubscription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            public static void Delete(this ISubscriptionsOperations operations, string subscription)
            {
                operations.DeleteAsync(subscription).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscription'>
            /// Subscription parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISubscriptionsOperations operations, string subscription, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(subscription, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
