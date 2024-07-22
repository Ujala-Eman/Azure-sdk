// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteBasicAuthPropertyResource : IJsonModel<StaticSiteBasicAuthPropertyData>
    {
        void IJsonModel<StaticSiteBasicAuthPropertyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteBasicAuthPropertyData>)Data).Write(writer, options);

        StaticSiteBasicAuthPropertyData IJsonModel<StaticSiteBasicAuthPropertyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StaticSiteBasicAuthPropertyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StaticSiteBasicAuthPropertyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StaticSiteBasicAuthPropertyData IPersistableModel<StaticSiteBasicAuthPropertyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StaticSiteBasicAuthPropertyData>(data, options);

        string IPersistableModel<StaticSiteBasicAuthPropertyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StaticSiteBasicAuthPropertyData>)Data).GetFormatFromOptions(options);
    }
}
