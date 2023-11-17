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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkPublicIPResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkPublicIPResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkPublicIPCollection" /> instance call the GetWorkloadNetworkPublicIPs method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkPublicIPCollection : ArmCollection, IEnumerable<WorkloadNetworkPublicIPResource>, IAsyncEnumerable<WorkloadNetworkPublicIPResource>
    {
        private readonly ClientDiagnostics _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkPublicIPWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkPublicIPCollection"/> class for mocking. </summary>
        protected WorkloadNetworkPublicIPCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkPublicIPCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkPublicIPCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkPublicIPResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkPublicIPResource.ResourceType, out string workloadNetworkPublicIPWorkloadNetworksApiVersion);
            _workloadNetworkPublicIPWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkPublicIPWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Public IP Block by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreatePublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="data"> NSX Public IP Block. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkPublicIPResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicIPId, WorkloadNetworkPublicIPData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPublicIPWorkloadNetworksRestClient.CreatePublicIPAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkPublicIPResource>(new WorkloadNetworkPublicIPOperationSource(Client), _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateCreatePublicIPRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a Public IP Block by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreatePublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="data"> NSX Public IP Block. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkPublicIPResource> CreateOrUpdate(WaitUntil waitUntil, string publicIPId, WorkloadNetworkPublicIPData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkPublicIPWorkloadNetworksRestClient.CreatePublicIP(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkPublicIPResource>(new WorkloadNetworkPublicIPOperationSource(Client), _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateCreatePublicIPRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Public IP Block by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkPublicIPResource>> GetAsync(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIPAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPublicIPResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Public IP Block by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual Response<WorkloadNetworkPublicIPResource> Get(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIP(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPublicIPResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of Public IP Blocks in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListPublicIPs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkPublicIPResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkPublicIPResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateListPublicIPsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateListPublicIPsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkPublicIPResource(Client, WorkloadNetworkPublicIPData.DeserializeWorkloadNetworkPublicIPData(e)), _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkPublicIPCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of Public IP Blocks in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListPublicIPs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkPublicIPResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkPublicIPResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateListPublicIPsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkPublicIPWorkloadNetworksRestClient.CreateListPublicIPsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkPublicIPResource(Client, WorkloadNetworkPublicIPData.DeserializeWorkloadNetworkPublicIPData(e)), _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkPublicIPCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIPAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual Response<bool> Exists(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIP(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkloadNetworkPublicIPResource>> GetIfExistsAsync(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIPAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkPublicIPResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPublicIPResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/publicIPs/{publicIPId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetPublicIP</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPId"> NSX Public IP Block identifier. Generally the same as the Public IP Block's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIPId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPId"/> is null. </exception>
        public virtual NullableResponse<WorkloadNetworkPublicIPResource> GetIfExists(string publicIPId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIPId, nameof(publicIPId));

            using var scope = _workloadNetworkPublicIPWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkPublicIPCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadNetworkPublicIPWorkloadNetworksRestClient.GetPublicIP(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, publicIPId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkPublicIPResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkPublicIPResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkPublicIPResource> IEnumerable<WorkloadNetworkPublicIPResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkPublicIPResource> IAsyncEnumerable<WorkloadNetworkPublicIPResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
