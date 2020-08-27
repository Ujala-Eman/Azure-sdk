// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class TableListResult
    {
        internal static TableListResult DeserializeTableListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TableGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TableGetResults> array = new List<TableGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TableGetResults.DeserializeTableGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new TableListResult(Optional.ToList(value));
        }
    }
}
