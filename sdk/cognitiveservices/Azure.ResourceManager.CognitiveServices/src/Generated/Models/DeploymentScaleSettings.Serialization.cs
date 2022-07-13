// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class DeploymentScaleSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType");
                writer.WriteStringValue(ScaleType.Value.ToString());
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity");
                writer.WriteNumberValue(Capacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeploymentScaleSettings DeserializeDeploymentScaleSettings(JsonElement element)
        {
            Optional<DeploymentScaleType> scaleType = default;
            Optional<int> capacity = default;
            Optional<int> activeCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleType = new DeploymentScaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("activeCapacity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activeCapacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new DeploymentScaleSettings(Optional.ToNullable(scaleType), Optional.ToNullable(capacity), Optional.ToNullable(activeCapacity));
        }
    }
}
