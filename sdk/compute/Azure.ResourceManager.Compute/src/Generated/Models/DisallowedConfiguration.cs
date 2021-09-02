// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the disallowed configuration for a virtual machine image. </summary>
    public partial class DisallowedConfiguration
    {
        /// <summary> Initializes a new instance of DisallowedConfiguration. </summary>
        public DisallowedConfiguration()
        {
        }

        /// <summary> Initializes a new instance of DisallowedConfiguration. </summary>
        /// <param name="vmDiskType"> VM disk types which are disallowed. </param>
        internal DisallowedConfiguration(VmDiskTypes? vmDiskType)
        {
            VmDiskType = vmDiskType;
        }

        /// <summary> VM disk types which are disallowed. </summary>
        public VmDiskTypes? VmDiskType { get; set; }
    }
}
