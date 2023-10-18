// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class ContainerServiceArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ContainerServiceArmClientMockingExtension"/> class for mocking. </summary>
        protected ContainerServiceArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerServiceArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal ContainerServiceArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="OSOptionProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OSOptionProfileResource.CreateResourceIdentifier" /> to create an <see cref="OSOptionProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSOptionProfileResource" /> object. </returns>
        public virtual OSOptionProfileResource GetOSOptionProfileResource(ResourceIdentifier id)
        {
            OSOptionProfileResource.ValidateResourceId(id);
            return new OSOptionProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedClusterUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedClusterUpgradeProfileResource.CreateResourceIdentifier" /> to create a <see cref="ManagedClusterUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedClusterUpgradeProfileResource" /> object. </returns>
        public virtual ManagedClusterUpgradeProfileResource GetManagedClusterUpgradeProfileResource(ResourceIdentifier id)
        {
            ManagedClusterUpgradeProfileResource.ValidateResourceId(id);
            return new ManagedClusterUpgradeProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceManagedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceManagedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceManagedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceManagedClusterResource" /> object. </returns>
        public virtual ContainerServiceManagedClusterResource GetContainerServiceManagedClusterResource(ResourceIdentifier id)
        {
            ContainerServiceManagedClusterResource.ValidateResourceId(id);
            return new ContainerServiceManagedClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceMaintenanceConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceMaintenanceConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceMaintenanceConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceMaintenanceConfigurationResource" /> object. </returns>
        public virtual ContainerServiceMaintenanceConfigurationResource GetContainerServiceMaintenanceConfigurationResource(ResourceIdentifier id)
        {
            ContainerServiceMaintenanceConfigurationResource.ValidateResourceId(id);
            return new ContainerServiceMaintenanceConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceAgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceAgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceAgentPoolResource" /> object. </returns>
        public virtual ContainerServiceAgentPoolResource GetContainerServiceAgentPoolResource(ResourceIdentifier id)
        {
            ContainerServiceAgentPoolResource.ValidateResourceId(id);
            return new ContainerServiceAgentPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolUpgradeProfileResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolUpgradeProfileResource" /> object. </returns>
        public virtual AgentPoolUpgradeProfileResource GetAgentPoolUpgradeProfileResource(ResourceIdentifier id)
        {
            AgentPoolUpgradeProfileResource.ValidateResourceId(id);
            return new AgentPoolUpgradeProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServicePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServicePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServicePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServicePrivateEndpointConnectionResource" /> object. </returns>
        public virtual ContainerServicePrivateEndpointConnectionResource GetContainerServicePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            ContainerServicePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new ContainerServicePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolSnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolSnapshotResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolSnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolSnapshotResource" /> object. </returns>
        public virtual AgentPoolSnapshotResource GetAgentPoolSnapshotResource(ResourceIdentifier id)
        {
            AgentPoolSnapshotResource.ValidateResourceId(id);
            return new AgentPoolSnapshotResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedClusterSnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedClusterSnapshotResource.CreateResourceIdentifier" /> to create a <see cref="ManagedClusterSnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedClusterSnapshotResource" /> object. </returns>
        public virtual ManagedClusterSnapshotResource GetManagedClusterSnapshotResource(ResourceIdentifier id)
        {
            ManagedClusterSnapshotResource.ValidateResourceId(id);
            return new ManagedClusterSnapshotResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceTrustedAccessRoleBindingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceTrustedAccessRoleBindingResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceTrustedAccessRoleBindingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceTrustedAccessRoleBindingResource" /> object. </returns>
        public virtual ContainerServiceTrustedAccessRoleBindingResource GetContainerServiceTrustedAccessRoleBindingResource(ResourceIdentifier id)
        {
            ContainerServiceTrustedAccessRoleBindingResource.ValidateResourceId(id);
            return new ContainerServiceTrustedAccessRoleBindingResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceFleetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceFleetResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceFleetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceFleetResource" /> object. </returns>
        public virtual ContainerServiceFleetResource GetContainerServiceFleetResource(ResourceIdentifier id)
        {
            ContainerServiceFleetResource.ValidateResourceId(id);
            return new ContainerServiceFleetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerServiceFleetMemberResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerServiceFleetMemberResource.CreateResourceIdentifier" /> to create a <see cref="ContainerServiceFleetMemberResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerServiceFleetMemberResource" /> object. </returns>
        public virtual ContainerServiceFleetMemberResource GetContainerServiceFleetMemberResource(ResourceIdentifier id)
        {
            ContainerServiceFleetMemberResource.ValidateResourceId(id);
            return new ContainerServiceFleetMemberResource(Client, id);
        }
    }
}
