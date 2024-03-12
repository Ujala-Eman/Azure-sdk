// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> L2NetworkAttachmentConfiguration represents the configuration of the attachment of a Layer 2 network. </summary>
    public partial class L2NetworkAttachmentConfiguration
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

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkId"/> is null. </exception>
        public L2NetworkAttachmentConfiguration(ResourceIdentifier networkId)
        {
            Argument.AssertNotNull(networkId, nameof(networkId));

            NetworkId = networkId;
        }

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/>. </summary>
        /// <param name="networkId"> The resource ID of the network that is being configured for attachment. </param>
        /// <param name="pluginType"> The indicator of how this network will be utilized by the Kubernetes cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal L2NetworkAttachmentConfiguration(ResourceIdentifier networkId, KubernetesPluginType? pluginType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkId = networkId;
            PluginType = pluginType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="L2NetworkAttachmentConfiguration"/> for deserialization. </summary>
        internal L2NetworkAttachmentConfiguration()
        {
        }

        /// <summary> The resource ID of the network that is being configured for attachment. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary> The indicator of how this network will be utilized by the Kubernetes cluster. </summary>
        public KubernetesPluginType? PluginType { get; set; }
    }
}
