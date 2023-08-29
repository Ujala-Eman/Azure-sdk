// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the MsixPackage data model.
    /// Schema for MSIX Package properties.
    /// </summary>
    public partial class MsixPackageData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MsixPackageData"/>. </summary>
        public MsixPackageData()
        {
            PackageDependencies = new ChangeTrackingList<MsixPackageDependencies>();
            PackageApplications = new ChangeTrackingList<MsixPackageApplications>();
        }

        /// <summary> Initializes a new instance of <see cref="MsixPackageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="imagePath"> VHD/CIM image path on Network Share. </param>
        /// <param name="packageName"> Package Name from appxmanifest.xml. </param>
        /// <param name="packageFamilyName"> Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. </param>
        /// <param name="displayName"> User friendly Name to be displayed in the portal. </param>
        /// <param name="packageRelativePath"> Relative Path to the package inside the image. </param>
        /// <param name="isRegularRegistration"> Specifies how to register Package in feed. </param>
        /// <param name="isActive"> Make this version of the package the active one across the hostpool. </param>
        /// <param name="packageDependencies"> List of package dependencies. </param>
        /// <param name="version"> Package Version found in the appxmanifest.xml. </param>
        /// <param name="lastUpdatedOn"> Date Package was last updated, found in the appxmanifest.xml. </param>
        /// <param name="packageApplications"> List of package applications. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MsixPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string imagePath, string packageName, string packageFamilyName, string displayName, string packageRelativePath, bool? isRegularRegistration, bool? isActive, IList<MsixPackageDependencies> packageDependencies, string version, DateTimeOffset? lastUpdatedOn, IList<MsixPackageApplications> packageApplications, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ImagePath = imagePath;
            PackageName = packageName;
            PackageFamilyName = packageFamilyName;
            DisplayName = displayName;
            PackageRelativePath = packageRelativePath;
            IsRegularRegistration = isRegularRegistration;
            IsActive = isActive;
            PackageDependencies = packageDependencies;
            Version = version;
            LastUpdatedOn = lastUpdatedOn;
            PackageApplications = packageApplications;
            _rawData = rawData;
        }

        /// <summary> VHD/CIM image path on Network Share. </summary>
        public string ImagePath { get; set; }
        /// <summary> Package Name from appxmanifest.xml. </summary>
        public string PackageName { get; set; }
        /// <summary> Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. </summary>
        public string PackageFamilyName { get; set; }
        /// <summary> User friendly Name to be displayed in the portal. </summary>
        public string DisplayName { get; set; }
        /// <summary> Relative Path to the package inside the image. </summary>
        public string PackageRelativePath { get; set; }
        /// <summary> Specifies how to register Package in feed. </summary>
        public bool? IsRegularRegistration { get; set; }
        /// <summary> Make this version of the package the active one across the hostpool. </summary>
        public bool? IsActive { get; set; }
        /// <summary> List of package dependencies. </summary>
        public IList<MsixPackageDependencies> PackageDependencies { get; }
        /// <summary> Package Version found in the appxmanifest.xml. </summary>
        public string Version { get; set; }
        /// <summary> Date Package was last updated, found in the appxmanifest.xml. </summary>
        public DateTimeOffset? LastUpdatedOn { get; set; }
        /// <summary> List of package applications. </summary>
        public IList<MsixPackageApplications> PackageApplications { get; }
    }
}
