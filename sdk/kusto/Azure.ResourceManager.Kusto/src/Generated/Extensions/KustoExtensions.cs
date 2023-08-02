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
using Azure.ResourceManager.Kusto.Mocking;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Kusto
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Kusto. </summary>
    public static partial class KustoExtensions
    {
        private static KustoArmClientMockingExtension GetKustoArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new KustoArmClientMockingExtension(client);
            });
        }

        private static KustoResourceGroupMockingExtension GetKustoResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new KustoResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static KustoSubscriptionMockingExtension GetKustoSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new KustoSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region KustoClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoClusterResource.CreateResourceIdentifier" /> to create a <see cref="KustoClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoClusterResource" /> object. </returns>
        public static KustoClusterResource GetKustoClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoClusterResource(id);
        }
        #endregion

        #region KustoClusterPrincipalAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoClusterPrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoClusterPrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="KustoClusterPrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoClusterPrincipalAssignmentResource" /> object. </returns>
        public static KustoClusterPrincipalAssignmentResource GetKustoClusterPrincipalAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoClusterPrincipalAssignmentResource(id);
        }
        #endregion

        #region KustoDatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="KustoDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDatabaseResource" /> object. </returns>
        public static KustoDatabaseResource GetKustoDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoDatabaseResource(id);
        }
        #endregion

        #region KustoAttachedDatabaseConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoAttachedDatabaseConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoAttachedDatabaseConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="KustoAttachedDatabaseConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoAttachedDatabaseConfigurationResource" /> object. </returns>
        public static KustoAttachedDatabaseConfigurationResource GetKustoAttachedDatabaseConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoAttachedDatabaseConfigurationResource(id);
        }
        #endregion

        #region KustoManagedPrivateEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoManagedPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoManagedPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="KustoManagedPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoManagedPrivateEndpointResource" /> object. </returns>
        public static KustoManagedPrivateEndpointResource GetKustoManagedPrivateEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoManagedPrivateEndpointResource(id);
        }
        #endregion

        #region KustoDatabasePrincipalAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoDatabasePrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDatabasePrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="KustoDatabasePrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDatabasePrincipalAssignmentResource" /> object. </returns>
        public static KustoDatabasePrincipalAssignmentResource GetKustoDatabasePrincipalAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoDatabasePrincipalAssignmentResource(id);
        }
        #endregion

        #region KustoScriptResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoScriptResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoScriptResource.CreateResourceIdentifier" /> to create a <see cref="KustoScriptResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoScriptResource" /> object. </returns>
        public static KustoScriptResource GetKustoScriptResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoScriptResource(id);
        }
        #endregion

        #region KustoPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateEndpointConnectionResource" /> object. </returns>
        public static KustoPrivateEndpointConnectionResource GetKustoPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region KustoPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateLinkResource" /> object. </returns>
        public static KustoPrivateLinkResource GetKustoPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoPrivateLinkResource(id);
        }
        #endregion

        #region KustoDataConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoDataConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDataConnectionResource.CreateResourceIdentifier" /> to create a <see cref="KustoDataConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDataConnectionResource" /> object. </returns>
        public static KustoDataConnectionResource GetKustoDataConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetKustoArmClientMockingExtension(client).GetKustoDataConnectionResource(id);
        }
        #endregion

        /// <summary> Gets a collection of KustoClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of KustoClusterResources and their operations over a KustoClusterResource. </returns>
        public static KustoClusterCollection GetKustoClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetKustoResourceGroupMockingExtension(resourceGroupResource).GetKustoClusters();
        }

        /// <summary>
        /// Gets a Kusto cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<KustoClusterResource>> GetKustoClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetKustoResourceGroupMockingExtension(resourceGroupResource).GetKustoClusterAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Kusto cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<KustoClusterResource> GetKustoCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return GetKustoResourceGroupMockingExtension(resourceGroupResource).GetKustoCluster(clusterName, cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<KustoClusterResource> GetKustoClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetKustoClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<KustoClusterResource> GetKustoClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetKustoClusters(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<KustoSkuDescription> GetKustoEligibleSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetKustoEligibleSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<KustoSkuDescription> GetKustoEligibleSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetKustoEligibleSkus(cancellationToken);
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<KustoNameAvailabilityResult>> CheckKustoClusterNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, KustoClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetKustoSubscriptionMockingExtension(subscriptionResource).CheckKustoClusterNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<KustoNameAvailabilityResult> CheckKustoClusterNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, KustoClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).CheckKustoClusterNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Lists eligible region SKUs for Kusto resource provider by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<KustoSkuDescription> GetSkusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetSkusAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists eligible region SKUs for Kusto resource provider by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<KustoSkuDescription> GetSkus(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetKustoSubscriptionMockingExtension(subscriptionResource).GetSkus(location, cancellationToken);
        }
    }
}
