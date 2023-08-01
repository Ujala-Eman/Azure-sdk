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
using Azure.ResourceManager.RecoveryServices.Mocking;
using Azure.ResourceManager.RecoveryServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.RecoveryServices. </summary>
    public static partial class RecoveryServicesExtensions
    {
        private static RecoveryServicesArmClientMockingExtension GetRecoveryServicesArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new RecoveryServicesArmClientMockingExtension(client);
            });
        }

        private static RecoveryServicesResourceGroupMockingExtension GetRecoveryServicesResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new RecoveryServicesResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static RecoveryServicesSubscriptionMockingExtension GetRecoveryServicesSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new RecoveryServicesSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region RecoveryServicesPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="RecoveryServicesPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RecoveryServicesPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="RecoveryServicesPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecoveryServicesPrivateLinkResource" /> object. </returns>
        public static RecoveryServicesPrivateLinkResource GetRecoveryServicesPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRecoveryServicesArmClientMockingExtension(client).GetRecoveryServicesPrivateLinkResource(id);
        }
        #endregion

        #region RecoveryServicesVaultResource
        /// <summary>
        /// Gets an object representing a <see cref="RecoveryServicesVaultResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RecoveryServicesVaultResource.CreateResourceIdentifier" /> to create a <see cref="RecoveryServicesVaultResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecoveryServicesVaultResource" /> object. </returns>
        public static RecoveryServicesVaultResource GetRecoveryServicesVaultResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRecoveryServicesArmClientMockingExtension(client).GetRecoveryServicesVaultResource(id);
        }
        #endregion

        #region RecoveryServicesVaultExtendedInfoResource
        /// <summary>
        /// Gets an object representing a <see cref="RecoveryServicesVaultExtendedInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RecoveryServicesVaultExtendedInfoResource.CreateResourceIdentifier" /> to create a <see cref="RecoveryServicesVaultExtendedInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecoveryServicesVaultExtendedInfoResource" /> object. </returns>
        public static RecoveryServicesVaultExtendedInfoResource GetRecoveryServicesVaultExtendedInfoResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetRecoveryServicesArmClientMockingExtension(client).GetRecoveryServicesVaultExtendedInfoResource(id);
        }
        #endregion

        /// <summary> Gets a collection of RecoveryServicesVaultResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RecoveryServicesVaultResources and their operations over a RecoveryServicesVaultResource. </returns>
        public static RecoveryServicesVaultCollection GetRecoveryServicesVaults(this ResourceGroupResource resourceGroupResource)
        {
            return GetRecoveryServicesResourceGroupMockingExtension(resourceGroupResource).GetRecoveryServicesVaults();
        }

        /// <summary>
        /// Get the Vault details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RecoveryServicesVaultResource>> GetRecoveryServicesVaultAsync(this ResourceGroupResource resourceGroupResource, string vaultName, CancellationToken cancellationToken = default)
        {
            return await GetRecoveryServicesResourceGroupMockingExtension(resourceGroupResource).GetRecoveryServicesVaultAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the Vault details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<RecoveryServicesVaultResource> GetRecoveryServicesVault(this ResourceGroupResource resourceGroupResource, string vaultName, CancellationToken cancellationToken = default)
        {
            return GetRecoveryServicesResourceGroupMockingExtension(resourceGroupResource).GetRecoveryServicesVault(vaultName, cancellationToken);
        }

        /// <summary>
        /// API to check for resource name availability.
        /// A name is available if no other resource exists that has the same SubscriptionId, Resource Name and Type
        /// or if one or more such resources exist, each of these must be GC'd and their time of deletion be more than 24 Hours Ago
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="content"> Contains information about Resource type and Resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RecoveryServicesNameAvailabilityResult>> CheckRecoveryServicesNameAvailabilityAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, RecoveryServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetRecoveryServicesResourceGroupMockingExtension(resourceGroupResource).CheckRecoveryServicesNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// API to check for resource name availability.
        /// A name is available if no other resource exists that has the same SubscriptionId, Resource Name and Type
        /// or if one or more such resources exist, each of these must be GC'd and their time of deletion be more than 24 Hours Ago
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="content"> Contains information about Resource type and Resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RecoveryServicesNameAvailabilityResult> CheckRecoveryServicesNameAvailability(this ResourceGroupResource resourceGroupResource, AzureLocation location, RecoveryServicesNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetRecoveryServicesResourceGroupMockingExtension(resourceGroupResource).CheckRecoveryServicesNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// API to get details about capabilities provided by Microsoft.RecoveryServices RP
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_Capabilities</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="input"> Contains information about Resource type and properties to get capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static async Task<Response<CapabilitiesResult>> GetRecoveryServiceCapabilitiesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ResourceCapabilities input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return await GetRecoveryServicesSubscriptionMockingExtension(subscriptionResource).GetRecoveryServiceCapabilitiesAsync(location, input, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// API to get details about capabilities provided by Microsoft.RecoveryServices RP
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_Capabilities</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="input"> Contains information about Resource type and properties to get capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public static Response<CapabilitiesResult> GetRecoveryServiceCapabilities(this SubscriptionResource subscriptionResource, AzureLocation location, ResourceCapabilities input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            return GetRecoveryServicesSubscriptionMockingExtension(subscriptionResource).GetRecoveryServiceCapabilities(location, input, cancellationToken);
        }

        /// <summary>
        /// Fetches all the resources of the specified type in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoveryServicesVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RecoveryServicesVaultResource> GetRecoveryServicesVaultsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetRecoveryServicesSubscriptionMockingExtension(subscriptionResource).GetRecoveryServicesVaultsAsync(cancellationToken);
        }

        /// <summary>
        /// Fetches all the resources of the specified type in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoveryServicesVaultResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RecoveryServicesVaultResource> GetRecoveryServicesVaults(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetRecoveryServicesSubscriptionMockingExtension(subscriptionResource).GetRecoveryServicesVaults(cancellationToken);
        }
    }
}
