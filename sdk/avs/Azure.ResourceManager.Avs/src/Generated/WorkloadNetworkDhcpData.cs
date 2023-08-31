// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the WorkloadNetworkDhcp data model.
    /// NSX DHCP
    /// </summary>
    public partial class WorkloadNetworkDhcpData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpData"/>. </summary>
        public WorkloadNetworkDhcpData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// DHCP properties.
        /// Please note <see cref="WorkloadNetworkDhcpEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WorkloadNetworkDhcpRelay"/> and <see cref="WorkloadNetworkDhcpServer"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkDhcpData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WorkloadNetworkDhcpEntity properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary>
        /// DHCP properties.
        /// Please note <see cref="WorkloadNetworkDhcpEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WorkloadNetworkDhcpRelay"/> and <see cref="WorkloadNetworkDhcpServer"/>.
        /// </summary>
        public WorkloadNetworkDhcpEntity Properties { get; set; }
    }
}
