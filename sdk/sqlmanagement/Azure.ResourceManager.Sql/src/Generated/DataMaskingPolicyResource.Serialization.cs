// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class DataMaskingPolicyResource : IJsonModel<DataMaskingPolicyData>
    {
        void IJsonModel<DataMaskingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataMaskingPolicyData IJsonModel<DataMaskingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataMaskingPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataMaskingPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataMaskingPolicyData IPersistableModel<DataMaskingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataMaskingPolicyData>(data, options);
        }

        string IPersistableModel<DataMaskingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
