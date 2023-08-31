// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents various service level limits. </summary>
    public partial class SearchServiceLimits
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchServiceLimits"/>. </summary>
        internal SearchServiceLimits()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceLimits"/>. </summary>
        /// <param name="maxFieldsPerIndex"> The maximum allowed fields per index. </param>
        /// <param name="maxFieldNestingDepthPerIndex"> The maximum depth which you can nest sub-fields in an index, including the top-level complex field. For example, a/b/c has a nesting depth of 3. </param>
        /// <param name="maxComplexCollectionFieldsPerIndex"> The maximum number of fields of type Collection(Edm.ComplexType) allowed in an index. </param>
        /// <param name="maxComplexObjectsInCollectionsPerDocument"> The maximum number of objects in complex collections allowed per document. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceLimits(int? maxFieldsPerIndex, int? maxFieldNestingDepthPerIndex, int? maxComplexCollectionFieldsPerIndex, int? maxComplexObjectsInCollectionsPerDocument, Dictionary<string, BinaryData> rawData)
        {
            MaxFieldsPerIndex = maxFieldsPerIndex;
            MaxFieldNestingDepthPerIndex = maxFieldNestingDepthPerIndex;
            MaxComplexCollectionFieldsPerIndex = maxComplexCollectionFieldsPerIndex;
            MaxComplexObjectsInCollectionsPerDocument = maxComplexObjectsInCollectionsPerDocument;
            _rawData = rawData;
        }

        /// <summary> The maximum allowed fields per index. </summary>
        public int? MaxFieldsPerIndex { get; }
        /// <summary> The maximum depth which you can nest sub-fields in an index, including the top-level complex field. For example, a/b/c has a nesting depth of 3. </summary>
        public int? MaxFieldNestingDepthPerIndex { get; }
        /// <summary> The maximum number of fields of type Collection(Edm.ComplexType) allowed in an index. </summary>
        public int? MaxComplexCollectionFieldsPerIndex { get; }
        /// <summary> The maximum number of objects in complex collections allowed per document. </summary>
        public int? MaxComplexObjectsInCollectionsPerDocument { get; }
    }
}
