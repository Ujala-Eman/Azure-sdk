// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Action to perform once matching of routes is done. </summary>
    internal partial class HttpRouteAction
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

        /// <summary> Initializes a new instance of <see cref="HttpRouteAction"/>. </summary>
        public HttpRouteAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HttpRouteAction"/>. </summary>
        /// <param name="prefixRewrite"> Rewrite prefix, default is no rewrites. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HttpRouteAction(string prefixRewrite, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrefixRewrite = prefixRewrite;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Rewrite prefix, default is no rewrites. </summary>
        [WirePath("prefixRewrite")]
        public string PrefixRewrite { get; set; }
    }
}
