// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the GalleryApplicationVersion data model. </summary>
    public partial class GalleryApplicationVersionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GalleryApplicationVersionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="publishingProfile"> The publishing profile of a gallery image version. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery image version. </param>
        internal GalleryApplicationVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, GalleryApplicationVersionPublishingProfile publishingProfile, GalleryApplicationVersionPropertiesProvisioningState? provisioningState, ReplicationStatus replicationStatus) : base(id, name, resourceType, systemData, tags, location)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            ReplicationStatus = replicationStatus;
        }

        /// <summary> The publishing profile of a gallery image version. </summary>
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryApplicationVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}
