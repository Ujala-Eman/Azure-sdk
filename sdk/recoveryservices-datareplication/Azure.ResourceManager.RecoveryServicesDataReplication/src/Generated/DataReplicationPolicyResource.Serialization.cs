// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationPolicyResource : IJsonModel<DataReplicationPolicyData>
    {
        void IJsonModel<DataReplicationPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataReplicationPolicyData IJsonModel<DataReplicationPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataReplicationPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataReplicationPolicyData IPersistableModel<DataReplicationPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataReplicationPolicyData>(data, options);
        }

        string IPersistableModel<DataReplicationPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
