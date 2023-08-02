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
using Azure.ResourceManager.IotCentral.Mocking;
using Azure.ResourceManager.IotCentral.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotCentral
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IotCentral. </summary>
    public static partial class IotCentralExtensions
    {
        private static IotCentralArmClientMockingExtension GetIotCentralArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new IotCentralArmClientMockingExtension(client);
            });
        }

        private static IotCentralResourceGroupMockingExtension GetIotCentralResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new IotCentralResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static IotCentralSubscriptionMockingExtension GetIotCentralSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new IotCentralSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region IotCentralAppResource
        /// <summary>
        /// Gets an object representing an <see cref="IotCentralAppResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralAppResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralAppResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralAppResource" /> object. </returns>
        public static IotCentralAppResource GetIotCentralAppResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetIotCentralArmClientMockingExtension(client).GetIotCentralAppResource(id);
        }
        #endregion

        #region IotCentralPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing an <see cref="IotCentralPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralPrivateEndpointConnectionResource" /> object. </returns>
        public static IotCentralPrivateEndpointConnectionResource GetIotCentralPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetIotCentralArmClientMockingExtension(client).GetIotCentralPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region IotCentralPrivateLinkResource
        /// <summary>
        /// Gets an object representing an <see cref="IotCentralPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotCentralPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="IotCentralPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotCentralPrivateLinkResource" /> object. </returns>
        public static IotCentralPrivateLinkResource GetIotCentralPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetIotCentralArmClientMockingExtension(client).GetIotCentralPrivateLinkResource(id);
        }
        #endregion

        /// <summary> Gets a collection of IotCentralAppResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of IotCentralAppResources and their operations over a IotCentralAppResource. </returns>
        public static IotCentralAppCollection GetIotCentralApps(this ResourceGroupResource resourceGroupResource)
        {
            return GetIotCentralResourceGroupMockingExtension(resourceGroupResource).GetIotCentralApps();
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<IotCentralAppResource>> GetIotCentralAppAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetIotCentralResourceGroupMockingExtension(resourceGroupResource).GetIotCentralAppAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of an IoT Central application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The ARM resource name of the IoT Central application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<IotCentralAppResource> GetIotCentralApp(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetIotCentralResourceGroupMockingExtension(resourceGroupResource).GetIotCentralApp(resourceName, cancellationToken);
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotCentralAppResource> GetIotCentralAppsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).GetIotCentralAppsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all IoT Central Applications in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/iotApps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotCentralAppResource> GetIotCentralApps(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).GetIotCentralApps(cancellationToken);
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppNameAvailabilityAsync(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetIotCentralSubscriptionMockingExtension(subscriptionResource).CheckIotCentralAppNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT Central application name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppNameAvailability(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).CheckIotCentralAppNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckSubdomainAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotCentralAppNameAvailabilityResponse>> CheckIotCentralAppSubdomainAvailabilityAsync(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetIotCentralSubscriptionMockingExtension(subscriptionResource).CheckIotCentralAppSubdomainAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT Central application subdomain is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/checkSubdomainAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_CheckSubdomainAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the subdomain of the IoT Central application to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<IotCentralAppNameAvailabilityResponse> CheckIotCentralAppSubdomainAvailability(this SubscriptionResource subscriptionResource, IotCentralAppNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).CheckIotCentralAppSubdomainAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get all available application templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListTemplates</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotCentralAppTemplate> GetTemplatesAppsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).GetTemplatesAppsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all available application templates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTCentral/appTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Apps_ListTemplates</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotCentralAppTemplate" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotCentralAppTemplate> GetTemplatesApps(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetIotCentralSubscriptionMockingExtension(subscriptionResource).GetTemplatesApps(cancellationToken);
        }
    }
}
