// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> IP configuration. </summary>
    public partial class InboundEndpointIPConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPConfiguration"/>. </summary>
        /// <param name="subnet"> The reference to the subnet bound to the IP configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnet"/> is null. </exception>
        public InboundEndpointIPConfiguration(WritableSubResource subnet)
        {
            Argument.AssertNotNull(subnet, nameof(subnet));

            Subnet = subnet;
        }

        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPConfiguration"/>. </summary>
        /// <param name="subnet"> The reference to the subnet bound to the IP configuration. </param>
        /// <param name="privateIPAddress"> Private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> Private IP address allocation method. </param>
        internal InboundEndpointIPConfiguration(WritableSubResource subnet, IPAddress privateIPAddress, InboundEndpointIPAllocationMethod? privateIPAllocationMethod)
        {
            Subnet = subnet;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
        }

        /// <summary> The reference to the subnet bound to the IP configuration. </summary>
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

        /// <summary> Private IP address of the IP configuration. </summary>
        public IPAddress PrivateIPAddress { get; set; }
        /// <summary> Private IP address allocation method. </summary>
        public InboundEndpointIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
    }
}
