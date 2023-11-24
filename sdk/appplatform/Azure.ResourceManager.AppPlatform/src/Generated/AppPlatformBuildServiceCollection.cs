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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformBuildServiceResource"/> and their operations.
    /// Each <see cref="AppPlatformBuildServiceResource"/> in the collection will belong to the same instance of <see cref="AppPlatformServiceResource"/>.
    /// To get an <see cref="AppPlatformBuildServiceCollection"/> instance call the GetAppPlatformBuildServices method from an instance of <see cref="AppPlatformServiceResource"/>.
    /// </summary>
    public partial class AppPlatformBuildServiceCollection : ArmCollection, IEnumerable<AppPlatformBuildServiceResource>, IAsyncEnumerable<AppPlatformBuildServiceResource>
    {
        private readonly ClientDiagnostics _appPlatformBuildServiceBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformBuildServiceBuildServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceCollection"/> class for mocking. </summary>
        protected AppPlatformBuildServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformBuildServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildServiceBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformBuildServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformBuildServiceResource.ResourceType, out string appPlatformBuildServiceBuildServiceApiVersion);
            _appPlatformBuildServiceBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildServiceBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a build service resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformBuildServiceResource>> GetAsync(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceBuildServiceRestClient.GetBuildServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a build service resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual Response<AppPlatformBuildServiceResource> Get(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceBuildServiceRestClient.GetBuildService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List build services resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListBuildServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformBuildServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformBuildServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildServiceBuildServiceRestClient.CreateListBuildServicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildServiceBuildServiceRestClient.CreateListBuildServicesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuildServiceResource(Client, AppPlatformBuildServiceData.DeserializeAppPlatformBuildServiceData(e)), _appPlatformBuildServiceBuildServiceClientDiagnostics, Pipeline, "AppPlatformBuildServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List build services resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListBuildServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformBuildServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformBuildServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformBuildServiceBuildServiceRestClient.CreateListBuildServicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformBuildServiceBuildServiceRestClient.CreateListBuildServicesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformBuildServiceResource(Client, AppPlatformBuildServiceData.DeserializeAppPlatformBuildServiceData(e)), _appPlatformBuildServiceBuildServiceClientDiagnostics, Pipeline, "AppPlatformBuildServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceBuildServiceRestClient.GetBuildServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceBuildServiceRestClient.GetBuildService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformBuildServiceResource>> GetIfExistsAsync(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceBuildServiceRestClient.GetBuildServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformBuildServiceResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildServiceName"> The name of the build service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildServiceName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformBuildServiceResource> GetIfExists(string buildServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildServiceName, nameof(buildServiceName));

            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceBuildServiceRestClient.GetBuildService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, buildServiceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformBuildServiceResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformBuildServiceResource> IEnumerable<AppPlatformBuildServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformBuildServiceResource> IAsyncEnumerable<AppPlatformBuildServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
