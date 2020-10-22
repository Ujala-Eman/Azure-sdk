// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RestorableDroppedManagedDatabaseListResult
    {
        internal static RestorableDroppedManagedDatabaseListResult DeserializeRestorableDroppedManagedDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RestorableDroppedManagedDatabase>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorableDroppedManagedDatabase> array = new List<RestorableDroppedManagedDatabase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableDroppedManagedDatabase.DeserializeRestorableDroppedManagedDatabase(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RestorableDroppedManagedDatabaseListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
