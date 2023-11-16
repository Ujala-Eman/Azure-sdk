// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Specifies the security settings like secure boot used while creating the virtual machine. </summary>
    internal partial class UefiSettings
    {
        /// <summary> Initializes a new instance of UefiSettings. </summary>
        public UefiSettings()
        {
        }

        /// <summary> Initializes a new instance of UefiSettings. </summary>
        /// <param name="secureBootEnabled"> Specifies whether secure boot should be enabled on the virtual machine. </param>
        internal UefiSettings(bool? secureBootEnabled)
        {
            SecureBootEnabled = secureBootEnabled;
        }

        /// <summary> Specifies whether secure boot should be enabled on the virtual machine. </summary>
        public bool? SecureBootEnabled { get; set; }
    }
}
