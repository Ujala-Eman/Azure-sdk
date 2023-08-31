// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> E2E Network Mapping fabric specific settings. </summary>
    public partial class VmmToVmmNetworkMappingSettings : NetworkMappingFabricSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="VmmToVmmNetworkMappingSettings"/>. </summary>
        internal VmmToVmmNetworkMappingSettings()
        {
            InstanceType = "VmmToVmm";
        }

        /// <summary> Initializes a new instance of <see cref="VmmToVmmNetworkMappingSettings"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VmmToVmmNetworkMappingSettings(string instanceType, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            InstanceType = instanceType ?? "VmmToVmm";
        }
    }
}
