// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> The resource set processing property of the account. </summary>
    public partial class AdvancedResourceSet
    {
        /// <summary> Initializes a new instance of AdvancedResourceSet. </summary>
        public AdvancedResourceSet()
        {
        }

        /// <summary> Initializes a new instance of AdvancedResourceSet. </summary>
        /// <param name="modifiedAt"> Date at which ResourceSetProcessing property of the account is updated. </param>
        /// <param name="resourceSetProcessing"> The advanced resource property of the account. </param>
        internal AdvancedResourceSet(DateTimeOffset? modifiedAt, ResourceSetProcessing? resourceSetProcessing)
        {
            ModifiedAt = modifiedAt;
            ResourceSetProcessing = resourceSetProcessing;
        }

        /// <summary> Date at which ResourceSetProcessing property of the account is updated. </summary>
        public DateTimeOffset? ModifiedAt { get; set; }
        /// <summary> The advanced resource property of the account. </summary>
        public ResourceSetProcessing? ResourceSetProcessing { get; set; }
    }
}
