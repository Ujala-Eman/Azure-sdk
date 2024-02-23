// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsDataConnectorResource : IJsonModel<SecurityInsightsDataConnectorData>
    {
        void IJsonModel<SecurityInsightsDataConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SecurityInsightsDataConnectorData IJsonModel<SecurityInsightsDataConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityInsightsDataConnectorData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SecurityInsightsDataConnectorData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SecurityInsightsDataConnectorData IPersistableModel<SecurityInsightsDataConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityInsightsDataConnectorData>(data, options);
        }

        string IPersistableModel<SecurityInsightsDataConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
