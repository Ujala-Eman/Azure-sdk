// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceFabricManagedClusters. </summary>
    public static partial class ServiceFabricManagedClustersExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of LocationManagedClusterVersionResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <returns> An object representing collection of LocationManagedClusterVersionResources and their operations over a LocationManagedClusterVersionResource. </returns>
        public static LocationManagedClusterVersionCollection GetLocationManagedClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            return GetExtensionClient(subscriptionResource).GetLocationManagedClusterVersions(location);
        }

        /// <summary>
        /// Gets information about an available Service Fabric managed cluster code version.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions/{clusterVersion}
        /// Operation Id: ManagedClusterVersion_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LocationManagedClusterVersionResource>> GetLocationManagedClusterVersionAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetLocationManagedClusterVersions(location).GetAsync(clusterVersion, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about an available Service Fabric managed cluster code version.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterVersions/{clusterVersion}
        /// Operation Id: ManagedClusterVersion_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<LocationManagedClusterVersionResource> GetLocationManagedClusterVersion(this SubscriptionResource subscriptionResource, AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetLocationManagedClusterVersions(location).Get(clusterVersion, cancellationToken);
        }

        /// <summary> Gets a collection of LocationEnvironmentManagedClusterVersionResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <returns> An object representing collection of LocationEnvironmentManagedClusterVersionResources and their operations over a LocationEnvironmentManagedClusterVersionResource. </returns>
        public static LocationEnvironmentManagedClusterVersionCollection GetLocationEnvironmentManagedClusterVersions(this SubscriptionResource subscriptionResource, AzureLocation location, ManagedClusterVersionEnvironment environment)
        {
            return GetExtensionClient(subscriptionResource).GetLocationEnvironmentManagedClusterVersions(location, environment);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions/{clusterVersion}
        /// Operation Id: ManagedClusterVersion_GetByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LocationEnvironmentManagedClusterVersionResource>> GetLocationEnvironmentManagedClusterVersionAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetLocationEnvironmentManagedClusterVersions(location, environment).GetAsync(clusterVersion, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/managedClusterVersions/{clusterVersion}
        /// Operation Id: ManagedClusterVersion_GetByEnvironment
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<LocationEnvironmentManagedClusterVersionResource> GetLocationEnvironmentManagedClusterVersion(this SubscriptionResource subscriptionResource, AzureLocation location, ManagedClusterVersionEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetLocationEnvironmentManagedClusterVersions(location, environment).Get(clusterVersion, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedVmSizeResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <returns> An object representing collection of ManagedVmSizeResources and their operations over a ManagedVmSizeResource. </returns>
        public static ManagedVmSizeCollection GetManagedVmSizes(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            return GetExtensionClient(subscriptionResource).GetManagedVmSizes(location);
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Managed Clusters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes/{vmSize}
        /// Operation Id: managedUnsupportedVMSizes_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedVmSizeResource>> GetManagedVmSizeAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetManagedVmSizes(location).GetAsync(vmSize, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Managed Clusters.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedUnsupportedVMSizes/{vmSize}
        /// Operation Id: managedUnsupportedVMSizes_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedVmSizeResource> GetManagedVmSize(this SubscriptionResource subscriptionResource, AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetManagedVmSizes(location).Get(vmSize, cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/managedClusters
        /// Operation Id: ManagedClusters_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedClusterResource> GetManagedClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/managedClusters
        /// Operation Id: ManagedClusters_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedClusterResource> GetManagedClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedClusters(cancellationToken);
        }

        /// <summary>
        /// Get long running operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterOperations/{operationId}
        /// Operation Id: OperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="operationId"> operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<LongRunningOperationResult>> GetOperationStatuAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationStatuAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get long running operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterOperations/{operationId}
        /// Operation Id: OperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="operationId"> operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response<LongRunningOperationResult> GetOperationStatu(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationStatu(location, operationId, cancellationToken);
        }

        /// <summary>
        /// Get long running operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterOperationResults/{operationId}
        /// Operation Id: OperationResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="operationId"> operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response> GetOperationResultAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationResultAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get long running operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/managedClusterOperationResults/{operationId}
        /// Operation Id: OperationResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for the cluster code versions. This is different from cluster location. </param>
        /// <param name="operationId"> operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response GetOperationResult(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationResult(location, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ManagedClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedClusterResources and their operations over a ManagedClusterResource. </returns>
        public static ManagedClusterCollection GetManagedClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetManagedClusters();
        }

        /// <summary>
        /// Get a Service Fabric managed cluster resource created or in the process of being created in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedClusterResource>> GetManagedClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetManagedClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service Fabric managed cluster resource created or in the process of being created in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}
        /// Operation Id: ManagedClusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedClusterResource> GetManagedCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetManagedClusters().Get(clusterName, cancellationToken);
        }

        #region ApplicationTypeResource
        /// <summary>
        /// Gets an object representing an <see cref="ApplicationTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApplicationTypeResource.CreateResourceIdentifier" /> to create an <see cref="ApplicationTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ApplicationTypeResource" /> object. </returns>
        public static ApplicationTypeResource GetApplicationTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ApplicationTypeResource.ValidateResourceId(id);
                return new ApplicationTypeResource(client, id);
            }
            );
        }
        #endregion

        #region ApplicationTypeVersionResource
        /// <summary>
        /// Gets an object representing an <see cref="ApplicationTypeVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApplicationTypeVersionResource.CreateResourceIdentifier" /> to create an <see cref="ApplicationTypeVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ApplicationTypeVersionResource" /> object. </returns>
        public static ApplicationTypeVersionResource GetApplicationTypeVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ApplicationTypeVersionResource.ValidateResourceId(id);
                return new ApplicationTypeVersionResource(client, id);
            }
            );
        }
        #endregion

        #region ApplicationResource
        /// <summary>
        /// Gets an object representing an <see cref="ApplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ApplicationResource.CreateResourceIdentifier" /> to create an <see cref="ApplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ApplicationResource" /> object. </returns>
        public static ApplicationResource GetApplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ApplicationResource.ValidateResourceId(id);
                return new ApplicationResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceResource" /> object. </returns>
        public static ServiceResource GetServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceResource.ValidateResourceId(id);
                return new ServiceResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ManagedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedClusterResource" /> object. </returns>
        public static ManagedClusterResource GetManagedClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedClusterResource.ValidateResourceId(id);
                return new ManagedClusterResource(client, id);
            }
            );
        }
        #endregion

        #region LocationManagedClusterVersionResource
        /// <summary>
        /// Gets an object representing a <see cref="LocationManagedClusterVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LocationManagedClusterVersionResource.CreateResourceIdentifier" /> to create a <see cref="LocationManagedClusterVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LocationManagedClusterVersionResource" /> object. </returns>
        public static LocationManagedClusterVersionResource GetLocationManagedClusterVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LocationManagedClusterVersionResource.ValidateResourceId(id);
                return new LocationManagedClusterVersionResource(client, id);
            }
            );
        }
        #endregion

        #region LocationEnvironmentManagedClusterVersionResource
        /// <summary>
        /// Gets an object representing a <see cref="LocationEnvironmentManagedClusterVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LocationEnvironmentManagedClusterVersionResource.CreateResourceIdentifier" /> to create a <see cref="LocationEnvironmentManagedClusterVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LocationEnvironmentManagedClusterVersionResource" /> object. </returns>
        public static LocationEnvironmentManagedClusterVersionResource GetLocationEnvironmentManagedClusterVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                LocationEnvironmentManagedClusterVersionResource.ValidateResourceId(id);
                return new LocationEnvironmentManagedClusterVersionResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedVmSizeResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedVmSizeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedVmSizeResource.CreateResourceIdentifier" /> to create a <see cref="ManagedVmSizeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedVmSizeResource" /> object. </returns>
        public static ManagedVmSizeResource GetManagedVmSizeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedVmSizeResource.ValidateResourceId(id);
                return new ManagedVmSizeResource(client, id);
            }
            );
        }
        #endregion

        #region NodeTypeResource
        /// <summary>
        /// Gets an object representing a <see cref="NodeTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NodeTypeResource.CreateResourceIdentifier" /> to create a <see cref="NodeTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NodeTypeResource" /> object. </returns>
        public static NodeTypeResource GetNodeTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NodeTypeResource.ValidateResourceId(id);
                return new NodeTypeResource(client, id);
            }
            );
        }
        #endregion
    }
}
