// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    /// <summary> A facet list that consists of index fields assetType ,classification, classificationCategory, contactId, fileExtension, label, and label. When the facet is specified in the request, the value of the facet is returned as an element of @search.facets. </summary>
    public partial class SearchFacetResultValue
    {
        /// <summary> Initializes a new instance of SearchFacetResultValue. </summary>
        internal SearchFacetResultValue()
        {
            AssetType = new ChangeTrackingList<SearchFacetItemValue>();
            Classification = new ChangeTrackingList<SearchFacetItemValue>();
            ClassificationCategory = new ChangeTrackingList<SearchFacetItemValue>();
            ContactId = new ChangeTrackingList<SearchFacetItemValue>();
            FileExtension = new ChangeTrackingList<SearchFacetItemValue>();
            Label = new ChangeTrackingList<SearchFacetItemValue>();
            Term = new ChangeTrackingList<SearchFacetItemValue>();
        }

        /// <summary> Initializes a new instance of SearchFacetResultValue. </summary>
        /// <param name="assetType"></param>
        /// <param name="classification"></param>
        /// <param name="classificationCategory"></param>
        /// <param name="contactId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="label"></param>
        /// <param name="term"></param>
        internal SearchFacetResultValue(IReadOnlyList<SearchFacetItemValue> assetType, IReadOnlyList<SearchFacetItemValue> classification, IReadOnlyList<SearchFacetItemValue> classificationCategory, IReadOnlyList<SearchFacetItemValue> contactId, IReadOnlyList<SearchFacetItemValue> fileExtension, IReadOnlyList<SearchFacetItemValue> label, IReadOnlyList<SearchFacetItemValue> term)
        {
            AssetType = assetType;
            Classification = classification;
            ClassificationCategory = classificationCategory;
            ContactId = contactId;
            FileExtension = fileExtension;
            Label = label;
            Term = term;
        }

        /// <summary> Gets the asset type. </summary>
        public IReadOnlyList<SearchFacetItemValue> AssetType { get; }
        /// <summary> Gets the classification. </summary>
        public IReadOnlyList<SearchFacetItemValue> Classification { get; }
        /// <summary> Gets the classification category. </summary>
        public IReadOnlyList<SearchFacetItemValue> ClassificationCategory { get; }
        /// <summary> Gets the contact id. </summary>
        public IReadOnlyList<SearchFacetItemValue> ContactId { get; }
        /// <summary> Gets the file extension. </summary>
        public IReadOnlyList<SearchFacetItemValue> FileExtension { get; }
        /// <summary> Gets the label. </summary>
        public IReadOnlyList<SearchFacetItemValue> Label { get; }
        /// <summary> Gets the term. </summary>
        public IReadOnlyList<SearchFacetItemValue> Term { get; }
    }
}
