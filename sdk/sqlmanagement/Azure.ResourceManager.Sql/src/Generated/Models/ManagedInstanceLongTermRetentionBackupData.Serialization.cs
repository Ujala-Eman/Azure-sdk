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
    public partial class ManagedInstanceLongTermRetentionBackupData : IUtf8JsonSerializable, IJsonModel<ManagedInstanceLongTermRetentionBackupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceLongTermRetentionBackupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceLongTermRetentionBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagedInstanceLongTermRetentionBackupData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagedInstanceLongTermRetentionBackupData>)} interface");
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
                if (Optional.IsDefined(ManagedInstanceName))
                {
                    writer.WritePropertyName("managedInstanceName"u8);
                    writer.WriteStringValue(ManagedInstanceName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ManagedInstanceCreateOn))
                {
                    writer.WritePropertyName("managedInstanceCreateTime"u8);
                    writer.WriteStringValue(ManagedInstanceCreateOn.Value, "O");
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

        ManagedInstanceLongTermRetentionBackupData IJsonModel<ManagedInstanceLongTermRetentionBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstanceLongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceLongTermRetentionBackupData(document.RootElement, options);
        }

        internal static ManagedInstanceLongTermRetentionBackupData DeserializeManagedInstanceLongTermRetentionBackupData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> managedInstanceName = default;
            Optional<DateTimeOffset> managedInstanceCreateTime = default;
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> databaseDeletionTime = default;
            Optional<DateTimeOffset> backupTime = default;
            Optional<DateTimeOffset> backupExpirationTime = default;
            Optional<SqlBackupStorageRedundancy> backupStorageRedundancy = default;
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
                        if (property0.NameEquals("managedInstanceName"u8))
                        {
                            managedInstanceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedInstanceCreateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedInstanceCreateTime = property0.Value.GetDateTimeOffset("O");
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
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceLongTermRetentionBackupData(id, name, type, systemData.Value, managedInstanceName.Value, Optional.ToNullable(managedInstanceCreateTime), databaseName.Value, Optional.ToNullable(databaseDeletionTime), Optional.ToNullable(backupTime), Optional.ToNullable(backupExpirationTime), Optional.ToNullable(backupStorageRedundancy), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceLongTermRetentionBackupData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstanceLongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedInstanceLongTermRetentionBackupData IPersistableModel<ManagedInstanceLongTermRetentionBackupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstanceLongTermRetentionBackupData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedInstanceLongTermRetentionBackupData(document.RootElement, options);
        }

        string IPersistableModel<ManagedInstanceLongTermRetentionBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
