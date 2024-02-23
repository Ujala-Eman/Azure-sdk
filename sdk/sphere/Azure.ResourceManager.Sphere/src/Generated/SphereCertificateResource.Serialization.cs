// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sphere
{
    public partial class SphereCertificateResource : IJsonModel<SphereCertificateData>
    {
        void IJsonModel<SphereCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SphereCertificateData IJsonModel<SphereCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SphereCertificateData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SphereCertificateData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SphereCertificateData IPersistableModel<SphereCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SphereCertificateData>(data, options);
        }

        string IPersistableModel<SphereCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
