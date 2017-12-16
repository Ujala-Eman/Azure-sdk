// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single item in a List or Get AuthorizationRule operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AuthorizationRule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AuthorizationRule class.
        /// </summary>
        public AuthorizationRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationRule class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        public AuthorizationRule(IList<string> rights, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            Rights = rights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rights")]
        public IList<string> Rights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rights");
            }
        }
    }
}
