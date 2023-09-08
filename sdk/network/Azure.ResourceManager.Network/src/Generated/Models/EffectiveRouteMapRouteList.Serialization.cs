// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveRouteMapRouteList
    {
        internal static EffectiveRouteMapRouteList DeserializeEffectiveRouteMapRouteList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EffectiveRouteMapRoute>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveRouteMapRoute> array = new List<EffectiveRouteMapRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveRouteMapRoute.DeserializeEffectiveRouteMapRoute(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new EffectiveRouteMapRouteList(Optional.ToList(value));
        }
    }
}
