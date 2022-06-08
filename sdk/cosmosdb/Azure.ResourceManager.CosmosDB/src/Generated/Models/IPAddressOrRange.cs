// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> IpAddressOrRange object. </summary>
    public partial class IPAddressOrRange
    {
        /// <summary> Initializes a new instance of <see cref="IPAddressOrRange"/>. </summary>
        public IPAddressOrRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IPAddressOrRange"/>. </summary>
        /// <param name="ipAddressOrRangeValue"> A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12, 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245” or “23.40.210.0/8”. </param>
        internal IPAddressOrRange(string ipAddressOrRangeValue)
        {
            IPAddressOrRangeValue = ipAddressOrRangeValue;
        }

        /// <summary> A single IPv4 address or a single IPv4 address range in CIDR format. Provided IPs must be well-formatted and cannot be contained in one of the following ranges: 10.0.0.0/8, 100.64.0.0/10, 172.16.0.0/12, 192.168.0.0/16, since these are not enforceable by the IP address filter. Example of valid inputs: “23.40.210.245” or “23.40.210.0/8”. </summary>
        public string IPAddressOrRangeValue { get; set; }
    }
}
