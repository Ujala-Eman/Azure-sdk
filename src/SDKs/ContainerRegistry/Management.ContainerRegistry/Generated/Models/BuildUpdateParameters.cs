// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The set of build properties that can be updated.
    /// </summary>
    public partial class BuildUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BuildUpdateParameters class.
        /// </summary>
        public BuildUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildUpdateParameters class.
        /// </summary>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled or not.</param>
        public BuildUpdateParameters(bool? isArchiveEnabled = default(bool?))
        {
            IsArchiveEnabled = isArchiveEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value that indicates whether archiving is enabled
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "isArchiveEnabled")]
        public bool? IsArchiveEnabled { get; set; }

    }
}
