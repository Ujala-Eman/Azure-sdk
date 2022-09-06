// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> An AAAA record. </summary>
    public partial class AaaaRecordInfo
    {
        /// <summary> Initializes a new instance of AaaaRecordInfo. </summary>
        public AaaaRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of AaaaRecordInfo. </summary>
        /// <param name="ipv6Address"> The IPv6 address of this AAAA record. </param>
        internal AaaaRecordInfo(IPAddress ipv6Address)
        {
            IPv6Address = ipv6Address;
        }

        /// <summary> The IPv6 address of this AAAA record. </summary>
        public IPAddress IPv6Address { get; set; }
    }
}
