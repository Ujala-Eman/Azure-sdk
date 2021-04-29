// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EHNamespaceIdListResult
    {
        internal static EHNamespaceIdListResult DeserializeEHNamespaceIdListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EHNamespaceIdContainer>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EHNamespaceIdContainer> array = new List<EHNamespaceIdContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EHNamespaceIdContainer.DeserializeEHNamespaceIdContainer(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EHNamespaceIdListResult(Optional.ToList(value));
        }
    }
}
