// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkTableRequestTargetStructureOptionsConverter))]
    public partial class LinkTableRequestTargetStructureOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Type != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            writer.WriteEndObject();
        }

        internal static LinkTableRequestTargetStructureOptions DeserializeLinkTableRequestTargetStructureOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new LinkTableRequestTargetStructureOptions(type);
        }

        internal partial class LinkTableRequestTargetStructureOptionsConverter : JsonConverter<LinkTableRequestTargetStructureOptions>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableRequestTargetStructureOptions model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkTableRequestTargetStructureOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableRequestTargetStructureOptions(document.RootElement);
            }
        }
    }
}
