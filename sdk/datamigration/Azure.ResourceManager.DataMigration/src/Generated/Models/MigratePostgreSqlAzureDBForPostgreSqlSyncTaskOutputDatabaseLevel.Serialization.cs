// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel : IUtf8JsonSerializable, IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteStringValue(MigrationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IncomingChanges))
            {
                writer.WritePropertyName("incomingChanges"u8);
                writer.WriteNumberValue(IncomingChanges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AppliedChanges))
            {
                writer.WritePropertyName("appliedChanges"u8);
                writer.WriteNumberValue(AppliedChanges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcInsertCounter))
            {
                writer.WritePropertyName("cdcInsertCounter"u8);
                writer.WriteNumberValue(CdcInsertCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcDeleteCounter))
            {
                writer.WritePropertyName("cdcDeleteCounter"u8);
                writer.WriteNumberValue(CdcDeleteCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CdcUpdateCounter))
            {
                writer.WritePropertyName("cdcUpdateCounter"u8);
                writer.WriteNumberValue(CdcUpdateCounter.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadCompletedTables))
            {
                writer.WritePropertyName("fullLoadCompletedTables"u8);
                writer.WriteNumberValue(FullLoadCompletedTables.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadLoadingTables))
            {
                writer.WritePropertyName("fullLoadLoadingTables"u8);
                writer.WriteNumberValue(FullLoadLoadingTables.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadQueuedTables))
            {
                writer.WritePropertyName("fullLoadQueuedTables"u8);
                writer.WriteNumberValue(FullLoadQueuedTables.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FullLoadErroredTables))
            {
                writer.WritePropertyName("fullLoadErroredTables"u8);
                writer.WriteNumberValue(FullLoadErroredTables.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InitializationCompleted))
            {
                writer.WritePropertyName("initializationCompleted"u8);
                writer.WriteBooleanValue(InitializationCompleted.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Latency))
            {
                writer.WritePropertyName("latency"u8);
                writer.WriteNumberValue(Latency.Value);
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(document.RootElement, options);
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            SyncDatabaseMigrationReportingState? migrationState = default;
            long? incomingChanges = default;
            long? appliedChanges = default;
            long? cdcInsertCounter = default;
            long? cdcDeleteCounter = default;
            long? cdcUpdateCounter = default;
            long? fullLoadCompletedTables = default;
            long? fullLoadLoadingTables = default;
            long? fullLoadQueuedTables = default;
            long? fullLoadErroredTables = default;
            bool? initializationCompleted = default;
            long? latency = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = new SyncDatabaseMigrationReportingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incomingChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incomingChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("appliedChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcInsertCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcInsertCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcDeleteCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcDeleteCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcUpdateCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcUpdateCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadCompletedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadCompletedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadLoadingTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadLoadingTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadQueuedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadQueuedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadErroredTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadErroredTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initializationCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initializationCompleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("latency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latency = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                databaseName,
                startedOn,
                endedOn,
                migrationState,
                incomingChanges,
                appliedChanges,
                cdcInsertCounter,
                cdcDeleteCounter,
                cdcUpdateCounter,
                fullLoadCompletedTables,
                fullLoadLoadingTables,
                fullLoadQueuedTables,
                fullLoadErroredTables,
                initializationCompleted,
                latency);
        }

        BinaryData IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel)} does not support writing '{options.Format}' format.");
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputDatabaseLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
