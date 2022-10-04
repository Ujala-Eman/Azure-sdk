// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    internal partial class DatadogApiKeyListResponse
    {
        internal static DatadogApiKeyListResponse DeserializeDatadogApiKeyListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<DatadogApiKey>> value = default;
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
                    List<DatadogApiKey> array = new List<DatadogApiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatadogApiKey.DeserializeDatadogApiKey(item));
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
            return new DatadogApiKeyListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
