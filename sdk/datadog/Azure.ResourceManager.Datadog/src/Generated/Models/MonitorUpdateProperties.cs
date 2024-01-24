// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The set of properties that can be update in a PATCH request to a monitor resource. </summary>
    internal partial class MonitorUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="MonitorUpdateProperties"/>. </summary>
        public MonitorUpdateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorUpdateProperties"/>. </summary>
        /// <param name="monitoringStatus"> Flag specifying if the resource monitoring is enabled or disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorUpdateProperties(MonitoringStatus? monitoringStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MonitoringStatus = monitoringStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag specifying if the resource monitoring is enabled or disabled. </summary>
        public MonitoringStatus? MonitoringStatus { get; set; }
    }
}
