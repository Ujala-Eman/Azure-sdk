// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The availability of the metric. </summary>
    public partial class CosmosDBMetricAvailability
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBMetricAvailability"/>. </summary>
        internal CosmosDBMetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBMetricAvailability"/>. </summary>
        /// <param name="timeGrain"> The time grain to be used to summarize the metric values. </param>
        /// <param name="retention"> The retention for the metric values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBMetricAvailability(string timeGrain, string retention, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeGrain = timeGrain;
            Retention = retention;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time grain to be used to summarize the metric values. </summary>
        public string TimeGrain { get; }
        /// <summary> The retention for the metric values. </summary>
        public string Retention { get; }
    }
}
