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
    public partial class MongoDBCollectionSettings : IUtf8JsonSerializable, IJsonModel<MongoDBCollectionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBCollectionSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBCollectionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CanDelete.HasValue)
            {
                writer.WritePropertyName("canDelete"u8);
                writer.WriteBooleanValue(CanDelete.Value);
            }
            if (ShardKey != null)
            {
                writer.WritePropertyName("shardKey"u8);
                writer.WriteObjectValue(ShardKey);
            }
            if (TargetRUs.HasValue)
            {
                writer.WritePropertyName("targetRUs"u8);
                writer.WriteNumberValue(TargetRUs.Value);
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

        MongoDBCollectionSettings IJsonModel<MongoDBCollectionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCollectionSettings(document.RootElement, options);
        }

        internal static MongoDBCollectionSettings DeserializeMongoDBCollectionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? canDelete = default;
            MongoDBShardKeySetting shardKey = default;
            int? targetRUs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("shardKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shardKey = MongoDBShardKeySetting.DeserializeMongoDBShardKeySetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetRUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetRUs = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBCollectionSettings(canDelete, shardKey, targetRUs, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBCollectionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionSettings)} does not support '{options.Format}' format.");
            }
        }

        MongoDBCollectionSettings IPersistableModel<MongoDBCollectionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBCollectionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBCollectionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
