// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class LongTermRetentionBackupData : IUtf8JsonSerializable, IJsonModel<LongTermRetentionBackupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LongTermRetentionBackupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LongTermRetentionBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LongTermRetentionBackupData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LongTermRetentionBackupData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ServerName))
                {
                    writer.WritePropertyName("serverName"u8);
                    writer.WriteStringValue(ServerName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ServerCreateOn))
                {
                    writer.WritePropertyName("serverCreateTime"u8);
                    writer.WriteStringValue(ServerCreateOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    writer.WritePropertyName("databaseName"u8);
                    writer.WriteStringValue(DatabaseName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DatabaseDeletedOn))
                {
                    writer.WritePropertyName("databaseDeletionTime"u8);
                    writer.WriteStringValue(DatabaseDeletedOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BackupOn))
                {
                    writer.WritePropertyName("backupTime"u8);
                    writer.WriteStringValue(BackupOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BackupExpireOn))
                {
                    writer.WritePropertyName("backupExpirationTime"u8);
                    writer.WriteStringValue(BackupExpireOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BackupStorageRedundancy))
                {
                    writer.WritePropertyName("backupStorageRedundancy"u8);
                    writer.WriteStringValue(BackupStorageRedundancy.Value.ToString());
                }
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy"u8);
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        LongTermRetentionBackupData IJsonModel<LongTermRetentionBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLongTermRetentionBackupData(document.RootElement, options);
        }

        internal static LongTermRetentionBackupData DeserializeLongTermRetentionBackupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> serverCreateTime = default;
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> databaseDeletionTime = default;
            Optional<DateTimeOffset> backupTime = default;
            Optional<DateTimeOffset> backupExpirationTime = default;
            Optional<SqlBackupStorageRedundancy> backupStorageRedundancy = default;
            Optional<SqlBackupStorageRedundancy> requestedBackupStorageRedundancy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverCreateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverCreateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseDeletionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseDeletionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("backupTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("backupExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("backupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestedBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestedBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LongTermRetentionBackupData(id, name, type, systemData.Value, serverName.Value, Optional.ToNullable(serverCreateTime), databaseName.Value, Optional.ToNullable(databaseDeletionTime), Optional.ToNullable(backupTime), Optional.ToNullable(backupExpirationTime), Optional.ToNullable(backupStorageRedundancy), Optional.ToNullable(requestedBackupStorageRedundancy), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LongTermRetentionBackupData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LongTermRetentionBackupData IPersistableModel<LongTermRetentionBackupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLongTermRetentionBackupData(document.RootElement, options);
        }

        string IPersistableModel<LongTermRetentionBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
