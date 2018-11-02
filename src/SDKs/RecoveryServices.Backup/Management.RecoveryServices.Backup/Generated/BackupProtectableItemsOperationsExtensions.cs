// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BackupProtectableItemsOperations.
    /// </summary>
    public static partial class BackupProtectableItemsOperationsExtensions
    {
            /// <summary>
            /// Provides a pageable list of protectable objects within your subscription
            /// according to the query filter and the
            /// pagination parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            public static IPage<WorkloadProtectableItemResource> List(this IBackupProtectableItemsOperations operations, string vaultName, string resourceGroupName, ODataQuery<BMSPOQueryObject> odataQuery = default(ODataQuery<BMSPOQueryObject>), string skipToken = default(string))
            {
                return operations.ListAsync(vaultName, resourceGroupName, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides a pageable list of protectable objects within your subscription
            /// according to the query filter and the
            /// pagination parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// skipToken Filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadProtectableItemResource>> ListAsync(this IBackupProtectableItemsOperations operations, string vaultName, string resourceGroupName, ODataQuery<BMSPOQueryObject> odataQuery = default(ODataQuery<BMSPOQueryObject>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Provides a pageable list of protectable objects within your subscription
            /// according to the query filter and the
            /// pagination parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkloadProtectableItemResource> ListNext(this IBackupProtectableItemsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides a pageable list of protectable objects within your subscription
            /// according to the query filter and the
            /// pagination parameters.
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
            public static async Task<IPage<WorkloadProtectableItemResource>> ListNextAsync(this IBackupProtectableItemsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
