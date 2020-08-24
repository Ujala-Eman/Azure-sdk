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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The customer name to be printed on a letter of authorization.
    /// </summary>
    public partial class GenerateExpressRoutePortsLOARequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GenerateExpressRoutePortsLOARequest class.
        /// </summary>
        public GenerateExpressRoutePortsLOARequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GenerateExpressRoutePortsLOARequest class.
        /// </summary>
        /// <param name="customerName">The customer name.</param>
        public GenerateExpressRoutePortsLOARequest(string customerName)
        {
            CustomerName = customerName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CustomerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CustomerName");
            }
        }
    }
}
