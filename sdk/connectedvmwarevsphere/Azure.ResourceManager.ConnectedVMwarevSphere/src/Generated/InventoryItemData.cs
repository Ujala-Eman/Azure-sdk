// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing the InventoryItem data model. </summary>
    public partial class InventoryItemData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="InventoryItemData"/>. </summary>
        /// <param name="inventoryType"> They inventory type. </param>
        public InventoryItemData(InventoryType inventoryType)
        {
            InventoryType = inventoryType;
        }

        /// <summary> Initializes a new instance of <see cref="InventoryItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="inventoryType"> They inventory type. </param>
        /// <param name="managedResourceId"> Gets or sets the tracked resource id corresponding to the inventory resource. </param>
        /// <param name="moRefId"> Gets or sets the MoRef (Managed Object Reference) ID for the inventory item. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the inventory item. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal InventoryItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, InventoryType inventoryType, string managedResourceId, string moRefId, string moName, string provisioningState) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            InventoryType = inventoryType;
            ManagedResourceId = managedResourceId;
            MoRefId = moRefId;
            MoName = moName;
            ProvisioningState = provisioningState;
        }

        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> They inventory type. </summary>
        internal InventoryType InventoryType { get; set; }
        /// <summary> Gets or sets the tracked resource id corresponding to the inventory resource. </summary>
        public string ManagedResourceId { get; set; }
        /// <summary> Gets or sets the MoRef (Managed Object Reference) ID for the inventory item. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the inventory item. </summary>
        public string MoName { get; set; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
