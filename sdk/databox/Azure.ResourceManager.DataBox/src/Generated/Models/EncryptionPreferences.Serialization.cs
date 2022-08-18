// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class EncryptionPreferences : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DoubleEncryption))
            {
                writer.WritePropertyName("doubleEncryption");
                writer.WriteStringValue(DoubleEncryption.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static EncryptionPreferences DeserializeEncryptionPreferences(JsonElement element)
        {
            Optional<DoubleEncryption> doubleEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("doubleEncryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    doubleEncryption = property.Value.GetString().ToDoubleEncryption();
                    continue;
                }
            }
            return new EncryptionPreferences(Optional.ToNullable(doubleEncryption));
        }
    }
}
