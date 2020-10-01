// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Metric availability specifies the time grain (aggregation interval or frequency) and the retention period for that time grain. </summary>
    public partial class MetricAvailability
    {
        /// <summary> Initializes a new instance of MetricAvailability. </summary>
        internal MetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of MetricAvailability. </summary>
        /// <param name="timeGrain"> the time grain specifies the aggregation interval for the metric. Expressed as a duration &apos;PT1M&apos;, &apos;P1D&apos;, etc. </param>
        /// <param name="retention"> the retention period for the metric at the specified timegrain.  Expressed as a duration &apos;PT1M&apos;, &apos;P1D&apos;, etc. </param>
        internal MetricAvailability(TimeSpan? timeGrain, TimeSpan? retention)
        {
            TimeGrain = timeGrain;
            Retention = retention;
        }

        /// <summary> the time grain specifies the aggregation interval for the metric. Expressed as a duration &apos;PT1M&apos;, &apos;P1D&apos;, etc. </summary>
        public TimeSpan? TimeGrain { get; }
        /// <summary> the retention period for the metric at the specified timegrain.  Expressed as a duration &apos;PT1M&apos;, &apos;P1D&apos;, etc. </summary>
        public TimeSpan? Retention { get; }
    }
}
