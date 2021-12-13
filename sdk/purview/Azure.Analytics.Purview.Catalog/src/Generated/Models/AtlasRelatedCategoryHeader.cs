// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Catalog.Models
{
    /// <summary> The header of the related category. </summary>
    public partial class AtlasRelatedCategoryHeader
    {
        /// <summary> Initializes a new instance of AtlasRelatedCategoryHeader. </summary>
        public AtlasRelatedCategoryHeader()
        {
        }

        /// <summary> Initializes a new instance of AtlasRelatedCategoryHeader. </summary>
        /// <param name="categoryGuid"> The GUID of the category. </param>
        /// <param name="description"> The description of the category header. </param>
        /// <param name="displayText"> The display text. </param>
        /// <param name="parentCategoryGuid"> The GUID of the parent category. </param>
        /// <param name="relationGuid"> The GUID of the relationship. </param>
        internal AtlasRelatedCategoryHeader(string categoryGuid, string description, string displayText, string parentCategoryGuid, string relationGuid)
        {
            CategoryGuid = categoryGuid;
            Description = description;
            DisplayText = displayText;
            ParentCategoryGuid = parentCategoryGuid;
            RelationGuid = relationGuid;
        }

        /// <summary> The GUID of the category. </summary>
        public string CategoryGuid { get; set; }
        /// <summary> The description of the category header. </summary>
        public string Description { get; set; }
        /// <summary> The display text. </summary>
        public string DisplayText { get; set; }
        /// <summary> The GUID of the parent category. </summary>
        public string ParentCategoryGuid { get; set; }
        /// <summary> The GUID of the relationship. </summary>
        public string RelationGuid { get; set; }
    }
}
