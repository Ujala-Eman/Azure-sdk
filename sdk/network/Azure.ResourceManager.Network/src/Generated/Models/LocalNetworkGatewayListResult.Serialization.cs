// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LocalNetworkGatewayListResult
    {
        internal static LocalNetworkGatewayListResult DeserializeLocalNetworkGatewayListResult(JsonElement element)
        {
            Optional<IReadOnlyList<LocalNetworkGateway>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<LocalNetworkGateway> array = new List<LocalNetworkGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LocalNetworkGateway.DeserializeLocalNetworkGateway(item));
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
            return new LocalNetworkGatewayListResult(new ChangeTrackingList<LocalNetworkGateway>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
