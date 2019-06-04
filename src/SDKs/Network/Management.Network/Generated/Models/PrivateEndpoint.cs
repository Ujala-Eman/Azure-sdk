// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Private endpoint resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpoint : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        public PrivateEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="subnet">The ID of the subnet from which the private IP
        /// will be allocated.</param>
        /// <param name="networkInterfaces">Gets an array of references to the
        /// network interfaces created for this private endpoint.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// private endpoint. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="privateLinkServiceConnections">A grouping of
        /// information about the connection to the remote resource.</param>
        /// <param name="manualPrivateLinkServiceConnections">A grouping of
        /// information about the connection to the remote resource. Used when
        /// the network admin does not have access to approve connections to
        /// the remote resource.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public PrivateEndpoint(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Subnet subnet = default(Subnet), IList<NetworkInterface> networkInterfaces = default(IList<NetworkInterface>), string provisioningState = default(string), IList<PrivateLinkServiceConnection> privateLinkServiceConnections = default(IList<PrivateLinkServiceConnection>), IList<PrivateLinkServiceConnection> manualPrivateLinkServiceConnections = default(IList<PrivateLinkServiceConnection>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Subnet = subnet;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateLinkServiceConnections = privateLinkServiceConnections;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the subnet from which the private IP will be
        /// allocated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Gets an array of references to the network interfaces created for
        /// this private endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkInterfaces")]
        public IList<NetworkInterface> NetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the private endpoint. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets a grouping of information about the connection to the
        /// remote resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnections")]
        public IList<PrivateLinkServiceConnection> PrivateLinkServiceConnections { get; set; }

        /// <summary>
        /// Gets or sets a grouping of information about the connection to the
        /// remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.manualPrivateLinkServiceConnections")]
        public IList<PrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
