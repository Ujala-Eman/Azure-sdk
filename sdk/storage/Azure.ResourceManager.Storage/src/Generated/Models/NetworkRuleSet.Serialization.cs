// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class NetworkRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Bypass))
            {
                writer.WritePropertyName("bypass");
                writer.WriteStringValue(Bypass.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IpRules))
            {
                writer.WritePropertyName("ipRules");
                writer.WriteStartArray();
                foreach (var item in IpRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("defaultAction");
            writer.WriteStringValue(DefaultAction.ToSerialString());
            writer.WriteEndObject();
        }

        internal static NetworkRuleSet DeserializeNetworkRuleSet(JsonElement element)
        {
            Optional<Bypass> bypass = default;
            Optional<IList<VirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IList<IPRule>> ipRules = default;
            DefaultAction defaultAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bypass"))
                {
                    bypass = new Bypass(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualNetworkRules"))
                {
                    List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                    }
                    virtualNetworkRules = array;
                    continue;
                }
                if (property.NameEquals("ipRules"))
                {
                    List<IPRule> array = new List<IPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPRule.DeserializeIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("defaultAction"))
                {
                    defaultAction = property.Value.GetString().ToDefaultAction();
                    continue;
                }
            }
            return new NetworkRuleSet(Optional.ToNullable(bypass), Optional.ToList(virtualNetworkRules), Optional.ToList(ipRules), defaultAction);
        }
    }
}
