// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateMySqlAzureDBForMySqlSyncTaskOutput))]
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutput)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutput IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlSyncTaskOutput DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelErrorOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(element, options);
                    case "DatabaseLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseLevel(element, options);
                    case "ErrorOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputError.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputError(element, options);
                    case "MigrationLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(element, options);
                    case "TableLevelOutput": return MigrateMySqlAzureDBForMySqlSyncTaskOutputTableLevel.DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputTableLevel(element, options);
                }
            }
            return UnknownMigrateMySqlAzureDBForMySqlSyncTaskOutput.DeserializeUnknownMigrateMySqlAzureDBForMySqlSyncTaskOutput(element, options);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutput IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
