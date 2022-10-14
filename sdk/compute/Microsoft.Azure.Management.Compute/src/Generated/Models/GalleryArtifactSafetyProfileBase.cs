// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This is the safety profile of the Gallery Artifact Version.
    /// </summary>
    public partial class GalleryArtifactSafetyProfileBase
    {
        /// <summary>
        /// Initializes a new instance of the GalleryArtifactSafetyProfileBase
        /// class.
        /// </summary>
        public GalleryArtifactSafetyProfileBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryArtifactSafetyProfileBase
        /// class.
        /// </summary>
        /// <param name="allowDeletionOfReplicatedLocations">Indicates whether
        /// or not removing this Gallery Image Version from replicated regions
        /// is allowed.</param>
        public GalleryArtifactSafetyProfileBase(bool? allowDeletionOfReplicatedLocations = default(bool?))
        {
            AllowDeletionOfReplicatedLocations = allowDeletionOfReplicatedLocations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether or not removing this Gallery Image
        /// Version from replicated regions is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "allowDeletionOfReplicatedLocations")]
        public bool? AllowDeletionOfReplicatedLocations { get; set; }

    }
}
