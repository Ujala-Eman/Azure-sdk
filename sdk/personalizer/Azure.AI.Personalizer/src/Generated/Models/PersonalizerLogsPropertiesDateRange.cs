// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Personalizer.Models
{
    /// <summary> Date range. </summary>
    public partial class PersonalizerLogsPropertiesDateRange : PersonalizerDateRange
    {
        /// <summary> Initializes a new instance of PersonalizerLogsPropertiesDateRange. </summary>
        internal PersonalizerLogsPropertiesDateRange()
        {
        }

        /// <summary> Initializes a new instance of PersonalizerLogsPropertiesDateRange. </summary>
        /// <param name="start"> Start date for the range. </param>
        /// <param name="end"> End date for the range. </param>
        internal PersonalizerLogsPropertiesDateRange(DateTimeOffset? start, DateTimeOffset? end) : base(start, end)
        {
        }
    }
}
