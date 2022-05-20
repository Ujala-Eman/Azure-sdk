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
    /// A class representing a collection of <see cref="BatchDeploymentDataResource" /> and their operations.
    /// Each <see cref="BatchDeploymentDataResource" /> in the collection will belong to the same instance of <see cref="BatchEndpointDataResource" />.
    /// To get a <see cref="BatchDeploymentDataCollection" /> instance call the GetBatchDeploymentData method from an instance of <see cref="BatchEndpointDataResource" />.
    /// </summary>
    public partial class BatchDeploymentDataCollection : ArmCollection, IEnumerable<BatchDeploymentDataResource>, IAsyncEnumerable<BatchDeploymentDataResource>
    {
        private readonly ClientDiagnostics _batchDeploymentDataBatchDeploymentsClientDiagnostics;
        private readonly BatchDeploymentsRestOperations _batchDeploymentDataBatchDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BatchDeploymentDataCollection"/> class for mocking. </summary>
        protected BatchDeploymentDataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchDeploymentDataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BatchDeploymentDataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchDeploymentDataBatchDeploymentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", BatchDeploymentDataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BatchDeploymentDataResource.ResourceType, out string batchDeploymentDataBatchDeploymentsApiVersion);
            _batchDeploymentDataBatchDeploymentsRestClient = new BatchDeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchDeploymentDataBatchDeploymentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchEndpointDataResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchEndpointDataResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates/updates a batch inference deployment (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="data"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BatchDeploymentDataResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentName, BatchDeploymentDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _batchDeploymentDataBatchDeploymentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<BatchDeploymentDataResource>(new BatchDeploymentDataOperationSource(Client), _batchDeploymentDataBatchDeploymentsClientDiagnostics, Pipeline, _batchDeploymentDataBatchDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates/updates a batch inference deployment (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="data"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BatchDeploymentDataResource> CreateOrUpdate(WaitUntil waitUntil, string deploymentName, BatchDeploymentDataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _batchDeploymentDataBatchDeploymentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<BatchDeploymentDataResource>(new BatchDeploymentDataOperationSource(Client), _batchDeploymentDataBatchDeploymentsClientDiagnostics, Pipeline, _batchDeploymentDataBatchDeploymentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a batch inference deployment by id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_Get
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<BatchDeploymentDataResource>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.Get");
            scope.Start();
            try
            {
                var response = await _batchDeploymentDataBatchDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchDeploymentDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a batch inference deployment by id.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_Get
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<BatchDeploymentDataResource> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.Get");
            scope.Start();
            try
            {
                var response = _batchDeploymentDataBatchDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchDeploymentDataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Batch inference deployments in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments
        /// Operation Id: BatchDeployments_List
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchDeploymentDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BatchDeploymentDataResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BatchDeploymentDataResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _batchDeploymentDataBatchDeploymentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BatchDeploymentDataResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _batchDeploymentDataBatchDeploymentsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists Batch inference deployments in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments
        /// Operation Id: BatchDeployments_List
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchDeploymentDataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BatchDeploymentDataResource> GetAll(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<BatchDeploymentDataResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _batchDeploymentDataBatchDeploymentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BatchDeploymentDataResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _batchDeploymentDataBatchDeploymentsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentDataResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_Get
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _batchDeploymentDataBatchDeploymentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}
        /// Operation Id: BatchDeployments_Get
        /// </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentName, nameof(deploymentName));

            using var scope = _batchDeploymentDataBatchDeploymentsClientDiagnostics.CreateScope("BatchDeploymentDataCollection.Exists");
            scope.Start();
            try
            {
                var response = _batchDeploymentDataBatchDeploymentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BatchDeploymentDataResource> IEnumerable<BatchDeploymentDataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BatchDeploymentDataResource> IAsyncEnumerable<BatchDeploymentDataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
