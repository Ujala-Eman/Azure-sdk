// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    internal partial class PredefinedUrlCategoryListResult
    {
        internal static PredefinedUrlCategoryListResult DeserializePredefinedUrlCategoryListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PredefinedUrlCategory> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<PredefinedUrlCategory> array = new List<PredefinedUrlCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredefinedUrlCategory.DeserializePredefinedUrlCategory(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PredefinedUrlCategoryListResult(value, nextLink.Value);
        }
    }
}
