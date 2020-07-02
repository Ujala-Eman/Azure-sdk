// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TopologyResource
    {
        internal static TopologyResource DeserializeTopologyResource(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> location = default;
            Optional<IReadOnlyList<TopologyAssociation>> associations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("associations"))
                {
                    List<TopologyAssociation> array = new List<TopologyAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TopologyAssociation.DeserializeTopologyAssociation(item));
                        }
                    }
                    associations = array;
                    continue;
                }
            }
            return new TopologyResource(name.HasValue ? name.Value : null, id.HasValue ? id.Value : null, location.HasValue ? location.Value : null, new ChangeTrackingList<TopologyAssociation>(associations));
        }
    }
}
