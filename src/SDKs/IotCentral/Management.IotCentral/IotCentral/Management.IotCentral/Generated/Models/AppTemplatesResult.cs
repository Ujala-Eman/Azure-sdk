// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotCentral.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of IoT Central Application Templates with a next link.
    /// </summary>
    public partial class AppTemplatesResult
    {
        /// <summary>
        /// Initializes a new instance of the AppTemplatesResult class.
        /// </summary>
        public AppTemplatesResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppTemplatesResult class.
        /// </summary>
        /// <param name="nextLink">The link used to get the next page of IoT
        /// Central description objects.</param>
        /// <param name="value">A list of IoT Central Application
        /// Templates.</param>
        public AppTemplatesResult(string nextLink = default(string), IList<AppTemplate> value = default(IList<AppTemplate>))
        {
            NextLink = nextLink;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link used to get the next page of IoT Central
        /// description objects.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets a list of IoT Central Application Templates.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AppTemplate> Value { get; private set; }

    }
}
