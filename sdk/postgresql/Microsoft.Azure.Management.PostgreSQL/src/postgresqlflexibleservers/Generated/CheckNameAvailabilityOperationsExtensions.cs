// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CheckNameAvailabilityOperations.
    /// </summary>
    public static partial class CheckNameAvailabilityOperationsExtensions
    {
            /// <summary>
            /// Check the availability of name for resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nameAvailabilityRequest'>
            /// The required parameters for checking if resource name is available.
            /// </param>
            public static NameAvailability Execute(this ICheckNameAvailabilityOperations operations, NameAvailabilityRequest nameAvailabilityRequest)
            {
                return operations.ExecuteAsync(nameAvailabilityRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the availability of name for resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nameAvailabilityRequest'>
            /// The required parameters for checking if resource name is available.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameAvailability> ExecuteAsync(this ICheckNameAvailabilityOperations operations, NameAvailabilityRequest nameAvailabilityRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExecuteWithHttpMessagesAsync(nameAvailabilityRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
