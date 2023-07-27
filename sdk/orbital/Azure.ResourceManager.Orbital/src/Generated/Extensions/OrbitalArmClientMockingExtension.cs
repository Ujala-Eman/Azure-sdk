// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class OrbitalArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="OrbitalArmClientMockingExtension"/> class for mocking. </summary>
        protected OrbitalArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OrbitalArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OrbitalArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal OrbitalArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalSpacecraftResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalSpacecraftResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalSpacecraftResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrbitalSpacecraftResource" /> object. </returns>
        public virtual OrbitalSpacecraftResource GetOrbitalSpacecraftResource(ResourceIdentifier id)
        {
            OrbitalSpacecraftResource.ValidateResourceId(id);
            return new OrbitalSpacecraftResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalContactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalContactResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalContactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrbitalContactResource" /> object. </returns>
        public virtual OrbitalContactResource GetOrbitalContactResource(ResourceIdentifier id)
        {
            OrbitalContactResource.ValidateResourceId(id);
            return new OrbitalContactResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrbitalContactProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrbitalContactProfileResource.CreateResourceIdentifier" /> to create an <see cref="OrbitalContactProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrbitalContactProfileResource" /> object. </returns>
        public virtual OrbitalContactProfileResource GetOrbitalContactProfileResource(ResourceIdentifier id)
        {
            OrbitalContactProfileResource.ValidateResourceId(id);
            return new OrbitalContactProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailableGroundStationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailableGroundStationResource.CreateResourceIdentifier" /> to create an <see cref="AvailableGroundStationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailableGroundStationResource" /> object. </returns>
        public virtual AvailableGroundStationResource GetAvailableGroundStationResource(ResourceIdentifier id)
        {
            AvailableGroundStationResource.ValidateResourceId(id);
            return new AvailableGroundStationResource(Client, id);
        }
    }
}
