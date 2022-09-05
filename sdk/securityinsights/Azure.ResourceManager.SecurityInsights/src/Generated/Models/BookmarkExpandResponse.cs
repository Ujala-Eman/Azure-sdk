// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The entity expansion result operation response. </summary>
    public partial class BookmarkExpandResponse
    {
        /// <summary> Initializes a new instance of BookmarkExpandResponse. </summary>
        internal BookmarkExpandResponse()
        {
        }

        /// <summary> Initializes a new instance of BookmarkExpandResponse. </summary>
        /// <param name="metaData"> The metadata from the expansion operation results. </param>
        /// <param name="value"> The expansion result values. </param>
        internal BookmarkExpandResponse(ExpansionResultsMetadata metaData, BookmarkExpandResponseValue value)
        {
            MetaData = metaData;
            Value = value;
        }

        /// <summary> The metadata from the expansion operation results. </summary>
        internal ExpansionResultsMetadata MetaData { get; }
        /// <summary> Information of the aggregated nodes in the expansion result. </summary>
        public IReadOnlyList<ExpansionResultAggregation> MetaDataAggregations
        {
            get => MetaData?.Aggregations;
        }

        /// <summary> The expansion result values. </summary>
        public BookmarkExpandResponseValue Value { get; }
    }
}
