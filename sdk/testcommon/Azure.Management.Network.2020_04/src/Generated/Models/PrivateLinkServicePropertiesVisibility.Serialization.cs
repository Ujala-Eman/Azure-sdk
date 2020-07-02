// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PrivateLinkServicePropertiesVisibility : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions");
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PrivateLinkServicePropertiesVisibility DeserializePrivateLinkServicePropertiesVisibility(JsonElement element)
        {
            Optional<IList<string>> subscriptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptions"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    subscriptions = array;
                    continue;
                }
            }
            return new PrivateLinkServicePropertiesVisibility(new ChangeTrackingList<string>(subscriptions));
        }
    }
}
