// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class SymmetricKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey");
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey");
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WriteEndObject();
        }

        internal static SymmetricKey DeserializeSymmetricKey(JsonElement element)
        {
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
            }
            return new SymmetricKey(primaryKey.Value, secondaryKey.Value);
        }
    }
}
