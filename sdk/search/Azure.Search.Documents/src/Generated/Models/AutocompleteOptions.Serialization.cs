// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    public partial class AutocompleteOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("search"u8);
            writer.WriteStringValue(SearchText);
            if (Mode.HasValue)
            {
                writer.WritePropertyName("autocompleteMode"u8);
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (UseFuzzyMatching.HasValue)
            {
                writer.WritePropertyName("fuzzy"u8);
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag"u8);
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag"u8);
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage.HasValue)
            {
                writer.WritePropertyName("minimumCoverage"u8);
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (SearchFieldsRaw != null)
            {
                writer.WritePropertyName("searchFields"u8);
                writer.WriteStringValue(SearchFieldsRaw);
            }
            writer.WritePropertyName("suggesterName"u8);
            writer.WriteStringValue(SuggesterName);
            if (Size.HasValue)
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Size.Value);
            }
            writer.WriteEndObject();
        }
    }
}
