// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V host details. </summary>
    public partial class HyperVHostDetails
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

        /// <summary> Initializes a new instance of <see cref="HyperVHostDetails"/>. </summary>
        internal HyperVHostDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HyperVHostDetails"/>. </summary>
        /// <param name="id"> The Hyper-V host Id. </param>
        /// <param name="name"> The Hyper-V host name. </param>
        /// <param name="marsAgentVersion"> The Mars agent version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVHostDetails(string id, string name, string marsAgentVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            MarsAgentVersion = marsAgentVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Hyper-V host Id. </summary>
        public string Id { get; }
        /// <summary> The Hyper-V host name. </summary>
        public string Name { get; }
        /// <summary> The Mars agent version. </summary>
        public string MarsAgentVersion { get; }
    }
}
