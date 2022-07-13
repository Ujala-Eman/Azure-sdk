// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskCSIDriver))
            {
                writer.WritePropertyName("diskCSIDriver");
                writer.WriteObjectValue(DiskCSIDriver);
            }
            if (Optional.IsDefined(FileCSIDriver))
            {
                writer.WritePropertyName("fileCSIDriver");
                writer.WriteObjectValue(FileCSIDriver);
            }
            if (Optional.IsDefined(SnapshotController))
            {
                writer.WritePropertyName("snapshotController");
                writer.WriteObjectValue(SnapshotController);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterStorageProfile DeserializeManagedClusterStorageProfile(JsonElement element)
        {
            Optional<ManagedClusterStorageProfileDiskCSIDriver> diskCSIDriver = default;
            Optional<ManagedClusterStorageProfileFileCSIDriver> fileCSIDriver = default;
            Optional<ManagedClusterStorageProfileSnapshotController> snapshotController = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskCSIDriver"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskCSIDriver = ManagedClusterStorageProfileDiskCSIDriver.DeserializeManagedClusterStorageProfileDiskCSIDriver(property.Value);
                    continue;
                }
                if (property.NameEquals("fileCSIDriver"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileCSIDriver = ManagedClusterStorageProfileFileCSIDriver.DeserializeManagedClusterStorageProfileFileCSIDriver(property.Value);
                    continue;
                }
                if (property.NameEquals("snapshotController"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snapshotController = ManagedClusterStorageProfileSnapshotController.DeserializeManagedClusterStorageProfileSnapshotController(property.Value);
                    continue;
                }
            }
            return new ManagedClusterStorageProfile(diskCSIDriver.Value, fileCSIDriver.Value, snapshotController.Value);
        }
    }
}
