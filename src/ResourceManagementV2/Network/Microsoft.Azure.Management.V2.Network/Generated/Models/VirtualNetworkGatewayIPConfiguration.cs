// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// IpConfiguration for Virtual network gateway
    /// </summary>
    [JsonTransformation]
    public partial class VirtualNetworkGatewayIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayIPConfiguration class.
        /// </summary>
        public VirtualNetworkGatewayIPConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayIPConfiguration class.
        /// </summary>
        /// <param name="privateIPAllocationMethod">Gets or sets PrivateIP
        /// allocation method. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="subnet">Gets or sets the reference of the subnet
        /// resource</param>
        /// <param name="publicIPAddress">Gets or sets the reference of the
        /// PublicIP resource</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public VirtualNetworkGatewayIPConfiguration(String id = default(String), string privateIPAllocationMethod = default(string), SubResource subnet = default(SubResource), SubResource publicIPAddress = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets PrivateIP allocation method. Possible values include:
        /// 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference of the PublicIP resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
