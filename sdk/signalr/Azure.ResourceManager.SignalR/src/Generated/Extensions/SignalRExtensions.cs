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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SignalR.Mocking;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.SignalR. </summary>
    public static partial class SignalRExtensions
    {
        private static SignalRArmClientMockingExtension GetSignalRArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new SignalRArmClientMockingExtension(client);
            });
        }

        private static SignalRResourceGroupMockingExtension GetSignalRResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SignalRResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static SignalRSubscriptionMockingExtension GetSignalRSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SignalRSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region SignalRResource
        /// <summary>
        /// Gets an object representing a <see cref="SignalRResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SignalRResource.CreateResourceIdentifier" /> to create a <see cref="SignalRResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRResource" /> object. </returns>
        public static SignalRResource GetSignalRResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSignalRArmClientMockingExtension(client).GetSignalRResource(id);
        }
        #endregion

        #region SignalRCustomCertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="SignalRCustomCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SignalRCustomCertificateResource.CreateResourceIdentifier" /> to create a <see cref="SignalRCustomCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRCustomCertificateResource" /> object. </returns>
        public static SignalRCustomCertificateResource GetSignalRCustomCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSignalRArmClientMockingExtension(client).GetSignalRCustomCertificateResource(id);
        }
        #endregion

        #region SignalRCustomDomainResource
        /// <summary>
        /// Gets an object representing a <see cref="SignalRCustomDomainResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SignalRCustomDomainResource.CreateResourceIdentifier" /> to create a <see cref="SignalRCustomDomainResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRCustomDomainResource" /> object. </returns>
        public static SignalRCustomDomainResource GetSignalRCustomDomainResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSignalRArmClientMockingExtension(client).GetSignalRCustomDomainResource(id);
        }
        #endregion

        #region SignalRPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="SignalRPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SignalRPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="SignalRPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRPrivateEndpointConnectionResource" /> object. </returns>
        public static SignalRPrivateEndpointConnectionResource GetSignalRPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSignalRArmClientMockingExtension(client).GetSignalRPrivateEndpointConnectionResource(id);
        }
        #endregion

        #region SignalRSharedPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="SignalRSharedPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SignalRSharedPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="SignalRSharedPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SignalRSharedPrivateLinkResource" /> object. </returns>
        public static SignalRSharedPrivateLinkResource GetSignalRSharedPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetSignalRArmClientMockingExtension(client).GetSignalRSharedPrivateLinkResource(id);
        }
        #endregion

        /// <summary> Gets a collection of SignalRResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SignalRResources and their operations over a SignalRResource. </returns>
        public static SignalRCollection GetSignalRs(this ResourceGroupResource resourceGroupResource)
        {
            return GetSignalRResourceGroupMockingExtension(resourceGroupResource).GetSignalRs();
        }

        /// <summary>
        /// Get the resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SignalRResource>> GetSignalRAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetSignalRResourceGroupMockingExtension(resourceGroupResource).GetSignalRAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the resource and its properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SignalRResource> GetSignalR(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetSignalRResourceGroupMockingExtension(resourceGroupResource).GetSignalR(resourceName, cancellationToken);
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<SignalRNameAvailabilityResult>> CheckSignalRNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, SignalRNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetSignalRSubscriptionMockingExtension(subscriptionResource).CheckSignalRNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<SignalRNameAvailabilityResult> CheckSignalRNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, SignalRNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetSignalRSubscriptionMockingExtension(subscriptionResource).CheckSignalRNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/signalR</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SignalRResource> GetSignalRsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSignalRSubscriptionMockingExtension(subscriptionResource).GetSignalRsAsync(cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/signalR</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SignalR_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SignalRResource> GetSignalRs(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSignalRSubscriptionMockingExtension(subscriptionResource).GetSignalRs(cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SignalRUsage> GetUsagesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetSignalRSubscriptionMockingExtension(subscriptionResource).GetUsagesAsync(location, cancellationToken);
        }

        /// <summary>
        /// List resource usage quotas by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SignalRService/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> the location like "eastus". </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SignalRUsage> GetUsages(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetSignalRSubscriptionMockingExtension(subscriptionResource).GetUsages(location, cancellationToken);
        }
    }
}
