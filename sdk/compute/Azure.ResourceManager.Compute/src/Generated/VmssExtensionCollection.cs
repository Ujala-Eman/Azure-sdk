// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="VmssExtensionResource" /> and their operations.
    /// Each <see cref="VmssExtensionResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineScaleSetResource" />.
    /// To get a <see cref="VmssExtensionCollection" /> instance call the GetVmssExtensions method from an instance of <see cref="VirtualMachineScaleSetResource" />.
    /// </summary>
    public partial class VmssExtensionCollection : ArmCollection, IEnumerable<VmssExtensionResource>, IAsyncEnumerable<VmssExtensionResource>
    {
        private readonly ClientDiagnostics _vmssExtensionVmssExtensionsClientDiagnostics;
        private readonly VirtualMachineScaleSetExtensionsRestOperations _vmssExtensionVmssExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VmssExtensionCollection"/> class for mocking. </summary>
        protected VmssExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VmssExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VmssExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vmssExtensionVmssExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", VmssExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VmssExtensionResource.ResourceType, out string vmssExtensionVmssExtensionsApiVersion);
            _vmssExtensionVmssExtensionsRestClient = new VirtualMachineScaleSetExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vmssExtensionVmssExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update an extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="data"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VmssExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmssExtensionName, VmssExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vmssExtensionVmssExtensionsRestClient.CreateOrUpdateAsync(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VmssExtensionResource>(new VmssExtensionOperationSource(Client), _vmssExtensionVmssExtensionsClientDiagnostics, Pipeline, _vmssExtensionVmssExtensionsRestClient.CreateCreateOrUpdateRequest(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update an extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="data"> Parameters supplied to the Create VM scale set Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VmssExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string vmssExtensionName, VmssExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vmssExtensionVmssExtensionsRestClient.CreateOrUpdate(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, data, cancellationToken);
                var operation = new ComputeArmOperation<VmssExtensionResource>(new VmssExtensionOperationSource(Client), _vmssExtensionVmssExtensionsClientDiagnostics, Pipeline, _vmssExtensionVmssExtensionsRestClient.CreateCreateOrUpdateRequest(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual async Task<Response<VmssExtensionResource>> GetAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _vmssExtensionVmssExtensionsRestClient.GetAsync(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmssExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual Response<VmssExtensionResource> Get(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _vmssExtensionVmssExtensionsRestClient.Get(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VmssExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all extensions in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetExtensions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VmssExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VmssExtensionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VmssExtensionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vmssExtensionVmssExtensionsRestClient.ListAsync(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VmssExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VmssExtensionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vmssExtensionVmssExtensionsRestClient.ListNextPageAsync(nextLink, Id.Name, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VmssExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of all extensions in a VM scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions
        /// Operation Id: VirtualMachineScaleSetExtensions_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VmssExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VmssExtensionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VmssExtensionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vmssExtensionVmssExtensionsRestClient.List(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VmssExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VmssExtensionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vmssExtensionVmssExtensionsRestClient.ListNextPage(nextLink, Id.Name, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VmssExtensionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vmssExtensionVmssExtensionsRestClient.GetAsync(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/extensions/{vmssExtensionName}
        /// Operation Id: VirtualMachineScaleSetExtensions_Get
        /// </summary>
        /// <param name="vmssExtensionName"> The name of the VM scale set extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmssExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmssExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmssExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmssExtensionName, nameof(vmssExtensionName));

            using var scope = _vmssExtensionVmssExtensionsClientDiagnostics.CreateScope("VmssExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _vmssExtensionVmssExtensionsRestClient.Get(Id.Name, Id.SubscriptionId, Id.ResourceGroupName, vmssExtensionName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VmssExtensionResource> IEnumerable<VmssExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VmssExtensionResource> IAsyncEnumerable<VmssExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
