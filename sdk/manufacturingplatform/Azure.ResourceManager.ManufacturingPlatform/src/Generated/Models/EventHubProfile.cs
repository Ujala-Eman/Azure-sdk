// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManufacturingPlatform.Models
{
    /// <summary> The properties related to EventHub Resource. </summary>
    public partial class EventHubProfile
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

        /// <summary> Initializes a new instance of <see cref="EventHubProfile"/>. </summary>
        internal EventHubProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubProfile"/>. </summary>
        /// <param name="adxInstanceId"> Resource Id of Adx Instance. </param>
        /// <param name="hostName"> Host Name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubProfile(string adxInstanceId, string hostName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdxInstanceId = adxInstanceId;
            HostName = hostName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource Id of Adx Instance. </summary>
        public string AdxInstanceId { get; }
        /// <summary> Host Name. </summary>
        public string HostName { get; }
    }
}
