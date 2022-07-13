// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the Create TagDescription operation. </summary>
    public partial class TagDescriptionContractCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of TagDescriptionContractCreateOrUpdateContent. </summary>
        public TagDescriptionContractCreateOrUpdateContent()
        {
        }

        /// <summary> Description of the Tag. </summary>
        public string Description { get; set; }
        /// <summary> Absolute URL of external resources describing the tag. </summary>
        public Uri ExternalDocsUri { get; set; }
        /// <summary> Description of the external resources describing the tag. </summary>
        public string ExternalDocsDescription { get; set; }
    }
}
