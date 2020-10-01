// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a managed private endpoint
    /// </summary>
    public partial class ManagedPrivateEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ManagedPrivateEndpoint class.
        /// </summary>
        public ManagedPrivateEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedPrivateEndpoint class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectionState">The managed private endpoint
        /// connection state</param>
        /// <param name="fqdns">Fully qualified domain names</param>
        /// <param name="groupId">The groupId to which the managed private
        /// endpoint is created</param>
        /// <param name="isReserved">Denotes whether the managed private
        /// endpoint is reserved</param>
        /// <param name="privateLinkResourceId">The ARM resource ID of the
        /// resource to which the managed private endpoint is created</param>
        /// <param name="provisioningState">The managed private endpoint
        /// provisioning state</param>
        public ManagedPrivateEndpoint(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), ConnectionStateProperties connectionState = default(ConnectionStateProperties), IList<string> fqdns = default(IList<string>), string groupId = default(string), bool? isReserved = default(bool?), string privateLinkResourceId = default(string), string provisioningState = default(string))
        {
            AdditionalProperties = additionalProperties;
            ConnectionState = connectionState;
            Fqdns = fqdns;
            GroupId = groupId;
            IsReserved = isReserved;
            PrivateLinkResourceId = privateLinkResourceId;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the managed private endpoint connection state
        /// </summary>
        [JsonProperty(PropertyName = "connectionState")]
        public ConnectionStateProperties ConnectionState { get; set; }

        /// <summary>
        /// Gets or sets fully qualified domain names
        /// </summary>
        [JsonProperty(PropertyName = "fqdns")]
        public IList<string> Fqdns { get; set; }

        /// <summary>
        /// Gets or sets the groupId to which the managed private endpoint is
        /// created
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets denotes whether the managed private endpoint is reserved
        /// </summary>
        [JsonProperty(PropertyName = "isReserved")]
        public bool? IsReserved { get; private set; }

        /// <summary>
        /// Gets or sets the ARM resource ID of the resource to which the
        /// managed private endpoint is created
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkResourceId")]
        public string PrivateLinkResourceId { get; set; }

        /// <summary>
        /// Gets the managed private endpoint provisioning state
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
