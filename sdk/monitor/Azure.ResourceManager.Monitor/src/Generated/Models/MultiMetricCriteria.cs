// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The types of conditions for a multi resource alert.
    /// Please note <see cref="MultiMetricCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DynamicMetricCriteria"/> and <see cref="MetricCriteria"/>.
    /// </summary>
    public partial class MultiMetricCriteria
    {
        /// <summary> Initializes a new instance of <see cref="MultiMetricCriteria"/>. </summary>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="metricName"/> is null. </exception>
        public MultiMetricCriteria(string name, string metricName, MetricCriteriaTimeAggregationType timeAggregation)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(metricName, nameof(metricName));

            Name = name;
            MetricName = metricName;
            TimeAggregation = timeAggregation;
            Dimensions = new ChangeTrackingList<MetricDimension>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="MultiMetricCriteria"/>. </summary>
        /// <param name="criterionType"> Specifies the type of threshold criteria. </param>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="metricNamespace"> Namespace of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <param name="dimensions"> List of dimension conditions. </param>
        /// <param name="skipMetricValidation"> Allows creating an alert rule on a custom metric that isn't yet emitted, by causing the metric validation to be skipped. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal MultiMetricCriteria(CriterionType criterionType, string name, string metricName, string metricNamespace, MetricCriteriaTimeAggregationType timeAggregation, IList<MetricDimension> dimensions, bool? skipMetricValidation, IDictionary<string, BinaryData> additionalProperties)
        {
            CriterionType = criterionType;
            Name = name;
            MetricName = metricName;
            MetricNamespace = metricNamespace;
            TimeAggregation = timeAggregation;
            Dimensions = dimensions;
            SkipMetricValidation = skipMetricValidation;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="MultiMetricCriteria"/> for deserialization. </summary>
        internal MultiMetricCriteria()
        {
        }

        /// <summary> Specifies the type of threshold criteria. </summary>
        internal CriterionType CriterionType { get; set; }
        /// <summary> Name of the criteria. </summary>
        public string Name { get; set; }
        /// <summary> Name of the metric. </summary>
        public string MetricName { get; set; }
        /// <summary> Namespace of the metric. </summary>
        public string MetricNamespace { get; set; }
        /// <summary> the criteria time aggregation types. </summary>
        public MetricCriteriaTimeAggregationType TimeAggregation { get; set; }
        /// <summary> List of dimension conditions. </summary>
        public IList<MetricDimension> Dimensions { get; }
        /// <summary> Allows creating an alert rule on a custom metric that isn't yet emitted, by causing the metric validation to be skipped. </summary>
        public bool? SkipMetricValidation { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
