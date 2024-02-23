// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityCloudConnectorResource : IJsonModel<SecurityCloudConnectorData>
    {
        void IJsonModel<SecurityCloudConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SecurityCloudConnectorData IJsonModel<SecurityCloudConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityCloudConnectorData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SecurityCloudConnectorData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SecurityCloudConnectorData IPersistableModel<SecurityCloudConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityCloudConnectorData>(data, options);
        }

        string IPersistableModel<SecurityCloudConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
