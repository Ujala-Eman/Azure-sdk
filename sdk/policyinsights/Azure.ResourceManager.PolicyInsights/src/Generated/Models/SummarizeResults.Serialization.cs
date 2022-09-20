// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class SummarizeResults
    {
        internal static SummarizeResults DeserializeSummarizeResults(JsonElement element)
        {
            Optional<string> odataContext = default;
            Optional<int> odataCount = default;
            Optional<IReadOnlyList<PolicySummary>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicySummary> array = new List<PolicySummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicySummary.DeserializePolicySummary(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SummarizeResults(odataContext.Value, Optional.ToNullable(odataCount), Optional.ToList(value));
        }
    }
}
