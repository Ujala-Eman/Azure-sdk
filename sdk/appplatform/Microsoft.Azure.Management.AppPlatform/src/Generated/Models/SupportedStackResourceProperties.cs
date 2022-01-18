// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Supported stack resource properties
    /// </summary>
    public partial class SupportedStackResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the SupportedStackResourceProperties
        /// class.
        /// </summary>
        public SupportedStackResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportedStackResourceProperties
        /// class.
        /// </summary>
        /// <param name="stackId">The id of supported stack</param>
        /// <param name="version">The version of supported stack</param>
        public SupportedStackResourceProperties(string stackId = default(string), string version = default(string))
        {
            StackId = stackId;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of supported stack
        /// </summary>
        [JsonProperty(PropertyName = "stackId")]
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets the version of supported stack
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
