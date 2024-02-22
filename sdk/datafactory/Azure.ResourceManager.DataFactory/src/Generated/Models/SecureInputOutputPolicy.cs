// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execution policy for an activity that supports secure input and output. </summary>
    public partial class SecureInputOutputPolicy
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

        /// <summary> Initializes a new instance of <see cref="SecureInputOutputPolicy"/>. </summary>
        public SecureInputOutputPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecureInputOutputPolicy"/>. </summary>
        /// <param name="isSecureInputEnabled"> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="isSecureOutputEnabled"> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecureInputOutputPolicy(bool? isSecureInputEnabled, bool? isSecureOutputEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsSecureInputEnabled = isSecureInputEnabled;
            IsSecureOutputEnabled = isSecureOutputEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? IsSecureInputEnabled { get; set; }
        /// <summary> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? IsSecureOutputEnabled { get; set; }
    }
}
