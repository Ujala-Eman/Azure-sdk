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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntelligencePacksOperations.
    /// </summary>
    public static partial class IntelligencePacksOperationsExtensions
    {
            /// <summary>
            /// Disables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be disabled.
            /// </param>
            public static void Disable(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
            {
                operations.DisableAsync(resourceGroupName, workspaceName, intelligencePackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be disabled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableAsync(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableWithHttpMessagesAsync(resourceGroupName, workspaceName, intelligencePackName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Enables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be enabled.
            /// </param>
            public static void Enable(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
            {
                operations.EnableAsync(resourceGroupName, workspaceName, intelligencePackName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables an intelligence pack for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='intelligencePackName'>
            /// The name of the intelligence pack to be enabled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableAsync(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableWithHttpMessagesAsync(resourceGroupName, workspaceName, intelligencePackName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the intelligence packs possible and whether they are enabled or
            /// disabled for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IList<IntelligencePack> List(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the intelligence packs possible and whether they are enabled or
            /// disabled for a given workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IntelligencePack>> ListAsync(this IIntelligencePacksOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
