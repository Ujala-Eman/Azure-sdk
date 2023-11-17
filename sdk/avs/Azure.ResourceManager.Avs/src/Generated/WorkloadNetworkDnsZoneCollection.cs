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
    /// A class representing a collection of <see cref="WorkloadNetworkDnsZoneResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkDnsZoneResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkDnsZoneCollection" /> instance call the GetWorkloadNetworkDnsZones method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkDnsZoneCollection : ArmCollection, IEnumerable<WorkloadNetworkDnsZoneResource>, IAsyncEnumerable<WorkloadNetworkDnsZoneResource>
    {
        private readonly ClientDiagnostics _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkDnsZoneWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDnsZoneCollection"/> class for mocking. </summary>
        protected WorkloadNetworkDnsZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDnsZoneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkDnsZoneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkDnsZoneResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkDnsZoneResource.ResourceType, out string workloadNetworkDnsZoneWorkloadNetworksApiVersion);
            _workloadNetworkDnsZoneWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkDnsZoneWorkloadNetworksApiVersion);
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
        /// Create a DNS zone by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="data"> NSX DNS Zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkDnsZoneResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dnsZoneId, WorkloadNetworkDnsZoneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateDnsZoneAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkDnsZoneResource>(new WorkloadNetworkDnsZoneOperationSource(Client), _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateCreateDnsZoneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a DNS zone by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="data"> NSX DNS Zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkDnsZoneResource> CreateOrUpdate(WaitUntil waitUntil, string dnsZoneId, WorkloadNetworkDnsZoneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateDnsZone(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkDnsZoneResource>(new WorkloadNetworkDnsZoneOperationSource(Client), _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateCreateDnsZoneRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a DNS zone by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkDnsZoneResource>> GetAsync(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZoneAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DNS zone by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual Response<WorkloadNetworkDnsZoneResource> Get(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZone(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of DNS zones in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDnsZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkDnsZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkDnsZoneResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateListDnsZonesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateListDnsZonesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDnsZoneResource(Client, WorkloadNetworkDnsZoneData.DeserializeWorkloadNetworkDnsZoneData(e)), _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of DNS zones in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDnsZones</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkDnsZoneResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkDnsZoneResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateListDnsZonesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDnsZoneWorkloadNetworksRestClient.CreateListDnsZonesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDnsZoneResource(Client, WorkloadNetworkDnsZoneData.DeserializeWorkloadNetworkDnsZoneData(e)), _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDnsZoneCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZoneAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZone(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkloadNetworkDnsZoneResource>> GetIfExistsAsync(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZoneAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkDnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsZoneResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsZones/{dnsZoneId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsZone</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsZoneId"> NSX DNS Zone identifier. Generally the same as the DNS Zone's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsZoneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsZoneId"/> is null. </exception>
        public virtual NullableResponse<WorkloadNetworkDnsZoneResource> GetIfExists(string dnsZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsZoneId, nameof(dnsZoneId));

            using var scope = _workloadNetworkDnsZoneWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsZoneWorkloadNetworksRestClient.GetDnsZone(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsZoneId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkDnsZoneResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkDnsZoneResource> IEnumerable<WorkloadNetworkDnsZoneResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkDnsZoneResource> IAsyncEnumerable<WorkloadNetworkDnsZoneResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
