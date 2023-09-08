// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryDiskEncryptionInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionKeyInfo))
            {
                writer.WritePropertyName("diskEncryptionKeyInfo"u8);
                writer.WriteObjectValue(DiskEncryptionKeyInfo);
            }
            if (Optional.IsDefined(KeyEncryptionKeyInfo))
            {
                writer.WritePropertyName("keyEncryptionKeyInfo"u8);
                writer.WriteObjectValue(KeyEncryptionKeyInfo);
            }
            writer.WriteEndObject();
        }

        internal static SiteRecoveryDiskEncryptionInfo DeserializeSiteRecoveryDiskEncryptionInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryDiskEncryptionKeyInfo> diskEncryptionKeyInfo = default;
            Optional<SiteRecoveryKeyEncryptionKeyInfo> keyEncryptionKeyInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionKeyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionKeyInfo = SiteRecoveryDiskEncryptionKeyInfo.DeserializeSiteRecoveryDiskEncryptionKeyInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKeyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKeyInfo = SiteRecoveryKeyEncryptionKeyInfo.DeserializeSiteRecoveryKeyEncryptionKeyInfo(property.Value);
                    continue;
                }
            }
            return new SiteRecoveryDiskEncryptionInfo(diskEncryptionKeyInfo.Value, keyEncryptionKeyInfo.Value);
        }
    }
}
