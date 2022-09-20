// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Routing.Models
{
    /// <summary> Data contained by a `GeoJson MultiPoint`. </summary>
    internal partial class GeoJsonMultiPointData
    {
        /// <summary> Initializes a new instance of GeoJsonMultiPointData. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson MultiPoint` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonMultiPointData(IEnumerable<IList<double>> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException(nameof(coordinates));
            }

            Coordinates = coordinates.ToList();
        }

        /// <summary> Coordinates for the `GeoJson MultiPoint` geometry. </summary>
        public IList<IList<double>> Coordinates { get; }
    }
}
