// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// List of NetApp account resources
    /// Serialized Name: NetAppAccountList
    /// </summary>
    internal partial class NetAppAccountList
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

        /// <summary> Initializes a new instance of <see cref="NetAppAccountList"/>. </summary>
        internal NetAppAccountList()
        {
            Value = new ChangeTrackingList<NetAppAccountData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountList"/>. </summary>
        /// <param name="value">
        /// Multiple NetApp accounts
        /// Serialized Name: NetAppAccountList.value
        /// </param>
        /// <param name="nextLink">
        /// URL to get the next set of results.
        /// Serialized Name: NetAppAccountList.nextLink
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppAccountList(IReadOnlyList<NetAppAccountData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Multiple NetApp accounts
        /// Serialized Name: NetAppAccountList.value
        /// </summary>
        public IReadOnlyList<NetAppAccountData> Value { get; }
        /// <summary>
        /// URL to get the next set of results.
        /// Serialized Name: NetAppAccountList.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
