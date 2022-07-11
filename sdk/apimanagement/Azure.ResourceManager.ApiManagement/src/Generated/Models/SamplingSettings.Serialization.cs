// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class SamplingSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SamplingType))
            {
                writer.WritePropertyName("samplingType");
                writer.WriteStringValue(SamplingType.Value.ToString());
            }
            if (Optional.IsDefined(Percentage))
            {
                writer.WritePropertyName("percentage");
                writer.WriteNumberValue(Percentage.Value);
            }
            writer.WriteEndObject();
        }

        internal static SamplingSettings DeserializeSamplingSettings(JsonElement element)
        {
            Optional<SamplingType> samplingType = default;
            Optional<double> percentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("samplingType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    samplingType = new SamplingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("percentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    percentage = property.Value.GetDouble();
                    continue;
                }
            }
            return new SamplingSettings(Optional.ToNullable(samplingType), Optional.ToNullable(percentage));
        }
    }
}
