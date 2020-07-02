// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class LoadBalancerOutboundRuleListResult
    {
        internal static LoadBalancerOutboundRuleListResult DeserializeLoadBalancerOutboundRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<OutboundRule>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OutboundRule> array = new List<OutboundRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(OutboundRule.DeserializeOutboundRule(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LoadBalancerOutboundRuleListResult(new ChangeTrackingList<OutboundRule>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
