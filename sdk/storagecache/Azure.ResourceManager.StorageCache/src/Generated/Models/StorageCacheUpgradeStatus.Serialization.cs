// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUpgradeStatus : IUtf8JsonSerializable, IJsonModel<StorageCacheUpgradeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheUpgradeStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageCacheUpgradeStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUpgradeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUpgradeStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CurrentFirmwareVersion))
            {
                writer.WritePropertyName("currentFirmwareVersion"u8);
                writer.WriteStringValue(CurrentFirmwareVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareUpdateStatus))
            {
                writer.WritePropertyName("firmwareUpdateStatus"u8);
                writer.WriteStringValue(FirmwareUpdateStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareUpdateDeadline))
            {
                writer.WritePropertyName("firmwareUpdateDeadline"u8);
                writer.WriteStringValue(FirmwareUpdateDeadline.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastFirmwareUpdate))
            {
                writer.WritePropertyName("lastFirmwareUpdate"u8);
                writer.WriteStringValue(LastFirmwareUpdate.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PendingFirmwareVersion))
            {
                writer.WritePropertyName("pendingFirmwareVersion"u8);
                writer.WriteStringValue(PendingFirmwareVersion);
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
        }

        StorageCacheUpgradeStatus IJsonModel<StorageCacheUpgradeStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUpgradeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUpgradeStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheUpgradeStatus(document.RootElement, options);
        }

        internal static StorageCacheUpgradeStatus DeserializeStorageCacheUpgradeStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string currentFirmwareVersion = default;
            StorageCacheFirmwareStatusType? firmwareUpdateStatus = default;
            DateTimeOffset? firmwareUpdateDeadline = default;
            DateTimeOffset? lastFirmwareUpdate = default;
            string pendingFirmwareVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentFirmwareVersion"u8))
                {
                    currentFirmwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateStatus = new StorageCacheFirmwareStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("firmwareUpdateDeadline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateDeadline = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastFirmwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFirmwareUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("pendingFirmwareVersion"u8))
                {
                    pendingFirmwareVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageCacheUpgradeStatus(
                currentFirmwareVersion,
                firmwareUpdateStatus,
                firmwareUpdateDeadline,
                lastFirmwareUpdate,
                pendingFirmwareVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheUpgradeStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUpgradeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUpgradeStatus)} does not support writing '{options.Format}' format.");
            }
        }

        StorageCacheUpgradeStatus IPersistableModel<StorageCacheUpgradeStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUpgradeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheUpgradeStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUpgradeStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheUpgradeStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
