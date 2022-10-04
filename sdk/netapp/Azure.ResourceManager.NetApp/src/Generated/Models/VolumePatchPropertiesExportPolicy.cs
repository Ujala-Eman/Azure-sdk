// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Set of export policy rules. </summary>
    internal partial class VolumePatchPropertiesExportPolicy
    {
        /// <summary> Initializes a new instance of VolumePatchPropertiesExportPolicy. </summary>
        public VolumePatchPropertiesExportPolicy()
        {
            Rules = new ChangeTrackingList<NetAppVolumeExportPolicyRule>();
        }

        /// <summary> Export policy rule. </summary>
        public IList<NetAppVolumeExportPolicyRule> Rules { get; }
    }
}
