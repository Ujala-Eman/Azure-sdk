// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class ExcludedServicesConfig : IUtf8JsonSerializable, IJsonModel<ExcludedServicesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExcludedServicesConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExcludedServicesConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ExcludedServicesConfigId))
            {
                writer.WritePropertyName("excludedServicesConfigId"u8);
                writer.WriteStringValue(ExcludedServicesConfigId);
            }
            if (Optional.IsDefined(ExcludedServicesList))
            {
                writer.WritePropertyName("excludedServicesList"u8);
                writer.WriteStringValue(ExcludedServicesList);
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

        ExcludedServicesConfig IJsonModel<ExcludedServicesConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExcludedServicesConfig(document.RootElement, options);
        }

        internal static ExcludedServicesConfig DeserializeExcludedServicesConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string excludedServicesConfigId = default;
            string excludedServicesList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("excludedServicesConfigId"u8))
                {
                    excludedServicesConfigId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedServicesList"u8))
                {
                    excludedServicesList = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExcludedServicesConfig(excludedServicesConfigId, excludedServicesList, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExcludedServicesConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ExcludedServicesConfig IPersistableModel<ExcludedServicesConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExcludedServicesConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExcludedServicesConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
