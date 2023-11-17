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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="CdnOriginGroupResource" /> and their operations.
    /// Each <see cref="CdnOriginGroupResource" /> in the collection will belong to the same instance of <see cref="CdnEndpointResource" />.
    /// To get a <see cref="CdnOriginGroupCollection" /> instance call the GetCdnOriginGroups method from an instance of <see cref="CdnEndpointResource" />.
    /// </summary>
    public partial class CdnOriginGroupCollection : ArmCollection, IEnumerable<CdnOriginGroupResource>, IAsyncEnumerable<CdnOriginGroupResource>
    {
        private readonly ClientDiagnostics _cdnOriginGroupClientDiagnostics;
        private readonly CdnOriginGroupsRestOperations _cdnOriginGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginGroupCollection"/> class for mocking. </summary>
        protected CdnOriginGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOriginGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CdnOriginGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", CdnOriginGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CdnOriginGroupResource.ResourceType, out string cdnOriginGroupApiVersion);
            _cdnOriginGroupRestClient = new CdnOriginGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cdnOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CdnEndpointResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CdnEndpointResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new origin group within the specified endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CdnOriginGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string originGroupName, CdnOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<CdnOriginGroupResource>(new CdnOriginGroupOperationSource(Client), _cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new origin group within the specified endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CdnOriginGroupResource> CreateOrUpdate(WaitUntil waitUntil, string originGroupName, CdnOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, data, cancellationToken);
                var operation = new CdnArmOperation<CdnOriginGroupResource>(new CdnOriginGroupOperationSource(Client), _cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual async Task<Response<CdnOriginGroupResource>> GetAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<CdnOriginGroupResource> Get(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the existing origin groups within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnOriginGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnOriginGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnOriginGroupRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnOriginGroupRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new CdnOriginGroupResource(Client, CdnOriginGroupData.DeserializeCdnOriginGroupData(e)), _cdnOriginGroupClientDiagnostics, Pipeline, "CdnOriginGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the existing origin groups within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnOriginGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnOriginGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnOriginGroupRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnOriginGroupRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new CdnOriginGroupResource(Client, CdnOriginGroupData.DeserializeCdnOriginGroupData(e)), _cdnOriginGroupClientDiagnostics, Pipeline, "CdnOriginGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<CdnOriginGroupResource>> GetIfExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CdnOriginGroupResource>(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual NullableResponse<CdnOriginGroupResource> GetIfExists(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CdnOriginGroupResource>(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CdnOriginGroupResource> IEnumerable<CdnOriginGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnOriginGroupResource> IAsyncEnumerable<CdnOriginGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
