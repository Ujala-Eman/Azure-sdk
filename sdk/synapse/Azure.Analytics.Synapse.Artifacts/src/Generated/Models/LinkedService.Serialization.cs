// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedServiceConverter))]
    public partial class LinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
            }
            writer.WriteEndObject();
        }

        internal static LinkedService DeserializeLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWS": return AmazonMWSLinkedService.DeserializeAmazonMWSLinkedService(element);
                    case "AmazonRdsForOracle": return AmazonRdsForOracleLinkedService.DeserializeAmazonRdsForOracleLinkedService(element);
                    case "AmazonRdsForSqlServer": return AmazonRdsForSqlServerLinkedService.DeserializeAmazonRdsForSqlServerLinkedService(element);
                    case "AmazonRedshift": return AmazonRedshiftLinkedService.DeserializeAmazonRedshiftLinkedService(element);
                    case "AmazonS3": return AmazonS3LinkedService.DeserializeAmazonS3LinkedService(element);
                    case "AppFigures": return AppFiguresLinkedService.DeserializeAppFiguresLinkedService(element);
                    case "Asana": return AsanaLinkedService.DeserializeAsanaLinkedService(element);
                    case "AzureBatch": return AzureBatchLinkedService.DeserializeAzureBatchLinkedService(element);
                    case "AzureBlobFS": return AzureBlobFSLinkedService.DeserializeAzureBlobFSLinkedService(element);
                    case "AzureBlobStorage": return AzureBlobStorageLinkedService.DeserializeAzureBlobStorageLinkedService(element);
                    case "AzureDataExplorer": return AzureDataExplorerLinkedService.DeserializeAzureDataExplorerLinkedService(element);
                    case "AzureDataLakeAnalytics": return AzureDataLakeAnalyticsLinkedService.DeserializeAzureDataLakeAnalyticsLinkedService(element);
                    case "AzureDataLakeStore": return AzureDataLakeStoreLinkedService.DeserializeAzureDataLakeStoreLinkedService(element);
                    case "AzureDatabricks": return AzureDatabricksLinkedService.DeserializeAzureDatabricksLinkedService(element);
                    case "AzureDatabricksDeltaLake": return AzureDatabricksDeltaLakeLinkedService.DeserializeAzureDatabricksDeltaLakeLinkedService(element);
                    case "AzureFileStorage": return AzureFileStorageLinkedService.DeserializeAzureFileStorageLinkedService(element);
                    case "AzureFunction": return AzureFunctionLinkedService.DeserializeAzureFunctionLinkedService(element);
                    case "AzureKeyVault": return AzureKeyVaultLinkedService.DeserializeAzureKeyVaultLinkedService(element);
                    case "AzureML": return AzureMLLinkedService.DeserializeAzureMLLinkedService(element);
                    case "AzureMLService": return AzureMLServiceLinkedService.DeserializeAzureMLServiceLinkedService(element);
                    case "AzureMariaDB": return AzureMariaDBLinkedService.DeserializeAzureMariaDBLinkedService(element);
                    case "AzureMySql": return AzureMySqlLinkedService.DeserializeAzureMySqlLinkedService(element);
                    case "AzurePostgreSql": return AzurePostgreSqlLinkedService.DeserializeAzurePostgreSqlLinkedService(element);
                    case "AzureSearch": return AzureSearchLinkedService.DeserializeAzureSearchLinkedService(element);
                    case "AzureSqlDW": return AzureSqlDWLinkedService.DeserializeAzureSqlDWLinkedService(element);
                    case "AzureSqlDatabase": return AzureSqlDatabaseLinkedService.DeserializeAzureSqlDatabaseLinkedService(element);
                    case "AzureSqlMI": return AzureSqlMILinkedService.DeserializeAzureSqlMILinkedService(element);
                    case "AzureStorage": return AzureStorageLinkedService.DeserializeAzureStorageLinkedService(element);
                    case "AzureSynapseArtifacts": return AzureSynapseArtifactsLinkedService.DeserializeAzureSynapseArtifactsLinkedService(element);
                    case "AzureTableStorage": return AzureTableStorageLinkedService.DeserializeAzureTableStorageLinkedService(element);
                    case "Cassandra": return CassandraLinkedService.DeserializeCassandraLinkedService(element);
                    case "CommonDataServiceForApps": return CommonDataServiceForAppsLinkedService.DeserializeCommonDataServiceForAppsLinkedService(element);
                    case "Concur": return ConcurLinkedService.DeserializeConcurLinkedService(element);
                    case "CosmosDb": return CosmosDbLinkedService.DeserializeCosmosDbLinkedService(element);
                    case "CosmosDbMongoDbApi": return CosmosDbMongoDbApiLinkedService.DeserializeCosmosDbMongoDbApiLinkedService(element);
                    case "Couchbase": return CouchbaseLinkedService.DeserializeCouchbaseLinkedService(element);
                    case "CustomDataSource": return CustomDataSourceLinkedService.DeserializeCustomDataSourceLinkedService(element);
                    case "Dataworld": return DataworldLinkedService.DeserializeDataworldLinkedService(element);
                    case "Db2": return Db2LinkedService.DeserializeDb2LinkedService(element);
                    case "Drill": return DrillLinkedService.DeserializeDrillLinkedService(element);
                    case "Dynamics": return DynamicsLinkedService.DeserializeDynamicsLinkedService(element);
                    case "DynamicsAX": return DynamicsAXLinkedService.DeserializeDynamicsAXLinkedService(element);
                    case "DynamicsCrm": return DynamicsCrmLinkedService.DeserializeDynamicsCrmLinkedService(element);
                    case "Eloqua": return EloquaLinkedService.DeserializeEloquaLinkedService(element);
                    case "FileServer": return FileServerLinkedService.DeserializeFileServerLinkedService(element);
                    case "FtpServer": return FtpServerLinkedService.DeserializeFtpServerLinkedService(element);
                    case "GoogleAdWords": return GoogleAdWordsLinkedService.DeserializeGoogleAdWordsLinkedService(element);
                    case "GoogleBigQuery": return GoogleBigQueryLinkedService.DeserializeGoogleBigQueryLinkedService(element);
                    case "GoogleCloudStorage": return GoogleCloudStorageLinkedService.DeserializeGoogleCloudStorageLinkedService(element);
                    case "GoogleSheets": return GoogleSheetsLinkedService.DeserializeGoogleSheetsLinkedService(element);
                    case "Greenplum": return GreenplumLinkedService.DeserializeGreenplumLinkedService(element);
                    case "HBase": return HBaseLinkedService.DeserializeHBaseLinkedService(element);
                    case "HDInsight": return HDInsightLinkedService.DeserializeHDInsightLinkedService(element);
                    case "HDInsightOnDemand": return HDInsightOnDemandLinkedService.DeserializeHDInsightOnDemandLinkedService(element);
                    case "Hdfs": return HdfsLinkedService.DeserializeHdfsLinkedService(element);
                    case "Hive": return HiveLinkedService.DeserializeHiveLinkedService(element);
                    case "HttpServer": return HttpLinkedService.DeserializeHttpLinkedService(element);
                    case "Hubspot": return HubspotLinkedService.DeserializeHubspotLinkedService(element);
                    case "Impala": return ImpalaLinkedService.DeserializeImpalaLinkedService(element);
                    case "Informix": return InformixLinkedService.DeserializeInformixLinkedService(element);
                    case "Jira": return JiraLinkedService.DeserializeJiraLinkedService(element);
                    case "Magento": return MagentoLinkedService.DeserializeMagentoLinkedService(element);
                    case "MariaDB": return MariaDBLinkedService.DeserializeMariaDBLinkedService(element);
                    case "Marketo": return MarketoLinkedService.DeserializeMarketoLinkedService(element);
                    case "MicrosoftAccess": return MicrosoftAccessLinkedService.DeserializeMicrosoftAccessLinkedService(element);
                    case "MongoDb": return MongoDbLinkedService.DeserializeMongoDbLinkedService(element);
                    case "MongoDbAtlas": return MongoDbAtlasLinkedService.DeserializeMongoDbAtlasLinkedService(element);
                    case "MongoDbV2": return MongoDbV2LinkedService.DeserializeMongoDbV2LinkedService(element);
                    case "MySql": return MySqlLinkedService.DeserializeMySqlLinkedService(element);
                    case "Netezza": return NetezzaLinkedService.DeserializeNetezzaLinkedService(element);
                    case "OData": return ODataLinkedService.DeserializeODataLinkedService(element);
                    case "Odbc": return OdbcLinkedService.DeserializeOdbcLinkedService(element);
                    case "Office365": return Office365LinkedService.DeserializeOffice365LinkedService(element);
                    case "Oracle": return OracleLinkedService.DeserializeOracleLinkedService(element);
                    case "OracleServiceCloud": return OracleServiceCloudLinkedService.DeserializeOracleServiceCloudLinkedService(element);
                    case "Paypal": return PaypalLinkedService.DeserializePaypalLinkedService(element);
                    case "Phoenix": return PhoenixLinkedService.DeserializePhoenixLinkedService(element);
                    case "PostgreSql": return PostgreSqlLinkedService.DeserializePostgreSqlLinkedService(element);
                    case "PowerBIWorkspace": return PowerBIWorkspaceLinkedService.DeserializePowerBIWorkspaceLinkedService(element);
                    case "Presto": return PrestoLinkedService.DeserializePrestoLinkedService(element);
                    case "QuickBooks": return QuickBooksLinkedService.DeserializeQuickBooksLinkedService(element);
                    case "Quickbase": return QuickbaseLinkedService.DeserializeQuickbaseLinkedService(element);
                    case "Responsys": return ResponsysLinkedService.DeserializeResponsysLinkedService(element);
                    case "RestService": return RestServiceLinkedService.DeserializeRestServiceLinkedService(element);
                    case "Salesforce": return SalesforceLinkedService.DeserializeSalesforceLinkedService(element);
                    case "SalesforceMarketingCloud": return SalesforceMarketingCloudLinkedService.DeserializeSalesforceMarketingCloudLinkedService(element);
                    case "SalesforceServiceCloud": return SalesforceServiceCloudLinkedService.DeserializeSalesforceServiceCloudLinkedService(element);
                    case "SapBW": return SapBWLinkedService.DeserializeSapBWLinkedService(element);
                    case "SapCloudForCustomer": return SapCloudForCustomerLinkedService.DeserializeSapCloudForCustomerLinkedService(element);
                    case "SapEcc": return SapEccLinkedService.DeserializeSapEccLinkedService(element);
                    case "SapHana": return SapHanaLinkedService.DeserializeSapHanaLinkedService(element);
                    case "SapOdp": return SapOdpLinkedService.DeserializeSapOdpLinkedService(element);
                    case "SapOpenHub": return SapOpenHubLinkedService.DeserializeSapOpenHubLinkedService(element);
                    case "SapTable": return SapTableLinkedService.DeserializeSapTableLinkedService(element);
                    case "ServiceNow": return ServiceNowLinkedService.DeserializeServiceNowLinkedService(element);
                    case "Sftp": return SftpServerLinkedService.DeserializeSftpServerLinkedService(element);
                    case "SharePointOnlineList": return SharePointOnlineListLinkedService.DeserializeSharePointOnlineListLinkedService(element);
                    case "Shopify": return ShopifyLinkedService.DeserializeShopifyLinkedService(element);
                    case "Smartsheet": return SmartsheetLinkedService.DeserializeSmartsheetLinkedService(element);
                    case "Snowflake": return SnowflakeLinkedService.DeserializeSnowflakeLinkedService(element);
                    case "Spark": return SparkLinkedService.DeserializeSparkLinkedService(element);
                    case "SqlServer": return SqlServerLinkedService.DeserializeSqlServerLinkedService(element);
                    case "Square": return SquareLinkedService.DeserializeSquareLinkedService(element);
                    case "Sybase": return SybaseLinkedService.DeserializeSybaseLinkedService(element);
                    case "TeamDesk": return TeamDeskLinkedService.DeserializeTeamDeskLinkedService(element);
                    case "Teradata": return TeradataLinkedService.DeserializeTeradataLinkedService(element);
                    case "Twilio": return TwilioLinkedService.DeserializeTwilioLinkedService(element);
                    case "Vertica": return VerticaLinkedService.DeserializeVerticaLinkedService(element);
                    case "Web": return WebLinkedService.DeserializeWebLinkedService(element);
                    case "Xero": return XeroLinkedService.DeserializeXeroLinkedService(element);
                    case "Zendesk": return ZendeskLinkedService.DeserializeZendeskLinkedService(element);
                    case "Zoho": return ZohoLinkedService.DeserializeZohoLinkedService(element);
                }
            }
            return UnknownLinkedService.DeserializeUnknownLinkedService(element);
        }

        internal partial class LinkedServiceConverter : JsonConverter<LinkedService>
        {
            public override void Write(Utf8JsonWriter writer, LinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedService(document.RootElement);
            }
        }
    }
}
