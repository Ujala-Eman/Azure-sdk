// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AzureFirewallNetworkRuleCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteObjectValue(Action);
            }
            if (Optional.IsDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureFirewallNetworkRuleCollection DeserializeAzureFirewallNetworkRuleCollection(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<int> priority = default;
            Optional<AzureFirewallRCAction> action = default;
            Optional<IList<AzureFirewallNetworkRule>> rules = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("priority"))
                        {
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("action"))
                        {
                            action = AzureFirewallRCAction.DeserializeAzureFirewallRCAction(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rules"))
                        {
                            List<AzureFirewallNetworkRule> array = new List<AzureFirewallNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(AzureFirewallNetworkRule.DeserializeAzureFirewallNetworkRule(item));
                                }
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureFirewallNetworkRuleCollection(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, etag.HasValue ? etag.Value : null, priority.HasValue ? priority.Value : (int?)null, action.HasValue ? action.Value : null, new ChangeTrackingList<AzureFirewallNetworkRule>(rules), provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null);
        }
    }
}
