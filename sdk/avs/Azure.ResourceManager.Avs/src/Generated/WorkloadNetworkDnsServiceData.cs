// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkDnsService data model.
    /// NSX DNS Service
    /// </summary>
    public partial class WorkloadNetworkDnsServiceData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDnsServiceData"/>. </summary>
        public WorkloadNetworkDnsServiceData()
        {
            FqdnZones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDnsServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the DNS Service. </param>
        /// <param name="dnsServiceIP"> DNS service IP of the DNS Service. </param>
        /// <param name="defaultDnsZone"> Default DNS zone of the DNS Service. </param>
        /// <param name="fqdnZones"> FQDN zones of the DNS Service. </param>
        /// <param name="logLevel"> DNS Service log level. </param>
        /// <param name="status"> DNS Service status. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkDnsServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, IPAddress dnsServiceIP, string defaultDnsZone, IList<string> fqdnZones, DnsServiceLogLevel? logLevel, DnsServiceStatus? status, WorkloadNetworkDnsServiceProvisioningState? provisioningState, long? revision, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            DnsServiceIP = dnsServiceIP;
            DefaultDnsZone = defaultDnsZone;
            FqdnZones = fqdnZones;
            LogLevel = logLevel;
            Status = status;
            ProvisioningState = provisioningState;
            Revision = revision;
            _rawData = rawData;
        }

        /// <summary> Display name of the DNS Service. </summary>
        public string DisplayName { get; set; }
        /// <summary> DNS service IP of the DNS Service. </summary>
        public IPAddress DnsServiceIP { get; set; }
        /// <summary> Default DNS zone of the DNS Service. </summary>
        public string DefaultDnsZone { get; set; }
        /// <summary> FQDN zones of the DNS Service. </summary>
        public IList<string> FqdnZones { get; }
        /// <summary> DNS Service log level. </summary>
        public DnsServiceLogLevel? LogLevel { get; set; }
        /// <summary> DNS Service status. </summary>
        public DnsServiceStatus? Status { get; }
        /// <summary> The provisioning state. </summary>
        public WorkloadNetworkDnsServiceProvisioningState? ProvisioningState { get; }
        /// <summary> NSX revision number. </summary>
        public long? Revision { get; set; }
    }
}
