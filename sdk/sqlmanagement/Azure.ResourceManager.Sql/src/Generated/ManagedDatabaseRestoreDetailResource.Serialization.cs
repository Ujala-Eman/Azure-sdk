// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseRestoreDetailResource : IJsonModel<ManagedDatabaseRestoreDetailData>
    {
        void IJsonModel<ManagedDatabaseRestoreDetailData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ManagedDatabaseRestoreDetailData IJsonModel<ManagedDatabaseRestoreDetailData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedDatabaseRestoreDetailData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ManagedDatabaseRestoreDetailData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ManagedDatabaseRestoreDetailData IPersistableModel<ManagedDatabaseRestoreDetailData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedDatabaseRestoreDetailData>(data, options);
        }

        string IPersistableModel<ManagedDatabaseRestoreDetailData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
