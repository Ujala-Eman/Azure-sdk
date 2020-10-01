// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AlertSnoozeCondition. </summary>
    public partial class MetricAnomalyAlertSnoozeCondition
    {
        /// <summary> Initializes a new instance of MetricAnomalyAlertSnoozeCondition. </summary>
        /// <param name="autoSnooze"> snooze point count, value range : [0, +∞). </param>
        /// <param name="snoozeScope"> snooze scope. </param>
        /// <param name="isOnlyForSuccessive"> only snooze for successive anomalies. </param>
        public MetricAnomalyAlertSnoozeCondition(int autoSnooze, SnoozeScope snoozeScope, bool isOnlyForSuccessive)
        {
            AutoSnooze = autoSnooze;
            SnoozeScope = snoozeScope;
            IsOnlyForSuccessive = isOnlyForSuccessive;
        }
    }
}
