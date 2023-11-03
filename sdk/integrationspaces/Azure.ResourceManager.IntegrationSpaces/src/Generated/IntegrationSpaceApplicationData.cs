// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IntegrationSpaces.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IntegrationSpaces
{
    /// <summary>
    /// A class representing the IntegrationSpaceApplication data model.
    /// An integration application under space.
    /// </summary>
    public partial class IntegrationSpaceApplicationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IntegrationSpaceApplicationData. </summary>
        /// <param name="location"> The location. </param>
        public IntegrationSpaceApplicationData(AzureLocation location) : base(location)
        {
            TrackingDataStores = new ChangeTrackingDictionary<string, TrackingDataStore>();
        }

        /// <summary> Initializes a new instance of IntegrationSpaceApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="description"> The description of the resource. </param>
        /// <param name="trackingDataStores"> The tracking data stores. </param>
        internal IntegrationSpaceApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, string description, IDictionary<string, TrackingDataStore> trackingDataStores) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Description = description;
            TrackingDataStores = trackingDataStores;
        }

        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The description of the resource. </summary>
        public string Description { get; set; }
        /// <summary> The tracking data stores. </summary>
        public IDictionary<string, TrackingDataStore> TrackingDataStores { get; }
    }
}
