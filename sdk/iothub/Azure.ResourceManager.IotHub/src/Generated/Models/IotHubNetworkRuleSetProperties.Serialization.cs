// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubNetworkRuleSetProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction");
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            writer.WritePropertyName("applyToBuiltInEventHubEndpoint");
            writer.WriteBooleanValue(ApplyToBuiltInEventHubEndpoint);
            writer.WritePropertyName("ipRules");
            writer.WriteStartArray();
            foreach (var item in IPRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static IotHubNetworkRuleSetProperties DeserializeIotHubNetworkRuleSetProperties(JsonElement element)
        {
            Optional<IotHubNetworkRuleSetDefaultAction> defaultAction = default;
            bool applyToBuiltInEventHubEndpoint = default;
            IList<IotHubNetworkRuleSetIPRule> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultAction = new IotHubNetworkRuleSetDefaultAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applyToBuiltInEventHubEndpoint"))
                {
                    applyToBuiltInEventHubEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipRules"))
                {
                    List<IotHubNetworkRuleSetIPRule> array = new List<IotHubNetworkRuleSetIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubNetworkRuleSetIPRule.DeserializeIotHubNetworkRuleSetIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new IotHubNetworkRuleSetProperties(Optional.ToNullable(defaultAction), applyToBuiltInEventHubEndpoint, ipRules);
        }
    }
}
