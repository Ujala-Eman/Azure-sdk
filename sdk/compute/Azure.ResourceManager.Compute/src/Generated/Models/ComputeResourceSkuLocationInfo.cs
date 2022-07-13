// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an available Compute SKU Location Information. </summary>
    public partial class ComputeResourceSkuLocationInfo
    {
        /// <summary> Initializes a new instance of ComputeResourceSkuLocationInfo. </summary>
        internal ComputeResourceSkuLocationInfo()
        {
            Zones = new ChangeTrackingList<string>();
            ZoneDetails = new ChangeTrackingList<ComputeResourceSkuZoneDetails>();
            ExtendedLocations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ComputeResourceSkuLocationInfo. </summary>
        /// <param name="location"> Location of the SKU. </param>
        /// <param name="zones"> List of availability zones where the SKU is supported. </param>
        /// <param name="zoneDetails"> Details of capabilities available to a SKU in specific zones. </param>
        /// <param name="extendedLocations"> The names of extended locations. </param>
        /// <param name="extendedLocationType"> The type of the extended location. </param>
        internal ComputeResourceSkuLocationInfo(AzureLocation? location, IReadOnlyList<string> zones, IReadOnlyList<ComputeResourceSkuZoneDetails> zoneDetails, IReadOnlyList<string> extendedLocations, ExtendedLocationType? extendedLocationType)
        {
            Location = location;
            Zones = zones;
            ZoneDetails = zoneDetails;
            ExtendedLocations = extendedLocations;
            ExtendedLocationType = extendedLocationType;
        }

        /// <summary> Location of the SKU. </summary>
        public AzureLocation? Location { get; }
        /// <summary> List of availability zones where the SKU is supported. </summary>
        public IReadOnlyList<string> Zones { get; }
        /// <summary> Details of capabilities available to a SKU in specific zones. </summary>
        public IReadOnlyList<ComputeResourceSkuZoneDetails> ZoneDetails { get; }
        /// <summary> The names of extended locations. </summary>
        public IReadOnlyList<string> ExtendedLocations { get; }
    }
}
