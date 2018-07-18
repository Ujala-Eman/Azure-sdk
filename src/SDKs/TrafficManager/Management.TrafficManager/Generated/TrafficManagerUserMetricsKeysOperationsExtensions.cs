// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.TrafficManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TrafficManagerUserMetricsKeysOperations.
    /// </summary>
    public static partial class TrafficManagerUserMetricsKeysOperationsExtensions
    {
            /// <summary>
            /// Get the subscription-level key used for Real User Metrics collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UserMetricsModel Get(this ITrafficManagerUserMetricsKeysOperations operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the subscription-level key used for Real User Metrics collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserMetricsModel> GetAsync(this ITrafficManagerUserMetricsKeysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a subscription-level key used for Real User Metrics
            /// collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UserMetricsModel CreateOrUpdate(this ITrafficManagerUserMetricsKeysOperations operations)
            {
                return operations.CreateOrUpdateAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a subscription-level key used for Real User Metrics
            /// collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserMetricsModel> CreateOrUpdateAsync(this ITrafficManagerUserMetricsKeysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a subscription-level key used for Real User Metrics collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DeleteOperationResult Delete(this ITrafficManagerUserMetricsKeysOperations operations)
            {
                return operations.DeleteAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a subscription-level key used for Real User Metrics collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteOperationResult> DeleteAsync(this ITrafficManagerUserMetricsKeysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
