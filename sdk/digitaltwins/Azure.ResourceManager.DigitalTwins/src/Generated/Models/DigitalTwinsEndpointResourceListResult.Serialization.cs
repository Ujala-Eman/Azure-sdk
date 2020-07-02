// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsEndpointResourceListResult
    {
        internal static DigitalTwinsEndpointResourceListResult DeserializeDigitalTwinsEndpointResourceListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<DigitalTwinsEndpointResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<DigitalTwinsEndpointResource> array = new List<DigitalTwinsEndpointResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DigitalTwinsEndpointResource.DeserializeDigitalTwinsEndpointResource(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new DigitalTwinsEndpointResourceListResult(nextLink.HasValue ? nextLink.Value : null, new ChangeTrackingList<DigitalTwinsEndpointResource>(value));
        }
    }
}
