// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines network configuration&apos;s DNS settings. </summary>
    internal partial class VirtualMachineNetworkInterfaceDnsSettingsConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachineNetworkInterfaceDnsSettingsConfiguration. </summary>
        public VirtualMachineNetworkInterfaceDnsSettingsConfiguration()
        {
            DnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineNetworkInterfaceDnsSettingsConfiguration. </summary>
        /// <param name="dnsServers"> List of DNS servers IP addresses. </param>
        internal VirtualMachineNetworkInterfaceDnsSettingsConfiguration(IList<string> dnsServers)
        {
            DnsServers = dnsServers;
        }

        /// <summary> List of DNS servers IP addresses. </summary>
        public IList<string> DnsServers { get; }
    }
}
