// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class FlexibleServersSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("tier");
            writer.WriteStringValue(Tier.ToString());
            writer.WriteEndObject();
        }

        internal static FlexibleServersSku DeserializeFlexibleServersSku(JsonElement element)
        {
            string name = default;
            FlexibleServersSkuTier tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = new FlexibleServersSkuTier(property.Value.GetString());
                    continue;
                }
            }
            return new FlexibleServersSku(name, tier);
        }
    }
}
