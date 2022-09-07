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
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.FrontDoor. </summary>
    public static partial class FrontDoorExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// Request Path: /providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailability_Check
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(this TenantResource tenantResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(tenantResource).CheckFrontDoorNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door resource name.
        /// Request Path: /providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailability_Check
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(this TenantResource tenantResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(tenantResource).CheckFrontDoorNameAvailability(content, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedRuleSetsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all available managed rule sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallManagedRuleSets
        /// Operation Id: ManagedRuleSets_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRuleSetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedRuleSets(cancellationToken);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<FrontDoorNameAvailabilityResult>> CheckFrontDoorNameAvailabilityAsync(this SubscriptionResource subscriptionResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckFrontDoorNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of a Front Door subdomain.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/checkFrontDoorNameAvailability
        /// Operation Id: FrontDoorNameAvailabilityWithSubscription_Check
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<FrontDoorNameAvailabilityResult> CheckFrontDoorNameAvailability(this SubscriptionResource subscriptionResource, FrontDoorNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckFrontDoorNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FrontDoorResource> GetFrontDoorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoorsAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all of the Front Doors within an Azure subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/frontDoors
        /// Operation Id: FrontDoors_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FrontDoorResource> GetFrontDoors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoors(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfilesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoorNetworkExperimentProfilesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Network Experiment Profiles under a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/NetworkExperimentProfiles
        /// Operation Id: NetworkExperimentProfiles_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorNetworkExperimentProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfiles(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetFrontDoorNetworkExperimentProfiles(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of FrontDoorWebApplicationFirewallPolicyResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorWebApplicationFirewallPolicyResources and their operations over a FrontDoorWebApplicationFirewallPolicyResource. </returns>
        public static FrontDoorWebApplicationFirewallPolicyCollection GetFrontDoorWebApplicationFirewallPolicies(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetFrontDoorWebApplicationFirewallPolicies();
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorWebApplicationFirewallPolicyResource>> GetFrontDoorWebApplicationFirewallPolicyAsync(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies().GetAsync(policyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyName"> The name of the Web Application Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorWebApplicationFirewallPolicyResource> GetFrontDoorWebApplicationFirewallPolicy(this ResourceGroupResource resourceGroupResource, string policyName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoorWebApplicationFirewallPolicies().Get(policyName, cancellationToken);
        }

        /// <summary> Gets a collection of FrontDoorResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorResources and their operations over a FrontDoorResource. </returns>
        public static FrontDoorCollection GetFrontDoors(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetFrontDoors();
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}
        /// Operation Id: FrontDoors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorResource>> GetFrontDoorAsync(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoors().GetAsync(frontDoorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Front Door with the specified Front Door name under the specified subscription and resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}
        /// Operation Id: FrontDoors_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="frontDoorName"> Name of the Front Door which is globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontDoorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontDoorName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorResource> GetFrontDoor(this ResourceGroupResource resourceGroupResource, string frontDoorName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoors().Get(frontDoorName, cancellationToken);
        }

        /// <summary> Gets a collection of FrontDoorNetworkExperimentProfileResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FrontDoorNetworkExperimentProfileResources and their operations over a FrontDoorNetworkExperimentProfileResource. </returns>
        public static FrontDoorNetworkExperimentProfileCollection GetFrontDoorNetworkExperimentProfiles(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetFrontDoorNetworkExperimentProfiles();
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}
        /// Operation Id: NetworkExperimentProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FrontDoorNetworkExperimentProfileResource>> GetFrontDoorNetworkExperimentProfileAsync(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetFrontDoorNetworkExperimentProfiles().GetAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an NetworkExperiment Profile by ProfileName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/NetworkExperimentProfiles/{profileName}
        /// Operation Id: NetworkExperimentProfiles_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The Profile identifier associated with the Tenant and Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="profileName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<FrontDoorNetworkExperimentProfileResource> GetFrontDoorNetworkExperimentProfile(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetFrontDoorNetworkExperimentProfiles().Get(profileName, cancellationToken);
        }

        #region FrontDoorWebApplicationFirewallPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorWebApplicationFirewallPolicyResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorWebApplicationFirewallPolicyResource" /> object. </returns>
        public static FrontDoorWebApplicationFirewallPolicyResource GetFrontDoorWebApplicationFirewallPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorWebApplicationFirewallPolicyResource.ValidateResourceId(id);
                return new FrontDoorWebApplicationFirewallPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorResource" /> object. </returns>
        public static FrontDoorResource GetFrontDoorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorResource.ValidateResourceId(id);
                return new FrontDoorResource(client, id);
            }
            );
        }
        #endregion

        #region FrontendEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontendEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontendEndpointResource.CreateResourceIdentifier" /> to create a <see cref="FrontendEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontendEndpointResource" /> object. </returns>
        public static FrontendEndpointResource GetFrontendEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontendEndpointResource.ValidateResourceId(id);
                return new FrontendEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorRulesEngineResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorRulesEngineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorRulesEngineResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorRulesEngineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorRulesEngineResource" /> object. </returns>
        public static FrontDoorRulesEngineResource GetFrontDoorRulesEngineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorRulesEngineResource.ValidateResourceId(id);
                return new FrontDoorRulesEngineResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorNetworkExperimentProfileResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorNetworkExperimentProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorNetworkExperimentProfileResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorNetworkExperimentProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorNetworkExperimentProfileResource" /> object. </returns>
        public static FrontDoorNetworkExperimentProfileResource GetFrontDoorNetworkExperimentProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorNetworkExperimentProfileResource.ValidateResourceId(id);
                return new FrontDoorNetworkExperimentProfileResource(client, id);
            }
            );
        }
        #endregion

        #region FrontDoorExperimentResource
        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorExperimentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorExperimentResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorExperimentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorExperimentResource" /> object. </returns>
        public static FrontDoorExperimentResource GetFrontDoorExperimentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FrontDoorExperimentResource.ValidateResourceId(id);
                return new FrontDoorExperimentResource(client, id);
            }
            );
        }
        #endregion
    }
}
