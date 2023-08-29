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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevCenterResource" /> and their operations.
    /// Each <see cref="DevCenterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DevCenterCollection" /> instance call the GetDevCenters method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DevCenterCollection : ArmCollection, IEnumerable<DevCenterResource>, IAsyncEnumerable<DevCenterResource>
    {
        private readonly ClientDiagnostics _devCenterClientDiagnostics;
        private readonly DevCentersRestOperations _devCenterRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevCenterCollection"/> class for mocking. </summary>
        protected DevCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevCenterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevCenterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devCenterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", DevCenterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevCenterResource.ResourceType, out string devCenterApiVersion);
            _devCenterRestClient = new DevCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devCenterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a devcenter resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="data"> Represents a devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevCenterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string devCenterName, DevCenterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devCenterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<DevCenterResource>(new DevCenterOperationSource(Client), _devCenterClientDiagnostics, Pipeline, _devCenterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a devcenter resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="data"> Represents a devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevCenterResource> CreateOrUpdate(WaitUntil waitUntil, string devCenterName, DevCenterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devCenterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, data, cancellationToken);
                var operation = new DevCenterArmOperation<DevCenterResource>(new DevCenterOperationSource(Client), _devCenterClientDiagnostics, Pipeline, _devCenterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        public virtual async Task<Response<DevCenterResource>> GetAsync(string devCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _devCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a devcenter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        public virtual Response<DevCenterResource> Get(string devCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _devCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all devcenters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevCenterResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterResource(Client, DevCenterData.DeserializeDevCenterData(e)), _devCenterClientDiagnostics, Pipeline, "DevCenterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all devcenters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevCenterResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devCenterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devCenterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevCenterResource(Client, DevCenterData.DeserializeDevCenterData(e)), _devCenterClientDiagnostics, Pipeline, "DevCenterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string devCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devCenterName"> The name of the devcenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devCenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string devCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devCenterName, nameof(devCenterName));

            using var scope = _devCenterClientDiagnostics.CreateScope("DevCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = _devCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, devCenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevCenterResource> IEnumerable<DevCenterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevCenterResource> IAsyncEnumerable<DevCenterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
