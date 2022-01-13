// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocation.Models
{
    internal partial class CustomLocationOperationsList
    {
        internal static CustomLocationOperationsList DeserializeCustomLocationOperationsList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<CustomLocationOperation> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<CustomLocationOperation> array = new List<CustomLocationOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomLocationOperation.DeserializeCustomLocationOperation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CustomLocationOperationsList(nextLink.Value, value);
        }
    }
}
