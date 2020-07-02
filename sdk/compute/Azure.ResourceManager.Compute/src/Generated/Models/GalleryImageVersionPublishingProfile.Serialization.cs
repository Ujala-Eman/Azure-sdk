// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionPublishingProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetRegions))
            {
                writer.WritePropertyName("targetRegions");
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount");
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(ExcludeFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest");
                writer.WriteBooleanValue(ExcludeFromLatest.Value);
            }
            if (Optional.IsDefined(PublishedDate))
            {
                writer.WritePropertyName("publishedDate");
                writer.WriteStringValue(PublishedDate.Value, "O");
            }
            if (Optional.IsDefined(EndOfLifeDate))
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static GalleryImageVersionPublishingProfile DeserializeGalleryImageVersionPublishingProfile(JsonElement element)
        {
            Optional<IList<TargetRegion>> targetRegions = default;
            Optional<int> replicaCount = default;
            Optional<bool> excludeFromLatest = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<StorageAccountType> storageAccountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"))
                {
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TargetRegion.DeserializeTargetRegion(item));
                        }
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"))
                {
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"))
                {
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"))
                {
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"))
                {
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    storageAccountType = new StorageAccountType(property.Value.GetString());
                    continue;
                }
            }
            return new GalleryImageVersionPublishingProfile(new ChangeTrackingList<TargetRegion>(targetRegions), replicaCount.HasValue ? replicaCount.Value : (int?)null, excludeFromLatest.HasValue ? excludeFromLatest.Value : (bool?)null, publishedDate.HasValue ? publishedDate.Value : (DateTimeOffset?)null, endOfLifeDate.HasValue ? endOfLifeDate.Value : (DateTimeOffset?)null, storageAccountType.HasValue ? storageAccountType.Value : (StorageAccountType?)null);
        }
    }
}
