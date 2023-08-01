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
using Azure.ResourceManager.AppConfiguration.Mocking;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AppConfiguration. </summary>
    public static partial class AppConfigurationExtensions
    {
        private static AppConfigurationArmClientMockingExtension GetAppConfigurationArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new AppConfigurationArmClientMockingExtension(client);
            });
        }

        private static AppConfigurationResourceGroupMockingExtension GetAppConfigurationResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new AppConfigurationResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static AppConfigurationSubscriptionMockingExtension GetAppConfigurationSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new AppConfigurationSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region AppConfigurationStoreResource
        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationStoreResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppConfigurationStoreResource" /> object. </returns>
        public static AppConfigurationStoreResource GetAppConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppConfigurationArmClientMockingExtension(client).GetAppConfigurationStoreResource(id);
        }
        #endregion

        #region DeletedAppConfigurationStoreResource
        /// <summary>
        /// Gets an object representing a <see cref="DeletedAppConfigurationStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeletedAppConfigurationStoreResource.CreateResourceIdentifier" /> to create a <see cref="DeletedAppConfigurationStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAppConfigurationStoreResource" /> object. </returns>
        public static DeletedAppConfigurationStoreResource GetDeletedAppConfigurationStoreResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppConfigurationArmClientMockingExtension(client).GetDeletedAppConfigurationStoreResource(id);
        }
        #endregion

        #region AppConfigurationPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppConfigurationPrivateEndpointConnectionResource" /> object. </returns>
        public static AppConfigurationPrivateEndpointConnectionResource GetAppConfigurationPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppConfigurationArmClientMockingExtension(client).GetAppConfigurationPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region AppConfigurationPrivateLinkResource
        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppConfigurationPrivateLinkResource" /> object. </returns>
        public static AppConfigurationPrivateLinkResource GetAppConfigurationPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppConfigurationArmClientMockingExtension(client).GetAppConfigurationPrivateLinkResource(id);
        }
        #endregion

        #region AppConfigurationKeyValueResource
        /// <summary>
        /// Gets an object representing an <see cref="AppConfigurationKeyValueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppConfigurationKeyValueResource.CreateResourceIdentifier" /> to create an <see cref="AppConfigurationKeyValueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppConfigurationKeyValueResource" /> object. </returns>
        public static AppConfigurationKeyValueResource GetAppConfigurationKeyValueResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetAppConfigurationArmClientMockingExtension(client).GetAppConfigurationKeyValueResource(id);
        }
        #endregion

        /// <summary> Gets a collection of AppConfigurationStoreResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AppConfigurationStoreResources and their operations over a AppConfigurationStoreResource. </returns>
        public static AppConfigurationStoreCollection GetAppConfigurationStores(this ResourceGroupResource resourceGroupResource)
        {
            return GetAppConfigurationResourceGroupMockingExtension(resourceGroupResource).GetAppConfigurationStores();
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AppConfigurationStoreResource>> GetAppConfigurationStoreAsync(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await GetAppConfigurationResourceGroupMockingExtension(resourceGroupResource).GetAppConfigurationStoreAsync(configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AppConfigurationStoreResource> GetAppConfigurationStore(this ResourceGroupResource resourceGroupResource, string configStoreName, CancellationToken cancellationToken = default)
        {
            return GetAppConfigurationResourceGroupMockingExtension(resourceGroupResource).GetAppConfigurationStore(configStoreName, cancellationToken);
        }

        /// <summary> Gets a collection of DeletedAppConfigurationStoreResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeletedAppConfigurationStoreResources and their operations over a DeletedAppConfigurationStoreResource. </returns>
        public static DeletedAppConfigurationStoreCollection GetDeletedAppConfigurationStores(this SubscriptionResource subscriptionResource)
        {
            return GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).GetDeletedAppConfigurationStores();
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DeletedAppConfigurationStoreResource>> GetDeletedAppConfigurationStoreAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return await GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).GetDeletedAppConfigurationStoreAsync(location, configStoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DeletedAppConfigurationStoreResource> GetDeletedAppConfigurationStore(this SubscriptionResource subscriptionResource, AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            return GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).GetDeletedAppConfigurationStore(location, configStoreName, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AppConfigurationStoreResource> GetAppConfigurationStoresAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).GetAppConfigurationStoresAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists the configuration stores for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/configurationStores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AppConfigurationStoreResource> GetAppConfigurationStores(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).GetAppConfigurationStores(skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<AppConfigurationNameAvailabilityResult>> CheckAppConfigurationNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).CheckAppConfigurationNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the configuration store name is available for use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAppConfigurationNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<AppConfigurationNameAvailabilityResult> CheckAppConfigurationNameAvailability(this SubscriptionResource subscriptionResource, AppConfigurationNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetAppConfigurationSubscriptionMockingExtension(subscriptionResource).CheckAppConfigurationNameAvailability(content, cancellationToken);
        }
    }
}
