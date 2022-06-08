// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies VM Size Property settings on the virtual machine. </summary>
    public partial class VmSizeProperties
    {
        /// <summary> Initializes a new instance of <see cref="VmSizeProperties"/>. </summary>
        public VmSizeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VmSizeProperties"/>. </summary>
        /// <param name="vcpUsAvailable"> Specifies the number of vCPUs available for the VM. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body the default behavior is to set it to the value of vCPUs available for that VM size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) . </param>
        /// <param name="vcpUsPerCore"> Specifies the vCPU to physical core ratio. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body the default behavior is set to the value of vCPUsPerCore for the VM Size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) &lt;br&gt;&lt;br&gt; Setting this property to 1 also means that hyper-threading is disabled. </param>
        internal VmSizeProperties(int? vcpUsAvailable, int? vcpUsPerCore)
        {
            VCPUsAvailable = vcpUsAvailable;
            VCPUsPerCore = vcpUsPerCore;
        }

        /// <summary> Specifies the number of vCPUs available for the VM. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body the default behavior is to set it to the value of vCPUs available for that VM size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) . </summary>
        public int? VCPUsAvailable { get; set; }
        /// <summary> Specifies the vCPU to physical core ratio. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body the default behavior is set to the value of vCPUsPerCore for the VM Size exposed in api response of [List all available virtual machine sizes in a region](https://docs.microsoft.com/en-us/rest/api/compute/resource-skus/list) &lt;br&gt;&lt;br&gt; Setting this property to 1 also means that hyper-threading is disabled. </summary>
        public int? VCPUsPerCore { get; set; }
    }
}
