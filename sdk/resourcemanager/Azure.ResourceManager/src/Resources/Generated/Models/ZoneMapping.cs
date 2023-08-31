// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The ZoneMapping. </summary>
    public partial class ZoneMapping
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ZoneMapping"/>. </summary>
        internal ZoneMapping()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ZoneMapping"/>. </summary>
        /// <param name="location"> The location of the zone mapping. </param>
        /// <param name="zones"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ZoneMapping(AzureLocation? location, IReadOnlyList<string> zones, Dictionary<string, BinaryData> rawData)
        {
            Location = location;
            Zones = zones;
            _rawData = rawData;
        }

        /// <summary> The location of the zone mapping. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Gets the zones. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
