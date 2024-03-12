// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Hop link. </summary>
    public partial class HopLink
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

        /// <summary> Initializes a new instance of <see cref="HopLink"/>. </summary>
        internal HopLink()
        {
            Issues = new ChangeTrackingList<ConnectivityIssueInfo>();
            Context = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="HopLink"/>. </summary>
        /// <param name="nextHopId"> The ID of the next hop. </param>
        /// <param name="linkType"> Link type. </param>
        /// <param name="issues"> List of issues. </param>
        /// <param name="context"> Provides additional context on links. </param>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="roundTripTimeMin"> Minimum roundtrip time in milliseconds. </param>
        /// <param name="roundTripTimeAvg"> Average roundtrip time in milliseconds. </param>
        /// <param name="roundTripTimeMax"> Maximum roundtrip time in milliseconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HopLink(string nextHopId, string linkType, IReadOnlyList<ConnectivityIssueInfo> issues, IReadOnlyDictionary<string, string> context, ResourceIdentifier resourceId, long? roundTripTimeMin, long? roundTripTimeAvg, long? roundTripTimeMax, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextHopId = nextHopId;
            LinkType = linkType;
            Issues = issues;
            Context = context;
            ResourceId = resourceId;
            RoundTripTimeMin = roundTripTimeMin;
            RoundTripTimeAvg = roundTripTimeAvg;
            RoundTripTimeMax = roundTripTimeMax;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the next hop. </summary>
        public string NextHopId { get; }
        /// <summary> Link type. </summary>
        public string LinkType { get; }
        /// <summary> List of issues. </summary>
        public IReadOnlyList<ConnectivityIssueInfo> Issues { get; }
        /// <summary> Provides additional context on links. </summary>
        public IReadOnlyDictionary<string, string> Context { get; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Minimum roundtrip time in milliseconds. </summary>
        public long? RoundTripTimeMin { get; }
        /// <summary> Average roundtrip time in milliseconds. </summary>
        public long? RoundTripTimeAvg { get; }
        /// <summary> Maximum roundtrip time in milliseconds. </summary>
        public long? RoundTripTimeMax { get; }
    }
}
