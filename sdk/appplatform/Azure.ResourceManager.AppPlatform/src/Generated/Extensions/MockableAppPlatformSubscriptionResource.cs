// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAppPlatformSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _appPlatformServiceServicesClientDiagnostics;
        private ServicesRestOperations _appPlatformServiceServicesRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAppPlatformSubscriptionResource"/> class for mocking. </summary>
        protected MockableAppPlatformSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppPlatformSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppPlatformSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AppPlatformServiceServicesClientDiagnostics => _appPlatformServiceServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformServiceResource.ResourceType.Namespace, Diagnostics);
        private ServicesRestOperations AppPlatformServiceServicesRestClient => _appPlatformServiceServicesRestClient ??= new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AppPlatformServiceResource.ResourceType));
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AppPlatformNameAvailabilityResult>> CheckAppPlatformNameAvailabilityAsync(AzureLocation location, AppPlatformNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = AppPlatformServiceServicesClientDiagnostics.CreateScope("MockableAppPlatformSubscriptionResource.CheckAppPlatformNameAvailability");
            scope.Start();
            try
            {
                var response = await AppPlatformServiceServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the resource name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> the region. </param>
        /// <param name="content"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AppPlatformNameAvailabilityResult> CheckAppPlatformNameAvailability(AzureLocation location, AppPlatformNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = AppPlatformServiceServicesClientDiagnostics.CreateScope("MockableAppPlatformSubscriptionResource.CheckAppPlatformNameAvailability");
            scope.Start();
            try
            {
                var response = AppPlatformServiceServicesRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/Spring</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformServiceResource> GetAppPlatformServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AppPlatformServiceServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AppPlatformServiceServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformServiceResource(Client, AppPlatformServiceData.DeserializeAppPlatformServiceData(e)), AppPlatformServiceServicesClientDiagnostics, Pipeline, "MockableAppPlatformSubscriptionResource.GetAppPlatformServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handles requests to list all resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/Spring</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformServiceResource> GetAppPlatformServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AppPlatformServiceServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AppPlatformServiceServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformServiceResource(Client, AppPlatformServiceData.DeserializeAppPlatformServiceData(e)), AppPlatformServiceServicesClientDiagnostics, Pipeline, "MockableAppPlatformSubscriptionResource.GetAppPlatformServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the available skus of the Microsoft.AppPlatform provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableAppPlatformSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableAppPlatformSku> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AvailableAppPlatformSku.DeserializeAvailableAppPlatformSku, SkusClientDiagnostics, Pipeline, "MockableAppPlatformSubscriptionResource.GetSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the available skus of the Microsoft.AppPlatform provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppPlatform/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableAppPlatformSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableAppPlatformSku> GetSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AvailableAppPlatformSku.DeserializeAvailableAppPlatformSku, SkusClientDiagnostics, Pipeline, "MockableAppPlatformSubscriptionResource.GetSkus", "value", "nextLink", cancellationToken);
        }
    }
}
