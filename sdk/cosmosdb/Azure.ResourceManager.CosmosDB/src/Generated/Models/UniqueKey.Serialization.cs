// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class UniqueKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Paths))
            {
                writer.WritePropertyName("paths");
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UniqueKey DeserializeUniqueKey(JsonElement element)
        {
            Optional<IList<string>> paths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("paths"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    paths = array;
                    continue;
                }
            }
            return new UniqueKey(Optional.ToList(paths));
        }
    }
}
