// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class PatternReplaceTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("pattern");
            writer.WriteStringValue(Pattern);
            writer.WritePropertyName("replacement");
            writer.WriteStringValue(Replacement);
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PatternReplaceTokenFilter DeserializePatternReplaceTokenFilter(JsonElement element)
        {
            string pattern = default;
            string replacement = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replacement"))
                {
                    replacement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PatternReplaceTokenFilter(odatatype, name, pattern, replacement);
        }
    }
}
