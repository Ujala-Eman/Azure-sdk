// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CheckNameAvailabilitySpecifications
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilitySpecifications class.
        /// </summary>
        public CheckNameAvailabilitySpecifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckNameAvailabilitySpecifications class.
        /// </summary>
        public CheckNameAvailabilitySpecifications(bool? enableDefaultValidation = default(bool?), IList<string> resourceTypesWithCustomValidation = default(IList<string>))
        {
            EnableDefaultValidation = enableDefaultValidation;
            ResourceTypesWithCustomValidation = resourceTypesWithCustomValidation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enableDefaultValidation")]
        public bool? EnableDefaultValidation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceTypesWithCustomValidation")]
        public IList<string> ResourceTypesWithCustomValidation { get; set; }

    }
}
