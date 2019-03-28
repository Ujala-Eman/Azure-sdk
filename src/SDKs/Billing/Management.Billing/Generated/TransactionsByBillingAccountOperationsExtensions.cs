// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TransactionsByBillingAccountOperations.
    /// </summary>
    public static partial class TransactionsByBillingAccountOperationsExtensions
    {
            /// <summary>
            /// Lists the transactions by billingAccountName for given start and end date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by transaction kind. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            public static IPage<TransactionsSummary> List(this ITransactionsByBillingAccountOperations operations, string billingAccountName, string startDate, string endDate, string filter = default(string))
            {
                return operations.ListAsync(billingAccountName, startDate, endDate, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transactions by billingAccountName for given start and end date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by transaction kind. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TransactionsSummary>> ListAsync(this ITransactionsByBillingAccountOperations operations, string billingAccountName, string startDate, string endDate, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, startDate, endDate, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the transactions by billingAccountName for given start and end date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TransactionsSummary> ListNext(this ITransactionsByBillingAccountOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transactions by billingAccountName for given start and end date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
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
            public static async Task<IPage<TransactionsSummary>> ListNextAsync(this ITransactionsByBillingAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
