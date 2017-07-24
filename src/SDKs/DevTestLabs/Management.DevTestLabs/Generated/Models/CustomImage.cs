// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A custom image.
    /// </summary>
    [JsonTransformation]
    public partial class CustomImage : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomImage class.
        /// </summary>
        public CustomImage() { }

        /// <summary>
        /// Initializes a new instance of the CustomImage class.
        /// </summary>
        public CustomImage(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), CustomImagePropertiesFromVm vm = default(CustomImagePropertiesFromVm), CustomImagePropertiesCustom vhd = default(CustomImagePropertiesCustom), string description = default(string), string author = default(string), DateTime? creationDate = default(DateTime?), string managedImageId = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            Vm = vm;
            Vhd = vhd;
            Description = description;
            Author = author;
            CreationDate = creationDate;
            ManagedImageId = managedImageId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary>
        /// The virtual machine from which the image is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vm")]
        public CustomImagePropertiesFromVm Vm { get; set; }

        /// <summary>
        /// The VHD from which the image is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vhd")]
        public CustomImagePropertiesCustom Vhd { get; set; }

        /// <summary>
        /// The description of the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// The author of the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; set; }

        /// <summary>
        /// The creation date of the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public DateTime? CreationDate { get; private set; }

        /// <summary>
        /// The Managed Image Id backing the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedImageId")]
        public string ManagedImageId { get; set; }

        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// The unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Vhd != null)
            {
                this.Vhd.Validate();
            }
        }
    }
}
