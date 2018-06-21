// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataLakeStoreAccountsOperations.
    /// </summary>
    public static partial class DataLakeStoreAccountsOperationsExtensions
    {
            /// <summary>
            /// Gets the first page of Data Lake Store accounts linked to the specified
            /// Data Lake Analytics account. The response includes a link to the next page,
            /// if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static IPage<DataLakeStoreAccountInformation> ListByAccount(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, ODataQuery<DataLakeStoreAccountInformation> odataQuery = default(ODataQuery<DataLakeStoreAccountInformation>), string select = default(string), bool? count = default(bool?))
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName, odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Store accounts linked to the specified
            /// Data Lake Analytics account. The response includes a link to the next page,
            /// if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccountInformation>> ListByAccountAsync(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, ODataQuery<DataLakeStoreAccountInformation> odataQuery = default(ODataQuery<DataLakeStoreAccountInformation>), string select = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to include the additional
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to add.
            /// </param>
            /// <param name='parameters'>
            /// The details of the Data Lake Store account.
            /// </param>
            public static void Add(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName, AddDataLakeStoreParameters parameters = default(AddDataLakeStoreParameters))
            {
                operations.AddAsync(resourceGroupName, accountName, dataLakeStoreAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified Data Lake Analytics account to include the additional
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to add.
            /// </param>
            /// <param name='parameters'>
            /// The details of the Data Lake Store account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddAsync(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName, AddDataLakeStoreParameters parameters = default(AddDataLakeStoreParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddWithHttpMessagesAsync(resourceGroupName, accountName, dataLakeStoreAccountName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Data Lake Store account details in the specified Data
            /// Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to retrieve
            /// </param>
            public static DataLakeStoreAccountInformation Get(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName)
            {
                return operations.GetAsync(resourceGroupName, accountName, dataLakeStoreAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake Store account details in the specified Data
            /// Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to retrieve
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccountInformation> GetAsync(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, dataLakeStoreAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the Data Lake Analytics account specified to remove the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to remove
            /// </param>
            public static void Delete(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, dataLakeStoreAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Analytics account specified to remove the specified
            /// Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account.
            /// </param>
            /// <param name='dataLakeStoreAccountName'>
            /// The name of the Data Lake Store account to remove
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataLakeStoreAccountsOperations operations, string resourceGroupName, string accountName, string dataLakeStoreAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, dataLakeStoreAccountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the first page of Data Lake Store accounts linked to the specified
            /// Data Lake Analytics account. The response includes a link to the next page,
            /// if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataLakeStoreAccountInformation> ListByAccountNext(this IDataLakeStoreAccountsOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of Data Lake Store accounts linked to the specified
            /// Data Lake Analytics account. The response includes a link to the next page,
            /// if any.
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
            public static async Task<IPage<DataLakeStoreAccountInformation>> ListByAccountNextAsync(this IDataLakeStoreAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
