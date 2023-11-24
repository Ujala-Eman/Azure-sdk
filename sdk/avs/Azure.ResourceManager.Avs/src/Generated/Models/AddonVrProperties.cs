// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a vSphere Replication (VR) addon. </summary>
    public partial class AddonVrProperties : AvsPrivateCloudAddonProperties
    {
        /// <summary> Initializes a new instance of <see cref="AddonVrProperties"/>. </summary>
        /// <param name="vrsCount"> The vSphere Replication Server (VRS) count. </param>
        public AddonVrProperties(int vrsCount)
        {
            VrsCount = vrsCount;
            AddonType = AddonType.VR;
        }

        /// <summary> Initializes a new instance of <see cref="AddonVrProperties"/>. </summary>
        /// <param name="addonType"> The type of private cloud addon. </param>
        /// <param name="provisioningState"> The state of the addon provisioning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vrsCount"> The vSphere Replication Server (VRS) count. </param>
        internal AddonVrProperties(AddonType addonType, AddonProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, int vrsCount) : base(addonType, provisioningState, serializedAdditionalRawData)
        {
            VrsCount = vrsCount;
            AddonType = addonType;
        }

        /// <summary> Initializes a new instance of <see cref="AddonVrProperties"/> for deserialization. </summary>
        internal AddonVrProperties()
        {
        }

        /// <summary> The vSphere Replication Server (VRS) count. </summary>
        public int VrsCount { get; set; }
    }
}
