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
using Azure.ResourceManager.Analysis.Mocking;
using Azure.ResourceManager.Analysis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Analysis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Analysis. </summary>
    public static partial class AnalysisExtensions
    {
        private static AnalysisArmClientMockingExtension GetAnalysisArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new AnalysisArmClientMockingExtension(client);
            });
        }

        private static AnalysisResourceGroupMockingExtension GetAnalysisResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new AnalysisResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static AnalysisSubscriptionMockingExtension GetAnalysisSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new AnalysisSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region AnalysisServerResource
        /// <summary>
        /// Gets an object representing an <see cref="AnalysisServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AnalysisServerResource.CreateResourceIdentifier" /> to create an <see cref="AnalysisServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnalysisServerResource" /> object. </returns>
        public static AnalysisServerResource GetAnalysisServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAnalysisArmClientMockingExtension(client).GetAnalysisServerResource(id);
        }
        #endregion

        /// <summary> Gets a collection of AnalysisServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AnalysisServerResources and their operations over a AnalysisServerResource. </returns>
        public static AnalysisServerCollection GetAnalysisServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetAnalysisResourceGroupMockingExtension(resourceGroupResource).GetAnalysisServers();
        }

        /// <summary>
        /// Gets details about the specified Analysis Services server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AnalysisServices/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_GetDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AnalysisServerResource>> GetAnalysisServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await GetAnalysisResourceGroupMockingExtension(resourceGroupResource).GetAnalysisServerAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about the specified Analysis Services server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AnalysisServices/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_GetDetails</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AnalysisServerResource> GetAnalysisServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return GetAnalysisResourceGroupMockingExtension(resourceGroupResource).GetAnalysisServer(serverName, cancellationToken);
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AnalysisServerResource> GetAnalysisServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetAnalysisSubscriptionMockingExtension(subscriptionResource).GetAnalysisServersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AnalysisServerResource> GetAnalysisServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetAnalysisSubscriptionMockingExtension(subscriptionResource).GetAnalysisServers(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListSkusForNew</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AnalysisResourceSku> GetEligibleSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetAnalysisSubscriptionMockingExtension(subscriptionResource).GetEligibleSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListSkusForNew</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AnalysisResourceSku> GetEligibleSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetAnalysisSubscriptionMockingExtension(subscriptionResource).GetEligibleSkus(cancellationToken);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<AnalysisServerNameAvailabilityResult>> CheckAnalysisServerNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetAnalysisSubscriptionMockingExtension(subscriptionResource).CheckAnalysisServerNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<AnalysisServerNameAvailabilityResult> CheckAnalysisServerNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, AnalysisServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetAnalysisSubscriptionMockingExtension(subscriptionResource).CheckAnalysisServerNameAvailability(location, content, cancellationToken);
        }
    }
}
