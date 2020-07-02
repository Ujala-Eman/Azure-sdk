// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class FirewallPolicyNatRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteObjectValue(Action);
            }
            if (Optional.IsDefined(TranslatedAddress))
            {
                writer.WritePropertyName("translatedAddress");
                writer.WriteStringValue(TranslatedAddress);
            }
            if (Optional.IsDefined(TranslatedPort))
            {
                writer.WritePropertyName("translatedPort");
                writer.WriteStringValue(TranslatedPort);
            }
            if (Optional.IsDefined(RuleCondition))
            {
                writer.WritePropertyName("ruleCondition");
                writer.WriteObjectValue(RuleCondition);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyNatRule DeserializeFirewallPolicyNatRule(JsonElement element)
        {
            Optional<FirewallPolicyNatRuleAction> action = default;
            Optional<string> translatedAddress = default;
            Optional<string> translatedPort = default;
            Optional<FirewallPolicyRuleCondition> ruleCondition = default;
            FirewallPolicyRuleType ruleType = default;
            Optional<string> name = default;
            Optional<int> priority = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"))
                {
                    action = FirewallPolicyNatRuleAction.DeserializeFirewallPolicyNatRuleAction(property.Value);
                    continue;
                }
                if (property.NameEquals("translatedAddress"))
                {
                    translatedAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translatedPort"))
                {
                    translatedPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCondition"))
                {
                    ruleCondition = FirewallPolicyRuleCondition.DeserializeFirewallPolicyRuleCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
            }
            return new FirewallPolicyNatRule(ruleType, name.HasValue ? name.Value : null, priority.HasValue ? priority.Value : (int?)null, action.HasValue ? action.Value : null, translatedAddress.HasValue ? translatedAddress.Value : null, translatedPort.HasValue ? translatedPort.Value : null, ruleCondition.HasValue ? ruleCondition.Value : null);
        }
    }
}
