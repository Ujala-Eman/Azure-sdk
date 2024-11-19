// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Gallery
{
    public partial class CommunityGalleryImageVersionResource : IJsonModel<CommunityGalleryImageVersionData>
    {
        void IJsonModel<CommunityGalleryImageVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CommunityGalleryImageVersionData>)Data).Write(writer, options);

        CommunityGalleryImageVersionData IJsonModel<CommunityGalleryImageVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CommunityGalleryImageVersionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CommunityGalleryImageVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CommunityGalleryImageVersionData IPersistableModel<CommunityGalleryImageVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CommunityGalleryImageVersionData>(data, options);

        string IPersistableModel<CommunityGalleryImageVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CommunityGalleryImageVersionData>)Data).GetFormatFromOptions(options);
    }
}
