// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> A network interface in a resource group. </summary>
    public partial class NetworkInterface : Resource
    {
        /// <summary> Initializes a new instance of NetworkInterface. </summary>
        public NetworkInterface()
        {
            IpConfigurations = new ChangeTrackingList<NetworkInterfaceIPConfiguration>();
            TapConfigurations = new ChangeTrackingList<NetworkInterfaceTapConfiguration>();
            HostedWorkloads = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkInterface. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualMachine"> The reference to a virtual machine. </param>
        /// <param name="networkSecurityGroup"> The reference to the NetworkSecurityGroup resource. </param>
        /// <param name="privateEndpoint"> A reference to the private endpoint to which the network interface is linked. </param>
        /// <param name="ipConfigurations"> A list of IPConfigurations of the network interface. </param>
        /// <param name="tapConfigurations"> A list of TapConfigurations of the network interface. </param>
        /// <param name="dnsSettings"> The DNS settings in network interface. </param>
        /// <param name="macAddress"> The MAC address of the network interface. </param>
        /// <param name="primary"> Whether this is a primary network interface on a virtual machine. </param>
        /// <param name="enableAcceleratedNetworking"> If the network interface is accelerated networking enabled. </param>
        /// <param name="enableIPForwarding"> Indicates whether IP forwarding is enabled on this network interface. </param>
        /// <param name="hostedWorkloads"> A list of references to linked BareMetal resources. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network interface resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network interface resource. </param>
        internal NetworkInterface(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, SubResource virtualMachine, NetworkSecurityGroup networkSecurityGroup, PrivateEndpoint privateEndpoint, IList<NetworkInterfaceIPConfiguration> ipConfigurations, IReadOnlyList<NetworkInterfaceTapConfiguration> tapConfigurations, NetworkInterfaceDnsSettings dnsSettings, string macAddress, bool? primary, bool? enableAcceleratedNetworking, bool? enableIPForwarding, IReadOnlyList<string> hostedWorkloads, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            PrivateEndpoint = privateEndpoint;
            IpConfigurations = ipConfigurations;
            TapConfigurations = tapConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            EnableIPForwarding = enableIPForwarding;
            HostedWorkloads = hostedWorkloads;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The reference to a virtual machine. </summary>
        public SubResource VirtualMachine { get; }
        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }
        /// <summary> A reference to the private endpoint to which the network interface is linked. </summary>
        public PrivateEndpoint PrivateEndpoint { get; }
        /// <summary> A list of IPConfigurations of the network interface. </summary>
        public IList<NetworkInterfaceIPConfiguration> IpConfigurations { get; }
        /// <summary> A list of TapConfigurations of the network interface. </summary>
        public IReadOnlyList<NetworkInterfaceTapConfiguration> TapConfigurations { get; }
        /// <summary> The DNS settings in network interface. </summary>
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }
        /// <summary> The MAC address of the network interface. </summary>
        public string MacAddress { get; }
        /// <summary> Whether this is a primary network interface on a virtual machine. </summary>
        public bool? Primary { get; }
        /// <summary> If the network interface is accelerated networking enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Indicates whether IP forwarding is enabled on this network interface. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> A list of references to linked BareMetal resources. </summary>
        public IReadOnlyList<string> HostedWorkloads { get; }
        /// <summary> The resource GUID property of the network interface resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the network interface resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
