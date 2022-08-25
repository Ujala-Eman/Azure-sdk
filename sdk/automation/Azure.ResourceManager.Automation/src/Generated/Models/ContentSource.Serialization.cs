// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class ContentSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Hash))
            {
                writer.WritePropertyName("hash");
                writer.WriteObjectValue(Hash);
            }
            if (Optional.IsDefined(SourceType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(SourceType.Value.ToString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static ContentSource DeserializeContentSource(JsonElement element)
        {
            Optional<ContentHash> hash = default;
            Optional<ContentSourceType> type = default;
            Optional<string> value = default;
            Optional<string> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hash"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hash = ContentHash.DeserializeContentHash(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ContentSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new ContentSource(hash.Value, Optional.ToNullable(type), value.Value, version.Value);
        }
    }
}
