// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> Represents a field in an index definition, which describes the name, data type, and search behavior of a field. </summary>
    public partial class SearchField
    {

        /// <summary> Initializes a new instance of SearchField. </summary>
        /// <param name="name"> The name of the field, which must be unique within the fields collection of the index or parent field. </param>
        /// <param name="type"> The data type of the field. </param>
        /// <param name="isKey"> A value indicating whether the field uniquely identifies documents in the index. Exactly one top-level field in each index must be chosen as the key field and it must be of type Edm.String. Key fields can be used to look up documents directly and update or delete specific documents. Default is false for simple fields and null for complex fields. </param>
        /// <param name="isRetrievable"> A value indicating whether the field can be returned in a search result. You can disable this option if you want to use a field (for example, margin) as a filter, sorting, or scoring mechanism but do not want the field to be visible to the end user. This property must be true for key fields, and it must be null for complex fields. This property can be changed on existing fields. Enabling this property does not cause any increase in index storage requirements. Default is true for simple fields and null for complex fields. </param>
        /// <param name="isSearchable"> A value indicating whether the field is full-text searchable. This means it will undergo analysis such as word-breaking during indexing. If you set a searchable field to a value like &quot;sunny day&quot;, internally it will be split into the individual tokens &quot;sunny&quot; and &quot;day&quot;. This enables full-text searches for these terms. Fields of type Edm.String or Collection(Edm.String) are searchable by default. This property must be false for simple fields of other non-string data types, and it must be null for complex fields. Note: searchable fields consume extra space in your index since Azure Cognitive Search will store an additional tokenized version of the field value for full-text searches. If you want to save space in your index and you don&apos;t need a field to be included in searches, set searchable to false. </param>
        /// <param name="isFilterable"> A value indicating whether to enable the field to be referenced in $filter queries. filterable differs from searchable in how strings are handled. Fields of type Edm.String or Collection(Edm.String) that are filterable do not undergo word-breaking, so comparisons are for exact matches only. For example, if you set such a field f to &quot;sunny day&quot;, $filter=f eq &apos;sunny&apos; will find no matches, but $filter=f eq &apos;sunny day&apos; will. This property must be null for complex fields. Default is true for simple fields and null for complex fields. </param>
        /// <param name="isSortable"> A value indicating whether to enable the field to be referenced in $orderby expressions. By default Azure Cognitive Search sorts results by score, but in many experiences users will want to sort by fields in the documents. A simple field can be sortable only if it is single-valued (it has a single value in the scope of the parent document). Simple collection fields cannot be sortable, since they are multi-valued. Simple sub-fields of complex collections are also multi-valued, and therefore cannot be sortable. This is true whether it&apos;s an immediate parent field, or an ancestor field, that&apos;s the complex collection. Complex fields cannot be sortable and the sortable property must be null for such fields. The default for sortable is true for single-valued simple fields, false for multi-valued simple fields, and null for complex fields. </param>
        /// <param name="isFacetable"> A value indicating whether to enable the field to be referenced in facet queries. Typically used in a presentation of search results that includes hit count by category (for example, search for digital cameras and see hits by brand, by megapixels, by price, and so on). This property must be null for complex fields. Fields of type Edm.GeographyPoint or Collection(Edm.GeographyPoint) cannot be facetable. Default is true for all other simple fields. </param>
        /// <param name="analyzer"> The name of the analyzer to use for the field. This option can be used only with searchable fields and it can&apos;t be set together with either searchAnalyzer or indexAnalyzer. Once the analyzer is chosen, it cannot be changed for the field. Must be null for complex fields. </param>
        /// <param name="searchAnalyzer"> The name of the analyzer used at search time for the field. This option can be used only with searchable fields. It must be set together with indexAnalyzer and it cannot be set together with the analyzer option. This property cannot be set to the name of a language analyzer; use the analyzer property instead if you need a language analyzer. This analyzer can be updated on an existing field. Must be null for complex fields. </param>
        /// <param name="indexAnalyzer"> The name of the analyzer used at indexing time for the field. This option can be used only with searchable fields. It must be set together with searchAnalyzer and it cannot be set together with the analyzer option.  This property cannot be set to the name of a language analyzer; use the analyzer property instead if you need a language analyzer. Once the analyzer is chosen, it cannot be changed for the field. Must be null for complex fields. </param>
        /// <param name="synonymMaps"> A list of the names of synonym maps to associate with this field. This option can be used only with searchable fields. Currently only one synonym map per field is supported. Assigning a synonym map to a field ensures that query terms targeting that field are expanded at query-time using the rules in the synonym map. This attribute can be changed on existing fields. Must be null or an empty collection for complex fields. </param>
        /// <param name="fields"> A list of sub-fields if this is a field of type Edm.ComplexType or Collection(Edm.ComplexType). Must be null or empty for simple fields. </param>
        internal SearchField(string name, DataType type, bool? isKey, bool? isRetrievable, bool? isSearchable, bool? isFilterable, bool? isSortable, bool? isFacetable, AnalyzerName? analyzer, AnalyzerName? searchAnalyzer, AnalyzerName? indexAnalyzer, IList<string> synonymMaps, IList<SearchField> fields)
        {
            Name = name;
            Type = type;
            IsKey = isKey;
            IsRetrievable = isRetrievable;
            IsSearchable = isSearchable;
            IsFilterable = isFilterable;
            IsSortable = isSortable;
            IsFacetable = isFacetable;
            Analyzer = analyzer;
            SearchAnalyzer = searchAnalyzer;
            IndexAnalyzer = indexAnalyzer;
            SynonymMaps = synonymMaps;
            Fields = fields;
        }
        /// <summary> The name of the analyzer to use for the field. This option can be used only with searchable fields and it can&apos;t be set together with either searchAnalyzer or indexAnalyzer. Once the analyzer is chosen, it cannot be changed for the field. Must be null for complex fields. </summary>
        public AnalyzerName? Analyzer { get; set; }
        /// <summary> The name of the analyzer used at search time for the field. This option can be used only with searchable fields. It must be set together with indexAnalyzer and it cannot be set together with the analyzer option. This property cannot be set to the name of a language analyzer; use the analyzer property instead if you need a language analyzer. This analyzer can be updated on an existing field. Must be null for complex fields. </summary>
        public AnalyzerName? SearchAnalyzer { get; set; }
        /// <summary> The name of the analyzer used at indexing time for the field. This option can be used only with searchable fields. It must be set together with searchAnalyzer and it cannot be set together with the analyzer option.  This property cannot be set to the name of a language analyzer; use the analyzer property instead if you need a language analyzer. Once the analyzer is chosen, it cannot be changed for the field. Must be null for complex fields. </summary>
        public AnalyzerName? IndexAnalyzer { get; set; }
    }
}
