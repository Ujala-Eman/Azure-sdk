// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class SentimentTaskResult
    {
        internal static SentimentTaskResult DeserializeSentimentTaskResult(JsonElement element)
        {
            Optional<SentimentResponse> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = SentimentResponse.DeserializeSentimentResponse(property.Value);
                    continue;
                }
            }
            return new SentimentTaskResult(results.Value);
        }
    }
}
