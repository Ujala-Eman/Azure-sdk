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

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisInstanceDetails : IUtf8JsonSerializable, IJsonModel<RedisInstanceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisInstanceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisInstanceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RedisInstanceDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RedisInstanceDetails>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SslPort))
                {
                    writer.WritePropertyName("sslPort"u8);
                    writer.WriteNumberValue(SslPort.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NonSslPort))
                {
                    writer.WritePropertyName("nonSslPort"u8);
                    writer.WriteNumberValue(NonSslPort.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Zone))
                {
                    writer.WritePropertyName("zone"u8);
                    writer.WriteStringValue(Zone);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ShardId))
                {
                    writer.WritePropertyName("shardId"u8);
                    writer.WriteNumberValue(ShardId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsMaster))
                {
                    writer.WritePropertyName("isMaster"u8);
                    writer.WriteBooleanValue(IsMaster.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsPrimary))
                {
                    writer.WritePropertyName("isPrimary"u8);
                    writer.WriteBooleanValue(IsPrimary.Value);
                }
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

        RedisInstanceDetails IJsonModel<RedisInstanceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisInstanceDetails(document.RootElement, options);
        }

        internal static RedisInstanceDetails DeserializeRedisInstanceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> sslPort = default;
            Optional<int> nonSslPort = default;
            Optional<string> zone = default;
            Optional<int> shardId = default;
            Optional<bool> isMaster = default;
            Optional<bool> isPrimary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sslPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nonSslPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonSslPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("zone"u8))
                {
                    zone = property.Value.GetString();
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
                if (property.NameEquals("isMaster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMaster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisInstanceDetails(Optional.ToNullable(sslPort), Optional.ToNullable(nonSslPort), zone.Value, Optional.ToNullable(shardId), Optional.ToNullable(isMaster), Optional.ToNullable(isPrimary), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisInstanceDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RedisInstanceDetails IPersistableModel<RedisInstanceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRedisInstanceDetails(document.RootElement, options);
        }

        string IPersistableModel<RedisInstanceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
