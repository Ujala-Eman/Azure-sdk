// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisRebootContent : IUtf8JsonSerializable, IJsonModel<RedisRebootContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisRebootContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisRebootContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisRebootContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisRebootContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RebootType.HasValue)
            {
                writer.WritePropertyName("rebootType"u8);
                writer.WriteStringValue(RebootType.Value.ToString());
            }
            if (ShardId.HasValue)
            {
                writer.WritePropertyName("shardId"u8);
                writer.WriteNumberValue(ShardId.Value);
            }
            if (!(Ports is ChangeTrackingList<int> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        RedisRebootContent IJsonModel<RedisRebootContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisRebootContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisRebootContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisRebootContent(document.RootElement, options);
        }

        internal static RedisRebootContent DeserializeRedisRebootContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RedisRebootType> rebootType = default;
            Optional<int> shardId = default;
            Optional<IList<int>> ports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootType = new RedisRebootType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shardId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shardId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    ports = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisRebootContent(Optional.ToNullable(rebootType), Optional.ToNullable(shardId), Optional.ToList(ports), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisRebootContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisRebootContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisRebootContent)} does not support '{options.Format}' format.");
            }
        }

        RedisRebootContent IPersistableModel<RedisRebootContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisRebootContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisRebootContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisRebootContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisRebootContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
