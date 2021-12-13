// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Generated.Models
{
    internal partial class ResourceListResult
    {
        internal static ResourceListResult DeserializeResourceListResult(JsonElement element)
        {
            IReadOnlyList<Resource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<Resource> array = new List<Resource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Resource.DeserializeResource(item));
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
            return new ResourceListResult(value, nextLink.Value);
        }
    }
}
