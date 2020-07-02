// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersListCountry
    {
        internal static AvailableProvidersListCountry DeserializeAvailableProvidersListCountry(JsonElement element)
        {
            Optional<string> countryName = default;
            Optional<IReadOnlyList<string>> providers = default;
            Optional<IReadOnlyList<AvailableProvidersListState>> states = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countryName"))
                {
                    countryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"))
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
                    providers = array;
                    continue;
                }
                if (property.NameEquals("states"))
                {
                    List<AvailableProvidersListState> array = new List<AvailableProvidersListState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AvailableProvidersListState.DeserializeAvailableProvidersListState(item));
                        }
                    }
                    states = array;
                    continue;
                }
            }
            return new AvailableProvidersListCountry(countryName.HasValue ? countryName.Value : null, new ChangeTrackingList<string>(providers), new ChangeTrackingList<AvailableProvidersListState>(states));
        }
    }
}
