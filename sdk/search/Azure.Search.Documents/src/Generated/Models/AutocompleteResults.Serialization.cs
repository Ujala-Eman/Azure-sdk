// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class AutocompleteResults
    {
        internal static AutocompleteResults DeserializeAutocompleteResults(JsonElement element)
        {
            Optional<double> searchCoverage = default;
            IReadOnlyList<AutocompleteItem> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.coverage"))
                {
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<AutocompleteItem> array = new List<AutocompleteItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AutocompleteItem.DeserializeAutocompleteItem(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new AutocompleteResults(searchCoverage.HasValue ? searchCoverage.Value : (double?)null, value);
        }
    }
}
