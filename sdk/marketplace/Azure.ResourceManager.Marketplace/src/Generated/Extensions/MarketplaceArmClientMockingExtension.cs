// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MarketplaceArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MarketplaceArmClientMockingExtension"/> class for mocking. </summary>
        protected MarketplaceArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MarketplaceArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MarketplaceArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateStoreResource.CreateResourceIdentifier" /> to create a <see cref="PrivateStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateStoreResource" /> object. </returns>
        public virtual PrivateStoreResource GetPrivateStoreResource(ResourceIdentifier id)
        {
            PrivateStoreResource.ValidateResourceId(id);
            return new PrivateStoreResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MarketplaceApprovalRequestResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MarketplaceApprovalRequestResource.CreateResourceIdentifier" /> to create a <see cref="MarketplaceApprovalRequestResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MarketplaceApprovalRequestResource" /> object. </returns>
        public virtual MarketplaceApprovalRequestResource GetMarketplaceApprovalRequestResource(ResourceIdentifier id)
        {
            MarketplaceApprovalRequestResource.ValidateResourceId(id);
            return new MarketplaceApprovalRequestResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MarketplaceAdminApprovalRequestResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MarketplaceAdminApprovalRequestResource.CreateResourceIdentifier" /> to create a <see cref="MarketplaceAdminApprovalRequestResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MarketplaceAdminApprovalRequestResource" /> object. </returns>
        public virtual MarketplaceAdminApprovalRequestResource GetMarketplaceAdminApprovalRequestResource(ResourceIdentifier id)
        {
            MarketplaceAdminApprovalRequestResource.ValidateResourceId(id);
            return new MarketplaceAdminApprovalRequestResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateStoreCollectionInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateStoreCollectionInfoResource.CreateResourceIdentifier" /> to create a <see cref="PrivateStoreCollectionInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateStoreCollectionInfoResource" /> object. </returns>
        public virtual PrivateStoreCollectionInfoResource GetPrivateStoreCollectionInfoResource(ResourceIdentifier id)
        {
            PrivateStoreCollectionInfoResource.ValidateResourceId(id);
            return new PrivateStoreCollectionInfoResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PrivateStoreOfferResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateStoreOfferResource.CreateResourceIdentifier" /> to create a <see cref="PrivateStoreOfferResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateStoreOfferResource" /> object. </returns>
        public virtual PrivateStoreOfferResource GetPrivateStoreOfferResource(ResourceIdentifier id)
        {
            PrivateStoreOfferResource.ValidateResourceId(id);
            return new PrivateStoreOfferResource(Client, id);
        }
    }
}
