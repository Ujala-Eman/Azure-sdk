// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of BareMetalMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of BareMetalMachineResources and their operations over a BareMetalMachineResource. </returns>
        public virtual BareMetalMachineCollection GetBareMetalMachines()
        {
            return GetCachedClient(Client => new BareMetalMachineCollection(Client, Id));
        }

        /// <summary> Gets a collection of CloudServicesNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of CloudServicesNetworkResources and their operations over a CloudServicesNetworkResource. </returns>
        public virtual CloudServicesNetworkCollection GetCloudServicesNetworks()
        {
            return GetCachedClient(Client => new CloudServicesNetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of ClusterManagerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ClusterManagerResources and their operations over a ClusterManagerResource. </returns>
        public virtual ClusterManagerCollection GetClusterManagers()
        {
            return GetCachedClient(Client => new ClusterManagerCollection(Client, Id));
        }

        /// <summary> Gets a collection of ClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ClusterResources and their operations over a ClusterResource. </returns>
        public virtual ClusterCollection GetClusters()
        {
            return GetCachedClient(Client => new ClusterCollection(Client, Id));
        }

        /// <summary> Gets a collection of KubernetesClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of KubernetesClusterResources and their operations over a KubernetesClusterResource. </returns>
        public virtual KubernetesClusterCollection GetKubernetesClusters()
        {
            return GetCachedClient(Client => new KubernetesClusterCollection(Client, Id));
        }

        /// <summary> Gets a collection of L2NetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of L2NetworkResources and their operations over a L2NetworkResource. </returns>
        public virtual L2NetworkCollection GetL2Networks()
        {
            return GetCachedClient(Client => new L2NetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of L3NetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of L3NetworkResources and their operations over a L3NetworkResource. </returns>
        public virtual L3NetworkCollection GetL3Networks()
        {
            return GetCachedClient(Client => new L3NetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of RackResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RackResources and their operations over a RackResource. </returns>
        public virtual RackCollection GetRacks()
        {
            return GetCachedClient(Client => new RackCollection(Client, Id));
        }

        /// <summary> Gets a collection of StorageApplianceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StorageApplianceResources and their operations over a StorageApplianceResource. </returns>
        public virtual StorageApplianceCollection GetStorageAppliances()
        {
            return GetCachedClient(Client => new StorageApplianceCollection(Client, Id));
        }

        /// <summary> Gets a collection of TrunkedNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of TrunkedNetworkResources and their operations over a TrunkedNetworkResource. </returns>
        public virtual TrunkedNetworkCollection GetTrunkedNetworks()
        {
            return GetCachedClient(Client => new TrunkedNetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of VirtualMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualMachineResources and their operations over a VirtualMachineResource. </returns>
        public virtual VirtualMachineCollection GetVirtualMachines()
        {
            return GetCachedClient(Client => new VirtualMachineCollection(Client, Id));
        }

        /// <summary> Gets a collection of VolumeResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VolumeResources and their operations over a VolumeResource. </returns>
        public virtual VolumeCollection GetVolumes()
        {
            return GetCachedClient(Client => new VolumeCollection(Client, Id));
        }
    }
}
