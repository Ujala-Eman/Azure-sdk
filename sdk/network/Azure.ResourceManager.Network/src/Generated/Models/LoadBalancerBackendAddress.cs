// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Load balancer backend addresses. </summary>
    public partial class LoadBalancerBackendAddress
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerBackendAddress"/>. </summary>
        public LoadBalancerBackendAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerBackendAddress"/>. </summary>
        /// <param name="name"> Name of the backend address. </param>
        /// <param name="virtualNetwork"> Reference to an existing virtual network. </param>
        /// <param name="subnet"> Reference to an existing subnet. </param>
        /// <param name="ipAddress"> IP Address belonging to the referenced virtual network. </param>
        /// <param name="networkInterfaceIPConfiguration"> Reference to IP address defined in network interfaces. </param>
        /// <param name="loadBalancerFrontendIPConfiguration"> Reference to the frontend ip address configuration defined in regional loadbalancer. </param>
        internal LoadBalancerBackendAddress(string name, WritableSubResource virtualNetwork, WritableSubResource subnet, string ipAddress, WritableSubResource networkInterfaceIPConfiguration, WritableSubResource loadBalancerFrontendIPConfiguration)
        {
            Name = name;
            VirtualNetwork = virtualNetwork;
            Subnet = subnet;
            IPAddress = ipAddress;
            NetworkInterfaceIPConfiguration = networkInterfaceIPConfiguration;
            LoadBalancerFrontendIPConfiguration = loadBalancerFrontendIPConfiguration;
        }

        /// <summary> Name of the backend address. </summary>
        public string Name { get; set; }
        /// <summary> Reference to an existing virtual network. </summary>
        internal WritableSubResource VirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkId
        {
            get => VirtualNetwork is null ? default : VirtualNetwork.Id;
            set
            {
                if (VirtualNetwork is null)
                    VirtualNetwork = new WritableSubResource();
                VirtualNetwork.Id = value;
            }
        }

        /// <summary> Reference to an existing subnet. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> IP Address belonging to the referenced virtual network. </summary>
        public string IPAddress { get; set; }
        /// <summary> Reference to IP address defined in network interfaces. </summary>
        internal WritableSubResource NetworkInterfaceIPConfiguration { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetworkInterfaceIPConfigurationId
        {
            get => NetworkInterfaceIPConfiguration?.Id;
        }

        /// <summary> Reference to the frontend ip address configuration defined in regional loadbalancer. </summary>
        internal WritableSubResource LoadBalancerFrontendIPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier LoadBalancerFrontendIPConfigurationId
        {
            get => LoadBalancerFrontendIPConfiguration is null ? default : LoadBalancerFrontendIPConfiguration.Id;
            set
            {
                if (LoadBalancerFrontendIPConfiguration is null)
                    LoadBalancerFrontendIPConfiguration = new WritableSubResource();
                LoadBalancerFrontendIPConfiguration.Id = value;
            }
        }
    }
}
