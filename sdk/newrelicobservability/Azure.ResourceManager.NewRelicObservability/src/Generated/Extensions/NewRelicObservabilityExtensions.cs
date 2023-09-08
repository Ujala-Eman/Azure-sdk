// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.NewRelicObservability.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.NewRelicObservability. </summary>
    public static partial class NewRelicObservabilityExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region NewRelicMonitorResource
        /// <summary>
        /// Gets an object representing a <see cref="NewRelicMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NewRelicMonitorResource.CreateResourceIdentifier" /> to create a <see cref="NewRelicMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NewRelicMonitorResource" /> object. </returns>
        public static NewRelicMonitorResource GetNewRelicMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NewRelicMonitorResource.ValidateResourceId(id);
                return new NewRelicMonitorResource(client, id);
            }
            );
        }
        #endregion

        #region NewRelicObservabilityTagRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NewRelicObservabilityTagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NewRelicObservabilityTagRuleResource.CreateResourceIdentifier" /> to create a <see cref="NewRelicObservabilityTagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NewRelicObservabilityTagRuleResource" /> object. </returns>
        public static NewRelicObservabilityTagRuleResource GetNewRelicObservabilityTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NewRelicObservabilityTagRuleResource.ValidateResourceId(id);
                return new NewRelicObservabilityTagRuleResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of NewRelicMonitorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of NewRelicMonitorResources and their operations over a NewRelicMonitorResource. </returns>
        public static NewRelicMonitorResourceCollection GetNewRelicMonitorResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetNewRelicMonitorResources();
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<NewRelicMonitorResource>> GetNewRelicMonitorResourceAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetNewRelicMonitorResources().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a NewRelicMonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/NewRelic.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Name of the Monitors resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<NewRelicMonitorResource> GetNewRelicMonitorResource(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetNewRelicMonitorResources().Get(monitorName, cancellationToken);
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicAccountResourceData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicAccountResourceData> GetNewRelicAccountsAsync(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicAccountsAsync(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List all the existing accounts
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicAccountResourceData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicAccountResourceData> GetNewRelicAccounts(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicAccounts(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicMonitorResource> GetNewRelicMonitorResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicMonitorResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List NewRelicMonitorResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicMonitorResource> GetNewRelicMonitorResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicMonitorResources(cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        /// <returns> An async collection of <see cref="NewRelicOrganizationResourceData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicOrganizationResourceData> GetNewRelicOrganizationsAsync(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicOrganizationsAsync(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List all the existing organizations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="userEmail"> User Email. </param>
        /// <param name="location"> Location for NewRelic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userEmail"/> is null. </exception>
        /// <returns> A collection of <see cref="NewRelicOrganizationResourceData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicOrganizationResourceData> GetNewRelicOrganizations(this SubscriptionResource subscriptionResource, string userEmail, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(userEmail, nameof(userEmail));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicOrganizations(userEmail, location, cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NewRelicPlanData" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<NewRelicPlanData> GetNewRelicPlansAsync(this SubscriptionResource subscriptionResource, string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicPlansAsync(accountId, organizationId, cancellationToken);
        }

        /// <summary>
        /// List plans data
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/NewRelic.Observability/plans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Plans_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="accountId"> Account Id. </param>
        /// <param name="organizationId"> Organization Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NewRelicPlanData" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<NewRelicPlanData> GetNewRelicPlans(this SubscriptionResource subscriptionResource, string accountId = null, string organizationId = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetNewRelicPlans(accountId, organizationId, cancellationToken);
        }
    }
}
