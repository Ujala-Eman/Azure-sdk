// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Data flow debug settings. </summary>
    public partial class DataFlowDebugPackageDebugSettings
    {
        /// <summary> Initializes a new instance of DataFlowDebugPackageDebugSettings. </summary>
        public DataFlowDebugPackageDebugSettings()
        {
            SourceSettings = new ChangeTrackingList<DataFlowSourceSetting>();
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Source setting for data flow debug. </summary>
        public IList<DataFlowSourceSetting> SourceSettings { get; }
        /// <summary> Data flow parameters. </summary>
        public IDictionary<string, BinaryData> Parameters { get; }
        /// <summary>
        /// Parameters for dataset.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData DatasetParameters { get; set; }
    }
}
