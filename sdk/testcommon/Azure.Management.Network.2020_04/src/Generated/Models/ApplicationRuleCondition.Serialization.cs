// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses");
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DestinationAddresses))
            {
                writer.WritePropertyName("destinationAddresses");
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Protocols))
            {
                writer.WritePropertyName("protocols");
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetUrls))
            {
                writer.WritePropertyName("targetUrls");
                writer.WriteStartArray();
                foreach (var item in TargetUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetFqdns))
            {
                writer.WritePropertyName("targetFqdns");
                writer.WriteStartArray();
                foreach (var item in TargetFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FqdnTags))
            {
                writer.WritePropertyName("fqdnTags");
                writer.WriteStartArray();
                foreach (var item in FqdnTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceIpGroups))
            {
                writer.WritePropertyName("sourceIpGroups");
                writer.WriteStartArray();
                foreach (var item in SourceIpGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        internal static ApplicationRuleCondition DeserializeApplicationRuleCondition(JsonElement element)
        {
            Optional<IList<string>> sourceAddresses = default;
            Optional<IList<string>> destinationAddresses = default;
            Optional<IList<FirewallPolicyRuleConditionApplicationProtocol>> protocols = default;
            Optional<IList<string>> targetUrls = default;
            Optional<IList<string>> targetFqdns = default;
            Optional<IList<string>> fqdnTags = default;
            Optional<IList<string>> sourceIpGroups = default;
            Optional<string> name = default;
            Optional<string> description = default;
            FirewallPolicyRuleConditionType ruleConditionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceAddresses"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("protocols"))
                {
                    List<FirewallPolicyRuleConditionApplicationProtocol> array = new List<FirewallPolicyRuleConditionApplicationProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(FirewallPolicyRuleConditionApplicationProtocol.DeserializeFirewallPolicyRuleConditionApplicationProtocol(item));
                        }
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("targetUrls"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    targetUrls = array;
                    continue;
                }
                if (property.NameEquals("targetFqdns"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    targetFqdns = array;
                    continue;
                }
                if (property.NameEquals("fqdnTags"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    fqdnTags = array;
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    sourceIpGroups = array;
                    continue;
                }
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
            return new ApplicationRuleCondition(name.HasValue ? name.Value : null, description.HasValue ? description.Value : null, ruleConditionType, new ChangeTrackingList<string>(sourceAddresses), new ChangeTrackingList<string>(destinationAddresses), new ChangeTrackingList<FirewallPolicyRuleConditionApplicationProtocol>(protocols), new ChangeTrackingList<string>(targetUrls), new ChangeTrackingList<string>(targetFqdns), new ChangeTrackingList<string>(fqdnTags), new ChangeTrackingList<string>(sourceIpGroups));
        }
    }
}
