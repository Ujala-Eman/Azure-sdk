// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusDisasterRecoveryAuthorizationRuleResource : IJsonModel<ServiceBusAuthorizationRuleData>
    {
        void IJsonModel<ServiceBusAuthorizationRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ServiceBusAuthorizationRuleData IJsonModel<ServiceBusAuthorizationRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceBusAuthorizationRuleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ServiceBusAuthorizationRuleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ServiceBusAuthorizationRuleData IPersistableModel<ServiceBusAuthorizationRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceBusAuthorizationRuleData>(data, options);
        }

        string IPersistableModel<ServiceBusAuthorizationRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
