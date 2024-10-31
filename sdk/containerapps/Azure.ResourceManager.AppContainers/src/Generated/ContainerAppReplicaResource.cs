// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A Class representing a ContainerAppReplica along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ContainerAppReplicaResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetContainerAppReplicaResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerAppRevisionResource"/> using the GetContainerAppReplica method.
    /// </summary>
    public partial class ContainerAppReplicaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ContainerAppReplicaResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="containerAppName"> The containerAppName. </param>
        /// <param name="revisionName"> The revisionName. </param>
        /// <param name="replicaName"> The replicaName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string containerAppName, string revisionName, string replicaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics;
        private readonly ContainerAppsRevisionReplicasRestOperations _containerAppReplicaContainerAppsRevisionReplicasRestClient;
        private readonly ContainerAppReplicaData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.App/containerApps/revisions/replicas";

        /// <summary> Initializes a new instance of the <see cref="ContainerAppReplicaResource"/> class for mocking. </summary>
        protected ContainerAppReplicaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppReplicaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ContainerAppReplicaResource(ArmClient client, ContainerAppReplicaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppReplicaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerAppReplicaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string containerAppReplicaContainerAppsRevisionReplicasApiVersion);
            _containerAppReplicaContainerAppsRevisionReplicasRestClient = new ContainerAppsRevisionReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppReplicaContainerAppsRevisionReplicasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ContainerAppReplicaData Data
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

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsRevisionReplicas_GetReplica</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerAppReplicaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaResource.Get");
            scope.Start();
            try
            {
                var response = await _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplicaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsRevisionReplicas_GetReplica</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerAppReplicaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaResource.Get");
            scope.Start();
            try
            {
                var response = _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplica(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
