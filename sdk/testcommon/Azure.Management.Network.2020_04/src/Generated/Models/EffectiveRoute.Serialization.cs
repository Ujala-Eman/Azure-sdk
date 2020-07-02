// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class EffectiveRoute
    {
        internal static EffectiveRoute DeserializeEffectiveRoute(JsonElement element)
        {
            Optional<string> name = default;
            Optional<bool> disableBgpRoutePropagation = default;
            Optional<EffectiveRouteSource> source = default;
            Optional<EffectiveRouteState> state = default;
            Optional<IReadOnlyList<string>> addressPrefix = default;
            Optional<IReadOnlyList<string>> nextHopIpAddress = default;
            Optional<RouteNextHopType> nextHopType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableBgpRoutePropagation"))
                {
                    disableBgpRoutePropagation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = new EffectiveRouteSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = new EffectiveRouteState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefix"))
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
                    addressPrefix = array;
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"))
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
                    nextHopIpAddress = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"))
                {
                    nextHopType = new RouteNextHopType(property.Value.GetString());
                    continue;
                }
            }
            return new EffectiveRoute(name.HasValue ? name.Value : null, disableBgpRoutePropagation.HasValue ? disableBgpRoutePropagation.Value : (bool?)null, source.HasValue ? source.Value : (EffectiveRouteSource?)null, state.HasValue ? state.Value : (EffectiveRouteState?)null, new ChangeTrackingList<string>(addressPrefix), new ChangeTrackingList<string>(nextHopIpAddress), nextHopType.HasValue ? nextHopType.Value : (RouteNextHopType?)null);
        }
    }
}
