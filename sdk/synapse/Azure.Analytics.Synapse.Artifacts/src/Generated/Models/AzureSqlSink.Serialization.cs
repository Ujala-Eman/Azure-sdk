// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AzureSqlSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlWriterStoredProcedureName))
            {
                writer.WritePropertyName("sqlWriterStoredProcedureName");
                writer.WriteObjectValue(SqlWriterStoredProcedureName);
            }
            if (Optional.IsDefined(SqlWriterTableType))
            {
                writer.WritePropertyName("sqlWriterTableType");
                writer.WriteObjectValue(SqlWriterTableType);
            }
            if (Optional.IsDefined(PreCopyScript))
            {
                writer.WritePropertyName("preCopyScript");
                writer.WriteObjectValue(PreCopyScript);
            }
            if (Optional.IsCollectionDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters");
                writer.WriteStartObject();
                foreach (var item in StoredProcedureParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(StoredProcedureTableTypeParameterName))
            {
                writer.WritePropertyName("storedProcedureTableTypeParameterName");
                writer.WriteObjectValue(StoredProcedureTableTypeParameterName);
            }
            if (Optional.IsDefined(TableOption))
            {
                writer.WritePropertyName("tableOption");
                writer.WriteObjectValue(TableOption);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureSqlSink DeserializeAzureSqlSink(JsonElement element)
        {
            Optional<object> sqlWriterStoredProcedureName = default;
            Optional<object> sqlWriterTableType = default;
            Optional<object> preCopyScript = default;
            Optional<IDictionary<string, StoredProcedureParameter>> storedProcedureParameters = default;
            Optional<object> storedProcedureTableTypeParameterName = default;
            Optional<object> tableOption = default;
            string type = default;
            Optional<object> writeBatchSize = default;
            Optional<object> writeBatchTimeout = default;
            Optional<object> sinkRetryCount = default;
            Optional<object> sinkRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlWriterStoredProcedureName"))
                {
                    sqlWriterStoredProcedureName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sqlWriterTableType"))
                {
                    sqlWriterTableType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("preCopyScript"))
                {
                    preCopyScript = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"))
                {
                    Dictionary<string, StoredProcedureParameter> dictionary = new Dictionary<string, StoredProcedureParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, StoredProcedureParameter.DeserializeStoredProcedureParameter(property0.Value));
                    }
                    storedProcedureParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("storedProcedureTableTypeParameterName"))
                {
                    storedProcedureTableTypeParameterName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("tableOption"))
                {
                    tableOption = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureSqlSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, sqlWriterStoredProcedureName.Value, sqlWriterTableType.Value, preCopyScript.Value, Optional.ToDictionary(storedProcedureParameters), storedProcedureTableTypeParameterName.Value, tableOption.Value);
        }
    }
}
