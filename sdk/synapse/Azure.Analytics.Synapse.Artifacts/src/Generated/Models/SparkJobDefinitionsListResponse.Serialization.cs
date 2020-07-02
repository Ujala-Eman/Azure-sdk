// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SparkJobDefinitionsListResponse
    {
        internal static SparkJobDefinitionsListResponse DeserializeSparkJobDefinitionsListResponse(JsonElement element)
        {
            IReadOnlyList<SparkJobDefinitionResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SparkJobDefinitionResource> array = new List<SparkJobDefinitionResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SparkJobDefinitionResource.DeserializeSparkJobDefinitionResource(item));
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
            return new SparkJobDefinitionsListResponse(value, nextLink.HasValue ? nextLink.Value : null);
        }
    }
}
