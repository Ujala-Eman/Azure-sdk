// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
    internal partial class DynatraceMonitorResourceMetricRules
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorResourceMetricRules"/>. </summary>
        public DynatraceMonitorResourceMetricRules()
        {
            FilteringTags = new ChangeTrackingList<DynatraceMonitorResourceFilteringTag>();
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorResourceMetricRules"/>. </summary>
        /// <param name="filteringTags"> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceMonitorResourceMetricRules(IList<DynatraceMonitorResourceFilteringTag> filteringTags, Dictionary<string, BinaryData> rawData)
        {
            FilteringTags = filteringTags;
            _rawData = rawData;
        }

        /// <summary> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </summary>
        public IList<DynatraceMonitorResourceFilteringTag> FilteringTags { get; }
    }
}
