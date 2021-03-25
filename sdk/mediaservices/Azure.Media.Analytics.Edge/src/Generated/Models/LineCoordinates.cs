// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Describes the start point and end point of a line in the frame. </summary>
    public partial class LineCoordinates
    {
        /// <summary> Initializes a new instance of LineCoordinates. </summary>
        /// <param name="start"> Sets the coordinates of the starting point for the line. </param>
        /// <param name="end"> Sets the coordinates of the ending point for the line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="start"/> or <paramref name="end"/> is null. </exception>
        public LineCoordinates(Point start, Point end)
        {
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }
            if (end == null)
            {
                throw new ArgumentNullException(nameof(end));
            }

            Start = start;
            End = end;
        }

        /// <summary> Sets the coordinates of the starting point for the line. </summary>
        public Point Start { get; set; }
        /// <summary> Sets the coordinates of the ending point for the line. </summary>
        public Point End { get; set; }
    }
}
