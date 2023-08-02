// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class PurviewArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="PurviewArmClientMockingExtension"/> class for mocking. </summary>
        protected PurviewArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PurviewArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PurviewArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal PurviewArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewAccountResource.CreateResourceIdentifier" /> to create a <see cref="PurviewAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PurviewAccountResource" /> object. </returns>
        public virtual PurviewAccountResource GetPurviewAccountResource(ResourceIdentifier id)
        {
            PurviewAccountResource.ValidateResourceId(id);
            return new PurviewAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PurviewPrivateEndpointConnectionResource" /> object. </returns>
        public virtual PurviewPrivateEndpointConnectionResource GetPurviewPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            PurviewPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new PurviewPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PurviewPrivateLinkResource" /> object. </returns>
        public virtual PurviewPrivateLinkResource GetPurviewPrivateLinkResource(ResourceIdentifier id)
        {
            PurviewPrivateLinkResource.ValidateResourceId(id);
            return new PurviewPrivateLinkResource(Client, id);
        }
    }
}
