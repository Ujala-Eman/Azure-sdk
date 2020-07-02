// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ListHubRouteTablesResult
    {
        internal static ListHubRouteTablesResult DeserializeListHubRouteTablesResult(JsonElement element)
        {
            Optional<IReadOnlyList<HubRouteTable>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<HubRouteTable> array = new List<HubRouteTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(HubRouteTable.DeserializeHubRouteTable(item));
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
            return new ListHubRouteTablesResult(new ChangeTrackingList<HubRouteTable>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
