// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateOrReplace operation.
    /// </summary>
    public partial class FunctionsCreateOrReplaceHeaders
    {
        /// <summary>
        /// Initializes a new instance of the FunctionsCreateOrReplaceHeaders
        /// class.
        /// </summary>
        public FunctionsCreateOrReplaceHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FunctionsCreateOrReplaceHeaders
        /// class.
        /// </summary>
        /// <param name="eTag">The current entity tag for the function. This is
        /// an opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.</param>
        public FunctionsCreateOrReplaceHeaders(string eTag = default(string))
        {
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current entity tag for the function. This is an
        /// opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

    }
}
