// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHybridComputeArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHybridComputeArmClient"/> class for mocking. </summary>
        protected MockableHybridComputeArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridComputeArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridComputeArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHybridComputeArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeLicenseResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeLicenseResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeLicenseResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeLicenseResource"/> object. </returns>
        public virtual HybridComputeLicenseResource GetHybridComputeLicenseResource(ResourceIdentifier id)
        {
            HybridComputeLicenseResource.ValidateResourceId(id);
            return new HybridComputeLicenseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeMachineResource"/> object. </returns>
        public virtual HybridComputeMachineResource GetHybridComputeMachineResource(ResourceIdentifier id)
        {
            HybridComputeMachineResource.ValidateResourceId(id);
            return new HybridComputeMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LicenseProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LicenseProfileResource.CreateResourceIdentifier" /> to create a <see cref="LicenseProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LicenseProfileResource"/> object. </returns>
        public virtual LicenseProfileResource GetLicenseProfileResource(ResourceIdentifier id)
        {
            LicenseProfileResource.ValidateResourceId(id);
            return new LicenseProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeMachineExtensionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeMachineExtensionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeMachineExtensionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeMachineExtensionResource"/> object. </returns>
        public virtual HybridComputeMachineExtensionResource GetHybridComputeMachineExtensionResource(ResourceIdentifier id)
        {
            HybridComputeMachineExtensionResource.ValidateResourceId(id);
            return new HybridComputeMachineExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputeExtensionValueResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputeExtensionValueResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputeExtensionValueResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputeExtensionValueResource"/> object. </returns>
        public virtual HybridComputeExtensionValueResource GetHybridComputeExtensionValueResource(ResourceIdentifier id)
        {
            HybridComputeExtensionValueResource.ValidateResourceId(id);
            return new HybridComputeExtensionValueResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkScopeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkScopeResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkScopeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkScopeResource"/> object. </returns>
        public virtual HybridComputePrivateLinkScopeResource GetHybridComputePrivateLinkScopeResource(ResourceIdentifier id)
        {
            HybridComputePrivateLinkScopeResource.ValidateResourceId(id);
            return new HybridComputePrivateLinkScopeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateLinkResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateLinkResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateLinkResource"/> object. </returns>
        public virtual HybridComputePrivateLinkResource GetHybridComputePrivateLinkResource(ResourceIdentifier id)
        {
            HybridComputePrivateLinkResource.ValidateResourceId(id);
            return new HybridComputePrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridComputePrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridComputePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HybridComputePrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridComputePrivateEndpointConnectionResource"/> object. </returns>
        public virtual HybridComputePrivateEndpointConnectionResource GetHybridComputePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            HybridComputePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new HybridComputePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NetworkSecurityPerimeterConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="NetworkSecurityPerimeterConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkSecurityPerimeterConfigurationResource"/> object. </returns>
        public virtual NetworkSecurityPerimeterConfigurationResource GetNetworkSecurityPerimeterConfigurationResource(ResourceIdentifier id)
        {
            NetworkSecurityPerimeterConfigurationResource.ValidateResourceId(id);
            return new NetworkSecurityPerimeterConfigurationResource(Client, id);
        }
    }
}
