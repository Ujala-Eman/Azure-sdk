// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PrivateEndpointConnectionListResult
    {
        internal static PrivateEndpointConnectionListResult DeserializePrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateEndpointConnection>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
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
            return new PrivateEndpointConnectionListResult(new ChangeTrackingList<PrivateEndpointConnection>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
