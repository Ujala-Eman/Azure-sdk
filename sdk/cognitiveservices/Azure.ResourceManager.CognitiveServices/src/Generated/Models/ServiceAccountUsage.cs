// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The usage data for a usage request. </summary>
    public partial class ServiceAccountUsage
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

        /// <summary> Initializes a new instance of <see cref="ServiceAccountUsage"/>. </summary>
        internal ServiceAccountUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceAccountUsage"/>. </summary>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="quotaPeriod"> The quota period used to summarize the usage values. </param>
        /// <param name="limit"> Maximum value for this metric. </param>
        /// <param name="currentValue"> Current value for this metric. </param>
        /// <param name="nextResetTime"> Next reset time for current quota. </param>
        /// <param name="status"> Cognitive Services account quota usage status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceAccountUsage(ServiceAccountUsageUnitType? unit, ServiceAccountUsageMetricName name, string quotaPeriod, double? limit, double? currentValue, string nextResetTime, ServiceAccountQuotaUsageStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Unit = unit;
            Name = name;
            QuotaPeriod = quotaPeriod;
            Limit = limit;
            CurrentValue = currentValue;
            NextResetTime = nextResetTime;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unit of the metric. </summary>
        public ServiceAccountUsageUnitType? Unit { get; }
        /// <summary> The name information for the metric. </summary>
        public ServiceAccountUsageMetricName Name { get; }
        /// <summary> The quota period used to summarize the usage values. </summary>
        public string QuotaPeriod { get; }
        /// <summary> Maximum value for this metric. </summary>
        public double? Limit { get; }
        /// <summary> Current value for this metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> Next reset time for current quota. </summary>
        public string NextResetTime { get; }
        /// <summary> Cognitive Services account quota usage status. </summary>
        public ServiceAccountQuotaUsageStatus? Status { get; }
    }
}
