// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedApplicationResource : IJsonModel<ServiceFabricManagedApplicationData>
    {
        void IJsonModel<ServiceFabricManagedApplicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ServiceFabricManagedApplicationData IJsonModel<ServiceFabricManagedApplicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceFabricManagedApplicationData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ServiceFabricManagedApplicationData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ServiceFabricManagedApplicationData IPersistableModel<ServiceFabricManagedApplicationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceFabricManagedApplicationData>(data, options);
        }

        string IPersistableModel<ServiceFabricManagedApplicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
