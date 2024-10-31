// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAppContainersResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersResourceGroupResource"/> class for mocking. </summary>
        protected MockableAppContainersResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppContainersResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppContainersResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of BuilderResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of BuilderResources and their operations over a BuilderResource. </returns>
        public virtual BuilderResourceCollection GetBuilderResources()
        {
            return GetCachedClient(client => new BuilderResourceCollection(client, Id));
        }

        /// <summary>
        /// Get a BuilderResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Builders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BuilderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BuilderResource>> GetBuilderResourceAsync(string builderName, CancellationToken cancellationToken = default)
        {
            return await GetBuilderResources().GetAsync(builderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a BuilderResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Builders_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BuilderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BuilderResource> GetBuilderResource(string builderName, CancellationToken cancellationToken = default)
        {
            return GetBuilderResources().Get(builderName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppConnectedEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppConnectedEnvironmentResources and their operations over a ContainerAppConnectedEnvironmentResource. </returns>
        public virtual ContainerAppConnectedEnvironmentCollection GetContainerAppConnectedEnvironments()
        {
            return GetCachedClient(client => new ContainerAppConnectedEnvironmentCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppConnectedEnvironmentResource>> GetContainerAppConnectedEnvironmentAsync(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppConnectedEnvironments().GetAsync(connectedEnvironmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedEnvironmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="connectedEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppConnectedEnvironmentResource> GetContainerAppConnectedEnvironment(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppConnectedEnvironments().Get(connectedEnvironmentName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppResources and their operations over a ContainerAppResource. </returns>
        public virtual ContainerAppCollection GetContainerApps()
        {
            return GetCachedClient(client => new ContainerAppCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppResource>> GetContainerAppAsync(string containerAppName, CancellationToken cancellationToken = default)
        {
            return await GetContainerApps().GetAsync(containerAppName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppResource> GetContainerApp(string containerAppName, CancellationToken cancellationToken = default)
        {
            return GetContainerApps().Get(containerAppName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppManagedEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppManagedEnvironmentResources and their operations over a ContainerAppManagedEnvironmentResource. </returns>
        public virtual ContainerAppManagedEnvironmentCollection GetContainerAppManagedEnvironments()
        {
            return GetCachedClient(client => new ContainerAppManagedEnvironmentCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppManagedEnvironmentResource>> GetContainerAppManagedEnvironmentAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppManagedEnvironments().GetAsync(environmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppManagedEnvironmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppManagedEnvironmentResource> GetContainerAppManagedEnvironment(string environmentName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppManagedEnvironments().Get(environmentName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppJobResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppJobResources and their operations over a ContainerAppJobResource. </returns>
        public virtual ContainerAppJobCollection GetContainerAppJobs()
        {
            return GetCachedClient(client => new ContainerAppJobCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a Container Apps Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppJobResource>> GetContainerAppJobAsync(string jobName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppJobs().GetAsync(jobName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Container Apps Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppJobResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Job Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppJobResource> GetContainerAppJob(string jobName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppJobs().Get(jobName, cancellationToken);
        }

        /// <summary> Gets a collection of SessionPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SessionPoolResources and their operations over a SessionPoolResource. </returns>
        public virtual SessionPoolCollection GetSessionPools()
        {
            return GetCachedClient(client => new SessionPoolCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a session pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/sessionPools/{sessionPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSessionPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionPoolName"> Name of the session pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sessionPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SessionPoolResource>> GetSessionPoolAsync(string sessionPoolName, CancellationToken cancellationToken = default)
        {
            return await GetSessionPools().GetAsync(sessionPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a session pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/sessionPools/{sessionPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerAppsSessionPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SessionPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionPoolName"> Name of the session pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="sessionPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SessionPoolResource> GetSessionPool(string sessionPoolName, CancellationToken cancellationToken = default)
        {
            return GetSessionPools().Get(sessionPoolName, cancellationToken);
        }
    }
}
