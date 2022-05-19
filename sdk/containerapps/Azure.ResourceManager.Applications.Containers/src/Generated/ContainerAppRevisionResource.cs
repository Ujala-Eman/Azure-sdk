// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Applications.Containers
{
    /// <summary>
    /// A Class representing a ContainerAppRevision along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ContainerAppRevisionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetContainerAppRevisionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppResource" /> using the GetContainerAppRevision method.
    /// </summary>
    public partial class ContainerAppRevisionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppRevisionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string containerAppName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppRevisionContainerAppsRevisionsClientDiagnostics;
        private readonly ContainerAppsRevisionsRestOperations _containerAppRevisionContainerAppsRevisionsRestClient;
        private readonly ContainerAppRevisionData _data;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppRevisionResource"/> class for mocking. </summary>
        protected ContainerAppRevisionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ContainerAppRevisionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppRevisionResource(ArmClient client, ContainerAppRevisionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppRevisionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppRevisionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppRevisionContainerAppsRevisionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Applications.Containers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppRevisionContainerAppsRevisionsApiVersion);
            _containerAppRevisionContainerAppsRevisionsRestClient = new ContainerAppsRevisionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppRevisionContainerAppsRevisionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/containerApps/revisions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppRevisionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ContainerAppReplicaResources in the ContainerAppRevision. </summary>
        /// <returns> An object representing collection of ContainerAppReplicaResources and their operations over a ContainerAppReplicaResource. </returns>
        public virtual ContainerAppReplicaCollection GetContainerAppReplicas()
        {
            return GetCachedClient(Client => new ContainerAppReplicaCollection(Client, Id));
        }

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{name}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="name"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppReplicaResource>> GetContainerAppReplicaAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppReplicas().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{name}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="name"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppReplicaResource> GetContainerAppReplica(string name, CancellationToken cancellationToken = default)
        {
            return GetContainerAppReplicas().Get(name, cancellationToken);
        }

        /// <summary>
        /// Get a revision of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}
        /// Operation Id: ContainerAppsRevisions_GetRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppRevisionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppRevisionContainerAppsRevisionsRestClient.GetRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a revision of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}
        /// Operation Id: ContainerAppsRevisions_GetRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppRevisionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppRevisionContainerAppsRevisionsRestClient.GetRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppRevisionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Activates a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/activate
        /// Operation Id: ContainerAppsRevisions_ActivateRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ActivateRevisionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.ActivateRevision");
            scope.Start();
            try
            {
                var response = await _containerAppRevisionContainerAppsRevisionsRestClient.ActivateRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Activates a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/activate
        /// Operation Id: ContainerAppsRevisions_ActivateRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ActivateRevision(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.ActivateRevision");
            scope.Start();
            try
            {
                var response = _containerAppRevisionContainerAppsRevisionsRestClient.ActivateRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deactivates a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/deactivate
        /// Operation Id: ContainerAppsRevisions_DeactivateRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeactivateRevisionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.DeactivateRevision");
            scope.Start();
            try
            {
                var response = await _containerAppRevisionContainerAppsRevisionsRestClient.DeactivateRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deactivates a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/deactivate
        /// Operation Id: ContainerAppsRevisions_DeactivateRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeactivateRevision(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.DeactivateRevision");
            scope.Start();
            try
            {
                var response = _containerAppRevisionContainerAppsRevisionsRestClient.DeactivateRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restarts a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/restart
        /// Operation Id: ContainerAppsRevisions_RestartRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RestartRevisionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.RestartRevision");
            scope.Start();
            try
            {
                var response = await _containerAppRevisionContainerAppsRevisionsRestClient.RestartRevisionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Restarts a revision for a Container App
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{name}/restart
        /// Operation Id: ContainerAppsRevisions_RestartRevision
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RestartRevision(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppRevisionContainerAppsRevisionsClientDiagnostics.CreateScope("ContainerAppRevisionResource.RestartRevision");
            scope.Start();
            try
            {
                var response = _containerAppRevisionContainerAppsRevisionsRestClient.RestartRevision(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
