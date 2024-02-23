// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceResource : IJsonModel<ManagedInstanceData>
    {
        void IJsonModel<ManagedInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ManagedInstanceData IJsonModel<ManagedInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedInstanceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ManagedInstanceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ManagedInstanceData IPersistableModel<ManagedInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedInstanceData>(data, options);
        }

        string IPersistableModel<ManagedInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
