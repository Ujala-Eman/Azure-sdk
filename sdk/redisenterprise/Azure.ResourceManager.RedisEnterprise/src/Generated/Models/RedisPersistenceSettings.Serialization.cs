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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisPersistenceSettings : IUtf8JsonSerializable, IJsonModel<RedisPersistenceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisPersistenceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisPersistenceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPersistenceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedisPersistenceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAofEnabled))
            {
                writer.WritePropertyName("aofEnabled"u8);
                writer.WriteBooleanValue(IsAofEnabled.Value);
            }
            if (Optional.IsDefined(IsRdbEnabled))
            {
                writer.WritePropertyName("rdbEnabled"u8);
                writer.WriteBooleanValue(IsRdbEnabled.Value);
            }
            if (Optional.IsDefined(AofFrequency))
            {
                writer.WritePropertyName("aofFrequency"u8);
                writer.WriteStringValue(AofFrequency.Value.ToString());
            }
            if (Optional.IsDefined(RdbFrequency))
            {
                writer.WritePropertyName("rdbFrequency"u8);
                writer.WriteStringValue(RdbFrequency.Value.ToString());
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

        RedisPersistenceSettings IJsonModel<RedisPersistenceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPersistenceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RedisPersistenceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisPersistenceSettings(document.RootElement, options);
        }

        internal static RedisPersistenceSettings DeserializeRedisPersistenceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> aofEnabled = default;
            Optional<bool> rdbEnabled = default;
            Optional<PersistenceSettingAofFrequency> aofFrequency = default;
            Optional<PersistenceSettingRdbFrequency> rdbFrequency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aofEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aofEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rdbEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdbEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("aofFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aofFrequency = new PersistenceSettingAofFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdbFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdbFrequency = new PersistenceSettingRdbFrequency(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisPersistenceSettings(Optional.ToNullable(aofEnabled), Optional.ToNullable(rdbEnabled), Optional.ToNullable(aofFrequency), Optional.ToNullable(rdbFrequency), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisPersistenceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPersistenceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RedisPersistenceSettings)} does not support '{options.Format}' format.");
            }
        }

        RedisPersistenceSettings IPersistableModel<RedisPersistenceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisPersistenceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisPersistenceSettings(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RedisPersistenceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisPersistenceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
