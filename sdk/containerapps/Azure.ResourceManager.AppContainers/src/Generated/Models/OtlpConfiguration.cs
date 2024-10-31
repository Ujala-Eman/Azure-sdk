// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration of otlp. </summary>
    public partial class OtlpConfiguration
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

        /// <summary> Initializes a new instance of <see cref="OtlpConfiguration"/>. </summary>
        public OtlpConfiguration()
        {
            Headers = new ChangeTrackingList<Header>();
        }

        /// <summary> Initializes a new instance of <see cref="OtlpConfiguration"/>. </summary>
        /// <param name="name"> The name of otlp configuration. </param>
        /// <param name="endpoint"> The endpoint of otlp configuration. </param>
        /// <param name="insecure"> Boolean indicating if otlp configuration is insecure. </param>
        /// <param name="headers"> Headers of otlp configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OtlpConfiguration(string name, string endpoint, bool? insecure, IList<Header> headers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Endpoint = endpoint;
            Insecure = insecure;
            Headers = headers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of otlp configuration. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> The endpoint of otlp configuration. </summary>
        [WirePath("endpoint")]
        public string Endpoint { get; set; }
        /// <summary> Boolean indicating if otlp configuration is insecure. </summary>
        [WirePath("insecure")]
        public bool? Insecure { get; set; }
        /// <summary> Headers of otlp configurations. </summary>
        [WirePath("headers")]
        public IList<Header> Headers { get; }
    }
}
