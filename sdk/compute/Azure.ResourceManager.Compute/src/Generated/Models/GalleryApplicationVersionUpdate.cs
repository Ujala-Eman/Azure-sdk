// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Version that you want to update. </summary>
    public partial class GalleryApplicationVersionUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryApplicationVersionUpdate. </summary>
        public GalleryApplicationVersionUpdate()
        {
        }

        /// <summary> The publishing profile of a gallery Image Version. </summary>
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryApplicationVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the replication status of the gallery Image Version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}
