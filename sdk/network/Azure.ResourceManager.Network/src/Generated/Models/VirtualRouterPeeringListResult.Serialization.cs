// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualRouterPeeringListResult
    {
        internal static VirtualRouterPeeringListResult DeserializeVirtualRouterPeeringListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualRouterPeering>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VirtualRouterPeering> array = new List<VirtualRouterPeering>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualRouterPeering.DeserializeVirtualRouterPeering(item));
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
            return new VirtualRouterPeeringListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
