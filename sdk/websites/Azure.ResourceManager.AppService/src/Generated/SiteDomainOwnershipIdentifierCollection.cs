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
    /// A class representing a collection of <see cref="SiteDomainOwnershipIdentifierResource"/> and their operations.
    /// Each <see cref="SiteDomainOwnershipIdentifierResource"/> in the collection will belong to the same instance of <see cref="WebSiteResource"/>.
    /// To get a <see cref="SiteDomainOwnershipIdentifierCollection"/> instance call the GetSiteDomainOwnershipIdentifiers method from an instance of <see cref="WebSiteResource"/>.
    /// </summary>
    public partial class SiteDomainOwnershipIdentifierCollection : ArmCollection, IEnumerable<SiteDomainOwnershipIdentifierResource>, IAsyncEnumerable<SiteDomainOwnershipIdentifierResource>
    {
        private readonly ClientDiagnostics _siteDomainOwnershipIdentifierWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteDomainOwnershipIdentifierWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifierCollection"/> class for mocking. </summary>
        protected SiteDomainOwnershipIdentifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDomainOwnershipIdentifierCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteDomainOwnershipIdentifierCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDomainOwnershipIdentifierWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteDomainOwnershipIdentifierResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteDomainOwnershipIdentifierResource.ResourceType, out string siteDomainOwnershipIdentifierWebAppsApiVersion);
            _siteDomainOwnershipIdentifierWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteDomainOwnershipIdentifierWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteDomainOwnershipIdentifierResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainOwnershipIdentifierName, AppServiceIdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteDomainOwnershipIdentifierResource>(Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateOrUpdateDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteDomainOwnershipIdentifierResource> CreateOrUpdate(WaitUntil waitUntil, string domainOwnershipIdentifierName, AppServiceIdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.CreateOrUpdateDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteDomainOwnershipIdentifierResource>(Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<SiteDomainOwnershipIdentifierResource>> GetAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<SiteDomainOwnershipIdentifierResource> Get(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Get");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Lists ownership identifiers for domain associated with web app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListDomainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteDomainOwnershipIdentifierResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteDomainOwnershipIdentifierResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDomainOwnershipIdentifierWebAppsRestClient.CreateListDomainOwnershipIdentifiersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDomainOwnershipIdentifierWebAppsRestClient.CreateListDomainOwnershipIdentifiersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteDomainOwnershipIdentifierResource(Client, AppServiceIdentifierData.DeserializeAppServiceIdentifierData(e)), _siteDomainOwnershipIdentifierWebAppsClientDiagnostics, Pipeline, "SiteDomainOwnershipIdentifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Lists ownership identifiers for domain associated with web app.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListDomainOwnershipIdentifiers</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteDomainOwnershipIdentifierResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteDomainOwnershipIdentifierResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteDomainOwnershipIdentifierWebAppsRestClient.CreateListDomainOwnershipIdentifiersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteDomainOwnershipIdentifierWebAppsRestClient.CreateListDomainOwnershipIdentifiersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteDomainOwnershipIdentifierResource(Client, AppServiceIdentifierData.DeserializeAppServiceIdentifierData(e)), _siteDomainOwnershipIdentifierWebAppsClientDiagnostics, Pipeline, "SiteDomainOwnershipIdentifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteDomainOwnershipIdentifierResource>> GetIfExistsAsync(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteDomainOwnershipIdentifierResource>(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetDomainOwnershipIdentifier</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteDomainOwnershipIdentifierResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainOwnershipIdentifierName"> Name of domain ownership identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainOwnershipIdentifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifierName"/> is null. </exception>
        public virtual NullableResponse<SiteDomainOwnershipIdentifierResource> GetIfExists(string domainOwnershipIdentifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainOwnershipIdentifierName, nameof(domainOwnershipIdentifierName));

            using var scope = _siteDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteDomainOwnershipIdentifierCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, domainOwnershipIdentifierName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteDomainOwnershipIdentifierResource>(response.GetRawResponse());
                return Response.FromValue(new SiteDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteDomainOwnershipIdentifierResource> IEnumerable<SiteDomainOwnershipIdentifierResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteDomainOwnershipIdentifierResource> IAsyncEnumerable<SiteDomainOwnershipIdentifierResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
