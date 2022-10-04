// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class MediaAssetFilterListResult
    {
        internal static MediaAssetFilterListResult DeserializeMediaAssetFilterListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MediaAssetFilterData>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaAssetFilterData> array = new List<MediaAssetFilterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaAssetFilterData.DeserializeMediaAssetFilterData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MediaAssetFilterListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
