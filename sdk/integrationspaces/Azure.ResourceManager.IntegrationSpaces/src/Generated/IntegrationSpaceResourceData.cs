// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IntegrationSpaces
{
    /// <summary>
    /// A class representing the IntegrationSpaceResource data model.
    /// A resource under application.
    /// </summary>
    public partial class IntegrationSpaceResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of IntegrationSpaceResourceData. </summary>
        public IntegrationSpaceResourceData()
        {
        }

        /// <summary> Initializes a new instance of IntegrationSpaceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="resourceId"> The Arm id of the application resource. </param>
        /// <param name="resourceKind"> The kind of the application resource. </param>
        internal IntegrationSpaceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, string resourceId, string resourceKind) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ResourceId = resourceId;
            ResourceKind = resourceKind;
        }

        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The Arm id of the application resource. </summary>
        public string ResourceId { get; set; }
        /// <summary> The kind of the application resource. </summary>
        public string ResourceKind { get; set; }
    }
}
