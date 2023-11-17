// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourceGroupSecurityAlertResource" /> and their operations.
    /// Each <see cref="ResourceGroupSecurityAlertResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResourceGroupSecurityAlertCollection" /> instance call the GetResourceGroupSecurityAlerts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResourceGroupSecurityAlertCollection : ArmCollection, IEnumerable<ResourceGroupSecurityAlertResource>, IAsyncEnumerable<ResourceGroupSecurityAlertResource>
    {
        private readonly ClientDiagnostics _resourceGroupSecurityAlertAlertsClientDiagnostics;
        private readonly AlertsRestOperations _resourceGroupSecurityAlertAlertsRestClient;
        private readonly AzureLocation _ascLocation;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityAlertCollection"/> class for mocking. </summary>
        protected ResourceGroupSecurityAlertCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupSecurityAlertCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="ascLocation"> The location where ASC stores the data of the subscription. can be retrieved from Get locations. </param>
        internal ResourceGroupSecurityAlertCollection(ArmClient client, ResourceIdentifier id, AzureLocation ascLocation) : base(client, id)
        {
            _ascLocation = ascLocation;
            _resourceGroupSecurityAlertAlertsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceGroupSecurityAlertResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceGroupSecurityAlertResource.ResourceType, out string resourceGroupSecurityAlertAlertsApiVersion);
            _resourceGroupSecurityAlertAlertsRestClient = new AlertsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceGroupSecurityAlertAlertsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an alert that is associated a resource group or a resource in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual async Task<Response<ResourceGroupSecurityAlertResource>> GetAsync(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an alert that is associated a resource group or a resource in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual Response<ResourceGroupSecurityAlertResource> Get(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the alerts that are associated with the resource group that are stored in a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ListResourceGroupLevelByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceGroupSecurityAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceGroupSecurityAlertResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupSecurityAlertAlertsRestClient.CreateListResourceGroupLevelByRegionRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupSecurityAlertAlertsRestClient.CreateListResourceGroupLevelByRegionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourceGroupSecurityAlertResource(Client, SecurityAlertData.DeserializeSecurityAlertData(e)), _resourceGroupSecurityAlertAlertsClientDiagnostics, Pipeline, "ResourceGroupSecurityAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the alerts that are associated with the resource group that are stored in a specific location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_ListResourceGroupLevelByRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceGroupSecurityAlertResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceGroupSecurityAlertResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourceGroupSecurityAlertAlertsRestClient.CreateListResourceGroupLevelByRegionRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourceGroupSecurityAlertAlertsRestClient.CreateListResourceGroupLevelByRegionNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourceGroupSecurityAlertResource(Client, SecurityAlertData.DeserializeSecurityAlertData(e)), _resourceGroupSecurityAlertAlertsClientDiagnostics, Pipeline, "ResourceGroupSecurityAlertCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual Response<bool> Exists(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual async Task<NullableResponse<ResourceGroupSecurityAlertResource>> GetIfExistsAsync(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevelAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupSecurityAlertResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/alerts/{alertName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alerts_GetResourceGroupLevel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="alertName"> Name of the alert object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="alertName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="alertName"/> is null. </exception>
        public virtual NullableResponse<ResourceGroupSecurityAlertResource> GetIfExists(string alertName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(alertName, nameof(alertName));

            using var scope = _resourceGroupSecurityAlertAlertsClientDiagnostics.CreateScope("ResourceGroupSecurityAlertCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceGroupSecurityAlertAlertsRestClient.GetResourceGroupLevel(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_ascLocation), alertName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResourceGroupSecurityAlertResource>(response.GetRawResponse());
                return Response.FromValue(new ResourceGroupSecurityAlertResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourceGroupSecurityAlertResource> IEnumerable<ResourceGroupSecurityAlertResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourceGroupSecurityAlertResource> IAsyncEnumerable<ResourceGroupSecurityAlertResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
