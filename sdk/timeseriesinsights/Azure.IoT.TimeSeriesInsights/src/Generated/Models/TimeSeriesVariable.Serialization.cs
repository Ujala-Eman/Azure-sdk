// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesVariable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesVariable DeserializeTimeSeriesVariable(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "aggregate": return AggregateVariable.DeserializeAggregateVariable(element);
                    case "categorical": return CategoricalVariable.DeserializeCategoricalVariable(element);
                    case "numeric": return NumericVariable.DeserializeNumericVariable(element);
                }
            }
            string kind = default;
            Optional<TimeSeriesExpression> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
            }
            return new TimeSeriesVariable(kind, filter.Value);
        }
    }
}
