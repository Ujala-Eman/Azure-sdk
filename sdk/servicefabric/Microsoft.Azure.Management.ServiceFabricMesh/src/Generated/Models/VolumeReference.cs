// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a reference to a volume resource.
    /// </summary>
    public partial class VolumeReference
    {
        /// <summary>
        /// Initializes a new instance of the VolumeReference class.
        /// </summary>
        public VolumeReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeReference class.
        /// </summary>
        /// <param name="name">Name of the volume being referenced.</param>
        /// <param name="destinationPath">The path within the container at
        /// which the volume should be mounted. Only valid path characters are
        /// allowed.</param>
        /// <param name="readOnlyProperty">The flag indicating whether the
        /// volume is read only. Default is 'false'.</param>
        public VolumeReference(string name, string destinationPath, bool? readOnlyProperty = default(bool?))
        {
            Name = name;
            ReadOnlyProperty = readOnlyProperty;
            DestinationPath = destinationPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the volume being referenced.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether the volume is read only.
        /// Default is 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets the path within the container at which the volume
        /// should be mounted. Only valid path characters are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPath")]
        public string DestinationPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DestinationPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DestinationPath");
            }
        }
    }
}
