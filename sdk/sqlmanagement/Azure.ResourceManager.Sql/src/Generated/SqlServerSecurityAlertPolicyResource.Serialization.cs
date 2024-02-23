// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerSecurityAlertPolicyResource : IJsonModel<SqlServerSecurityAlertPolicyData>
    {
        void IJsonModel<SqlServerSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SqlServerSecurityAlertPolicyData IJsonModel<SqlServerSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SqlServerSecurityAlertPolicyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SqlServerSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SqlServerSecurityAlertPolicyData IPersistableModel<SqlServerSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SqlServerSecurityAlertPolicyData>(data, options);
        }

        string IPersistableModel<SqlServerSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
