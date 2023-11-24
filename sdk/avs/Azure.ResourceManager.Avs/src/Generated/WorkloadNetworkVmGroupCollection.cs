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
    /// A class representing a collection of <see cref="WorkloadNetworkVmGroupResource"/> and their operations.
    /// Each <see cref="WorkloadNetworkVmGroupResource"/> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource"/>.
    /// To get a <see cref="WorkloadNetworkVmGroupCollection"/> instance call the GetWorkloadNetworkVmGroups method from an instance of <see cref="AvsPrivateCloudResource"/>.
    /// </summary>
    public partial class WorkloadNetworkVmGroupCollection : ArmCollection, IEnumerable<WorkloadNetworkVmGroupResource>, IAsyncEnumerable<WorkloadNetworkVmGroupResource>
    {
        private readonly ClientDiagnostics _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkVmGroupWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVmGroupCollection"/> class for mocking. </summary>
        protected WorkloadNetworkVmGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkVmGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkVmGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkVmGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkVmGroupResource.ResourceType, out string workloadNetworkVmGroupWorkloadNetworksApiVersion);
            _workloadNetworkVmGroupWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkVmGroupWorkloadNetworksApiVersion);
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
        /// Create a vm group by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="data"> NSX VM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkVmGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmGroupId, WorkloadNetworkVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkVmGroupResource>(new WorkloadNetworkVmGroupOperationSource(Client), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateCreateVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a vm group by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="data"> NSX VM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkVmGroupResource> CreateOrUpdate(WaitUntil waitUntil, string vmGroupId, WorkloadNetworkVmGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkVmGroupResource>(new WorkloadNetworkVmGroupOperationSource(Client), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateCreateVmGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a vm group by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkVmGroupResource>> GetAsync(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a vm group by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual Response<WorkloadNetworkVmGroupResource> Get(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of vm groups in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListVMGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkVmGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkVmGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateListVmGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateListVmGroupsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkVmGroupResource(Client, WorkloadNetworkVmGroupData.DeserializeWorkloadNetworkVmGroupData(e)), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkVmGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of vm groups in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListVMGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkVmGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkVmGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateListVmGroupsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkVmGroupWorkloadNetworksRestClient.CreateListVmGroupsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkVmGroupResource(Client, WorkloadNetworkVmGroupData.DeserializeWorkloadNetworkVmGroupData(e)), _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkVmGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual Response<bool> Exists(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkloadNetworkVmGroupResource>> GetIfExistsAsync(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkVmGroupResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/vmGroups/{vmGroupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetVMGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmGroupId"> NSX VM Group identifier. Generally the same as the VM Group's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmGroupId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmGroupId"/> is null. </exception>
        public virtual NullableResponse<WorkloadNetworkVmGroupResource> GetIfExists(string vmGroupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmGroupId, nameof(vmGroupId));

            using var scope = _workloadNetworkVmGroupWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkVmGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadNetworkVmGroupWorkloadNetworksRestClient.GetVmGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmGroupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkloadNetworkVmGroupResource>(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkVmGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkVmGroupResource> IEnumerable<WorkloadNetworkVmGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkVmGroupResource> IAsyncEnumerable<WorkloadNetworkVmGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
