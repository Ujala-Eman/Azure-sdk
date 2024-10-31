// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppContainers
{
    public partial class BuilderResource : IJsonModel<BuilderResourceData>
    {
        void IJsonModel<BuilderResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BuilderResourceData>)Data).Write(writer, options);

        BuilderResourceData IJsonModel<BuilderResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BuilderResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BuilderResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        BuilderResourceData IPersistableModel<BuilderResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BuilderResourceData>(data, options);

        string IPersistableModel<BuilderResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BuilderResourceData>)Data).GetFormatFromOptions(options);
    }
}
