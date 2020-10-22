// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AlertingResultQuery. </summary>
    internal partial class AlertingResultQuery
    {
        /// <summary> Initializes a new instance of AlertingResultQuery. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="timeMode"> time mode. </param>
        public AlertingResultQuery(DateTimeOffset startTime, DateTimeOffset endTime, AlertQueryTimeMode timeMode)
        {
            StartTime = startTime;
            EndTime = endTime;
            TimeMode = timeMode;
        }

        /// <summary> start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> time mode. </summary>
        public AlertQueryTimeMode TimeMode { get; }
    }
}
