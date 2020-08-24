// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ListVpnSitesResult
    {
        internal static ListVpnSitesResult DeserializeListVpnSitesResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnSite>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<VpnSite> array = new List<VpnSite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnSite.DeserializeVpnSite(item));
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
            return new ListVpnSitesResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
