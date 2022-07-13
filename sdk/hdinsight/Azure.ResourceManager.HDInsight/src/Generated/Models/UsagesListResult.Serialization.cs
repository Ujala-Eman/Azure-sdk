// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    internal partial class UsagesListResult
    {
        internal static UsagesListResult DeserializeUsagesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<HDInsightUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HDInsightUsage> array = new List<HDInsightUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightUsage.DeserializeHDInsightUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new UsagesListResult(Optional.ToList(value));
        }
    }
}
