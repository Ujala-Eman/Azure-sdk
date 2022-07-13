// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SQLStorageSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Luns))
            {
                writer.WritePropertyName("luns");
                writer.WriteStartArray();
                foreach (var item in Luns)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultFilePath))
            {
                writer.WritePropertyName("defaultFilePath");
                writer.WriteStringValue(DefaultFilePath);
            }
            writer.WriteEndObject();
        }

        internal static SQLStorageSettings DeserializeSQLStorageSettings(JsonElement element)
        {
            Optional<IList<int>> luns = default;
            Optional<string> defaultFilePath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("luns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    luns = array;
                    continue;
                }
                if (property.NameEquals("defaultFilePath"))
                {
                    defaultFilePath = property.Value.GetString();
                    continue;
                }
            }
            return new SQLStorageSettings(Optional.ToList(luns), defaultFilePath.Value);
        }
    }
}
