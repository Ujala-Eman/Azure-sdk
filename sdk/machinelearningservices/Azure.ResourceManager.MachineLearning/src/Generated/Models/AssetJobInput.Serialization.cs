// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class AssetJobInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static AssetJobInput DeserializeAssetJobInput(JsonElement element)
        {
            Optional<InputDeliveryMode> mode = default;
            Uri uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new InputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new AssetJobInput(Optional.ToNullable(mode), uri);
        }
    }
}
