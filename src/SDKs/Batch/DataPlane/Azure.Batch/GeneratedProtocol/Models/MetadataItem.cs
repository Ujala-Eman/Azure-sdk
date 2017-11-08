// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A name-value pair associated with a Batch service resource.
    /// </summary>
    /// <remarks>
    /// The Batch service does not assign any meaning to this metadata; it is
    /// solely for the use of user code.
    /// </remarks>
    public partial class MetadataItem
    {
        /// <summary>
        /// Initializes a new instance of the MetadataItem class.
        /// </summary>
        public MetadataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataItem class.
        /// </summary>
        /// <param name="name">The name of the metadata item.</param>
        /// <param name="value">The value of the metadata item.</param>
        public MetadataItem(string name, string value)
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metadata item.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the metadata item.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
