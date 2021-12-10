// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Account.Models
{
    public partial class CollectionPathResponse
    {
        internal static CollectionPathResponse DeserializeCollectionPathResponse(JsonElement element)
        {
            Optional<IReadOnlyList<string>> parentFriendlyNameChain = default;
            Optional<IReadOnlyList<string>> parentNameChain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentFriendlyNameChain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    parentFriendlyNameChain = array;
                    continue;
                }
                if (property.NameEquals("parentNameChain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    parentNameChain = array;
                    continue;
                }
            }
            return new CollectionPathResponse(Optional.ToList(parentFriendlyNameChain), Optional.ToList(parentNameChain));
        }
    }
}
