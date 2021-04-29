// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A cluster resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="sku">The cluster SKU</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="clusterSize">The cluster size</param>
        /// <param name="provisioningState">The state of the cluster
        /// provisioning. Possible values include: 'Succeeded', 'Failed',
        /// 'Cancelled', 'Deleting', 'Updating'</param>
        /// <param name="clusterId">The identity</param>
        /// <param name="hosts">The hosts</param>
        public Cluster(Sku sku, string id = default(string), string name = default(string), string type = default(string), int? clusterSize = default(int?), string provisioningState = default(string), int? clusterId = default(int?), IList<string> hosts = default(IList<string>))
            : base(id, name, type)
        {
            Sku = sku;
            ClusterSize = clusterSize;
            ProvisioningState = provisioningState;
            ClusterId = clusterId;
            Hosts = hosts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cluster SKU
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the cluster size
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterSize")]
        public int? ClusterSize { get; set; }

        /// <summary>
        /// Gets or sets the state of the cluster provisioning. Possible values
        /// include: 'Succeeded', 'Failed', 'Cancelled', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the identity
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusterId")]
        public int? ClusterId { get; private set; }

        /// <summary>
        /// Gets the hosts
        /// </summary>
        [JsonProperty(PropertyName = "properties.hosts")]
        public IList<string> Hosts { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
