// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the DaprComponentResiliencyPolicy data model.
    /// Dapr Component Resiliency Policy.
    /// </summary>
    public partial class DaprComponentResiliencyPolicyData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DaprComponentResiliencyPolicyData"/>. </summary>
        public DaprComponentResiliencyPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DaprComponentResiliencyPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="inboundPolicy"> The optional inbound component resiliency policy configuration. </param>
        /// <param name="outboundPolicy"> The optional outbound component resiliency policy configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DaprComponentResiliencyPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DaprComponentResiliencyPolicyConfiguration inboundPolicy, DaprComponentResiliencyPolicyConfiguration outboundPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            InboundPolicy = inboundPolicy;
            OutboundPolicy = outboundPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The optional inbound component resiliency policy configuration. </summary>
        [WirePath("properties.inboundPolicy")]
        public DaprComponentResiliencyPolicyConfiguration InboundPolicy { get; set; }
        /// <summary> The optional outbound component resiliency policy configuration. </summary>
        [WirePath("properties.outboundPolicy")]
        public DaprComponentResiliencyPolicyConfiguration OutboundPolicy { get; set; }
    }
}
