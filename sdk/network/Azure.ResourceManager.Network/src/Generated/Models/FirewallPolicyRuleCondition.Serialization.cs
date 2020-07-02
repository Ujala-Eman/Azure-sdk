// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleConditionType");
            writer.WriteStringValue(RuleConditionType.ToString());
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRuleCondition DeserializeFirewallPolicyRuleCondition(JsonElement element)
        {
            if (element.TryGetProperty("ruleConditionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ApplicationRuleCondition": return ApplicationRuleCondition.DeserializeApplicationRuleCondition(element);
                    case "NatRuleCondition": return NatRuleCondition.DeserializeNatRuleCondition(element);
                    case "NetworkRuleCondition": return NetworkRuleCondition.DeserializeNetworkRuleCondition(element);
                }
            }
            Optional<string> name = default;
            Optional<string> description = default;
            FirewallPolicyRuleConditionType ruleConditionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleConditionType"))
                {
                    ruleConditionType = new FirewallPolicyRuleConditionType(property.Value.GetString());
                    continue;
                }
            }
            return new FirewallPolicyRuleCondition(name.HasValue ? name.Value : null, description.HasValue ? description.Value : null, ruleConditionType);
        }
    }
}
