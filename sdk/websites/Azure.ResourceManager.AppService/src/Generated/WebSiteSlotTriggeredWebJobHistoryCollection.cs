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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> and their operations.
    /// Each <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> in the collection will belong to the same instance of <see cref="WebSiteSlotTriggeredWebJobResource"/>.
    /// To get a <see cref="WebSiteSlotTriggeredWebJobHistoryCollection"/> instance call the GetWebSiteSlotTriggeredWebJobHistories method from an instance of <see cref="WebSiteSlotTriggeredWebJobResource"/>.
    /// </summary>
    public partial class WebSiteSlotTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<WebSiteSlotTriggeredWebJobHistoryResource>, IAsyncEnumerable<WebSiteSlotTriggeredWebJobHistoryResource>
    {
        private readonly ClientDiagnostics _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected WebSiteSlotTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteSlotTriggeredWebJobHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteSlotTriggeredWebJobHistoryResource.ResourceType, out string webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteSlotTriggeredWebJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteSlotTriggeredWebJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<WebSiteSlotTriggeredWebJobHistoryResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<WebSiteSlotTriggeredWebJobHistoryResource> Get(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List a triggered web job's history for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteSlotTriggeredWebJobHistoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistorySlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistorySlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotTriggeredWebJobHistoryResource(Client, TriggeredJobHistoryData.DeserializeTriggeredJobHistoryData(e)), _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics, Pipeline, "WebSiteSlotTriggeredWebJobHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List a triggered web job's history for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteSlotTriggeredWebJobHistoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistorySlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistorySlotNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebSiteSlotTriggeredWebJobHistoryResource(Client, TriggeredJobHistoryData.DeserializeTriggeredJobHistoryData(e)), _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics, Pipeline, "WebSiteSlotTriggeredWebJobHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<WebSiteSlotTriggeredWebJobHistoryResource>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotTriggeredWebJobHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<WebSiteSlotTriggeredWebJobHistoryResource> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (id.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(id));
            }

            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebSiteSlotTriggeredWebJobHistoryResource>(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteSlotTriggeredWebJobHistoryResource> IEnumerable<WebSiteSlotTriggeredWebJobHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteSlotTriggeredWebJobHistoryResource> IAsyncEnumerable<WebSiteSlotTriggeredWebJobHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
