// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SqlManagementClient.Models
{
    /// <summary> The edition capability. </summary>
    public partial class EditionCapability
    {
        /// <summary> Initializes a new instance of EditionCapability. </summary>
        internal EditionCapability()
        {
            SupportedServiceLevelObjectives = new ChangeTrackingList<ServiceObjectiveCapability>();
            SupportedStorageCapabilities = new ChangeTrackingList<StorageCapability>();
        }

        /// <summary> Initializes a new instance of EditionCapability. </summary>
        /// <param name="name"> The database edition name. </param>
        /// <param name="supportedServiceLevelObjectives"> The list of supported service objectives for the edition. </param>
        /// <param name="zoneRedundant"> Whether or not zone redundancy is supported for the edition. </param>
        /// <param name="readScale"> The read scale capability for the edition. </param>
        /// <param name="supportedStorageCapabilities"> The list of supported storage capabilities for this edition. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal EditionCapability(string name, IReadOnlyList<ServiceObjectiveCapability> supportedServiceLevelObjectives, bool? zoneRedundant, ReadScaleCapability readScale, IReadOnlyList<StorageCapability> supportedStorageCapabilities, CapabilityStatus? status, string reason)
        {
            Name = name;
            SupportedServiceLevelObjectives = supportedServiceLevelObjectives;
            ZoneRedundant = zoneRedundant;
            ReadScale = readScale;
            SupportedStorageCapabilities = supportedStorageCapabilities;
            Status = status;
            Reason = reason;
        }

        /// <summary> The database edition name. </summary>
        public string Name { get; }
        /// <summary> The list of supported service objectives for the edition. </summary>
        public IReadOnlyList<ServiceObjectiveCapability> SupportedServiceLevelObjectives { get; }
        /// <summary> Whether or not zone redundancy is supported for the edition. </summary>
        public bool? ZoneRedundant { get; }
        /// <summary> The read scale capability for the edition. </summary>
        public ReadScaleCapability ReadScale { get; }
        /// <summary> The list of supported storage capabilities for this edition. </summary>
        public IReadOnlyList<StorageCapability> SupportedStorageCapabilities { get; }
        /// <summary> The status of the capability. </summary>
        public CapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
