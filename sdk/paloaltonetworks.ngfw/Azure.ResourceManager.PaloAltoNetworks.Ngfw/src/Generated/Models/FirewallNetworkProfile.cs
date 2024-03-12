// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Network settings for Firewall. </summary>
    public partial class FirewallNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="FirewallNetworkProfile"/>. </summary>
        /// <param name="networkType"> vnet or vwan, cannot be updated. </param>
        /// <param name="publicIPs"> List of IPs associated with the Firewall. </param>
        /// <param name="enableEgressNat"> Enable egress NAT, enabled by default. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPs"/> is null. </exception>
        public FirewallNetworkProfile(FirewallNetworkType networkType, IEnumerable<IPAddressInfo> publicIPs, AllowEgressNatType enableEgressNat)
        {
            Argument.AssertNotNull(publicIPs, nameof(publicIPs));

            NetworkType = networkType;
            PublicIPs = publicIPs.ToList();
            EnableEgressNat = enableEgressNat;
            EgressNatIP = new ChangeTrackingList<IPAddressInfo>();
            TrustedRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallNetworkProfile"/>. </summary>
        /// <param name="vnetConfiguration"> Vnet configurations. </param>
        /// <param name="vwanConfiguration"> Vwan configurations. </param>
        /// <param name="networkType"> vnet or vwan, cannot be updated. </param>
        /// <param name="publicIPs"> List of IPs associated with the Firewall. </param>
        /// <param name="enableEgressNat"> Enable egress NAT, enabled by default. </param>
        /// <param name="egressNatIP"> Egress nat IP to use. </param>
        /// <param name="trustedRanges"> Non-RFC 1918 address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallNetworkProfile(FirewallVnetConfiguration vnetConfiguration, FirewallVwanConfiguration vwanConfiguration, FirewallNetworkType networkType, IList<IPAddressInfo> publicIPs, AllowEgressNatType enableEgressNat, IList<IPAddressInfo> egressNatIP, IList<string> trustedRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VnetConfiguration = vnetConfiguration;
            VwanConfiguration = vwanConfiguration;
            NetworkType = networkType;
            PublicIPs = publicIPs;
            EnableEgressNat = enableEgressNat;
            EgressNatIP = egressNatIP;
            TrustedRanges = trustedRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallNetworkProfile"/> for deserialization. </summary>
        internal FirewallNetworkProfile()
        {
        }

        /// <summary> Vnet configurations. </summary>
        public FirewallVnetConfiguration VnetConfiguration { get; set; }
        /// <summary> Vwan configurations. </summary>
        public FirewallVwanConfiguration VwanConfiguration { get; set; }
        /// <summary> vnet or vwan, cannot be updated. </summary>
        public FirewallNetworkType NetworkType { get; set; }
        /// <summary> List of IPs associated with the Firewall. </summary>
        public IList<IPAddressInfo> PublicIPs { get; }
        /// <summary> Enable egress NAT, enabled by default. </summary>
        public AllowEgressNatType EnableEgressNat { get; set; }
        /// <summary> Egress nat IP to use. </summary>
        public IList<IPAddressInfo> EgressNatIP { get; }
        /// <summary> Non-RFC 1918 address. </summary>
        public IList<string> TrustedRanges { get; }
    }
}
