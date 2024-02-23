// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationFabricResource : IJsonModel<DataReplicationFabricData>
    {
        void IJsonModel<DataReplicationFabricData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataReplicationFabricData IJsonModel<DataReplicationFabricData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationFabricData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataReplicationFabricData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataReplicationFabricData IPersistableModel<DataReplicationFabricData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationFabricData>(data, options);
        }

        string IPersistableModel<DataReplicationFabricData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
