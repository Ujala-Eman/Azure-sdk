// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConfigurationsOperations.
    /// </summary>
    public static partial class ConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Configures the configuration on the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            /// <param name='parameters'>
            /// The cluster configurations.
            /// </param>
            public static void Update(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> parameters)
            {
                operations.UpdateAsync(resourceGroupName, clusterName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures the configuration on the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            /// <param name='parameters'>
            /// The cluster configurations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The configuration object for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            public static IDictionary<string, string> Get(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The configuration object for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, string>> GetAsync(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures the configuration on the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            /// <param name='parameters'>
            /// The cluster configurations.
            /// </param>
            public static void BeginUpdate(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> parameters)
            {
                operations.BeginUpdateAsync(resourceGroupName, clusterName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures the configuration on the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the cluster configuration.
            /// </param>
            /// <param name='parameters'>
            /// The cluster configurations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginUpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string clusterName, string configurationName, IDictionary<string, string> parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
