// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> CDC table details. </summary>
    public partial class MapperTable
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

        /// <summary> Initializes a new instance of <see cref="MapperTable"/>. </summary>
        public MapperTable()
        {
            Schema = new ChangeTrackingList<MapperTableSchema>();
            DslConnectorProperties = new ChangeTrackingList<MapperDslConnectorProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="MapperTable"/>. </summary>
        /// <param name="name"> Name of the table. </param>
        /// <param name="schema"> List of columns for the source table. </param>
        /// <param name="dslConnectorProperties"> List of name/value pairs for connection properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapperTable(string name, IList<MapperTableSchema> schema, IList<MapperDslConnectorProperties> dslConnectorProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Schema = schema;
            DslConnectorProperties = dslConnectorProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the table. </summary>
        public string Name { get; set; }
        /// <summary> List of columns for the source table. </summary>
        public IList<MapperTableSchema> Schema { get; }
        /// <summary> List of name/value pairs for connection properties. </summary>
        public IList<MapperDslConnectorProperties> DslConnectorProperties { get; }
    }
}
