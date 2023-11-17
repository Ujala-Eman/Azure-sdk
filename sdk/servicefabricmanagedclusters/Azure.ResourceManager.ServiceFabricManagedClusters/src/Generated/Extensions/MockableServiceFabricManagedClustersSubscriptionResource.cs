// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceFabricManagedClusters;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableServiceFabricManagedClustersSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _serviceFabricManagedClusterManagedClustersClientDiagnostics;
        private ManagedClustersRestOperations _serviceFabricManagedClusterManagedClustersRestClient;
        private ClientDiagnostics _managedClusterVersionClientDiagnostics;
        private ManagedClusterVersionRestOperations _managedClusterVersionRestClient;
        private ClientDiagnostics _managedUnsupportedVmSizesClientDiagnostics;
        private ManagedUnsupportedVMSizesRestOperations _managedUnsupportedVmSizesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersSubscriptionResource"/> class for mocking. </summary>
        protected MockableServiceFabricManagedClustersSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceFabricManagedClustersSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ServiceFabricManagedClusterManagedClustersClientDiagnostics => _serviceFabricManagedClusterManagedClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ServiceFabricManagedClusterResource.ResourceType.Namespace, Diagnostics);
        private ManagedClustersRestOperations ServiceFabricManagedClusterManagedClustersRestClient => _serviceFabricManagedClusterManagedClustersRestClient ??= new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ServiceFabricManagedClusterResource.ResourceType));
        private ClientDiagnostics ManagedClusterVersionClientDiagnostics => _managedClusterVersionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedClusterVersionRestOperations ManagedClusterVersionRestClient => _managedClusterVersionRestClient ??= new ManagedClusterVersionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics managedUnsupportedVMSizesClientDiagnostics => _managedUnsupportedVmSizesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ManagedUnsupportedVMSizesRestOperations managedUnsupportedVMSizesRestClient => _managedUnsupportedVmSizesRestClient ??= new ManagedUnsupportedVMSizesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/managedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedClusterResource> GetServiceFabricManagedClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricManagedClusterManagedClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceFabricManagedClusterManagedClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceFabricManagedClusterResource(Client, ServiceFabricManagedClusterData.DeserializeServiceFabricManagedClusterData(e)), ServiceFabricManagedClusterManagedClustersClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetServiceFabricManagedClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/managedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedClusterResource> GetServiceFabricManagedClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricManagedClusterManagedClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceFabricManagedClusterManagedClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ServiceFabricManagedClusterResource(Client, ServiceFabricManagedClusterData.DeserializeServiceFabricManagedClusterData(e)), ServiceFabricManagedClusterManagedClustersClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetServiceFabricManagedClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric managed cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedClusterVersion>> GetManagedClusterVersionAsync(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var scope = ManagedClusterVersionClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersion");
            scope.Start();
            try
            {
                var response = await ManagedClusterVersionRestClient.GetAsync(Id.SubscriptionId, location, clusterVersion, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about an available Service Fabric managed cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        public virtual Response<ServiceFabricManagedClusterVersion> GetManagedClusterVersion(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var scope = ManagedClusterVersionClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersion");
            scope.Start();
            try
            {
                var response = ManagedClusterVersionRestClient.Get(Id.SubscriptionId, location, clusterVersion, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedClusterVersion>> GetManagedClusterVersionByEnvironmentAsync(AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var scope = ManagedClusterVersionClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersionByEnvironment");
            scope.Start();
            try
            {
                var response = await ManagedClusterVersionRestClient.GetByEnvironmentAsync(Id.SubscriptionId, location, environment, clusterVersion, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_GetByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        public virtual Response<ServiceFabricManagedClusterVersion> GetManagedClusterVersionByEnvironment(AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterVersion, nameof(clusterVersion));

            using var scope = ManagedClusterVersionClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersionByEnvironment");
            scope.Start();
            try
            {
                var response = ManagedClusterVersionRestClient.GetByEnvironment(Id.SubscriptionId, location, environment, clusterVersion, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedClusterVersion> GetManagedClusterVersionsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedClusterVersionRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion, ManagedClusterVersionClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersions", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedClusterVersion> GetManagedClusterVersions(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedClusterVersionRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion, ManagedClusterVersionClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersions", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedClusterVersion> GetManagedClusterVersionsByEnvironmentAsync(AzureLocation location, ManagedClusterVersionEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedClusterVersionRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion, ManagedClusterVersionClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersionsByEnvironment", "", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterVersion_ListByEnvironment</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedClusterVersion> GetManagedClusterVersionsByEnvironment(AzureLocation location, ManagedClusterVersionEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedClusterVersionRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ServiceFabricManagedClusterVersion.DeserializeServiceFabricManagedClusterVersion, ManagedClusterVersionClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedClusterVersionsByEnvironment", "", null, cancellationToken);
        }

        /// <summary>
        /// Get the lists of unsupported vm sizes for Service Fabric Managed Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>managedUnsupportedVMSizes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedUnsupportedVmSize" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedUnsupportedVmSize> GetManagedUnsupportedVmSizesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => managedUnsupportedVMSizesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => managedUnsupportedVMSizesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ServiceFabricManagedUnsupportedVmSize.DeserializeServiceFabricManagedUnsupportedVmSize, managedUnsupportedVMSizesClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedUnsupportedVmSizes", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the lists of unsupported vm sizes for Service Fabric Managed Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>managedUnsupportedVMSizes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedUnsupportedVmSize" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedUnsupportedVmSize> GetManagedUnsupportedVmSizes(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => managedUnsupportedVMSizesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => managedUnsupportedVMSizesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ServiceFabricManagedUnsupportedVmSize.DeserializeServiceFabricManagedUnsupportedVmSize, managedUnsupportedVMSizesClientDiagnostics, Pipeline, "MockableServiceFabricManagedClustersSubscriptionResource.GetManagedUnsupportedVmSizes", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Managed Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes/{vmSize}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>managedUnsupportedVMSizes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedUnsupportedVmSize>> GetManagedUnsupportedVmSizeAsync(AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmSize, nameof(vmSize));

            using var scope = managedUnsupportedVMSizesClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedUnsupportedVmSize");
            scope.Start();
            try
            {
                var response = await managedUnsupportedVMSizesRestClient.GetAsync(Id.SubscriptionId, location, vmSize, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Managed Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes/{vmSize}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>managedUnsupportedVMSizes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        public virtual Response<ServiceFabricManagedUnsupportedVmSize> GetManagedUnsupportedVmSize(AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmSize, nameof(vmSize));

            using var scope = managedUnsupportedVMSizesClientDiagnostics.CreateScope("MockableServiceFabricManagedClustersSubscriptionResource.GetManagedUnsupportedVmSize");
            scope.Start();
            try
            {
                var response = managedUnsupportedVMSizesRestClient.Get(Id.SubscriptionId, location, vmSize, cancellationToken);
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
