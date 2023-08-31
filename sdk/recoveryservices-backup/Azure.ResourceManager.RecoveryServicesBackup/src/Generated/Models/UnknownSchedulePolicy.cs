// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownSchedulePolicy. </summary>
    internal partial class UnknownSchedulePolicy : BackupSchedulePolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSchedulePolicy"/>. </summary>
        /// <param name="schedulePolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSchedulePolicy(string schedulePolicyType, Dictionary<string, BinaryData> rawData) : base(schedulePolicyType, rawData)
        {
            SchedulePolicyType = schedulePolicyType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSchedulePolicy"/> for deserialization. </summary>
        internal UnknownSchedulePolicy()
        {
        }
    }
}
