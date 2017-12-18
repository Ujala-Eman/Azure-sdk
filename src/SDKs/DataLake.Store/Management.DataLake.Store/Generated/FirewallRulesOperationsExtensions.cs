// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FirewallRulesOperations.
    /// </summary>
    public static partial class FirewallRulesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates the specified firewall rule. During update, the firewall
            /// rule with the specified name will be replaced with this new firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to add or replace the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update the firewall rule.
            /// </param>
            public static FirewallRule CreateOrUpdate(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, FirewallRule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, firewallRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified firewall rule. During update, the firewall
            /// rule with the specified name will be replaced with this new firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to add or replace the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create or update the firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> CreateOrUpdateAsync(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, FirewallRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to update the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the firewall rule.
            /// </param>
            public static FirewallRule Update(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, UpdateFirewallRuleParameters parameters = default(UpdateFirewallRuleParameters))
            {
                return operations.UpdateAsync(resourceGroupName, accountName, firewallRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account to which to update the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update the firewall rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> UpdateAsync(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, UpdateFirewallRuleParameters parameters = default(UpdateFirewallRuleParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified firewall rule from the specified Data Lake Store
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to delete.
            /// </param>
            public static void Delete(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, firewallRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified firewall rule from the specified Data Lake Store
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to delete the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Data Lake Store firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to retrieve.
            /// </param>
            public static FirewallRule Get(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName)
            {
                return operations.GetAsync(resourceGroupName, accountName, firewallRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake Store firewall rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the firewall
            /// rule.
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> GetAsync(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store firewall rules within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the firewall
            /// rules.
            /// </param>
            public static IPage<FirewallRule> ListByAccount(this IFirewallRulesOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store firewall rules within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Azure resource group that contains the Data Lake Store
            /// account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Store account from which to get the firewall
            /// rules.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> ListByAccountAsync(this IFirewallRulesOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Data Lake Store firewall rules within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallRule> ListByAccountNext(this IFirewallRulesOperations operations, string nextPageLink)
            {
                return operations.ListByAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store firewall rules within the specified Data Lake
            /// Store account.
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
            public static async Task<IPage<FirewallRule>> ListByAccountNextAsync(this IFirewallRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
