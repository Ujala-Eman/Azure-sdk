// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ManagedRuleGroupOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleGroupName");
            writer.WriteStringValue(RuleGroupName);
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleGroupOverride DeserializeManagedRuleGroupOverride(JsonElement element)
        {
            string ruleGroupName = default;
            Optional<IList<ManagedRuleOverride>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"))
                {
                    ruleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    List<ManagedRuleOverride> array = new List<ManagedRuleOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleOverride.DeserializeManagedRuleOverride(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new ManagedRuleGroupOverride(ruleGroupName, Optional.ToList(rules));
        }
    }
}
