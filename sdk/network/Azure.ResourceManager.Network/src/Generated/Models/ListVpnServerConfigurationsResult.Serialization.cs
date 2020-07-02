// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ListVpnServerConfigurationsResult
    {
        internal static ListVpnServerConfigurationsResult DeserializeListVpnServerConfigurationsResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnServerConfiguration>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VpnServerConfiguration> array = new List<VpnServerConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(VpnServerConfiguration.DeserializeVpnServerConfiguration(item));
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
            return new ListVpnServerConfigurationsResult(new ChangeTrackingList<VpnServerConfiguration>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
