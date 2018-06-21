// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maps.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Whether the operation refers to the primary or secondary key.
    /// </summary>
    public partial class MapsKeySpecification
    {
        /// <summary>
        /// Initializes a new instance of the MapsKeySpecification class.
        /// </summary>
        public MapsKeySpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapsKeySpecification class.
        /// </summary>
        /// <param name="keyType">Whether the operation refers to the primary
        /// or secondary key. Possible values include: 'primary',
        /// 'secondary'</param>
        public MapsKeySpecification(string keyType)
        {
            KeyType = keyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether the operation refers to the primary or
        /// secondary key. Possible values include: 'primary', 'secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public string KeyType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyType");
            }
        }
    }
}
