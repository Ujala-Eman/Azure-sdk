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

namespace Azure.ResourceManager.SpringAppDiscovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SpringBootServerResource"/> and their operations.
    /// Each <see cref="SpringBootServerResource"/> in the collection will belong to the same instance of <see cref="SpringBootSiteResource"/>.
    /// To get a <see cref="SpringBootServerCollection"/> instance call the GetSpringBootServers method from an instance of <see cref="SpringBootSiteResource"/>.
    /// </summary>
    public partial class SpringBootServerCollection : ArmCollection, IEnumerable<SpringBootServerResource>, IAsyncEnumerable<SpringBootServerResource>
    {
        private readonly ClientDiagnostics _springBootServerspringbootserversClientDiagnostics;
        private readonly SpringbootserversRestOperations _springBootServerspringbootserversRestClient;

        /// <summary> Initializes a new instance of the <see cref="SpringBootServerCollection"/> class for mocking. </summary>
        protected SpringBootServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SpringBootServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SpringBootServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _springBootServerspringbootserversClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SpringAppDiscovery", SpringBootServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SpringBootServerResource.ResourceType, out string springBootServerspringbootserversApiVersion);
            _springBootServerspringbootserversRestClient = new SpringbootserversRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, springBootServerspringbootserversApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SpringBootSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SpringBootSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create springbootservers resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="data"> Create a springbootservers payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SpringBootServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string springbootserversName, SpringBootServerData data, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _springBootServerspringbootserversRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, data, cancellationToken).ConfigureAwait(false);
                var uri = _springBootServerspringbootserversRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SpringAppDiscoveryArmOperation<SpringBootServerResource>(Response.FromValue(new SpringBootServerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create springbootservers resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="data"> Create a springbootservers payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SpringBootServerResource> CreateOrUpdate(WaitUntil waitUntil, string springbootserversName, SpringBootServerData data, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _springBootServerspringbootserversRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, data, cancellationToken);
                var uri = _springBootServerspringbootserversRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SpringAppDiscoveryArmOperation<SpringBootServerResource>(Response.FromValue(new SpringBootServerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// List springbootservers resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual async Task<Response<SpringBootServerResource>> GetAsync(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _springBootServerspringbootserversRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpringBootServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List springbootservers resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual Response<SpringBootServerResource> Get(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.Get");
            scope.Start();
            try
            {
                var response = _springBootServerspringbootserversRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SpringBootServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List springbootservers resource by resourceGroup
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpringBootServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SpringBootServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _springBootServerspringbootserversRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _springBootServerspringbootserversRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SpringBootServerResource(Client, SpringBootServerData.DeserializeSpringBootServerData(e)), _springBootServerspringbootserversClientDiagnostics, Pipeline, "SpringBootServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List springbootservers resource by resourceGroup
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpringBootServerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SpringBootServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _springBootServerspringbootserversRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _springBootServerspringbootserversRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SpringBootServerResource(Client, SpringBootServerData.DeserializeSpringBootServerData(e)), _springBootServerspringbootserversClientDiagnostics, Pipeline, "SpringBootServerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _springBootServerspringbootserversRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual Response<bool> Exists(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _springBootServerspringbootserversRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual async Task<NullableResponse<SpringBootServerResource>> GetIfExistsAsync(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _springBootServerspringbootserversRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SpringBootServerResource>(response.GetRawResponse());
                return Response.FromValue(new SpringBootServerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OffAzureSpringBoot/springbootsites/{siteName}/springbootservers/{springbootserversName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>springbootservers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SpringBootServerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="springbootserversName"> The springbootservers name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="springbootserversName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="springbootserversName"/> is null. </exception>
        public virtual NullableResponse<SpringBootServerResource> GetIfExists(string springbootserversName, CancellationToken cancellationToken = default)
        {
            if (springbootserversName == null)
            {
                throw new ArgumentNullException(nameof(springbootserversName));
            }
            if (springbootserversName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(springbootserversName));
            }

            using var scope = _springBootServerspringbootserversClientDiagnostics.CreateScope("SpringBootServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _springBootServerspringbootserversRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, springbootserversName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SpringBootServerResource>(response.GetRawResponse());
                return Response.FromValue(new SpringBootServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SpringBootServerResource> IEnumerable<SpringBootServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SpringBootServerResource> IAsyncEnumerable<SpringBootServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
