// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MobileNetwork
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

        /// <summary> Gets a collection of MobileNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MobileNetworkResources and their operations over a MobileNetworkResource. </returns>
        public virtual MobileNetworkCollection GetMobileNetworks()
        {
            return GetCachedClient(Client => new MobileNetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of PacketCoreControlPlaneResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PacketCoreControlPlaneResources and their operations over a PacketCoreControlPlaneResource. </returns>
        public virtual PacketCoreControlPlaneCollection GetPacketCoreControlPlanes()
        {
            return GetCachedClient(Client => new PacketCoreControlPlaneCollection(Client, Id));
        }

        /// <summary> Gets a collection of MobileNetworkSimGroupResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MobileNetworkSimGroupResources and their operations over a MobileNetworkSimGroupResource. </returns>
        public virtual MobileNetworkSimGroupCollection GetMobileNetworkSimGroups()
        {
            return GetCachedClient(Client => new MobileNetworkSimGroupCollection(Client, Id));
        }
    }
}
