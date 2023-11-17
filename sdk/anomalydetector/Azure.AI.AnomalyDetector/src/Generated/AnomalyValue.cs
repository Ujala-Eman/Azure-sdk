// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Detailed information of the anomalous time stamp. </summary>
    public partial class AnomalyValue
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

        /// <summary> Initializes a new instance of <see cref="AnomalyValue"/>. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current time stamp. </param>
        /// <param name="severity">
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </param>
        /// <param name="score"> Raw anomaly score of severity, to help indicate the degree of abnormality. </param>
        internal AnomalyValue(bool isAnomaly, float severity, float score)
        {
            IsAnomaly = isAnomaly;
            Severity = severity;
            Score = score;
            Interpretation = new ChangeTrackingList<AnomalyInterpretation>();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyValue"/>. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current time stamp. </param>
        /// <param name="severity">
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </param>
        /// <param name="score"> Raw anomaly score of severity, to help indicate the degree of abnormality. </param>
        /// <param name="interpretation"> Interpretation of this anomalous time stamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnomalyValue(bool isAnomaly, float severity, float score, IReadOnlyList<AnomalyInterpretation> interpretation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAnomaly = isAnomaly;
            Severity = severity;
            Score = score;
            Interpretation = interpretation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyValue"/> for deserialization. </summary>
        internal AnomalyValue()
        {
        }

        /// <summary> True if an anomaly is detected at the current time stamp. </summary>
        public bool IsAnomaly { get; }
        /// <summary>
        /// Indicates the significance of the anomaly. The higher the severity, the more
        /// significant the anomaly is.
        /// </summary>
        public float Severity { get; }
        /// <summary> Raw anomaly score of severity, to help indicate the degree of abnormality. </summary>
        public float Score { get; }
        /// <summary> Interpretation of this anomalous time stamp. </summary>
        public IReadOnlyList<AnomalyInterpretation> Interpretation { get; }
    }
}
