// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointSourceVmOSDisk
    {
        internal static RestorePointSourceVmOSDisk DeserializeRestorePointSourceVmOSDisk(JsonElement element)
        {
            Optional<OperatingSystemType> osType = default;
            Optional<DiskEncryptionSettings> encryptionSettings = default;
            Optional<string> name = default;
            Optional<CachingType> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<ManagedDiskParameters> managedDisk = default;
            Optional<WritableSubResource> diskRestorePoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = new OperatingSystemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryptionSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryptionSettings = DiskEncryptionSettings.DeserializeDiskEncryptionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedDisk = ManagedDiskParameters.DeserializeManagedDiskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("diskRestorePoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskRestorePoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
            }
            return new RestorePointSourceVmOSDisk(Optional.ToNullable(osType), encryptionSettings.Value, name.Value, Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), managedDisk.Value, diskRestorePoint);
        }
    }
}
