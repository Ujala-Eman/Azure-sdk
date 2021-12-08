// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CodePackageOperations.
    /// </summary>
    public static partial class CodePackageOperationsExtensions
    {
            /// <summary>
            /// Gets the logs from the container.
            /// </summary>
            /// <remarks>
            /// Gets the logs for the container of the specified code package of the
            /// service replica.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='applicationResourceName'>
            /// The identity of the application.
            /// </param>
            /// <param name='serviceResourceName'>
            /// The identity of the service.
            /// </param>
            /// <param name='replicaName'>
            /// Service Fabric replica name.
            /// </param>
            /// <param name='codePackageName'>
            /// The name of code package of the service.
            /// </param>
            /// <param name='tail'>
            /// Number of lines to show from the end of the logs. Default is 100.
            /// </param>
            public static ContainerLogs GetContainerLogs(this ICodePackageOperations operations, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, string codePackageName, int? tail = default(int?))
            {
                return operations.GetContainerLogsAsync(resourceGroupName, applicationResourceName, serviceResourceName, replicaName, codePackageName, tail).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the logs from the container.
            /// </summary>
            /// <remarks>
            /// Gets the logs for the container of the specified code package of the
            /// service replica.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group name
            /// </param>
            /// <param name='applicationResourceName'>
            /// The identity of the application.
            /// </param>
            /// <param name='serviceResourceName'>
            /// The identity of the service.
            /// </param>
            /// <param name='replicaName'>
            /// Service Fabric replica name.
            /// </param>
            /// <param name='codePackageName'>
            /// The name of code package of the service.
            /// </param>
            /// <param name='tail'>
            /// Number of lines to show from the end of the logs. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerLogs> GetContainerLogsAsync(this ICodePackageOperations operations, string resourceGroupName, string applicationResourceName, string serviceResourceName, string replicaName, string codePackageName, int? tail = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetContainerLogsWithHttpMessagesAsync(resourceGroupName, applicationResourceName, serviceResourceName, replicaName, codePackageName, tail, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
