// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Endpoint Configuration for frontend and backend. </summary>
    public partial class FirewallEndpointConfiguration
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

        /// <summary> Initializes a new instance of <see cref="FirewallEndpointConfiguration"/>. </summary>
        /// <param name="port"> port ID. </param>
        /// <param name="address"> Address Space. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="port"/> or <paramref name="address"/> is null. </exception>
        public FirewallEndpointConfiguration(string port, IPAddressInfo address)
        {
            Argument.AssertNotNull(port, nameof(port));
            Argument.AssertNotNull(address, nameof(address));

            Port = port;
            Address = address;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallEndpointConfiguration"/>. </summary>
        /// <param name="port"> port ID. </param>
        /// <param name="address"> Address Space. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallEndpointConfiguration(string port, IPAddressInfo address, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Port = port;
            Address = address;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallEndpointConfiguration"/> for deserialization. </summary>
        internal FirewallEndpointConfiguration()
        {
        }

        /// <summary> port ID. </summary>
        public string Port { get; set; }
        /// <summary> Address Space. </summary>
        public IPAddressInfo Address { get; set; }
    }
}
