// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class RegulatoryComplianceStandardResource : IJsonModel<RegulatoryComplianceStandardData>
    {
        void IJsonModel<RegulatoryComplianceStandardData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RegulatoryComplianceStandardData IJsonModel<RegulatoryComplianceStandardData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RegulatoryComplianceStandardData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RegulatoryComplianceStandardData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RegulatoryComplianceStandardData IPersistableModel<RegulatoryComplianceStandardData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RegulatoryComplianceStandardData>(data, options);
        }

        string IPersistableModel<RegulatoryComplianceStandardData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
