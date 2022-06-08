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
    /// <summary> A class representing the VirtualMachineExtension data model. </summary>
    public partial class VirtualMachineExtensionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineExtensionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="extensionType"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The virtual machine extension instance view. </param>
        /// <param name="suppressFailures"> Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false. </param>
        internal VirtualMachineExtensionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string forceUpdateTag, string publisher, string extensionType, string typeHandlerVersion, bool? autoUpgradeMinorVersion, bool? enableAutomaticUpgrade, BinaryData settings, BinaryData protectedSettings, string provisioningState, VirtualMachineExtensionInstanceView instanceView, bool? suppressFailures) : base(id, name, resourceType, systemData, tags, location)
        {
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            ExtensionType = extensionType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            SuppressFailures = suppressFailures;
        }

        /// <summary> How the extension handler should be forced to update even if the extension configuration has not changed. </summary>
        public string ForceUpdateTag { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string ExtensionType { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </summary>
        public bool? EnableAutomaticUpgrade { get; set; }
        /// <summary> Json formatted public settings for the extension. </summary>
        public BinaryData Settings { get; set; }
        /// <summary> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </summary>
        public BinaryData ProtectedSettings { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The virtual machine extension instance view. </summary>
        public VirtualMachineExtensionInstanceView InstanceView { get; set; }
        /// <summary> Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false. </summary>
        public bool? SuppressFailures { get; set; }
    }
}
