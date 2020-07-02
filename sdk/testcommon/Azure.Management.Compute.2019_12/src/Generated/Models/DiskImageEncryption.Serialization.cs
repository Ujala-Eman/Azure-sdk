// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DiskImageEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId");
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            writer.WriteEndObject();
        }

        internal static DiskImageEncryption DeserializeDiskImageEncryption(JsonElement element)
        {
            Optional<string> diskEncryptionSetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    diskEncryptionSetId = property.Value.GetString();
                    continue;
                }
            }
            return new DiskImageEncryption(diskEncryptionSetId.HasValue ? diskEncryptionSetId.Value : null);
        }
    }
}
