// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HopLink
    {
        internal static HopLink DeserializeHopLink(JsonElement element)
        {
            Optional<string> nextHopId = default;
            Optional<string> linkType = default;
            Optional<IReadOnlyList<ConnectivityIssue>> issues = default;
            Optional<IReadOnlyDictionary<string, string>> context = default;
            Optional<string> resourceId = default;
            Optional<long> roundTripTimeMin = default;
            Optional<long> roundTripTimeAvg = default;
            Optional<long> roundTripTimeMax = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextHopId"))
                {
                    nextHopId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkType"))
                {
                    linkType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectivityIssue> array = new List<ConnectivityIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityIssue.DeserializeConnectivityIssue(item));
                    }
                    issues = array;
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    context = dictionary;
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("roundTripTimeMin"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roundTripTimeMin = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("roundTripTimeAvg"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roundTripTimeAvg = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("roundTripTimeMax"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            roundTripTimeMax = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HopLink(nextHopId.Value, linkType.Value, Optional.ToList(issues), Optional.ToDictionary(context), resourceId.Value, Optional.ToNullable(roundTripTimeMin), Optional.ToNullable(roundTripTimeAvg), Optional.ToNullable(roundTripTimeMax));
        }
    }
}
