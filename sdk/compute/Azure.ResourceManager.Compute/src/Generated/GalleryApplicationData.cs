// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the GalleryApplication data model. </summary>
    public partial class GalleryApplicationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="GalleryApplicationData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GalleryApplicationData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of this gallery Application Definition resource. This property is updatable. </param>
        /// <param name="eula"> The Eula agreement for the gallery Application Definition. </param>
        /// <param name="privacyStatementUri"> The privacy statement uri. </param>
        /// <param name="releaseNoteUri"> The release note uri. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="supportedOSType"> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        internal GalleryApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, string eula, Uri privacyStatementUri, Uri releaseNoteUri, DateTimeOffset? endOfLifeOn, OperatingSystemTypes? supportedOSType) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            EndOfLifeOn = endOfLifeOn;
            SupportedOSType = supportedOSType;
        }

        /// <summary> The description of this gallery Application Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Application Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public Uri PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public Uri ReleaseNoteUri { get; set; }
        /// <summary> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; set; }
        /// <summary> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? SupportedOSType { get; set; }
    }
}
