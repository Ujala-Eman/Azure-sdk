// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Private Link Configuration on an application gateway. </summary>
    public partial class ApplicationGatewayPrivateLinkConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayPrivateLinkConfiguration. </summary>
        public ApplicationGatewayPrivateLinkConfiguration()
        {
            IpConfigurations = new ChangeTrackingList<ApplicationGatewayPrivateLinkIpConfiguration>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayPrivateLinkConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the private link configuration that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="ipConfigurations"> An array of application gateway private link ip configurations. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway private link configuration. </param>
        internal ApplicationGatewayPrivateLinkConfiguration(string id, string name, string etag, string type, IList<ApplicationGatewayPrivateLinkIpConfiguration> ipConfigurations, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the private link configuration that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> An array of application gateway private link ip configurations. </summary>
        public IList<ApplicationGatewayPrivateLinkIpConfiguration> IpConfigurations { get; }
        /// <summary> The provisioning state of the application gateway private link configuration. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
