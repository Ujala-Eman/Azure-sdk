// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class FeedbackDimensionFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dimension");
            writer.WriteStartObject();
            foreach (var item in Dimension)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FeedbackDimensionFilter DeserializeFeedbackDimensionFilter(JsonElement element)
        {
            IDictionary<string, string> dimension = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimension"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    dimension = dictionary;
                    continue;
                }
            }
            return new FeedbackDimensionFilter(dimension);
        }
    }
}
