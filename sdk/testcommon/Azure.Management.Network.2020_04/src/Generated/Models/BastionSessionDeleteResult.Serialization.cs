// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BastionSessionDeleteResult
    {
        internal static BastionSessionDeleteResult DeserializeBastionSessionDeleteResult(JsonElement element)
        {
            Optional<IReadOnlyList<BastionSessionState>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<BastionSessionState> array = new List<BastionSessionState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BastionSessionState.DeserializeBastionSessionState(item));
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
            return new BastionSessionDeleteResult(new ChangeTrackingList<BastionSessionState>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
