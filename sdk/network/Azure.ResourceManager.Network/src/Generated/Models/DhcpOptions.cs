// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> DhcpOptions contains an array of DNS servers available to VMs deployed in the virtual network. Standard DHCP option for a subnet overrides VNET DHCP options. </summary>
    public partial class DhcpOptions
    {
        /// <summary> Initializes a new instance of DhcpOptions. </summary>
        public DhcpOptions()
        {
        }

        /// <summary> Initializes a new instance of DhcpOptions. </summary>
        /// <param name="dnsServers"> The list of DNS servers IP addresses. </param>
        internal DhcpOptions(IList<string> dnsServers)
        {
            DnsServers = dnsServers;
        }

        /// <summary> The list of DNS servers IP addresses. </summary>
        public IList<string> DnsServers { get; set; }
    }
}
