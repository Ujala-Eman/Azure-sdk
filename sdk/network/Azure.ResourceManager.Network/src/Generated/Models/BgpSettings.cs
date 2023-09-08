// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> BGP settings details. </summary>
    public partial class BgpSettings
    {
        /// <summary> Initializes a new instance of BgpSettings. </summary>
        public BgpSettings()
        {
            BgpPeeringAddresses = new ChangeTrackingList<NetworkIPConfigurationBgpPeeringAddress>();
        }

        /// <summary> Initializes a new instance of BgpSettings. </summary>
        /// <param name="asn"> The BGP speaker's ASN. </param>
        /// <param name="bgpPeeringAddress"> The BGP peering address and BGP identifier of this BGP speaker. </param>
        /// <param name="peerWeight"> The weight added to routes learned from this BGP speaker. </param>
        /// <param name="bgpPeeringAddresses"> BGP peering address with IP configuration ID for virtual network gateway. </param>
        internal BgpSettings(long? asn, string bgpPeeringAddress, int? peerWeight, IList<NetworkIPConfigurationBgpPeeringAddress> bgpPeeringAddresses)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
            PeerWeight = peerWeight;
            BgpPeeringAddresses = bgpPeeringAddresses;
        }

        /// <summary> The BGP speaker's ASN. </summary>
        public long? Asn { get; set; }
        /// <summary> The BGP peering address and BGP identifier of this BGP speaker. </summary>
        public string BgpPeeringAddress { get; set; }
        /// <summary> The weight added to routes learned from this BGP speaker. </summary>
        public int? PeerWeight { get; set; }
        /// <summary> BGP peering address with IP configuration ID for virtual network gateway. </summary>
        public IList<NetworkIPConfigurationBgpPeeringAddress> BgpPeeringAddresses { get; }
    }
}
