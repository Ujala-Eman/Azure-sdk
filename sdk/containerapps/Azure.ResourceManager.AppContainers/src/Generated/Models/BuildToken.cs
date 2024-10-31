// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Build Auth Token. </summary>
    public partial class BuildToken
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

        /// <summary> Initializes a new instance of <see cref="BuildToken"/>. </summary>
        internal BuildToken()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BuildToken"/>. </summary>
        /// <param name="token"> Authentication token. </param>
        /// <param name="expires"> Token expiration date. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildToken(string token, DateTimeOffset? expires, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            Expires = expires;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Authentication token. </summary>
        [WirePath("token")]
        public string Token { get; }
        /// <summary> Token expiration date. </summary>
        [WirePath("expires")]
        public DateTimeOffset? Expires { get; }
    }
}
