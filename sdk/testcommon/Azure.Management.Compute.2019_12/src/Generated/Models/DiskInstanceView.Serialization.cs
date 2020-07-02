// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DiskInstanceView : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
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
            if (Optional.IsDefined(Statuses))
            {
                writer.WritePropertyName("statuses");
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DiskInstanceView DeserializeDiskInstanceView(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IList<DiskEncryptionSettings>> encryptionSettings = default;
            Optional<IList<InstanceViewStatus>> statuses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"))
                {
                    List<DiskEncryptionSettings> array = new List<DiskEncryptionSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DiskEncryptionSettings.DeserializeDiskEncryptionSettings(item));
                        }
                    }
                    encryptionSettings = array;
                    continue;
                }
                if (property.NameEquals("statuses"))
                {
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                        }
                    }
                    statuses = array;
                    continue;
                }
            }
            return new DiskInstanceView(name.HasValue ? name.Value : null, new ChangeTrackingList<DiskEncryptionSettings>(encryptionSettings), new ChangeTrackingList<InstanceViewStatus>(statuses));
        }
    }
}
