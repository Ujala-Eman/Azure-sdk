// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class TableEntityQueryResponse
    {
        internal static TableEntityQueryResponse DeserializeTableEntityQueryResponse(JsonElement element)
        {
            Optional<string> odataMetadata = default;
            Optional<IReadOnlyList<IDictionary<string, object>>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"))
                {
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<IDictionary<string, object>> array = new List<IDictionary<string, object>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                if (property0.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property0.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property0.Name, property0.Value.GetObject());
                                }
                            }
                            array.Add(dictionary);
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new TableEntityQueryResponse(odataMetadata.HasValue ? odataMetadata.Value : null, new ChangeTrackingList<IDictionary<string, object>>(value));
        }
    }
}
