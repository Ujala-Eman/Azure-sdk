// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class EffectiveNetworkSecurityRule
    {
        internal static EffectiveNetworkSecurityRule DeserializeEffectiveNetworkSecurityRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<EffectiveSecurityRuleProtocol> protocol = default;
            Optional<string> sourcePortRange = default;
            Optional<string> destinationPortRange = default;
            Optional<IReadOnlyList<string>> sourcePortRanges = default;
            Optional<IReadOnlyList<string>> destinationPortRanges = default;
            Optional<string> sourceAddressPrefix = default;
            Optional<string> destinationAddressPrefix = default;
            Optional<IReadOnlyList<string>> sourceAddressPrefixes = default;
            Optional<IReadOnlyList<string>> destinationAddressPrefixes = default;
            Optional<IReadOnlyList<string>> expandedSourceAddressPrefix = default;
            Optional<IReadOnlyList<string>> expandedDestinationAddressPrefix = default;
            Optional<SecurityRuleAccess> access = default;
            Optional<int> priority = default;
            Optional<SecurityRuleDirection> direction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = new EffectiveSecurityRuleProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePortRange"))
                {
                    sourcePortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPortRange"))
                {
                    destinationPortRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePortRanges"))
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
                    sourcePortRanges = array;
                    continue;
                }
                if (property.NameEquals("destinationPortRanges"))
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
                    destinationPortRanges = array;
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefix"))
                {
                    destinationAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefixes"))
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
                    sourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("destinationAddressPrefixes"))
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
                    destinationAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("expandedSourceAddressPrefix"))
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
                    expandedSourceAddressPrefix = array;
                    continue;
                }
                if (property.NameEquals("expandedDestinationAddressPrefix"))
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
                    expandedDestinationAddressPrefix = array;
                    continue;
                }
                if (property.NameEquals("access"))
                {
                    access = new SecurityRuleAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("direction"))
                {
                    direction = new SecurityRuleDirection(property.Value.GetString());
                    continue;
                }
            }
            return new EffectiveNetworkSecurityRule(name.HasValue ? name.Value : null, protocol.HasValue ? protocol.Value : (EffectiveSecurityRuleProtocol?)null, sourcePortRange.HasValue ? sourcePortRange.Value : null, destinationPortRange.HasValue ? destinationPortRange.Value : null, new ChangeTrackingList<string>(sourcePortRanges), new ChangeTrackingList<string>(destinationPortRanges), sourceAddressPrefix.HasValue ? sourceAddressPrefix.Value : null, destinationAddressPrefix.HasValue ? destinationAddressPrefix.Value : null, new ChangeTrackingList<string>(sourceAddressPrefixes), new ChangeTrackingList<string>(destinationAddressPrefixes), new ChangeTrackingList<string>(expandedSourceAddressPrefix), new ChangeTrackingList<string>(expandedDestinationAddressPrefix), access.HasValue ? access.Value : (SecurityRuleAccess?)null, priority.HasValue ? priority.Value : (int?)null, direction.HasValue ? direction.Value : (SecurityRuleDirection?)null);
        }
    }
}
