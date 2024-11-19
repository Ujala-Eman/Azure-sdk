// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Gallery
{
    public partial class CommunityGalleryImageResource : IJsonModel<CommunityGalleryImageData>
    {
        void IJsonModel<CommunityGalleryImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CommunityGalleryImageData>)Data).Write(writer, options);

        CommunityGalleryImageData IJsonModel<CommunityGalleryImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CommunityGalleryImageData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CommunityGalleryImageData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CommunityGalleryImageData IPersistableModel<CommunityGalleryImageData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CommunityGalleryImageData>(data, options);

        string IPersistableModel<CommunityGalleryImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CommunityGalleryImageData>)Data).GetFormatFromOptions(options);
    }
}
