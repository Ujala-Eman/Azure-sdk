// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DataDiskImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun");
                writer.WriteNumberValue(Lun.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataDiskImage DeserializeDataDiskImage(JsonElement element)
        {
            Optional<int> lun = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lun"))
                {
                    lun = property.Value.GetInt32();
                    continue;
                }
            }
            return new DataDiskImage(lun.HasValue ? lun.Value : (int?)null);
        }
    }
}
