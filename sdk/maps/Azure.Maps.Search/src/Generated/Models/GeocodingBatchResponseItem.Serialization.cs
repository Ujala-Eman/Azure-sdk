// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class GeocodingBatchResponseItem
    {
        internal static GeocodingBatchResponseItem DeserializeGeocodingBatchResponseItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string optionalId = default;
            FeatureCollectionEnum? type = default;
            IReadOnlyList<FeaturesItem> features = default;
            string nextLink = default;
            ErrorDetail error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optionalId"u8))
                {
                    optionalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new FeatureCollectionEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FeaturesItem> array = new List<FeaturesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FeaturesItem.DeserializeFeaturesItem(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ErrorDetail.DeserializeErrorDetail(property.Value);
                    continue;
                }
            }
            return new GeocodingBatchResponseItem(optionalId, type, features ?? new ChangeTrackingList<FeaturesItem>(), nextLink, error);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeocodingBatchResponseItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeocodingBatchResponseItem(document.RootElement);
        }
    }
}
