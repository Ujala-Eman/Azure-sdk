// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SensitivityLabelListResult
    {
        internal static SensitivityLabelListResult DeserializeSensitivityLabelListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SensitivityLabelData>> value = default;
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
                    List<SensitivityLabelData> array = new List<SensitivityLabelData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SensitivityLabelData.DeserializeSensitivityLabelData(item));
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
            return new SensitivityLabelListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
