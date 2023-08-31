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
    /// A class representing a collection of <see cref="WorkloadNetworkDhcpResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkDhcpResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkDhcpCollection" /> instance call the GetWorkloadNetworkDhcps method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkDhcpCollection : ArmCollection, IEnumerable<WorkloadNetworkDhcpResource>, IAsyncEnumerable<WorkloadNetworkDhcpResource>
    {
        private readonly ClientDiagnostics _workloadNetworkDhcpWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkDhcpWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDhcpCollection"/> class for mocking. </summary>
        protected WorkloadNetworkDhcpCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDhcpCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkDhcpCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkDhcpWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkDhcpResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkDhcpResource.ResourceType, out string workloadNetworkDhcpWorkloadNetworksApiVersion);
            _workloadNetworkDhcpWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkDhcpWorkloadNetworksApiVersion);
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
        /// Create dhcp by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="data"> NSX DHCP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkDhcpResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dhcpId, WorkloadNetworkDhcpData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDhcpWorkloadNetworksRestClient.CreateDhcpAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkDhcpResource>(new WorkloadNetworkDhcpOperationSource(Client), _workloadNetworkDhcpWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDhcpWorkloadNetworksRestClient.CreateCreateDhcpRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create dhcp by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="data"> NSX DHCP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkDhcpResource> CreateOrUpdate(WaitUntil waitUntil, string dhcpId, WorkloadNetworkDhcpData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkDhcpWorkloadNetworksRestClient.CreateDhcp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkDhcpResource>(new WorkloadNetworkDhcpOperationSource(Client), _workloadNetworkDhcpWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDhcpWorkloadNetworksRestClient.CreateCreateDhcpRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get dhcp by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkDhcpResource>> GetAsync(string dhcpId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDhcpWorkloadNetworksRestClient.GetDhcpAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDhcpResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get dhcp by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> is null. </exception>
        public virtual Response<WorkloadNetworkDhcpResource> Get(string dhcpId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkDhcpWorkloadNetworksRestClient.GetDhcp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDhcpResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List dhcp in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkDhcpResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkDhcpResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDhcpWorkloadNetworksRestClient.CreateListDhcpRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDhcpWorkloadNetworksRestClient.CreateListDhcpNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDhcpResource(Client, WorkloadNetworkDhcpData.DeserializeWorkloadNetworkDhcpData(e)), _workloadNetworkDhcpWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDhcpCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List dhcp in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkDhcpResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkDhcpResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDhcpWorkloadNetworksRestClient.CreateListDhcpRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDhcpWorkloadNetworksRestClient.CreateListDhcpNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDhcpResource(Client, WorkloadNetworkDhcpData.DeserializeWorkloadNetworkDhcpData(e)), _workloadNetworkDhcpWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDhcpCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dhcpId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDhcpWorkloadNetworksRestClient.GetDhcpAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dhcpConfigurations/{dhcpId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDhcp</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dhcpId"> NSX DHCP identifier. Generally the same as the DHCP display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dhcpId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dhcpId"/> is null. </exception>
        public virtual Response<bool> Exists(string dhcpId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dhcpId, nameof(dhcpId));

            using var scope = _workloadNetworkDhcpWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDhcpCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkDhcpWorkloadNetworksRestClient.GetDhcp(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dhcpId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkDhcpResource> IEnumerable<WorkloadNetworkDhcpResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkDhcpResource> IAsyncEnumerable<WorkloadNetworkDhcpResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
