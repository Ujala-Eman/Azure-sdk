// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> A request to perform the connectivity check operation on a API Management service. </summary>
    public partial class ConnectivityCheckContent
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

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckContent"/>. </summary>
        /// <param name="source"> Definitions about the connectivity check origin. </param>
        /// <param name="destination"> The connectivity check operation destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="destination"/> is null. </exception>
        public ConnectivityCheckContent(ConnectivityCheckRequestSource source, ConnectivityCheckRequestDestination destination)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            Source = source;
            Destination = destination;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckContent"/>. </summary>
        /// <param name="source"> Definitions about the connectivity check origin. </param>
        /// <param name="destination"> The connectivity check operation destination. </param>
        /// <param name="preferredIPVersion"> The IP version to be used. Only IPv4 is supported for now. </param>
        /// <param name="protocol"> The request's protocol. Specific protocol configuration can be available based on this selection. The specified destination address must be coherent with this value. </param>
        /// <param name="protocolConfiguration"> Protocol-specific configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityCheckContent(ConnectivityCheckRequestSource source, ConnectivityCheckRequestDestination destination, PreferredIPVersion? preferredIPVersion, ConnectivityCheckProtocol? protocol, ConnectivityCheckRequestProtocolConfiguration protocolConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            Destination = destination;
            PreferredIPVersion = preferredIPVersion;
            Protocol = protocol;
            ProtocolConfiguration = protocolConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckContent"/> for deserialization. </summary>
        internal ConnectivityCheckContent()
        {
        }

        /// <summary> Definitions about the connectivity check origin. </summary>
        public ConnectivityCheckRequestSource Source { get; }
        /// <summary> The connectivity check operation destination. </summary>
        public ConnectivityCheckRequestDestination Destination { get; }
        /// <summary> The IP version to be used. Only IPv4 is supported for now. </summary>
        public PreferredIPVersion? PreferredIPVersion { get; set; }
        /// <summary> The request's protocol. Specific protocol configuration can be available based on this selection. The specified destination address must be coherent with this value. </summary>
        public ConnectivityCheckProtocol? Protocol { get; set; }
        /// <summary> Protocol-specific configuration. </summary>
        internal ConnectivityCheckRequestProtocolConfiguration ProtocolConfiguration { get; set; }
        /// <summary> Configuration for HTTP or HTTPS requests. </summary>
        public ConnectivityCheckRequestHttpConfiguration ProtocolHttpConfiguration
        {
            get => ProtocolConfiguration is null ? default : ProtocolConfiguration.HttpConfiguration;
            set
            {
                if (ProtocolConfiguration is null)
                    ProtocolConfiguration = new ConnectivityCheckRequestProtocolConfiguration();
                ProtocolConfiguration.HttpConfiguration = value;
            }
        }
    }
}
