// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Admin overview resource object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AdminOverview : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AdminOverview class.
        /// </summary>
        public AdminOverview()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminOverview class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        /// <param name="virtualNetworkHealth">Health for all virtual networks
        /// as reported by the NC.</param>
        /// <param name="loadBalancerMuxHealth">Health for all LB MUXes as
        /// reported by the NC.</param>
        /// <param name="virtualGatewayHealth">Health for all gateways as
        /// reported by the NC.</param>
        /// <param name="publicIpAddressUsage">Total Public IP usage as
        /// reported by the NC.</param>
        /// <param name="backendIpUsage">Total Backend IP usage as reported by
        /// the NC.</param>
        /// <param name="macAddressUsage">Total MAC address usage as reported
        /// by the NC.</param>
        public AdminOverview(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), AdminOverviewResourceHealth virtualNetworkHealth = default(AdminOverviewResourceHealth), AdminOverviewResourceHealth loadBalancerMuxHealth = default(AdminOverviewResourceHealth), AdminOverviewResourceHealth virtualGatewayHealth = default(AdminOverviewResourceHealth), AdminOverviewResourceUsage publicIpAddressUsage = default(AdminOverviewResourceUsage), AdminOverviewResourceUsage backendIpUsage = default(AdminOverviewResourceUsage), AdminOverviewResourceUsage macAddressUsage = default(AdminOverviewResourceUsage))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            VirtualNetworkHealth = virtualNetworkHealth;
            LoadBalancerMuxHealth = loadBalancerMuxHealth;
            VirtualGatewayHealth = virtualGatewayHealth;
            PublicIpAddressUsage = publicIpAddressUsage;
            BackendIpUsage = backendIpUsage;
            MacAddressUsage = macAddressUsage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets health for all virtual networks as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkHealth")]
        public AdminOverviewResourceHealth VirtualNetworkHealth { get; set; }

        /// <summary>
        /// Gets or sets health for all LB MUXes as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerMuxHealth")]
        public AdminOverviewResourceHealth LoadBalancerMuxHealth { get; set; }

        /// <summary>
        /// Gets or sets health for all gateways as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualGatewayHealth")]
        public AdminOverviewResourceHealth VirtualGatewayHealth { get; set; }

        /// <summary>
        /// Gets or sets total Public IP usage as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIpAddressUsage")]
        public AdminOverviewResourceUsage PublicIpAddressUsage { get; set; }

        /// <summary>
        /// Gets or sets total Backend IP usage as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIpUsage")]
        public AdminOverviewResourceUsage BackendIpUsage { get; set; }

        /// <summary>
        /// Gets or sets total MAC address usage as reported by the NC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.macAddressUsage")]
        public AdminOverviewResourceUsage MacAddressUsage { get; set; }

    }
}
