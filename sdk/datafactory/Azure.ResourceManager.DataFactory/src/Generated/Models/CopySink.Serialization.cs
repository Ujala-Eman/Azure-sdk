// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CopySink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CopySink DeserializeCopySink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroSink": return AvroSink.DeserializeAvroSink(element);
                    case "AzureBlobFSSink": return AzureBlobFSSink.DeserializeAzureBlobFSSink(element);
                    case "AzureDataExplorerSink": return AzureDataExplorerSink.DeserializeAzureDataExplorerSink(element);
                    case "AzureDataLakeStoreSink": return AzureDataLakeStoreSink.DeserializeAzureDataLakeStoreSink(element);
                    case "AzureDatabricksDeltaLakeSink": return AzureDatabricksDeltaLakeSink.DeserializeAzureDatabricksDeltaLakeSink(element);
                    case "AzureMySqlSink": return AzureMySqlSink.DeserializeAzureMySqlSink(element);
                    case "AzurePostgreSqlSink": return AzurePostgreSqlSink.DeserializeAzurePostgreSqlSink(element);
                    case "AzureQueueSink": return AzureQueueSink.DeserializeAzureQueueSink(element);
                    case "AzureSearchIndexSink": return AzureSearchIndexSink.DeserializeAzureSearchIndexSink(element);
                    case "AzureSqlSink": return AzureSqlSink.DeserializeAzureSqlSink(element);
                    case "AzureTableSink": return AzureTableSink.DeserializeAzureTableSink(element);
                    case "BinarySink": return BinarySink.DeserializeBinarySink(element);
                    case "BlobSink": return DataFactoryBlobSink.DeserializeDataFactoryBlobSink(element);
                    case "CommonDataServiceForAppsSink": return CommonDataServiceForAppsSink.DeserializeCommonDataServiceForAppsSink(element);
                    case "CosmosDbMongoDbApiSink": return CosmosDBMongoDBApiSink.DeserializeCosmosDBMongoDBApiSink(element);
                    case "CosmosDbSqlApiSink": return CosmosDBSqlApiSink.DeserializeCosmosDBSqlApiSink(element);
                    case "DelimitedTextSink": return DelimitedTextSink.DeserializeDelimitedTextSink(element);
                    case "DocumentDbCollectionSink": return DocumentDBCollectionSink.DeserializeDocumentDBCollectionSink(element);
                    case "DynamicsCrmSink": return DynamicsCrmSink.DeserializeDynamicsCrmSink(element);
                    case "DynamicsSink": return DynamicsSink.DeserializeDynamicsSink(element);
                    case "FileSystemSink": return FileSystemSink.DeserializeFileSystemSink(element);
                    case "InformixSink": return InformixSink.DeserializeInformixSink(element);
                    case "JsonSink": return JsonSink.DeserializeJsonSink(element);
                    case "MicrosoftAccessSink": return MicrosoftAccessSink.DeserializeMicrosoftAccessSink(element);
                    case "MongoDbAtlasSink": return MongoDBAtlasSink.DeserializeMongoDBAtlasSink(element);
                    case "MongoDbV2Sink": return MongoDBV2Sink.DeserializeMongoDBV2Sink(element);
                    case "OdbcSink": return OdbcSink.DeserializeOdbcSink(element);
                    case "OracleSink": return OracleSink.DeserializeOracleSink(element);
                    case "OrcSink": return OrcSink.DeserializeOrcSink(element);
                    case "ParquetSink": return ParquetSink.DeserializeParquetSink(element);
                    case "RestSink": return RestSink.DeserializeRestSink(element);
                    case "SalesforceServiceCloudSink": return SalesforceServiceCloudSink.DeserializeSalesforceServiceCloudSink(element);
                    case "SalesforceSink": return SalesforceSink.DeserializeSalesforceSink(element);
                    case "SapCloudForCustomerSink": return SapCloudForCustomerSink.DeserializeSapCloudForCustomerSink(element);
                    case "SnowflakeSink": return SnowflakeSink.DeserializeSnowflakeSink(element);
                    case "SqlDWSink": return SqlDWSink.DeserializeSqlDWSink(element);
                    case "SqlMISink": return SqlMISink.DeserializeSqlMISink(element);
                    case "SqlServerSink": return SqlServerSink.DeserializeSqlServerSink(element);
                    case "SqlSink": return SqlSink.DeserializeSqlSink(element);
                }
            }
            return UnknownCopySink.DeserializeUnknownCopySink(element);
        }
    }
}
