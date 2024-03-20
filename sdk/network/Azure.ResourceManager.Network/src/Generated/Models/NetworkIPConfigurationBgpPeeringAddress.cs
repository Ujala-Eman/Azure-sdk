// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of IPConfigurationBgpPeeringAddress. </summary>
    public partial class NetworkIPConfigurationBgpPeeringAddress
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

        /// <summary> Initializes a new instance of <see cref="NetworkIPConfigurationBgpPeeringAddress"/>. </summary>
        public NetworkIPConfigurationBgpPeeringAddress()
        {
            DefaultBgpIPAddresses = new ChangeTrackingList<string>();
            CustomBgpIPAddresses = new ChangeTrackingList<string>();
            TunnelIPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkIPConfigurationBgpPeeringAddress"/>. </summary>
        /// <param name="ipConfigurationId"> The ID of IP configuration which belongs to gateway. </param>
        /// <param name="defaultBgpIPAddresses"> The list of default BGP peering addresses which belong to IP configuration. </param>
        /// <param name="customBgpIPAddresses"> The list of custom BGP peering addresses which belong to IP configuration. </param>
        /// <param name="tunnelIPAddresses"> The list of tunnel public IP addresses which belong to IP configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkIPConfigurationBgpPeeringAddress(string ipConfigurationId, IReadOnlyList<string> defaultBgpIPAddresses, IList<string> customBgpIPAddresses, IReadOnlyList<string> tunnelIPAddresses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPConfigurationId = ipConfigurationId;
            DefaultBgpIPAddresses = defaultBgpIPAddresses;
            CustomBgpIPAddresses = customBgpIPAddresses;
            TunnelIPAddresses = tunnelIPAddresses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of IP configuration which belongs to gateway. </summary>
        public string IPConfigurationId { get; set; }
        /// <summary> The list of default BGP peering addresses which belong to IP configuration. </summary>
        public IReadOnlyList<string> DefaultBgpIPAddresses { get; }
        /// <summary> The list of custom BGP peering addresses which belong to IP configuration. </summary>
        public IList<string> CustomBgpIPAddresses { get; }
        /// <summary> The list of tunnel public IP addresses which belong to IP configuration. </summary>
        public IReadOnlyList<string> TunnelIPAddresses { get; }
    }
}
