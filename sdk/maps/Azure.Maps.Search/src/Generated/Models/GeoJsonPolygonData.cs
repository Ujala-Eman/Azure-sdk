// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> The GeoJsonPolygonData. </summary>
    public partial class GeoJsonPolygonData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonPolygonData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson Polygon` geometry type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonPolygonData(IEnumerable<IList<IList<double>>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonPolygonData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson Polygon` geometry type. </param>
        internal GeoJsonPolygonData(IList<IList<IList<double>>> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> Coordinates for the `GeoJson Polygon` geometry type. </summary>
        public IList<IList<IList<double>>> Coordinates { get; }
    }
}
