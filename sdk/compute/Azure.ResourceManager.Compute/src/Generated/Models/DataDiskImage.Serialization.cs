// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DataDiskImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Lun != null)
            {
                writer.WritePropertyName("lun");
                writer.WriteNumberValue(Lun.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataDiskImage DeserializeDataDiskImage(JsonElement element)
        {
            int? lun = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
            }
            return new DataDiskImage(lun);
        }
    }
}
