// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FirewallPolicyRuleCollectionGroupsOperations.
    /// </summary>
    public static partial class FirewallPolicyRuleCollectionGroupsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            public static void Delete(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName)
            {
                operations.DeleteAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            public static FirewallPolicyRuleCollectionGroup Get(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName)
            {
                return operations.GetAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleCollectionGroup> GetAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update
            /// FirewallPolicyRuleCollectionGroup operation.
            /// </param>
            public static FirewallPolicyRuleCollectionGroup CreateOrUpdate(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update
            /// FirewallPolicyRuleCollectionGroup operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleCollectionGroup> CreateOrUpdateAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            public static IPage<FirewallPolicyRuleCollectionGroup> List(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName)
            {
                return operations.ListAsync(resourceGroupName, firewallPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallPolicyRuleCollectionGroup>> ListAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            public static void BeginDelete(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update
            /// FirewallPolicyRuleCollectionGroup operation.
            /// </param>
            public static FirewallPolicyRuleCollectionGroup BeginCreateOrUpdate(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified FirewallPolicyRuleCollectionGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='firewallPolicyName'>
            /// The name of the Firewall Policy.
            /// </param>
            /// <param name='ruleCollectionGroupName'>
            /// The name of the FirewallPolicyRuleCollectionGroup.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update
            /// FirewallPolicyRuleCollectionGroup operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallPolicyRuleCollectionGroup> BeginCreateOrUpdateAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallPolicyRuleCollectionGroup> ListNext(this IFirewallPolicyRuleCollectionGroupsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource.
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
            public static async Task<IPage<FirewallPolicyRuleCollectionGroup>> ListNextAsync(this IFirewallPolicyRuleCollectionGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
