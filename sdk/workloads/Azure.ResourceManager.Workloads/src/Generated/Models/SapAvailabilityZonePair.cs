// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP Availability Zone Pair. </summary>
    public partial class SapAvailabilityZonePair
    {
        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZonePair"/>. </summary>
        internal SapAvailabilityZonePair()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapAvailabilityZonePair"/>. </summary>
        /// <param name="zoneA"> The zone A. </param>
        /// <param name="zoneB"> The zone B. </param>
        internal SapAvailabilityZonePair(long? zoneA, long? zoneB)
        {
            ZoneA = zoneA;
            ZoneB = zoneB;
        }

        /// <summary> The zone A. </summary>
        public long? ZoneA { get; }
        /// <summary> The zone B. </summary>
        public long? ZoneB { get; }
    }
}
