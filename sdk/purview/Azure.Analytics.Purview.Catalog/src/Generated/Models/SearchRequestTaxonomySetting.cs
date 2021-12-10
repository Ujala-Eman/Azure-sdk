// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    /// <summary> The SearchRequestTaxonomySetting. </summary>
    public partial class SearchRequestTaxonomySetting
    {
        /// <summary> Initializes a new instance of SearchRequestTaxonomySetting. </summary>
        public SearchRequestTaxonomySetting()
        {
            AssetTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Gets the asset types. </summary>
        public IList<string> AssetTypes { get; }
        /// <summary> The content of a search facet result item. </summary>
        public SearchFacetItem Facet { get; set; }
    }
}
