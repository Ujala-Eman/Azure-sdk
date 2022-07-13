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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AppContainers. </summary>
    public static partial class AppContainersExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Get the Container Apps in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.App/containerApps
        /// Operation Id: ContainerApps_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContainerAppResource> GetContainerAppsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetContainerAppsAsync(cancellationToken);
        }

        /// <summary>
        /// Get the Container Apps in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.App/containerApps
        /// Operation Id: ContainerApps_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContainerAppResource> GetContainerApps(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetContainerApps(cancellationToken);
        }

        /// <summary>
        /// Get all Managed Environments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.App/managedEnvironments
        /// Operation Id: ManagedEnvironments_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedEnvironmentResource> GetManagedEnvironmentsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedEnvironmentsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all Managed Environments for a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.App/managedEnvironments
        /// Operation Id: ManagedEnvironments_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedEnvironmentResource> GetManagedEnvironments(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetManagedEnvironments(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ContainerAppResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ContainerAppResources and their operations over a ContainerAppResource. </returns>
        public static ContainerAppCollection GetContainerApps(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetContainerApps();
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}
        /// Operation Id: ContainerApps_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ContainerAppResource>> GetContainerAppAsync(this ResourceGroupResource resourceGroupResource, string containerAppName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetContainerApps().GetAsync(containerAppName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}
        /// Operation Id: ContainerApps_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerAppName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ContainerAppResource> GetContainerApp(this ResourceGroupResource resourceGroupResource, string containerAppName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetContainerApps().Get(containerAppName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedEnvironmentResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedEnvironmentResources and their operations over a ManagedEnvironmentResource. </returns>
        public static ManagedEnvironmentCollection GetManagedEnvironments(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetManagedEnvironments();
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
        /// Operation Id: ManagedEnvironments_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedEnvironmentResource>> GetManagedEnvironmentAsync(this ResourceGroupResource resourceGroupResource, string environmentName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetManagedEnvironments().GetAsync(environmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}
        /// Operation Id: ManagedEnvironments_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedEnvironmentResource> GetManagedEnvironment(this ResourceGroupResource resourceGroupResource, string environmentName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetManagedEnvironments().Get(environmentName, cancellationToken);
        }

        #region AuthConfigResource
        /// <summary>
        /// Gets an object representing an <see cref="AuthConfigResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AuthConfigResource.CreateResourceIdentifier" /> to create an <see cref="AuthConfigResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AuthConfigResource" /> object. </returns>
        public static AuthConfigResource GetAuthConfigResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AuthConfigResource.ValidateResourceId(id);
                return new AuthConfigResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerAppResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppResource" /> object. </returns>
        public static ContainerAppResource GetContainerAppResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerAppResource.ValidateResourceId(id);
                return new ContainerAppResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerAppRevisionResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppRevisionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppRevisionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppRevisionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppRevisionResource" /> object. </returns>
        public static ContainerAppRevisionResource GetContainerAppRevisionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerAppRevisionResource.ValidateResourceId(id);
                return new ContainerAppRevisionResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerAppReplicaResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppReplicaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppReplicaResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppReplicaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppReplicaResource" /> object. </returns>
        public static ContainerAppReplicaResource GetContainerAppReplicaResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerAppReplicaResource.ValidateResourceId(id);
                return new ContainerAppReplicaResource(client, id);
            }
            );
        }
        #endregion

        #region DaprComponentResource
        /// <summary>
        /// Gets an object representing a <see cref="DaprComponentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DaprComponentResource.CreateResourceIdentifier" /> to create a <see cref="DaprComponentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DaprComponentResource" /> object. </returns>
        public static DaprComponentResource GetDaprComponentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DaprComponentResource.ValidateResourceId(id);
                return new DaprComponentResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedEnvironmentResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedEnvironmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedEnvironmentResource.CreateResourceIdentifier" /> to create a <see cref="ManagedEnvironmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedEnvironmentResource" /> object. </returns>
        public static ManagedEnvironmentResource GetManagedEnvironmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedEnvironmentResource.ValidateResourceId(id);
                return new ManagedEnvironmentResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerAppCertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerAppCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerAppCertificateResource.CreateResourceIdentifier" /> to create a <see cref="ContainerAppCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerAppCertificateResource" /> object. </returns>
        public static ContainerAppCertificateResource GetContainerAppCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerAppCertificateResource.ValidateResourceId(id);
                return new ContainerAppCertificateResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedEnvironmentStorageResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedEnvironmentStorageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedEnvironmentStorageResource.CreateResourceIdentifier" /> to create a <see cref="ManagedEnvironmentStorageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedEnvironmentStorageResource" /> object. </returns>
        public static ManagedEnvironmentStorageResource GetManagedEnvironmentStorageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedEnvironmentStorageResource.ValidateResourceId(id);
                return new ManagedEnvironmentStorageResource(client, id);
            }
            );
        }
        #endregion

        #region SourceControlResource
        /// <summary>
        /// Gets an object representing a <see cref="SourceControlResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SourceControlResource.CreateResourceIdentifier" /> to create a <see cref="SourceControlResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SourceControlResource" /> object. </returns>
        public static SourceControlResource GetSourceControlResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SourceControlResource.ValidateResourceId(id);
                return new SourceControlResource(client, id);
            }
            );
        }
        #endregion
    }
}
