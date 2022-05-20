// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The estimated price info for using a VM of a particular OS type, tier, etc. </summary>
    public partial class EstimatedVMPrice
    {
        /// <summary> Initializes a new instance of EstimatedVMPrice. </summary>
        /// <param name="retailPrice"> The price charged for using the VM. </param>
        /// <param name="osType"> Operating system type used by the VM. </param>
        /// <param name="vmTier"> The type of the VM. </param>
        internal EstimatedVMPrice(double retailPrice, VMPriceOSType osType, VMTier vmTier)
        {
            RetailPrice = retailPrice;
            OsType = osType;
            VmTier = vmTier;
        }

        /// <summary> The price charged for using the VM. </summary>
        public double RetailPrice { get; }
        /// <summary> Operating system type used by the VM. </summary>
        public VMPriceOSType OsType { get; }
        /// <summary> The type of the VM. </summary>
        public VMTier VmTier { get; }
    }
}
