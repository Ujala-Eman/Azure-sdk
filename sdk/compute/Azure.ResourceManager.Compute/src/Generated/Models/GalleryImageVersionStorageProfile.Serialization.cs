// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionStorageProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteObjectValue(Source);
            }
            if (Optional.IsDefined(OsDiskImage))
            {
                writer.WritePropertyName("osDiskImage");
                writer.WriteObjectValue(OsDiskImage);
            }
            if (Optional.IsDefined(DataDiskImages))
            {
                writer.WritePropertyName("dataDiskImages");
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GalleryImageVersionStorageProfile DeserializeGalleryImageVersionStorageProfile(JsonElement element)
        {
            Optional<GalleryArtifactVersionSource> source = default;
            Optional<GalleryDiskImage> osDiskImage = default;
            Optional<IList<GalleryDataDiskImage>> dataDiskImages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    source = GalleryArtifactVersionSource.DeserializeGalleryArtifactVersionSource(property.Value);
                    continue;
                }
                if (property.NameEquals("osDiskImage"))
                {
                    osDiskImage = GalleryDiskImage.DeserializeGalleryDiskImage(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDiskImages"))
                {
                    List<GalleryDataDiskImage> array = new List<GalleryDataDiskImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(GalleryDataDiskImage.DeserializeGalleryDataDiskImage(item));
                        }
                    }
                    dataDiskImages = array;
                    continue;
                }
            }
            return new GalleryImageVersionStorageProfile(source.HasValue ? source.Value : null, osDiskImage.HasValue ? osDiskImage.Value : null, new ChangeTrackingList<GalleryDataDiskImage>(dataDiskImages));
        }
    }
}
