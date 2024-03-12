// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Supported operating systems property. </summary>
    public partial class SiteRecoverySupportedOSProperty
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoverySupportedOSProperty"/>. </summary>
        internal SiteRecoverySupportedOSProperty()
        {
            SupportedOS = new ChangeTrackingList<SiteRecoverySupportedOSDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoverySupportedOSProperty"/>. </summary>
        /// <param name="instanceType"> The replication provider type. </param>
        /// <param name="supportedOS"> The list of supported operating systems. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoverySupportedOSProperty(string instanceType, IReadOnlyList<SiteRecoverySupportedOSDetails> supportedOS, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            SupportedOS = supportedOS;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The replication provider type. </summary>
        public string InstanceType { get; }
        /// <summary> The list of supported operating systems. </summary>
        public IReadOnlyList<SiteRecoverySupportedOSDetails> SupportedOS { get; }
    }
}
