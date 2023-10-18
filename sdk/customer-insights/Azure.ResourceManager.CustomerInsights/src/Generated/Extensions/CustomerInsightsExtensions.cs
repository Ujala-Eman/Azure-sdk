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
using Azure.ResourceManager.CustomerInsights.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.CustomerInsights. </summary>
    public static partial class CustomerInsightsExtensions
    {
        private static CustomerInsightsArmClientMockingExtension GetCustomerInsightsArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new CustomerInsightsArmClientMockingExtension(client0));
        }

        private static CustomerInsightsResourceGroupMockingExtension GetCustomerInsightsResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new CustomerInsightsResourceGroupMockingExtension(client, resource.Id));
        }

        private static CustomerInsightsSubscriptionMockingExtension GetCustomerInsightsSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new CustomerInsightsSubscriptionMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HubResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HubResource.CreateResourceIdentifier" /> to create a <see cref="HubResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetHubResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HubResource" /> object. </returns>
        public static HubResource GetHubResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetHubResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProfileResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProfileResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ProfileResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetProfileResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProfileResourceFormatResource" /> object. </returns>
        public static ProfileResourceFormatResource GetProfileResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetProfileResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="InteractionResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="InteractionResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="InteractionResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetInteractionResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InteractionResourceFormatResource" /> object. </returns>
        public static InteractionResourceFormatResource GetInteractionResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetInteractionResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelationshipResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetRelationshipResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipResourceFormatResource" /> object. </returns>
        public static RelationshipResourceFormatResource GetRelationshipResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetRelationshipResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RelationshipLinkResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelationshipLinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RelationshipLinkResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetRelationshipLinkResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelationshipLinkResourceFormatResource" /> object. </returns>
        public static RelationshipLinkResourceFormatResource GetRelationshipLinkResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetRelationshipLinkResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AuthorizationPolicyResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AuthorizationPolicyResourceFormatResource.CreateResourceIdentifier" /> to create an <see cref="AuthorizationPolicyResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetAuthorizationPolicyResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthorizationPolicyResourceFormatResource" /> object. </returns>
        public static AuthorizationPolicyResourceFormatResource GetAuthorizationPolicyResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetAuthorizationPolicyResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetConnectorResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorResourceFormatResource" /> object. </returns>
        public static ConnectorResourceFormatResource GetConnectorResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetConnectorResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectorMappingResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectorMappingResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ConnectorMappingResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetConnectorMappingResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectorMappingResourceFormatResource" /> object. </returns>
        public static ConnectorMappingResourceFormatResource GetConnectorMappingResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetConnectorMappingResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KpiResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KpiResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="KpiResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetKpiResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KpiResourceFormatResource" /> object. </returns>
        public static KpiResourceFormatResource GetKpiResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetKpiResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="WidgetTypeResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WidgetTypeResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="WidgetTypeResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetWidgetTypeResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WidgetTypeResourceFormatResource" /> object. </returns>
        public static WidgetTypeResourceFormatResource GetWidgetTypeResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetWidgetTypeResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ViewResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ViewResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="ViewResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetViewResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ViewResourceFormatResource" /> object. </returns>
        public static ViewResourceFormatResource GetViewResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetViewResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LinkResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LinkResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="LinkResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetLinkResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LinkResourceFormatResource" /> object. </returns>
        public static LinkResourceFormatResource GetLinkResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetLinkResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RoleAssignmentResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RoleAssignmentResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="RoleAssignmentResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetRoleAssignmentResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleAssignmentResourceFormatResource" /> object. </returns>
        public static RoleAssignmentResourceFormatResource GetRoleAssignmentResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetRoleAssignmentResourceFormatResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PredictionResourceFormatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PredictionResourceFormatResource.CreateResourceIdentifier" /> to create a <see cref="PredictionResourceFormatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsArmClientMockingExtension.GetPredictionResourceFormatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PredictionResourceFormatResource" /> object. </returns>
        public static PredictionResourceFormatResource GetPredictionResourceFormatResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetCustomerInsightsArmClientMockingExtension(client).GetPredictionResourceFormatResource(id);
        }

        /// <summary>
        /// Gets a collection of HubResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsResourceGroupMockingExtension.GetHubs()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HubResources and their operations over a HubResource. </returns>
        public static HubCollection GetHubs(this ResourceGroupResource resourceGroupResource)
        {
            return GetCustomerInsightsResourceGroupMockingExtension(resourceGroupResource).GetHubs();
        }

        /// <summary>
        /// Gets information about the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hubs_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsResourceGroupMockingExtension.GetHubAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HubResource>> GetHubAsync(this ResourceGroupResource resourceGroupResource, string hubName, CancellationToken cancellationToken = default)
        {
            return await GetCustomerInsightsResourceGroupMockingExtension(resourceGroupResource).GetHubAsync(hubName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hubs_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsResourceGroupMockingExtension.GetHub(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="hubName"> The name of the hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hubName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hubName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HubResource> GetHub(this ResourceGroupResource resourceGroupResource, string hubName, CancellationToken cancellationToken = default)
        {
            return GetCustomerInsightsResourceGroupMockingExtension(resourceGroupResource).GetHub(hubName, cancellationToken);
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hubs_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsSubscriptionMockingExtension.GetHubs(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HubResource> GetHubsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetCustomerInsightsSubscriptionMockingExtension(subscriptionResource).GetHubsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all hubs in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CustomerInsights/hubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hubs_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="CustomerInsightsSubscriptionMockingExtension.GetHubs(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HubResource> GetHubs(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetCustomerInsightsSubscriptionMockingExtension(subscriptionResource).GetHubs(cancellationToken);
        }
    }
}
