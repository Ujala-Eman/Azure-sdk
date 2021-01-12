// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisEnterprise
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatabasesOperations.
    /// </summary>
    public static partial class DatabasesOperationsExtensions
    {
            /// <summary>
            /// Gets all databases in the specified RedisEnterprise cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            public static IPage<Database> ListByCluster(this IDatabasesOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListByClusterAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all databases in the specified RedisEnterprise cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Database>> ListByClusterAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            public static Database Create(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, Database parameters)
            {
                return operations.CreateAsync(resourceGroupName, clusterName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> CreateAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, Database parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            public static Database Update(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, DatabaseUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> UpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, DatabaseUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about a database in a RedisEnterprise cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static Database GetMethod(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                return operations.GetMethodAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about a database in a RedisEnterprise cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> GetMethodAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMethodWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a single database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static void Delete(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a single database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves the access keys for the RedisEnterprise database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static AccessKeys ListKeys(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                return operations.ListKeysAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the access keys for the RedisEnterprise database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static AccessKeys RegenerateKey(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, clusterName, databaseName, keyType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeyAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, keyType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            public static void Import(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.ImportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ImportAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ImportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            public static void Export(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.ExportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExportAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            public static Database BeginCreate(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, Database parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, clusterName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> BeginCreateAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, Database parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            public static Database BeginUpdate(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, DatabaseUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update database operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Database> BeginUpdateAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, DatabaseUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a single database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static void BeginDelete(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a single database
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static AccessKeys BeginRegenerateKey(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType)
            {
                return operations.BeginRegenerateKeyAsync(resourceGroupName, clusterName, databaseName, keyType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> BeginRegenerateKeyAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRegenerateKeyWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, keyType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            public static void BeginImport(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.BeginImportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginImportAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginImportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            public static void BeginExport(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.BeginExportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginExportAsync(this IDatabasesOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginExportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all databases in the specified RedisEnterprise cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Database> ListByClusterNext(this IDatabasesOperations operations, string nextPageLink)
            {
                return operations.ListByClusterNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all databases in the specified RedisEnterprise cluster.
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
            public static async Task<IPage<Database>> ListByClusterNextAsync(this IDatabasesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
