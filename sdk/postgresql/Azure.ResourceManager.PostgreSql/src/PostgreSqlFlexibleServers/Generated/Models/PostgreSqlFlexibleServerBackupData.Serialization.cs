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
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlFlexibleServerBackupData : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerBackupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerBackupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerBackupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType"u8);
                writer.WriteStringValue(BackupType.Value.ToString());
            }
            if (Optional.IsDefined(CompletedOn))
            {
                writer.WritePropertyName("completedTime"u8);
                writer.WriteStringValue(CompletedOn.Value, "O");
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
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

        PostgreSqlFlexibleServerBackupData IJsonModel<PostgreSqlFlexibleServerBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerBackupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerBackupData(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerBackupData DeserializePostgreSqlFlexibleServerBackupData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<PostgreSqlFlexibleServerBackupOrigin> backupType = default;
            Optional<DateTimeOffset> completedTime = default;
            Optional<string> source = default;
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
                        if (property0.NameEquals("backupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupType = new PostgreSqlFlexibleServerBackupOrigin(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("completedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            completedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
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
            return new PostgreSqlFlexibleServerBackupData(id, name, type, systemData.Value, Optional.ToNullable(backupType), Optional.ToNullable(completedTime), source.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerBackupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerBackupData)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerBackupData IPersistableModel<PostgreSqlFlexibleServerBackupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerBackupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerBackupData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PostgreSqlFlexibleServerBackupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
