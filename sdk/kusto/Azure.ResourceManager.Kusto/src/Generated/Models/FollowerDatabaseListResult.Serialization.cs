// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class FollowerDatabaseListResult
    {
        internal static FollowerDatabaseListResult DeserializeFollowerDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KustoFollowerDatabaseDefinition>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KustoFollowerDatabaseDefinition> array = new List<KustoFollowerDatabaseDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoFollowerDatabaseDefinition.DeserializeKustoFollowerDatabaseDefinition(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new FollowerDatabaseListResult(Optional.ToList(value));
        }
    }
}
