// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Analysis;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that represents enumerating SKUs for existing resources
    /// </summary>
    public partial class SkuEnumerationForExistingResourceResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SkuEnumerationForExistingResourceResult class.
        /// </summary>
        public SkuEnumerationForExistingResourceResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SkuEnumerationForExistingResourceResult class.
        /// </summary>
        /// <param name="value">The collection of available SKUs for existing
        /// resources</param>
        public SkuEnumerationForExistingResourceResult(IList<SkuDetailsForExistingResource> value = default(IList<SkuDetailsForExistingResource>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of available SKUs for existing
        /// resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SkuDetailsForExistingResource> Value { get; set; }

    }
}
