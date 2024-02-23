// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class StorageBackupJobExtendedInfo : IUtf8JsonSerializable, IJsonModel<StorageBackupJobExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageBackupJobExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageBackupJobExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBackupJobExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(TasksList is ChangeTrackingList<StorageBackupJobTaskDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tasksList"u8);
                writer.WriteStartArray();
                foreach (var item in TasksList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PropertyBag is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (DynamicErrorMessage != null)
            {
                writer.WritePropertyName("dynamicErrorMessage"u8);
                writer.WriteStringValue(DynamicErrorMessage);
            }
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

        StorageBackupJobExtendedInfo IJsonModel<StorageBackupJobExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBackupJobExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageBackupJobExtendedInfo(document.RootElement, options);
        }

        internal static StorageBackupJobExtendedInfo DeserializeStorageBackupJobExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<StorageBackupJobTaskDetails>> tasksList = default;
            Optional<IDictionary<string, string>> propertyBag = default;
            Optional<string> dynamicErrorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tasksList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageBackupJobTaskDetails> array = new List<StorageBackupJobTaskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageBackupJobTaskDetails.DeserializeStorageBackupJobTaskDetails(item, options));
                    }
                    tasksList = array;
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
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
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("dynamicErrorMessage"u8))
                {
                    dynamicErrorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageBackupJobExtendedInfo(Optional.ToList(tasksList), Optional.ToDictionary(propertyBag), dynamicErrorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageBackupJobExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageBackupJobExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        StorageBackupJobExtendedInfo IPersistableModel<StorageBackupJobExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBackupJobExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageBackupJobExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageBackupJobExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageBackupJobExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
