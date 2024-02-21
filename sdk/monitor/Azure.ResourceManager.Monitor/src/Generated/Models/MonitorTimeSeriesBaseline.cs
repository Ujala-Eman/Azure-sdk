// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The baseline values for a single time series. </summary>
    public partial class MonitorTimeSeriesBaseline
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorTimeSeriesBaseline"/>. </summary>
        /// <param name="aggregation"> The aggregation type of the metric. </param>
        /// <param name="timestamps"> The list of timestamps of the baselines. </param>
        /// <param name="data"> The baseline values for each sensitivity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregation"/>, <paramref name="timestamps"/> or <paramref name="data"/> is null. </exception>
        internal MonitorTimeSeriesBaseline(string aggregation, IEnumerable<DateTimeOffset> timestamps, IEnumerable<MonitorSingleBaseline> data)
        {
            Argument.AssertNotNull(aggregation, nameof(aggregation));
            Argument.AssertNotNull(timestamps, nameof(timestamps));
            Argument.AssertNotNull(data, nameof(data));

            Aggregation = aggregation;
            Dimensions = new ChangeTrackingList<MonitorMetricSingleDimension>();
            Timestamps = timestamps.ToList();
            Data = data.ToList();
            MetadataValues = new ChangeTrackingList<MonitorBaselineMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorTimeSeriesBaseline"/>. </summary>
        /// <param name="aggregation"> The aggregation type of the metric. </param>
        /// <param name="dimensions"> The dimensions of this time series. </param>
        /// <param name="timestamps"> The list of timestamps of the baselines. </param>
        /// <param name="data"> The baseline values for each sensitivity. </param>
        /// <param name="metadataValues"> The baseline metadata values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorTimeSeriesBaseline(string aggregation, IReadOnlyList<MonitorMetricSingleDimension> dimensions, IReadOnlyList<DateTimeOffset> timestamps, IReadOnlyList<MonitorSingleBaseline> data, IReadOnlyList<MonitorBaselineMetadata> metadataValues, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Aggregation = aggregation;
            Dimensions = dimensions;
            Timestamps = timestamps;
            Data = data;
            MetadataValues = metadataValues;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorTimeSeriesBaseline"/> for deserialization. </summary>
        internal MonitorTimeSeriesBaseline()
        {
        }

        /// <summary> The aggregation type of the metric. </summary>
        public string Aggregation { get; }
        /// <summary> The dimensions of this time series. </summary>
        public IReadOnlyList<MonitorMetricSingleDimension> Dimensions { get; }
        /// <summary> The list of timestamps of the baselines. </summary>
        public IReadOnlyList<DateTimeOffset> Timestamps { get; }
        /// <summary> The baseline values for each sensitivity. </summary>
        public IReadOnlyList<MonitorSingleBaseline> Data { get; }
        /// <summary> The baseline metadata values. </summary>
        public IReadOnlyList<MonitorBaselineMetadata> MetadataValues { get; }
    }
}
