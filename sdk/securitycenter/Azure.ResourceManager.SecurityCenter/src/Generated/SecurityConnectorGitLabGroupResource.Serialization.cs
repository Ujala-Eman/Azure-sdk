// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityConnectorGitLabGroupResource : IJsonModel<SecurityConnectorGitLabGroupData>
    {
        void IJsonModel<SecurityConnectorGitLabGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SecurityConnectorGitLabGroupData IJsonModel<SecurityConnectorGitLabGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityConnectorGitLabGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SecurityConnectorGitLabGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SecurityConnectorGitLabGroupData IPersistableModel<SecurityConnectorGitLabGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SecurityConnectorGitLabGroupData>(data, options);
        }

        string IPersistableModel<SecurityConnectorGitLabGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
