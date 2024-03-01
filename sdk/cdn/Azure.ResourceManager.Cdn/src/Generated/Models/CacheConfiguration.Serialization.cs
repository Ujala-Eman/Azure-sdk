// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CacheConfiguration : IUtf8JsonSerializable, IJsonModel<CacheConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CacheConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CacheConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QueryStringCachingBehavior.HasValue)
            {
                writer.WritePropertyName("queryStringCachingBehavior"u8);
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToString());
            }
            if (QueryParameters != null)
            {
                writer.WritePropertyName("queryParameters"u8);
                writer.WriteStringValue(QueryParameters);
            }
            if (IsCompressionEnabled.HasValue)
            {
                writer.WritePropertyName("isCompressionEnabled"u8);
                writer.WriteStringValue(IsCompressionEnabled.Value.ToString());
            }
            if (CacheBehavior.HasValue)
            {
                writer.WritePropertyName("cacheBehavior"u8);
                writer.WriteStringValue(CacheBehavior.Value.ToString());
            }
            if (CacheDuration.HasValue)
            {
                if (CacheDuration != null)
                {
                    writer.WritePropertyName("cacheDuration"u8);
                    writer.WriteStringValue(CacheDuration.Value, "c");
                }
                else
                {
                    writer.WriteNull("cacheDuration");
                }
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

        CacheConfiguration IJsonModel<CacheConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCacheConfiguration(document.RootElement, options);
        }

        internal static CacheConfiguration DeserializeCacheConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RuleQueryStringCachingBehavior? queryStringCachingBehavior = default;
            string queryParameters = default;
            RuleIsCompressionEnabled? isCompressionEnabled = default;
            RuleCacheBehavior? cacheBehavior = default;
            TimeSpan? cacheDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryStringCachingBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryStringCachingBehavior = new RuleQueryStringCachingBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    queryParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCompressionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompressionEnabled = new RuleIsCompressionEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheBehavior = new RuleCacheBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cacheDuration = null;
                        continue;
                    }
                    cacheDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CacheConfiguration(
                queryStringCachingBehavior,
                queryParameters,
                isCompressionEnabled,
                cacheBehavior,
                cacheDuration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CacheConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CacheConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CacheConfiguration IPersistableModel<CacheConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCacheConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CacheConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CacheConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
