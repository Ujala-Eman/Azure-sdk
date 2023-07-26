// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache network settings. </summary>
    public partial class StorageCacheNetworkSettings
    {
        /// <summary> Initializes a new instance of StorageCacheNetworkSettings. </summary>
        public StorageCacheNetworkSettings()
        {
            UtilityAddresses = new ChangeTrackingList<IPAddress>();
            DnsServers = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of StorageCacheNetworkSettings. </summary>
        /// <param name="mtu"> The IPv4 maximum transmission unit configured for the subnet. </param>
        /// <param name="utilityAddresses"> Array of additional IP addresses used by this cache. </param>
        /// <param name="dnsServers"> DNS servers for the cache to use.  It will be set from the network configuration if no value is provided. </param>
        /// <param name="dnsSearchDomain"> DNS search domain. </param>
        /// <param name="ntpServer"> NTP server IP Address or FQDN for the cache to use. The default is time.windows.com. </param>
        internal StorageCacheNetworkSettings(int? mtu, IReadOnlyList<IPAddress> utilityAddresses, IList<IPAddress> dnsServers, string dnsSearchDomain, string ntpServer)
        {
            Mtu = mtu;
            UtilityAddresses = utilityAddresses;
            DnsServers = dnsServers;
            DnsSearchDomain = dnsSearchDomain;
            NtpServer = ntpServer;
        }

        /// <summary> The IPv4 maximum transmission unit configured for the subnet. </summary>
        public int? Mtu { get; set; }
        /// <summary> Array of additional IP addresses used by this cache. </summary>
        public IReadOnlyList<IPAddress> UtilityAddresses { get; }
        /// <summary> DNS servers for the cache to use.  It will be set from the network configuration if no value is provided. </summary>
        public IList<IPAddress> DnsServers { get; }
        /// <summary> DNS search domain. </summary>
        public string DnsSearchDomain { get; set; }
        /// <summary> NTP server IP Address or FQDN for the cache to use. The default is time.windows.com. </summary>
        public string NtpServer { get; set; }
    }
}
