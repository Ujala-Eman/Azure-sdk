// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationPatch : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlMigrationPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SourceDbServerResourceId != null)
            {
                writer.WritePropertyName("sourceDbServerResourceId"u8);
                writer.WriteStringValue(SourceDbServerResourceId);
            }
            if (SourceDbServerFullyQualifiedDomainName != null)
            {
                writer.WritePropertyName("sourceDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(SourceDbServerFullyQualifiedDomainName);
            }
            if (TargetDbServerFullyQualifiedDomainName != null)
            {
                writer.WritePropertyName("targetDbServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(TargetDbServerFullyQualifiedDomainName);
            }
            if (SecretParameters != null)
            {
                writer.WritePropertyName("secretParameters"u8);
                writer.WriteObjectValue(SecretParameters);
            }
            if (!(DbsToMigrate is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dbsToMigrate"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToMigrate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SetupLogicalReplicationOnSourceDbIfNeeded.HasValue)
            {
                writer.WritePropertyName("setupLogicalReplicationOnSourceDbIfNeeded"u8);
                writer.WriteStringValue(SetupLogicalReplicationOnSourceDbIfNeeded.Value.ToString());
            }
            if (OverwriteDbsInTarget.HasValue)
            {
                writer.WritePropertyName("overwriteDbsInTarget"u8);
                writer.WriteStringValue(OverwriteDbsInTarget.Value.ToString());
            }
            if (MigrationWindowStartTimeInUtc.HasValue)
            {
                writer.WritePropertyName("migrationWindowStartTimeInUtc"u8);
                writer.WriteStringValue(MigrationWindowStartTimeInUtc.Value, "O");
            }
            if (StartDataMigration.HasValue)
            {
                writer.WritePropertyName("startDataMigration"u8);
                writer.WriteStringValue(StartDataMigration.Value.ToString());
            }
            if (TriggerCutover.HasValue)
            {
                writer.WritePropertyName("triggerCutover"u8);
                writer.WriteStringValue(TriggerCutover.Value.ToString());
            }
            if (!(DbsToTriggerCutoverOn is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("dbsToTriggerCutoverOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToTriggerCutoverOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Cancel.HasValue)
            {
                writer.WritePropertyName("cancel"u8);
                writer.WriteStringValue(Cancel.Value.ToString());
            }
            if (!(DbsToCancelMigrationOn is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("dbsToCancelMigrationOn"u8);
                writer.WriteStartArray();
                foreach (var item in DbsToCancelMigrationOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (MigrationMode.HasValue)
            {
                writer.WritePropertyName("migrationMode"u8);
                writer.WriteStringValue(MigrationMode.Value.ToString());
            }
            writer.WriteEndObject();
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
            writer.WriteEndObject();
        }

        PostgreSqlMigrationPatch IJsonModel<PostgreSqlMigrationPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationPatch(document.RootElement, options);
        }

        internal static PostgreSqlMigrationPatch DeserializePostgreSqlMigrationPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ResourceIdentifier sourceDbServerResourceId = default;
            string sourceDbServerFullyQualifiedDomainName = default;
            string targetDbServerFullyQualifiedDomainName = default;
            PostgreSqlMigrationSecretParameters secretParameters = default;
            IList<string> dbsToMigrate = default;
            PostgreSqlMigrationLogicalReplicationOnSourceDb? setupLogicalReplicationOnSourceDbIfNeeded = default;
            PostgreSqlMigrationOverwriteDbsInTarget? overwriteDbsInTarget = default;
            DateTimeOffset? migrationWindowStartTimeInUtc = default;
            PostgreSqlMigrationStartDataMigration? startDataMigration = default;
            PostgreSqlMigrationTriggerCutover? triggerCutover = default;
            IList<string> dbsToTriggerCutoverOn = default;
            PostgreSqlMigrationCancel? cancel = default;
            IList<string> dbsToCancelMigrationOn = default;
            PostgreSqlMigrationMode? migrationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceDbServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDbServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDbServerFullyQualifiedDomainName"u8))
                        {
                            sourceDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDbServerFullyQualifiedDomainName"u8))
                        {
                            targetDbServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secretParameters = PostgreSqlMigrationSecretParameters.DeserializePostgreSqlMigrationSecretParameters(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dbsToMigrate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToMigrate = array;
                            continue;
                        }
                        if (property0.NameEquals("setupLogicalReplicationOnSourceDbIfNeeded"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            setupLogicalReplicationOnSourceDbIfNeeded = new PostgreSqlMigrationLogicalReplicationOnSourceDb(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("overwriteDbsInTarget"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwriteDbsInTarget = new PostgreSqlMigrationOverwriteDbsInTarget(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("migrationWindowStartTimeInUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationWindowStartTimeInUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startDataMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDataMigration = new PostgreSqlMigrationStartDataMigration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerCutover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerCutover = new PostgreSqlMigrationTriggerCutover(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToTriggerCutoverOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToTriggerCutoverOn = array;
                            continue;
                        }
                        if (property0.NameEquals("cancel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cancel = new PostgreSqlMigrationCancel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dbsToCancelMigrationOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dbsToCancelMigrationOn = array;
                            continue;
                        }
                        if (property0.NameEquals("migrationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationMode = new PostgreSqlMigrationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlMigrationPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sourceDbServerResourceId,
                sourceDbServerFullyQualifiedDomainName,
                targetDbServerFullyQualifiedDomainName,
                secretParameters,
                dbsToMigrate ?? new ChangeTrackingList<string>(),
                setupLogicalReplicationOnSourceDbIfNeeded,
                overwriteDbsInTarget,
                migrationWindowStartTimeInUtc,
                startDataMigration,
                triggerCutover,
                dbsToTriggerCutoverOn ?? new ChangeTrackingList<string>(),
                cancel,
                dbsToCancelMigrationOn ?? new ChangeTrackingList<string>(),
                migrationMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlMigrationPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlMigrationPatch IPersistableModel<PostgreSqlMigrationPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlMigrationPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlMigrationPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
