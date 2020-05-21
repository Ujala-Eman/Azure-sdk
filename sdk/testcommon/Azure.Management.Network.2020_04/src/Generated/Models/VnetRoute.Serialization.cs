// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VnetRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (StaticRoutes != null)
            {
                writer.WritePropertyName("staticRoutes");
                writer.WriteStartArray();
                foreach (var item in StaticRoutes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VnetRoute DeserializeVnetRoute(JsonElement element)
        {
            IList<StaticRoute> staticRoutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("staticRoutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRoute> array = new List<StaticRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(StaticRoute.DeserializeStaticRoute(item));
                        }
                    }
                    staticRoutes = array;
                    continue;
                }
            }
            return new VnetRoute(staticRoutes);
        }
    }
}
