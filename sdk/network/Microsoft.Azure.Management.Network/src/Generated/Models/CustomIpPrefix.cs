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
    /// Custom IP prefix resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomIpPrefix : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomIpPrefix class.
        /// </summary>
        public CustomIpPrefix()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomIpPrefix class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="extendedLocation">The extended location of the custom
        /// IP prefix.</param>
        /// <param name="cidr">The prefix range in CIDR notation. Should
        /// include the start address and the prefix length.</param>
        /// <param name="commissionedState">The commissioned state of the
        /// Custom IP Prefix. Possible values include: 'Provisioning',
        /// 'Provisioned', 'Commissioning', 'Commissioned', 'Decommissioning',
        /// 'Deprovisioning'</param>
        /// <param name="publicIpPrefixes">The list of all referenced
        /// PublicIpPrefixes.</param>
        /// <param name="resourceGuid">The resource GUID property of the custom
        /// IP prefix resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// custom IP prefix resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="zones">A list of availability zones denoting the IP
        /// allocated for the resource needs to come from.</param>
        public CustomIpPrefix(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation), string cidr = default(string), string commissionedState = default(string), IList<SubResource> publicIpPrefixes = default(IList<SubResource>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string), IList<string> zones = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Cidr = cidr;
            CommissionedState = commissionedState;
            PublicIpPrefixes = publicIpPrefixes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the extended location of the custom IP prefix.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets the prefix range in CIDR notation. Should include the
        /// start address and the prefix length.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cidr")]
        public string Cidr { get; set; }

        /// <summary>
        /// Gets or sets the commissioned state of the Custom IP Prefix.
        /// Possible values include: 'Provisioning', 'Provisioned',
        /// 'Commissioning', 'Commissioned', 'Decommissioning',
        /// 'Deprovisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.commissionedState")]
        public string CommissionedState { get; set; }

        /// <summary>
        /// Gets the list of all referenced PublicIpPrefixes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIpPrefixes")]
        public IList<SubResource> PublicIpPrefixes { get; private set; }

        /// <summary>
        /// Gets the resource GUID property of the custom IP prefix resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the custom IP prefix resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting the IP allocated
        /// for the resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExtendedLocation != null)
            {
                ExtendedLocation.Validate();
            }
        }
    }
}
