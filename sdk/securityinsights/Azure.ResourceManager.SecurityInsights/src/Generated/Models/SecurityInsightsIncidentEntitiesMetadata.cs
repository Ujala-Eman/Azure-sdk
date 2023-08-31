// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Information of a specific aggregation in the incident related entities result. </summary>
    public partial class SecurityInsightsIncidentEntitiesMetadata
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentEntitiesMetadata"/>. </summary>
        /// <param name="count"> Total number of aggregations of the given kind in the incident related entities result. </param>
        /// <param name="entityKind"> The kind of the aggregated entity. </param>
        internal SecurityInsightsIncidentEntitiesMetadata(int count, SecurityInsightsEntityKind entityKind)
        {
            Count = count;
            EntityKind = entityKind;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentEntitiesMetadata"/>. </summary>
        /// <param name="count"> Total number of aggregations of the given kind in the incident related entities result. </param>
        /// <param name="entityKind"> The kind of the aggregated entity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsIncidentEntitiesMetadata(int count, SecurityInsightsEntityKind entityKind, Dictionary<string, BinaryData> rawData)
        {
            Count = count;
            EntityKind = entityKind;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsIncidentEntitiesMetadata"/> for deserialization. </summary>
        internal SecurityInsightsIncidentEntitiesMetadata()
        {
        }

        /// <summary> Total number of aggregations of the given kind in the incident related entities result. </summary>
        public int Count { get; }
        /// <summary> The kind of the aggregated entity. </summary>
        public SecurityInsightsEntityKind EntityKind { get; }
    }
}
