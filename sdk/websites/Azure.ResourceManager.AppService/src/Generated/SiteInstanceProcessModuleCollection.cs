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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteInstanceProcessModuleResource" /> and their operations.
    /// Each <see cref="SiteInstanceProcessModuleResource" /> in the collection will belong to the same instance of <see cref="SiteInstanceProcessResource" />.
    /// To get a <see cref="SiteInstanceProcessModuleCollection" /> instance call the GetSiteInstanceProcessModules method from an instance of <see cref="SiteInstanceProcessResource" />.
    /// </summary>
    public partial class SiteInstanceProcessModuleCollection : ArmCollection, IEnumerable<SiteInstanceProcessModuleResource>, IAsyncEnumerable<SiteInstanceProcessModuleResource>
    {
        private readonly ClientDiagnostics _siteInstanceProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteInstanceProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessModuleCollection"/> class for mocking. </summary>
        protected SiteInstanceProcessModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceProcessModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteInstanceProcessModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteInstanceProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteInstanceProcessModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteInstanceProcessModuleResource.ResourceType, out string siteInstanceProcessModuleWebAppsApiVersion);
            _siteInstanceProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteInstanceProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteInstanceProcessResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteInstanceProcessResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<SiteInstanceProcessModuleResource>> GetAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<SiteInstanceProcessModuleResource> Get(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstanceProcessModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceProcessModules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteInstanceProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteInstanceProcessModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteInstanceProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteInstanceProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteInstanceProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List module information for a process by its ID for a specific scaled-out instance in a web site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListInstanceProcessModules</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteInstanceProcessModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteInstanceProcessModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteInstanceProcessModuleWebAppsRestClient.CreateListInstanceProcessModulesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteInstanceProcessModuleResource(Client, ProcessModuleInfoData.DeserializeProcessModuleInfoData(e)), _siteInstanceProcessModuleWebAppsClientDiagnostics, Pipeline, "SiteInstanceProcessModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}/processes/{processId}/modules/{baseAddress}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetInstanceProcessModule</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        public virtual Response<bool> Exists(string baseAddress, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(baseAddress, nameof(baseAddress));

            using var scope = _siteInstanceProcessModuleWebAppsClientDiagnostics.CreateScope("SiteInstanceProcessModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteInstanceProcessModuleWebAppsRestClient.GetInstanceProcessModule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, baseAddress, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteInstanceProcessModuleResource> IEnumerable<SiteInstanceProcessModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteInstanceProcessModuleResource> IAsyncEnumerable<SiteInstanceProcessModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
