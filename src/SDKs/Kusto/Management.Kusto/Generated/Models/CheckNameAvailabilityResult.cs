// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result returned from a check name availability request.
    /// </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        public CheckNameAvailabilityResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        /// <param name="nameAvailable">Specifies whether or not the name is
        /// available. Possible values include: 'Available',
        /// 'NotAvailable'</param>
        /// <param name="name">The name that was checked.</param>
        /// <param name="message">Message indicating an unavailable name due to
        /// a conflict, or a description of the naming rules that are
        /// violated.</param>
        public CheckNameAvailabilityResult(string nameAvailable = default(string), string name = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Name = name;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether or not the name is available.
        /// Possible values include: 'Available', 'NotAvailable'
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public string NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets the name that was checked.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets message indicating an unavailable name due to a
        /// conflict, or a description of the naming rules that are violated.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
