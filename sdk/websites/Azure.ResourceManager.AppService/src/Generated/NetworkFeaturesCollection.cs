// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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
    /// A class representing a collection of <see cref="NetworkFeaturesResource" /> and their operations.
    /// Each <see cref="NetworkFeaturesResource" /> in the collection will belong to the same instance of <see cref="SiteSlotResource" />.
    /// To get a <see cref="NetworkFeaturesCollection" /> instance call the GetNetworkFeatures method from an instance of <see cref="SiteSlotResource" />.
    /// </summary>
    public partial class NetworkFeaturesCollection : ArmCollection
    {
        private readonly ClientDiagnostics _networkFeaturesWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _networkFeaturesWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFeaturesCollection"/> class for mocking. </summary>
        protected NetworkFeaturesCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFeaturesCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFeaturesCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFeaturesWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", NetworkFeaturesResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFeaturesResource.ResourceType, out string networkFeaturesWebAppsApiVersion);
            _networkFeaturesWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFeaturesWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets all network features used by the app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<Response<NetworkFeaturesResource>> GetAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFeaturesWebAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFeaturesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all network features used by the app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<NetworkFeaturesResource> Get(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFeaturesWebAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFeaturesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(view, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<bool> Exists(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(view, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual async Task<Response<NetworkFeaturesResource>> GetIfExistsAsync(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFeaturesWebAppsRestClient.ListNetworkFeaturesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkFeaturesResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkFeaturesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkFeatures/{view}
        /// Operation Id: WebApps_ListNetworkFeaturesSlot
        /// </summary>
        /// <param name="view"> The type of view. Only &quot;summary&quot; is supported at this time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="view"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="view"/> is null. </exception>
        public virtual Response<NetworkFeaturesResource> GetIfExists(string view, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(view, nameof(view));

            using var scope = _networkFeaturesWebAppsClientDiagnostics.CreateScope("NetworkFeaturesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFeaturesWebAppsRestClient.ListNetworkFeaturesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, view, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkFeaturesResource>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkFeaturesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
