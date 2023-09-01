// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The MetricResultsResponseValuesItem. </summary>
    public partial class MetricResultsResponseValuesItem
    {
        /// <summary> Initializes a new instance of MetricResultsResponseValuesItem. </summary>
        /// <param name="starttime"> The start time, in datetime format, for which the data was retrieved. </param>
        /// <param name="endtime"> The end time, in datetime format, for which the data was retrieved. </param>
        /// <param name="value"> The value of the collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="starttime"/>, <paramref name="endtime"/> or <paramref name="value"/> is null. </exception>
        internal MetricResultsResponseValuesItem(string starttime, string endtime, IEnumerable<QueryBatchMetric> value)
        {
            Argument.AssertNotNull(starttime, nameof(starttime));
            Argument.AssertNotNull(endtime, nameof(endtime));
            Argument.AssertNotNull(value, nameof(value));

            Starttime = starttime;
            Endtime = endtime;
            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of MetricResultsResponseValuesItem. </summary>
        /// <param name="starttime"> The start time, in datetime format, for which the data was retrieved. </param>
        /// <param name="endtime"> The end time, in datetime format, for which the data was retrieved. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in. Follows the IS8601/RFC3339 duration format (e.g. 'P1D' for 1 day). This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="resourceregion"> The region of the resource been queried for metrics. </param>
        /// <param name="resourceid"> The resource that has been queried for metrics. </param>
        /// <param name="value"> The value of the collection. </param>
        internal MetricResultsResponseValuesItem(string starttime, string endtime, TimeSpan? interval, string @namespace, string resourceregion, string resourceid, IReadOnlyList<QueryBatchMetric> value)
        {
            Starttime = starttime;
            Endtime = endtime;
            Interval = interval;
            Namespace = @namespace;
            Resourceregion = resourceregion;
            Resourceid = resourceid;
            Value = value;
        }

        /// <summary> The start time, in datetime format, for which the data was retrieved. </summary>
        public string Starttime { get; }
        /// <summary> The end time, in datetime format, for which the data was retrieved. </summary>
        public string Endtime { get; }
        /// <summary> The interval (window size) for which the metric data was returned in. Follows the IS8601/RFC3339 duration format (e.g. 'P1D' for 1 day). This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The namespace of the metrics been queried. </summary>
        public string Namespace { get; }
        /// <summary> The region of the resource been queried for metrics. </summary>
        public string Resourceregion { get; }
        /// <summary> The resource that has been queried for metrics. </summary>
        public string Resourceid { get; }
        /// <summary> The value of the collection. </summary>
        public IReadOnlyList<QueryBatchMetric> Value { get; }
    }
}
