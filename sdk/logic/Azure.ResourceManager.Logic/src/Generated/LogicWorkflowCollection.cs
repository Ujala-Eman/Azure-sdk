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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="LogicWorkflowResource" /> and their operations.
    /// Each <see cref="LogicWorkflowResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LogicWorkflowCollection" /> instance call the GetLogicWorkflows method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LogicWorkflowCollection : ArmCollection, IEnumerable<LogicWorkflowResource>, IAsyncEnumerable<LogicWorkflowResource>
    {
        private readonly ClientDiagnostics _logicWorkflowWorkflowsClientDiagnostics;
        private readonly WorkflowsRestOperations _logicWorkflowWorkflowsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowCollection"/> class for mocking. </summary>
        protected LogicWorkflowCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogicWorkflowCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowWorkflowsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", LogicWorkflowResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogicWorkflowResource.ResourceType, out string logicWorkflowWorkflowsApiVersion);
            _logicWorkflowWorkflowsRestClient = new WorkflowsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowWorkflowsApiVersion);
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
        /// Creates or updates a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="data"> The workflow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogicWorkflowResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workflowName, LogicWorkflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logicWorkflowWorkflowsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, workflowName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<LogicWorkflowResource>(Response.FromValue(new LogicWorkflowResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="data"> The workflow. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogicWorkflowResource> CreateOrUpdate(WaitUntil waitUntil, string workflowName, LogicWorkflowData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logicWorkflowWorkflowsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, workflowName, data, cancellationToken);
                var operation = new LogicArmOperation<LogicWorkflowResource>(Response.FromValue(new LogicWorkflowResource(Client, response), response.GetRawResponse()));
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
        /// Gets a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        public virtual async Task<Response<LogicWorkflowResource>> GetAsync(string workflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowWorkflowsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workflowName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        public virtual Response<LogicWorkflowResource> Get(string workflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowWorkflowsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workflowName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of workflows by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogicWorkflowResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogicWorkflowResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowWorkflowsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowWorkflowsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowResource(Client, LogicWorkflowData.DeserializeLogicWorkflowData(e)), _logicWorkflowWorkflowsClientDiagnostics, Pipeline, "LogicWorkflowCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of workflows by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: State, Trigger, and ReferencedResourceId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogicWorkflowResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogicWorkflowResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logicWorkflowWorkflowsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _logicWorkflowWorkflowsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LogicWorkflowResource(Client, LogicWorkflowData.DeserializeLogicWorkflowData(e)), _logicWorkflowWorkflowsClientDiagnostics, Pipeline, "LogicWorkflowCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logicWorkflowWorkflowsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workflowName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workflows_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workflowName"/> is null. </exception>
        public virtual Response<bool> Exists(string workflowName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var scope = _logicWorkflowWorkflowsClientDiagnostics.CreateScope("LogicWorkflowCollection.Exists");
            scope.Start();
            try
            {
                var response = _logicWorkflowWorkflowsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workflowName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogicWorkflowResource> IEnumerable<LogicWorkflowResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogicWorkflowResource> IAsyncEnumerable<LogicWorkflowResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
