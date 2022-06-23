// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing the VirtualWorkspace data model. </summary>
    public partial class VirtualWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualWorkspaceData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualWorkspaceData(AzureLocation location) : base(location)
        {
            ApplicationGroupReferences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualWorkspaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="objectId"> ObjectId of Workspace. (internal use). </param>
        /// <param name="description"> Description of Workspace. </param>
        /// <param name="friendlyName"> Friendly name of Workspace. </param>
        /// <param name="applicationGroupReferences"> List of applicationGroup resource Ids. </param>
        /// <param name="cloudPcResource"> Is cloud pc resource. </param>
        /// <param name="managedBy"> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"></param>
        /// <param name="sku"></param>
        /// <param name="plan"></param>
        internal VirtualWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string objectId, string description, string friendlyName, IList<string> applicationGroupReferences, bool? cloudPcResource, string managedBy, string kind, ETag? etag, SystemAssignedServiceIdentity identity, ResourceModelWithAllowedPropertySetSku sku, ArmPlan plan) : base(id, name, resourceType, systemData, tags, location)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            ApplicationGroupReferences = applicationGroupReferences;
            CloudPcResource = cloudPcResource;
            ManagedBy = managedBy;
            Kind = kind;
            Etag = etag;
            Identity = identity;
            Sku = sku;
            Plan = plan;
        }

        /// <summary> ObjectId of Workspace. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Description of Workspace. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Workspace. </summary>
        public string FriendlyName { get; set; }
        /// <summary> List of applicationGroup resource Ids. </summary>
        public IList<string> ApplicationGroupReferences { get; }
        /// <summary> Is cloud pc resource. </summary>
        public bool? CloudPcResource { get; }
        /// <summary> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        public ETag? Etag { get; }
        /// <summary> Gets or sets the identity. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the sku. </summary>
        public ResourceModelWithAllowedPropertySetSku Sku { get; set; }
        /// <summary> Gets or sets the plan. </summary>
        public ArmPlan Plan { get; set; }
    }
}
