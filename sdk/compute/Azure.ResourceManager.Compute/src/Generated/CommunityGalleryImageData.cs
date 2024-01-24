// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CommunityGalleryImage data model.
    /// Specifies information about the gallery image definition that you want to create or update.
    /// </summary>
    public partial class CommunityGalleryImageData : PirCommunityGalleryResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageData"/>. </summary>
        internal CommunityGalleryImageData()
        {
            Features = new ChangeTrackingList<GalleryImageFeature>();
            ArtifactTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageData"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="uniqueId"> The unique id of this community gallery. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. Possible values are: **Windows,** **Linux.**. </param>
        /// <param name="osState"> This property allows the user to specify whether the virtual machines created under this image are 'Generalized' or 'Specialized'. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="imageIdentifier"> This is the community gallery image definition identifier. </param>
        /// <param name="recommended"> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </param>
        /// <param name="disallowed"> Describes the disallowed disk types. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="features"> A list of gallery image features. </param>
        /// <param name="purchasePlan"> Describes the gallery image definition purchase plan. This is used by marketplace images. </param>
        /// <param name="architecture"> The architecture of the image. Applicable to OS disks only. </param>
        /// <param name="privacyStatementUri"> Privacy statement URI for the current community gallery image. </param>
        /// <param name="eula"> The end-user license agreement for the current community gallery image. </param>
        /// <param name="disclaimer"> The disclaimer for a community gallery resource. </param>
        /// <param name="artifactTags"> The artifact tags of a community gallery resource. </param>
        internal CommunityGalleryImageData(string name, AzureLocation? location, ResourceType? resourceType, string uniqueId, IDictionary<string, BinaryData> serializedAdditionalRawData, SupportedOperatingSystemType? osType, OperatingSystemStateType? osState, DateTimeOffset? endOfLifeOn, CommunityGalleryImageIdentifier imageIdentifier, RecommendedMachineConfiguration recommended, Disallowed disallowed, HyperVGeneration? hyperVGeneration, IReadOnlyList<GalleryImageFeature> features, ImagePurchasePlan purchasePlan, ArchitectureType? architecture, Uri privacyStatementUri, string eula, string disclaimer, IReadOnlyDictionary<string, string> artifactTags) : base(name, location, resourceType, uniqueId, serializedAdditionalRawData)
        {
            OSType = osType;
            OSState = osState;
            EndOfLifeOn = endOfLifeOn;
            ImageIdentifier = imageIdentifier;
            Recommended = recommended;
            Disallowed = disallowed;
            HyperVGeneration = hyperVGeneration;
            Features = features;
            PurchasePlan = purchasePlan;
            Architecture = architecture;
            PrivacyStatementUri = privacyStatementUri;
            Eula = eula;
            Disclaimer = disclaimer;
            ArtifactTags = artifactTags;
        }

        /// <summary> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. Possible values are: **Windows,** **Linux.**. </summary>
        public SupportedOperatingSystemType? OSType { get; }
        /// <summary> This property allows the user to specify whether the virtual machines created under this image are 'Generalized' or 'Specialized'. </summary>
        public OperatingSystemStateType? OSState { get; }
        /// <summary> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
        /// <summary> This is the community gallery image definition identifier. </summary>
        public CommunityGalleryImageIdentifier ImageIdentifier { get; }
        /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
        public RecommendedMachineConfiguration Recommended { get; }
        /// <summary> Describes the disallowed disk types. </summary>
        internal Disallowed Disallowed { get; }
        /// <summary> A list of disk types. </summary>
        public IList<string> DisallowedDiskTypes
        {
            get => Disallowed?.DiskTypes;
        }

        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; }
        /// <summary> A list of gallery image features. </summary>
        public IReadOnlyList<GalleryImageFeature> Features { get; }
        /// <summary> Describes the gallery image definition purchase plan. This is used by marketplace images. </summary>
        public ImagePurchasePlan PurchasePlan { get; }
        /// <summary> The architecture of the image. Applicable to OS disks only. </summary>
        public ArchitectureType? Architecture { get; }
        /// <summary> Privacy statement URI for the current community gallery image. </summary>
        public Uri PrivacyStatementUri { get; }
        /// <summary> The end-user license agreement for the current community gallery image. </summary>
        public string Eula { get; }
        /// <summary> The disclaimer for a community gallery resource. </summary>
        public string Disclaimer { get; }
        /// <summary> The artifact tags of a community gallery resource. </summary>
        public IReadOnlyDictionary<string, string> ArtifactTags { get; }
        /// <summary> The resource identifier. </summary>
        public ResourceIdentifier Id { get; internal set; }
    }
}
