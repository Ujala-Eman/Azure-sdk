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

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkspaceResource" /> and their operations.
    /// Each <see cref="WorkspaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="WorkspaceResourceCollection" /> instance call the GetWorkspaceResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class WorkspaceResourceCollection : ArmCollection, IEnumerable<WorkspaceResource>, IAsyncEnumerable<WorkspaceResource>
    {
        private readonly ClientDiagnostics _workspaceResourceWorkspacesClientDiagnostics;
        private readonly WorkspacesRestOperations _workspaceResourceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceResourceCollection"/> class for mocking. </summary>
        protected WorkspaceResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspaceResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkspaceResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspaceResourceWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DefenderEasm", WorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkspaceResource.ResourceType, out string workspaceResourceWorkspacesApiVersion);
            _workspaceResourceWorkspacesRestClient = new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspaceResourceWorkspacesApiVersion);
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
        /// Create or update a Workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateAndUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="data"> Workspace details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, WorkspaceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspaceResourceWorkspacesRestClient.CreateAndUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DefenderEasmArmOperation<WorkspaceResource>(new WorkspaceResourceOperationSource(Client), _workspaceResourceWorkspacesClientDiagnostics, Pipeline, _workspaceResourceWorkspacesRestClient.CreateCreateAndUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a Workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateAndUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="data"> Workspace details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, WorkspaceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspaceResourceWorkspacesRestClient.CreateAndUpdate(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken);
                var operation = new DefenderEasmArmOperation<WorkspaceResource>(new WorkspaceResourceOperationSource(Client), _workspaceResourceWorkspacesClientDiagnostics, Pipeline, _workspaceResourceWorkspacesRestClient.CreateCreateAndUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns a workspace with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<WorkspaceResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _workspaceResourceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a workspace with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<WorkspaceResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _workspaceResourceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of workspaces in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workspaceResourceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workspaceResourceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkspaceResource(Client, WorkspaceResourceData.DeserializeWorkspaceResourceData(e)), _workspaceResourceWorkspacesClientDiagnostics, Pipeline, "WorkspaceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of workspaces in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workspaceResourceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workspaceResourceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkspaceResource(Client, WorkspaceResourceData.DeserializeWorkspaceResourceData(e)), _workspaceResourceWorkspacesClientDiagnostics, Pipeline, "WorkspaceResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workspaceResourceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Easm/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the Workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _workspaceResourceWorkspacesClientDiagnostics.CreateScope("WorkspaceResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _workspaceResourceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkspaceResource> IEnumerable<WorkspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkspaceResource> IAsyncEnumerable<WorkspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
