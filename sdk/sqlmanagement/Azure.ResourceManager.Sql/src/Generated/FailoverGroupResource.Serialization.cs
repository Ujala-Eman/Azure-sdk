// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class FailoverGroupResource : IJsonModel<FailoverGroupData>
    {
        void IJsonModel<FailoverGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        FailoverGroupData IJsonModel<FailoverGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FailoverGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<FailoverGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        FailoverGroupData IPersistableModel<FailoverGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FailoverGroupData>(data, options);
        }

        string IPersistableModel<FailoverGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
