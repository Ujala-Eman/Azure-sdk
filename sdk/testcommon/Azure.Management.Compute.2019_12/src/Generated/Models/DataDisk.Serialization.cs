// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DataDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("lun");
            writer.WriteNumberValue(Lun);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Vhd))
            {
                writer.WritePropertyName("vhd");
                writer.WriteObjectValue(Vhd);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image");
                writer.WriteObjectValue(Image);
            }
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(WriteAcceleratorEnabled))
            {
                writer.WritePropertyName("writeAcceleratorEnabled");
                writer.WriteBooleanValue(WriteAcceleratorEnabled.Value);
            }
            writer.WritePropertyName("createOption");
            writer.WriteStringValue(CreateOption.ToString());
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk");
                writer.WriteObjectValue(ManagedDisk);
            }
            if (Optional.IsDefined(ToBeDetached))
            {
                writer.WritePropertyName("toBeDetached");
                writer.WriteBooleanValue(ToBeDetached.Value);
            }
            if (Optional.IsDefined(DiskIopsReadWrite))
            {
                writer.WritePropertyName("diskIOPSReadWrite");
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (Optional.IsDefined(DiskMBpsReadWrite))
            {
                writer.WritePropertyName("diskMBpsReadWrite");
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataDisk DeserializeDataDisk(JsonElement element)
        {
            int lun = default;
            Optional<string> name = default;
            Optional<VirtualHardDisk> vhd = default;
            Optional<VirtualHardDisk> image = default;
            Optional<CachingTypes> caching = default;
            Optional<bool> writeAcceleratorEnabled = default;
            DiskCreateOptionTypes createOption = default;
            Optional<int> diskSizeGB = default;
            Optional<ManagedDiskParameters> managedDisk = default;
            Optional<bool> toBeDetached = default;
            Optional<long> diskIOPSReadWrite = default;
            Optional<long> diskMBpsReadWrite = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhd"))
                {
                    vhd = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("image"))
                {
                    image = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    caching = property.Value.GetString().ToCachingTypes();
                    continue;
                }
                if (property.NameEquals("writeAcceleratorEnabled"))
                {
                    writeAcceleratorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createOption"))
                {
                    createOption = new DiskCreateOptionTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    managedDisk = ManagedDiskParameters.DeserializeManagedDiskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("toBeDetached"))
                {
                    toBeDetached = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskIOPSReadWrite"))
                {
                    diskIOPSReadWrite = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskMBpsReadWrite"))
                {
                    diskMBpsReadWrite = property.Value.GetInt64();
                    continue;
                }
            }
            return new DataDisk(lun, name.HasValue ? name.Value : null, vhd.HasValue ? vhd.Value : null, image.HasValue ? image.Value : null, caching.HasValue ? caching.Value : (CachingTypes?)null, writeAcceleratorEnabled.HasValue ? writeAcceleratorEnabled.Value : (bool?)null, createOption, diskSizeGB.HasValue ? diskSizeGB.Value : (int?)null, managedDisk.HasValue ? managedDisk.Value : null, toBeDetached.HasValue ? toBeDetached.Value : (bool?)null, diskIOPSReadWrite.HasValue ? diskIOPSReadWrite.Value : (long?)null, diskMBpsReadWrite.HasValue ? diskMBpsReadWrite.Value : (long?)null);
        }
    }
}
