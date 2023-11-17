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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MabContainerExtendedInfo : IUtf8JsonSerializable, IJsonModel<MabContainerExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MabContainerExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MabContainerExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MabContainerExtendedInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MabContainerExtendedInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshedAt"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(BackupItemType))
            {
                writer.WritePropertyName("backupItemType"u8);
                writer.WriteStringValue(BackupItemType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(BackupItems))
            {
                writer.WritePropertyName("backupItems"u8);
                writer.WriteStartArray();
                foreach (var item in BackupItems)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
            }
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

        MabContainerExtendedInfo IJsonModel<MabContainerExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MabContainerExtendedInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMabContainerExtendedInfo(document.RootElement, options);
        }

        internal static MabContainerExtendedInfo DeserializeMabContainerExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastRefreshedAt = default;
            Optional<BackupItemType> backupItemType = default;
            Optional<IList<string>> backupItems = default;
            Optional<string> policyName = default;
            Optional<string> lastBackupStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastRefreshedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupItemType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupItemType = new BackupItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    backupItems = array;
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MabContainerExtendedInfo(Optional.ToNullable(lastRefreshedAt), Optional.ToNullable(backupItemType), Optional.ToList(backupItems), policyName.Value, lastBackupStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MabContainerExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MabContainerExtendedInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MabContainerExtendedInfo IPersistableModel<MabContainerExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MabContainerExtendedInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMabContainerExtendedInfo(document.RootElement, options);
        }

        string IPersistableModel<MabContainerExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
