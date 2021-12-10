// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class ClassificationRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static ClassificationRule DeserializeClassificationRule(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return CustomClassificationRule.DeserializeCustomClassificationRule(element);
                    case "System": return SystemClassificationRule.DeserializeSystemClassificationRule(element);
                }
            }
            ClassificationRuleType kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new ClassificationRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new ClassificationRule(id.Value, name.Value, kind);
        }
    }
}
