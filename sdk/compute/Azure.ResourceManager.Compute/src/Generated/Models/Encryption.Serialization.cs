// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class Encryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DiskEncryptionSetId != null)
            {
                writer.WritePropertyName("diskEncryptionSetId");
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Encryption DeserializeEncryption(JsonElement element)
        {
            string diskEncryptionSetId = default;
            EncryptionType? type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new EncryptionType(property.Value.GetString());
                    continue;
                }
            }
            return new Encryption(diskEncryptionSetId, type);
        }
    }
}
