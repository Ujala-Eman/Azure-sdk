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
    internal partial class PrivateLinkHubInfoListResult
    {
        internal static PrivateLinkHubInfoListResult DeserializePrivateLinkHubInfoListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<PrivateLinkHubData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateLinkHubData> array = new List<PrivateLinkHubData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkHubData.DeserializePrivateLinkHubData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkHubInfoListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
