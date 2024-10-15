// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class PreRestoreContent : IUtf8JsonSerializable, IJsonModel<PreRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PreRestoreContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PreRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PreRestoreContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Partition))
            {
                writer.WritePropertyName("partition"u8);
                writer.WriteStringValue(Partition);
            }
            if (Optional.IsDefined(ReplicaGroup))
            {
                writer.WritePropertyName("replicaGroup"u8);
                writer.WriteStringValue(ReplicaGroup);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(AzureFileShareUri))
            {
                writer.WritePropertyName("azureFileShareUri"u8);
                writer.WriteStringValue(AzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SourceAzureFileShareUri))
            {
                writer.WritePropertyName("sourceAzureFileShareUri"u8);
                writer.WriteStringValue(SourceAzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BackupMetadataPropertyBag))
            {
                writer.WritePropertyName("backupMetadataPropertyBag"u8);
                writer.WriteStringValue(BackupMetadataPropertyBag);
            }
            if (Optional.IsCollectionDefined(RestoreFileSpec))
            {
                writer.WritePropertyName("restoreFileSpec"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreFileSpec)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PauseWaitForSyncDrainTimePeriodInSeconds))
            {
                writer.WritePropertyName("pauseWaitForSyncDrainTimePeriodInSeconds"u8);
                writer.WriteNumberValue(PauseWaitForSyncDrainTimePeriodInSeconds.Value);
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

        PreRestoreContent IJsonModel<PreRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PreRestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePreRestoreContent(document.RootElement, options);
        }

        internal static PreRestoreContent DeserializePreRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partition = default;
            string replicaGroup = default;
            string requestId = default;
            Uri azureFileShareUri = default;
            string status = default;
            Uri sourceAzureFileShareUri = default;
            string backupMetadataPropertyBag = default;
            IList<RestoreFileSpec> restoreFileSpec = default;
            int? pauseWaitForSyncDrainTimePeriodInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partition"u8))
                {
                    partition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaGroup"u8))
                {
                    replicaGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAzureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceAzureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupMetadataPropertyBag"u8))
                {
                    backupMetadataPropertyBag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreFileSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestoreFileSpec> array = new List<RestoreFileSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RestoreFileSpec.DeserializeRestoreFileSpec(item, options));
                    }
                    restoreFileSpec = array;
                    continue;
                }
                if (property.NameEquals("pauseWaitForSyncDrainTimePeriodInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pauseWaitForSyncDrainTimePeriodInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PreRestoreContent(
                partition,
                replicaGroup,
                requestId,
                azureFileShareUri,
                status,
                sourceAzureFileShareUri,
                backupMetadataPropertyBag,
                restoreFileSpec ?? new ChangeTrackingList<RestoreFileSpec>(),
                pauseWaitForSyncDrainTimePeriodInSeconds,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PreRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PreRestoreContent)} does not support writing '{options.Format}' format.");
            }
        }

        PreRestoreContent IPersistableModel<PreRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePreRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PreRestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PreRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
