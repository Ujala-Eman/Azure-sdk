// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SharesOperations.
    /// </summary>
    public static partial class SharesOperationsExtensions
    {
            /// <summary>
            /// Returns a list of storage shares.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            public static IList<Share> List(this ISharesOperations operations, string resourceGroupName, string farmId)
            {
                return operations.ListAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of storage shares.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Share>> ListAsync(this ISharesOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metrics for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            public static IPage<Metric> ListMetrics(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName)
            {
                return operations.ListMetricsAsync(resourceGroupName, farmId, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metrics for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Metric>> ListMetricsAsync(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, farmId, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metric definitions for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitions(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, farmId, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metric definitions for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsAsync(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, farmId, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            public static Share Get(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName)
            {
                return operations.GetAsync(resourceGroupName, farmId, shareName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='farmId'>
            /// Farm Id.
            /// </param>
            /// <param name='shareName'>
            /// Share name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Share> GetAsync(this ISharesOperations operations, string resourceGroupName, string farmId, string shareName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, farmId, shareName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metrics for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Metric> ListMetricsNext(this ISharesOperations operations, string nextPageLink)
            {
                return operations.ListMetricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metrics for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Metric>> ListMetricsNextAsync(this ISharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of metric definitions for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<MetricDefinition> ListMetricDefinitionsNext(this ISharesOperations operations, string nextPageLink)
            {
                return operations.ListMetricDefinitionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of metric definitions for a storage share.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<MetricDefinition>> ListMetricDefinitionsNextAsync(this ISharesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
