// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the network interfaces or the networking configuration of the virtual machine. </summary>
    public partial class NetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        public NetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceReference>();
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineNetworkInterfaceConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        /// <param name="networkInterfaces"> Specifies the list of resource Ids for the network interfaces associated with the virtual machine. </param>
        /// <param name="networkApiVersion"> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations. </param>
        /// <param name="networkInterfaceConfigurations"> Specifies the networking configurations that will be used to create the virtual machine networking resources. </param>
        internal NetworkProfile(IList<NetworkInterfaceReference> networkInterfaces, NetworkApiVersion? networkApiVersion, IList<VirtualMachineNetworkInterfaceConfiguration> networkInterfaceConfigurations)
        {
            NetworkInterfaces = networkInterfaces;
            NetworkApiVersion = networkApiVersion;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
        }

        /// <summary> Specifies the list of resource Ids for the network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterfaceReference> NetworkInterfaces { get; }
        /// <summary> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations. </summary>
        public NetworkApiVersion? NetworkApiVersion { get; set; }
        /// <summary> Specifies the networking configurations that will be used to create the virtual machine networking resources. </summary>
        public IList<VirtualMachineNetworkInterfaceConfiguration> NetworkInterfaceConfigurations { get; }
    }
}
