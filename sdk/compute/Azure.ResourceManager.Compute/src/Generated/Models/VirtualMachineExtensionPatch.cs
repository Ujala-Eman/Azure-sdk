// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Extension. </summary>
    public partial class VirtualMachineExtensionPatch : ComputeUpdateResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionPatch"/>. </summary>
        public VirtualMachineExtensionPatch()
        {
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
        /// <summary> Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false. </summary>
        public bool? SuppressFailures { get; set; }
    }
}
