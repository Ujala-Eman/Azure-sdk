// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AutoApprovedPrivateLinkServicesResult
    {
        internal static AutoApprovedPrivateLinkServicesResult DeserializeAutoApprovedPrivateLinkServicesResult(JsonElement element)
        {
            Optional<IReadOnlyList<AutoApprovedPrivateLinkService>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AutoApprovedPrivateLinkService> array = new List<AutoApprovedPrivateLinkService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AutoApprovedPrivateLinkService.DeserializeAutoApprovedPrivateLinkService(item));
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
            return new AutoApprovedPrivateLinkServicesResult(new ChangeTrackingList<AutoApprovedPrivateLinkService>(value), nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
