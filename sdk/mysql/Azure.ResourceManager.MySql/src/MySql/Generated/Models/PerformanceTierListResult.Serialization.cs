// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class PerformanceTierListResult
    {
        internal static PerformanceTierListResult DeserializePerformanceTierListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PerformanceTierProperties>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PerformanceTierProperties> array = new List<PerformanceTierProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PerformanceTierProperties.DeserializePerformanceTierProperties(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PerformanceTierListResult(Optional.ToList(value));
        }
    }
}
