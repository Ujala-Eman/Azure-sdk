// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class AvailableClustersList
    {
        internal static AvailableClustersList DeserializeAvailableClustersList(JsonElement element)
        {
            Optional<IReadOnlyList<AvailableCluster>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AvailableCluster> array = new List<AvailableCluster>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AvailableCluster.DeserializeAvailableCluster(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new AvailableClustersList(new ChangeTrackingList<AvailableCluster>(value));
        }
    }
}
