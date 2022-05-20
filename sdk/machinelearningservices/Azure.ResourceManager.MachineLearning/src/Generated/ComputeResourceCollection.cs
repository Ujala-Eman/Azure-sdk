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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="ComputeResource" /> and their operations.
    /// Each <see cref="ComputeResource" /> in the collection will belong to the same instance of <see cref="WorkspaceResource" />.
    /// To get a <see cref="ComputeResourceCollection" /> instance call the GetComputeResources method from an instance of <see cref="WorkspaceResource" />.
    /// </summary>
    public partial class ComputeResourceCollection : ArmCollection, IEnumerable<ComputeResource>, IAsyncEnumerable<ComputeResource>
    {
        private readonly ClientDiagnostics _computeResourceComputeClientDiagnostics;
        private readonly ComputeRestOperations _computeResourceComputeRestClient;

        /// <summary> Initializes a new instance of the <see cref="ComputeResourceCollection"/> class for mocking. </summary>
        protected ComputeResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ComputeResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ComputeResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _computeResourceComputeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ComputeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ComputeResource.ResourceType, out string computeResourceComputeApiVersion);
            _computeResourceComputeRestClient = new ComputeRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, computeResourceComputeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. If your intent is to create a new compute, do a GET first to verify that it does not exist yet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="data"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ComputeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string computeName, ComputeResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _computeResourceComputeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<ComputeResource>(new ComputeResourceOperationSource(Client), _computeResourceComputeClientDiagnostics, Pipeline, _computeResourceComputeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. If your intent is to create a new compute, do a GET first to verify that it does not exist yet.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="data"> Payload with Machine Learning compute definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ComputeResource> CreateOrUpdate(WaitUntil waitUntil, string computeName, ComputeResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _computeResourceComputeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<ComputeResource>(new ComputeResourceOperationSource(Client), _computeResourceComputeClientDiagnostics, Pipeline, _computeResourceComputeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets compute definition by its name. Any secrets (storage keys, service credentials, etc) are not returned - use &apos;keys&apos; nested resource to get them.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_Get
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual async Task<Response<ComputeResource>> GetAsync(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _computeResourceComputeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComputeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets compute definition by its name. Any secrets (storage keys, service credentials, etc) are not returned - use &apos;keys&apos; nested resource to get them.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_Get
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual Response<ComputeResource> Get(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _computeResourceComputeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComputeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets computes in specified workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes
        /// Operation Id: Compute_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ComputeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ComputeResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ComputeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _computeResourceComputeRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ComputeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _computeResourceComputeRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets computes in specified workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes
        /// Operation Id: Compute_List
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ComputeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ComputeResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            Page<ComputeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _computeResourceComputeRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ComputeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _computeResourceComputeRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComputeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_Get
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _computeResourceComputeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
        /// Operation Id: Compute_Get
        /// </summary>
        /// <param name="computeName"> Name of the Azure Machine Learning compute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="computeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="computeName"/> is null. </exception>
        public virtual Response<bool> Exists(string computeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(computeName, nameof(computeName));

            using var scope = _computeResourceComputeClientDiagnostics.CreateScope("ComputeResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _computeResourceComputeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, computeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ComputeResource> IEnumerable<ComputeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ComputeResource> IAsyncEnumerable<ComputeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
