// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Gallery
{
    public partial class GalleryImageResource : IJsonModel<GalleryImageData>
    {
        void IJsonModel<GalleryImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GalleryImageData>)Data).Write(writer, options);

        GalleryImageData IJsonModel<GalleryImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GalleryImageData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GalleryImageData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GalleryImageData IPersistableModel<GalleryImageData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GalleryImageData>(data, options);

        string IPersistableModel<GalleryImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GalleryImageData>)Data).GetFormatFromOptions(options);
    }
}
