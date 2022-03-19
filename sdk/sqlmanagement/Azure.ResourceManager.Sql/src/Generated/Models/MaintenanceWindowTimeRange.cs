// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Maintenance window time range. </summary>
    public partial class MaintenanceWindowTimeRange
    {
        /// <summary> Initializes a new instance of MaintenanceWindowTimeRange. </summary>
        public MaintenanceWindowTimeRange()
        {
        }

        /// <summary> Initializes a new instance of MaintenanceWindowTimeRange. </summary>
        /// <param name="dayOfWeek"> Day of maintenance window. </param>
        /// <param name="startTime"> Start time minutes offset from 12am. </param>
        /// <param name="duration"> Duration of maintenance window in minutes. </param>
        internal MaintenanceWindowTimeRange(SqlDayOfWeek? dayOfWeek, string startTime, TimeSpan? duration)
        {
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            Duration = duration;
        }

        /// <summary> Day of maintenance window. </summary>
        public SqlDayOfWeek? DayOfWeek { get; set; }
        /// <summary> Start time minutes offset from 12am. </summary>
        public string StartTime { get; set; }
        /// <summary> Duration of maintenance window in minutes. </summary>
        public TimeSpan? Duration { get; set; }
    }
}
