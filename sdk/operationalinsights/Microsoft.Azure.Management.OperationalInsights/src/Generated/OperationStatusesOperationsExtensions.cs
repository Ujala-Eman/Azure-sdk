// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OperationStatusesOperations.
    /// </summary>
    public static partial class OperationStatusesOperationsExtensions
    {
            /// <summary>
            /// Get the status of a long running azure asynchronous operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The region name of operation.
            /// </param>
            /// <param name='asyncOperationId'>
            /// The operation Id.
            /// </param>
            public static OperationStatus Get(this IOperationStatusesOperations operations, string location, string asyncOperationId)
            {
                return operations.GetAsync(location, asyncOperationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the status of a long running azure asynchronous operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The region name of operation.
            /// </param>
            /// <param name='asyncOperationId'>
            /// The operation Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> GetAsync(this IOperationStatusesOperations operations, string location, string asyncOperationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, asyncOperationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
