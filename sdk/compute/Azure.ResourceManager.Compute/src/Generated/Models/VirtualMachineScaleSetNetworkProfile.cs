// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile. </summary>
    public partial class VirtualMachineScaleSetNetworkProfile
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkProfile"/>. </summary>
        public VirtualMachineScaleSetNetworkProfile()
        {
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineScaleSetNetworkConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkProfile"/>. </summary>
        /// <param name="healthProbe"> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;. </param>
        /// <param name="networkInterfaceConfigurations"> The list of network configurations. </param>
        /// <param name="networkApiVersion"> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set with orchestration mode &apos;Flexible&apos;. </param>
        internal VirtualMachineScaleSetNetworkProfile(WritableSubResource healthProbe, IList<VirtualMachineScaleSetNetworkConfiguration> networkInterfaceConfigurations, NetworkApiVersion? networkApiVersion)
        {
            HealthProbe = healthProbe;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            NetworkApiVersion = networkApiVersion;
        }

        /// <summary> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;. </summary>
        internal WritableSubResource HealthProbe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HealthProbeId
        {
            get => HealthProbe is null ? default : HealthProbe.Id;
            set
            {
                if (HealthProbe is null)
                    HealthProbe = new WritableSubResource();
                HealthProbe.Id = value;
            }
        }

        /// <summary> The list of network configurations. </summary>
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations { get; }
        /// <summary> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set with orchestration mode &apos;Flexible&apos;. </summary>
        public NetworkApiVersion? NetworkApiVersion { get; set; }
    }
}
