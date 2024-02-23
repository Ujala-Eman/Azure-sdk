// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusDisasterRecoveryResource : IJsonModel<ServiceBusDisasterRecoveryData>
    {
        void IJsonModel<ServiceBusDisasterRecoveryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ServiceBusDisasterRecoveryData IJsonModel<ServiceBusDisasterRecoveryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceBusDisasterRecoveryData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ServiceBusDisasterRecoveryData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ServiceBusDisasterRecoveryData IPersistableModel<ServiceBusDisasterRecoveryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceBusDisasterRecoveryData>(data, options);
        }

        string IPersistableModel<ServiceBusDisasterRecoveryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
