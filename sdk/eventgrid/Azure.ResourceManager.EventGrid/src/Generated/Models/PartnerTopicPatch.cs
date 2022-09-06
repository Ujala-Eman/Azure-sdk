// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Partner Topic update. </summary>
    public partial class PartnerTopicPatch
    {
        /// <summary> Initializes a new instance of PartnerTopicPatch. </summary>
        public PartnerTopicPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags of the Partner Topic resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Identity information for the Partner Topic resource. </summary>
        public IdentityInfo Identity { get; set; }
    }
}
