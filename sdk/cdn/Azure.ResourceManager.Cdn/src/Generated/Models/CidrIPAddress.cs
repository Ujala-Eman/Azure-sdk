// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> CIDR Ip address. </summary>
    public partial class CidrIPAddress
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CidrIPAddress"/>. </summary>
        public CidrIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CidrIPAddress"/>. </summary>
        /// <param name="baseIPAddress"> Ip address itself. </param>
        /// <param name="prefixLength"> The length of the prefix of the ip address. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CidrIPAddress(string baseIPAddress, int? prefixLength, Dictionary<string, BinaryData> rawData)
        {
            BaseIPAddress = baseIPAddress;
            PrefixLength = prefixLength;
            _rawData = rawData;
        }

        /// <summary> Ip address itself. </summary>
        public string BaseIPAddress { get; set; }
        /// <summary> The length of the prefix of the ip address. </summary>
        public int? PrefixLength { get; set; }
    }
}
