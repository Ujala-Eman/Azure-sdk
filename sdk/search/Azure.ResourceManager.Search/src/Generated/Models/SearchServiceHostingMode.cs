// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </summary>
    public enum SearchServiceHostingMode
    {
        /// <summary> The limit on number of indexes is determined by the default limits for the SKU. </summary>
        Default,
        /// <summary> Only application for standard3 SKU, where the search service can have up to 1000 indexes. </summary>
        HighDensity
    }
}
