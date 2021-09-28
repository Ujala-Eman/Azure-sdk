// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a namespace resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SBNamespace : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SBNamespace class.
        /// </summary>
        public SBNamespace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SBNamespace class.
        /// </summary>
        /// <param name="location">The Geo-location where the resource
        /// lives</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Properties of SKU</param>
        /// <param name="identity">Properties of BYOK Identity
        /// description</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// namespace.</param>
        /// <param name="status">Status of the namespace.</param>
        /// <param name="createdAt">The time the namespace was created</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// Service Bus operations.</param>
        /// <param name="metricId">Identifier for Azure Insights
        /// metrics</param>
        /// <param name="zoneRedundant">Enabling this property creates a
        /// Premium Service Bus Namespace in regions supported availability
        /// zones.</param>
        /// <param name="encryption">Properties of BYOK Encryption
        /// description</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections.</param>
        /// <param name="disableLocalAuth">This property disables SAS
        /// authentication for the Service Bus namespace.</param>
        public SBNamespace(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SBSku sku = default(SBSku), Identity identity = default(Identity), SystemData systemData = default(SystemData), string provisioningState = default(string), string status = default(string), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string metricId = default(string), bool? zoneRedundant = default(bool?), Encryption encryption = default(Encryption), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), bool? disableLocalAuth = default(bool?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            ZoneRedundant = zoneRedundant;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of SKU
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SBSku Sku { get; set; }

        /// <summary>
        /// Gets or sets properties of BYOK Identity description
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets provisioning state of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets status of the namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time the namespace was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets endpoint you can use to perform Service Bus operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint { get; private set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; private set; }

        /// <summary>
        /// Gets or sets enabling this property creates a Premium Service Bus
        /// Namespace in regions supported availability zones.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Gets or sets properties of BYOK Encryption description
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets list of private endpoint connections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; set; }

        /// <summary>
        /// Gets or sets this property disables SAS authentication for the
        /// Service Bus namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
