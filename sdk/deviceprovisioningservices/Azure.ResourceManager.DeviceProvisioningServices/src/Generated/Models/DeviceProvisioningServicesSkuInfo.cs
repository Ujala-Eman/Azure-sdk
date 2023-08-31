// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> List of possible provisioning service SKUs. </summary>
    public partial class DeviceProvisioningServicesSkuInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSkuInfo"/>. </summary>
        public DeviceProvisioningServicesSkuInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesSkuInfo"/>. </summary>
        /// <param name="name"> Sku name. </param>
        /// <param name="tier"> Pricing tier name of the provisioning service. </param>
        /// <param name="capacity"> The number of units to provision. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesSkuInfo(DeviceProvisioningServicesSku? name, string tier, long? capacity, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _rawData = rawData;
        }

        /// <summary> Sku name. </summary>
        public DeviceProvisioningServicesSku? Name { get; set; }
        /// <summary> Pricing tier name of the provisioning service. </summary>
        public string Tier { get; }
        /// <summary> The number of units to provision. </summary>
        public long? Capacity { get; set; }
    }
}
