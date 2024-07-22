// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class CustomDnsSuffixConfigurationResource : IJsonModel<CustomDnsSuffixConfigurationData>
    {
        void IJsonModel<CustomDnsSuffixConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CustomDnsSuffixConfigurationData>)Data).Write(writer, options);

        CustomDnsSuffixConfigurationData IJsonModel<CustomDnsSuffixConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CustomDnsSuffixConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CustomDnsSuffixConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CustomDnsSuffixConfigurationData IPersistableModel<CustomDnsSuffixConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CustomDnsSuffixConfigurationData>(data, options);

        string IPersistableModel<CustomDnsSuffixConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CustomDnsSuffixConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
