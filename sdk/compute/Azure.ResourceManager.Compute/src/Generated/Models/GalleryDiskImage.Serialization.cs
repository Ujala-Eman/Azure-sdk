// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryDiskImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SizeInGB))
            {
                writer.WritePropertyName("sizeInGB");
                writer.WriteNumberValue(SizeInGB.Value);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching");
                writer.WriteStringValue(HostCaching.Value.ToSerialString());
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteObjectValue(Source);
            }
            writer.WriteEndObject();
        }

        internal static GalleryDiskImage DeserializeGalleryDiskImage(JsonElement element)
        {
            Optional<int> sizeInGB = default;
            Optional<HostCaching> hostCaching = default;
            Optional<GalleryArtifactVersionSource> source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sizeInGB"))
                {
                    sizeInGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostCaching"))
                {
                    hostCaching = property.Value.GetString().ToHostCaching();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = GalleryArtifactVersionSource.DeserializeGalleryArtifactVersionSource(property.Value);
                    continue;
                }
            }
            return new GalleryDiskImage(sizeInGB.HasValue ? sizeInGB.Value : (int?)null, hostCaching.HasValue ? hostCaching.Value : (HostCaching?)null, source.HasValue ? source.Value : null);
        }
    }
}
