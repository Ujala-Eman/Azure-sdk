// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownConfigurationSettings. </summary>
    internal partial class UnknownConfigurationSettings : SiteRecoveryReplicationProviderSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownConfigurationSettings"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownConfigurationSettings(string instanceType, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownConfigurationSettings"/> for deserialization. </summary>
        internal UnknownConfigurationSettings()
        {
        }
    }
}
