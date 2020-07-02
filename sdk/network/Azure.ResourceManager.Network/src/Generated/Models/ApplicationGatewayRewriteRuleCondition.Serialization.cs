// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRewriteRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable");
                writer.WriteStringValue(Variable);
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(IgnoreCase))
            {
                writer.WritePropertyName("ignoreCase");
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Optional.IsDefined(Negate))
            {
                writer.WritePropertyName("negate");
                writer.WriteBooleanValue(Negate.Value);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayRewriteRuleCondition DeserializeApplicationGatewayRewriteRuleCondition(JsonElement element)
        {
            Optional<string> variable = default;
            Optional<string> pattern = default;
            Optional<bool> ignoreCase = default;
            Optional<bool> negate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("variable"))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pattern"))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreCase"))
                {
                    ignoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("negate"))
                {
                    negate = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ApplicationGatewayRewriteRuleCondition(variable.HasValue ? variable.Value : null, pattern.HasValue ? pattern.Value : null, ignoreCase.HasValue ? ignoreCase.Value : (bool?)null, negate.HasValue ? negate.Value : (bool?)null);
        }
    }
}
