// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class UserProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Value.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static UserProperty DeserializeUserProperty(JsonElement element)
        {
            string name = default;
            BinaryData value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new UserProperty(name, value);
        }
    }
}
