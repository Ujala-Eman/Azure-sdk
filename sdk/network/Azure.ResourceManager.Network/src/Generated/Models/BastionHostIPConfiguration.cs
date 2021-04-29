// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP configuration of an Bastion Host. </summary>
    public partial class BastionHostIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of BastionHostIPConfiguration. </summary>
        public BastionHostIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of BastionHostIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Ip configuration type. </param>
        /// <param name="subnet"> Reference of the subnet resource. </param>
        /// <param name="publicIPAddress"> Reference of the PublicIP resource. </param>
        /// <param name="provisioningState"> The provisioning state of the bastion host IP configuration resource. </param>
        /// <param name="privateIPAllocationMethod"> Private IP allocation method. </param>
        internal BastionHostIPConfiguration(string id, string name, string etag, string type, SubResource subnet, SubResource publicIPAddress, ProvisioningState? provisioningState, IPAllocationMethod? privateIPAllocationMethod) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
        }

        /// <summary> Name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Ip configuration type. </summary>
        public string Type { get; }
        /// <summary> Reference of the subnet resource. </summary>
        public SubResource Subnet { get; set; }
        /// <summary> Reference of the PublicIP resource. </summary>
        public SubResource PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the bastion host IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Private IP allocation method. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
    }
}
