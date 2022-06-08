// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the CloudServiceRole data model. </summary>
    public partial class CloudServiceRoleData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleData"/>. </summary>
        internal CloudServiceRoleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="sku"> Describes the cloud service role sku. </param>
        /// <param name="uniqueId"> Specifies the ID which uniquely identifies a cloud service role. </param>
        internal CloudServiceRoleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, CloudServiceRoleSku sku, string uniqueId) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Sku = sku;
            UniqueId = uniqueId;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Describes the cloud service role sku. </summary>
        public CloudServiceRoleSku Sku { get; }
        /// <summary> Specifies the ID which uniquely identifies a cloud service role. </summary>
        public string UniqueId { get; }
    }
}
