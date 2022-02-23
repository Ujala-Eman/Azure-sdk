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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of WorkspaceConnection and their operations over its parent. </summary>
    public partial class WorkspaceConnectionCollection : ArmCollection, IEnumerable<WorkspaceConnection>, IAsyncEnumerable<WorkspaceConnection>
    {
        private readonly ClientDiagnostics _workspaceConnectionClientDiagnostics;
        private readonly WorkspaceConnectionsRestOperations _workspaceConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceConnectionCollection"/> class for mocking. </summary>
        protected WorkspaceConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspaceConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkspaceConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspaceConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", WorkspaceConnection.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(WorkspaceConnection.ResourceType, out string workspaceConnectionApiVersion);
            _workspaceConnectionRestClient = new WorkspaceConnectionsRestOperations(_workspaceConnectionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, workspaceConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Workspace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Workspace.ResourceType), nameof(id));
        }

        /// <summary>
        /// Add a new workspace connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="parameters"> The object for creating or updating a new workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<WorkspaceConnection>> CreateOrUpdateAsync(bool waitForCompletion, string connectionName, WorkspaceConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningServicesArmOperation<WorkspaceConnection>(Response.FromValue(new WorkspaceConnection(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Add a new workspace connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="parameters"> The object for creating or updating a new workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<WorkspaceConnection> CreateOrUpdate(bool waitForCompletion, string connectionName, WorkspaceConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workspaceConnectionRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, parameters, cancellationToken);
                var operation = new MachineLearningServicesArmOperation<WorkspaceConnection>(Response.FromValue(new WorkspaceConnection(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Get the detail of a workspace connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<WorkspaceConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _workspaceConnectionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WorkspaceConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the detail of a workspace connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<WorkspaceConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _workspaceConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw _workspaceConnectionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspaceConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all connections under a AML workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections
        /// Operation Id: WorkspaceConnections_List
        /// </summary>
        /// <param name="target"> Target of the workspace connection. </param>
        /// <param name="category"> Category of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkspaceConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkspaceConnection> GetAllAsync(string target = null, string category = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkspaceConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workspaceConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, target, category, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspaceConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all connections under a AML workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections
        /// Operation Id: WorkspaceConnections_List
        /// </summary>
        /// <param name="target"> Target of the workspace connection. </param>
        /// <param name="category"> Category of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkspaceConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkspaceConnection> GetAll(string target = null, string category = null, CancellationToken cancellationToken = default)
        {
            Page<WorkspaceConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workspaceConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, target, category, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkspaceConnection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public async virtual Task<Response<WorkspaceConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<WorkspaceConnection>(null, response.GetRawResponse());
                return Response.FromValue(new WorkspaceConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="connectionName"> Friendly name of the workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<WorkspaceConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _workspaceConnectionClientDiagnostics.CreateScope("WorkspaceConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workspaceConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<WorkspaceConnection>(null, response.GetRawResponse());
                return Response.FromValue(new WorkspaceConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkspaceConnection> IEnumerable<WorkspaceConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkspaceConnection> IAsyncEnumerable<WorkspaceConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
