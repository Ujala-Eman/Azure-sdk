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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputePrivateLinkResource"/> and their operations.
    /// Each <see cref="HybridComputePrivateLinkResource"/> in the collection will belong to the same instance of <see cref="HybridComputePrivateLinkScopeResource"/>.
    /// To get a <see cref="HybridComputePrivateLinkResourceCollection"/> instance call the GetHybridComputePrivateLinkResources method from an instance of <see cref="HybridComputePrivateLinkScopeResource"/>.
    /// </summary>
    public partial class HybridComputePrivateLinkResourceCollection : ArmCollection, IEnumerable<HybridComputePrivateLinkResource>, IAsyncEnumerable<HybridComputePrivateLinkResource>
    {
        private readonly ClientDiagnostics _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridComputePrivateLinkResourceCollection"/> class for mocking. </summary>
        protected HybridComputePrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputePrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridComputePrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputePrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputePrivateLinkResource.ResourceType, out string hybridComputePrivateLinkResourcePrivateLinkResourcesApiVersion);
            _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputePrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HybridComputePrivateLinkScopeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HybridComputePrivateLinkScopeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<HybridComputePrivateLinkResource>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<HybridComputePrivateLinkResource> Get(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByPrivateLinkScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputePrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByPrivateLinkScopeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByPrivateLinkScopeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkResource(Client, HybridComputePrivateLinkResourceData.DeserializeHybridComputePrivateLinkResourceData(e)), _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "HybridComputePrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the private link resources that need to be created for a Azure Monitor PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_ListByPrivateLinkScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputePrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByPrivateLinkScopeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.CreateListByPrivateLinkScopeNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkResource(Client, HybridComputePrivateLinkResourceData.DeserializeHybridComputePrivateLinkResourceData(e)), _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics, Pipeline, "HybridComputePrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> Exists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridComputePrivateLinkResource>> GetIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputePrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}/privateLinkResources/{groupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResources_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-10</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputePrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual NullableResponse<HybridComputePrivateLinkResource> GetIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var scope = _hybridComputePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("HybridComputePrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputePrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputePrivateLinkResource> IEnumerable<HybridComputePrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputePrivateLinkResource> IAsyncEnumerable<HybridComputePrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
