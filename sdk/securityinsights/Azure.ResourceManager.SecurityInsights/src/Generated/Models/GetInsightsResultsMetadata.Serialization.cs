// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class GetInsightsResultsMetadata
    {
        internal static GetInsightsResultsMetadata DeserializeGetInsightsResultsMetadata(JsonElement element)
        {
            int totalCount = default;
            Optional<IReadOnlyList<GetInsightsErrorKind>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalCount"))
                {
                    totalCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GetInsightsErrorKind> array = new List<GetInsightsErrorKind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GetInsightsErrorKind.DeserializeGetInsightsErrorKind(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new GetInsightsResultsMetadata(totalCount, Optional.ToList(errors));
        }
    }
}
