// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlConfiguration data model.
    /// Represents a Configuration.
    /// </summary>
    public partial class MySqlConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="MySqlConfigurationData"/>. </summary>
        public MySqlConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, string description, string defaultValue, string dataType, string allowedValues, string source, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Value = value;
            Description = description;
            DefaultValue = defaultValue;
            DataType = dataType;
            AllowedValues = allowedValues;
            Source = source;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Value of the configuration. </summary>
        public string Value { get; set; }
        /// <summary> Description of the configuration. </summary>
        public string Description { get; }
        /// <summary> Default value of the configuration. </summary>
        public string DefaultValue { get; }
        /// <summary> Data type of the configuration. </summary>
        public string DataType { get; }
        /// <summary> Allowed values of the configuration. </summary>
        public string AllowedValues { get; }
        /// <summary> Source of the configuration. </summary>
        public string Source { get; set; }
    }
}
