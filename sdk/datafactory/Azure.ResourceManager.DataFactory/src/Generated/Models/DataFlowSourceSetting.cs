// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Definition of data flow source setting for debug. </summary>
    public partial class DataFlowSourceSetting
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowSourceSetting"/>. </summary>
        public DataFlowSourceSetting()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowSourceSetting"/>. </summary>
        /// <param name="sourceName"> The data flow source name. </param>
        /// <param name="rowLimit"> Defines the row limit of data flow source in debug. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFlowSourceSetting(string sourceName, int? rowLimit, IDictionary<string, BinaryData> additionalProperties)
        {
            SourceName = sourceName;
            RowLimit = rowLimit;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The data flow source name. </summary>
        public string SourceName { get; set; }
        /// <summary> Defines the row limit of data flow source in debug. </summary>
        public int? RowLimit { get; set; }
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
