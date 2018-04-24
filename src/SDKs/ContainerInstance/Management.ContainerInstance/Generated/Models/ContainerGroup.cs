// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A container group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContainerGroup : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerGroup class.
        /// </summary>
        public ContainerGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerGroup class.
        /// </summary>
        /// <param name="containers">The containers within the container
        /// group.</param>
        /// <param name="osType">The operating system type required by the
        /// containers in the container group. Possible values include:
        /// 'Windows', 'Linux'</param>
        /// <param name="id">The resource id.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// container group. This only appears in the response.</param>
        /// <param name="imageRegistryCredentials">The image registry
        /// credentials by which the container group is created from.</param>
        /// <param name="restartPolicy">Restart policy for all containers
        /// within the container group.
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        /// . Possible values include: 'Always', 'OnFailure', 'Never'</param>
        /// <param name="ipAddress">The IP address type of the container
        /// group.</param>
        /// <param name="volumes">The list of volumes that can be mounted by
        /// containers in this container group.</param>
        /// <param name="instanceView">The instance view of the container
        /// group. Only valid in response.</param>
        public ContainerGroup(IList<Container> containers, string osType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), IList<ImageRegistryCredential> imageRegistryCredentials = default(IList<ImageRegistryCredential>), string restartPolicy = default(string), IpAddress ipAddress = default(IpAddress), IList<Volume> volumes = default(IList<Volume>), ContainerGroupPropertiesInstanceView instanceView = default(ContainerGroupPropertiesInstanceView))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            Containers = containers;
            ImageRegistryCredentials = imageRegistryCredentials;
            RestartPolicy = restartPolicy;
            IpAddress = ipAddress;
            OsType = osType;
            Volumes = volumes;
            InstanceView = instanceView;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the container group. This only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the containers within the container group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containers")]
        public IList<Container> Containers { get; set; }

        /// <summary>
        /// Gets or sets the image registry credentials by which the container
        /// group is created from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.imageRegistryCredentials")]
        public IList<ImageRegistryCredential> ImageRegistryCredentials { get; set; }

        /// <summary>
        /// Gets or sets restart policy for all containers within the container
        /// group.
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        /// . Possible values include: 'Always', 'OnFailure', 'Never'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restartPolicy")]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// Gets or sets the IP address type of the container group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public IpAddress IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the operating system type required by the containers
        /// in the container group. Possible values include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the list of volumes that can be mounted by containers
        /// in this container group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumes")]
        public IList<Volume> Volumes { get; set; }

        /// <summary>
        /// Gets the instance view of the container group. Only valid in
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public ContainerGroupPropertiesInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Containers == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Containers");
            }
            if (OsType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsType");
            }
            if (Containers != null)
            {
                foreach (var element in Containers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ImageRegistryCredentials != null)
            {
                foreach (var element1 in ImageRegistryCredentials)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (IpAddress != null)
            {
                IpAddress.Validate();
            }
            if (Volumes != null)
            {
                foreach (var element2 in Volumes)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
