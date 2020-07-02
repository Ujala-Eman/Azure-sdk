// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class EncryptionSettingsCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsDefined(EncryptionSettings))
            {
                writer.WritePropertyName("encryptionSettings");
                writer.WriteStartArray();
                foreach (var item in EncryptionSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptionSettingsVersion))
            {
                writer.WritePropertyName("encryptionSettingsVersion");
                writer.WriteStringValue(EncryptionSettingsVersion);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionSettingsCollection DeserializeEncryptionSettingsCollection(JsonElement element)
        {
            bool enabled = default;
            Optional<IList<EncryptionSettingsElement>> encryptionSettings = default;
            Optional<string> encryptionSettingsVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"))
                {
                    List<EncryptionSettingsElement> array = new List<EncryptionSettingsElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(EncryptionSettingsElement.DeserializeEncryptionSettingsElement(item));
                        }
                    }
                    encryptionSettings = array;
                    continue;
                }
                if (property.NameEquals("encryptionSettingsVersion"))
                {
                    encryptionSettingsVersion = property.Value.GetString();
                    continue;
                }
            }
            return new EncryptionSettingsCollection(enabled, new ChangeTrackingList<EncryptionSettingsElement>(encryptionSettings), encryptionSettingsVersion.HasValue ? encryptionSettingsVersion.Value : null);
        }
    }
}
