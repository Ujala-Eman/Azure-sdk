// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupLongTermRetentionPoliciesOperations.
    /// </summary>
    public static partial class BackupLongTermRetentionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Returns a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static BackupLongTermRetentionPolicy Get(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupLongTermRetentionPolicy> GetAsync(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database
            /// </param>
            /// <param name='parameters'>
            /// The required parameters to update a backup long term retention policy
            /// </param>
            public static BackupLongTermRetentionPolicy CreateOrUpdate(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, BackupLongTermRetentionPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database
            /// </param>
            /// <param name='parameters'>
            /// The required parameters to update a backup long term retention policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupLongTermRetentionPolicy> CreateOrUpdateAsync(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, BackupLongTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database
            /// </param>
            /// <param name='parameters'>
            /// The required parameters to update a backup long term retention policy
            /// </param>
            public static BackupLongTermRetentionPolicy BeginCreateOrUpdate(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, BackupLongTermRetentionPolicy parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a database backup long term retention policy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database
            /// </param>
            /// <param name='parameters'>
            /// The required parameters to update a backup long term retention policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BackupLongTermRetentionPolicy> BeginCreateOrUpdateAsync(this IBackupLongTermRetentionPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, BackupLongTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
