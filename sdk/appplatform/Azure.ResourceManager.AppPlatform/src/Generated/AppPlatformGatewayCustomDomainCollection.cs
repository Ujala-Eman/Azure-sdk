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
    /// A class representing a collection of <see cref="AppPlatformGatewayCustomDomainResource" /> and their operations.
    /// Each <see cref="AppPlatformGatewayCustomDomainResource" /> in the collection will belong to the same instance of <see cref="AppPlatformGatewayResource" />.
    /// To get an <see cref="AppPlatformGatewayCustomDomainCollection" /> instance call the GetAppPlatformGatewayCustomDomains method from an instance of <see cref="AppPlatformGatewayResource" />.
    /// </summary>
    public partial class AppPlatformGatewayCustomDomainCollection : ArmCollection, IEnumerable<AppPlatformGatewayCustomDomainResource>, IAsyncEnumerable<AppPlatformGatewayCustomDomainResource>
    {
        private readonly ClientDiagnostics _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics;
        private readonly GatewayCustomDomainsRestOperations _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformGatewayCustomDomainCollection"/> class for mocking. </summary>
        protected AppPlatformGatewayCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformGatewayCustomDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformGatewayCustomDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformGatewayCustomDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformGatewayCustomDomainResource.ResourceType, out string appPlatformGatewayCustomDomainGatewayCustomDomainsApiVersion);
            _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient = new GatewayCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformGatewayCustomDomainGatewayCustomDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the Spring Cloud Gateway custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="data"> The gateway custom domain resource for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppPlatformGatewayCustomDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string domainName, AppPlatformGatewayCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<AppPlatformGatewayCustomDomainResource>(new AppPlatformGatewayCustomDomainOperationSource(Client), _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics, Pipeline, _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update the Spring Cloud Gateway custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="data"> The gateway custom domain resource for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppPlatformGatewayCustomDomainResource> CreateOrUpdate(WaitUntil waitUntil, string domainName, AppPlatformGatewayCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data, cancellationToken);
                var operation = new AppPlatformArmOperation<AppPlatformGatewayCustomDomainResource>(new AppPlatformGatewayCustomDomainOperationSource(Client), _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics, Pipeline, _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the Spring Cloud Gateway custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformGatewayCustomDomainResource>> GetAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Spring Cloud Gateway custom domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<AppPlatformGatewayCustomDomainResource> Get(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handle requests to list all Spring Cloud Gateway custom domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformGatewayCustomDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformGatewayCustomDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformGatewayCustomDomainResource(Client, AppPlatformGatewayCustomDomainData.DeserializeAppPlatformGatewayCustomDomainData(e)), _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics, Pipeline, "AppPlatformGatewayCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Handle requests to list all Spring Cloud Gateway custom domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformGatewayCustomDomainResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformGatewayCustomDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AppPlatformGatewayCustomDomainResource(Client, AppPlatformGatewayCustomDomainData.DeserializeAppPlatformGatewayCustomDomainData(e)), _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics, Pipeline, "AppPlatformGatewayCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual Response<bool> Exists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppPlatformGatewayCustomDomainResource>> GetIfExistsAsync(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformGatewayCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/gateways/{gatewayName}/domains/{domainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCustomDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="domainName"> The name of the Spring Cloud Gateway custom domain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="domainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public virtual NullableResponse<AppPlatformGatewayCustomDomainResource> GetIfExists(string domainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));

            using var scope = _appPlatformGatewayCustomDomainGatewayCustomDomainsClientDiagnostics.CreateScope("AppPlatformGatewayCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appPlatformGatewayCustomDomainGatewayCustomDomainsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppPlatformGatewayCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new AppPlatformGatewayCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformGatewayCustomDomainResource> IEnumerable<AppPlatformGatewayCustomDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformGatewayCustomDomainResource> IAsyncEnumerable<AppPlatformGatewayCustomDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
