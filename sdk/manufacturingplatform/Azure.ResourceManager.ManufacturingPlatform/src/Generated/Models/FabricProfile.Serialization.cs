// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManufacturingPlatform.Models
{
    public partial class FabricProfile : IUtf8JsonSerializable, IJsonModel<FabricProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FabricProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FabricProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyUri"u8);
            writer.WriteStringValue(KeyUri);
            writer.WritePropertyName("oneLakeUri"u8);
            writer.WriteStringValue(OneLakeUri);
            writer.WritePropertyName("oneLakePath"u8);
            writer.WriteStringValue(OneLakePath);
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

        FabricProfile IJsonModel<FabricProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FabricProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFabricProfile(document.RootElement, options);
        }

        internal static FabricProfile DeserializeFabricProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyUri = default;
            string oneLakeUri = default;
            string oneLakePath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyUri"u8))
                {
                    keyUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oneLakeUri"u8))
                {
                    oneLakeUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oneLakePath"u8))
                {
                    oneLakePath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FabricProfile(keyUri, oneLakeUri, oneLakePath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FabricProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FabricProfile)} does not support writing '{options.Format}' format.");
            }
        }

        FabricProfile IPersistableModel<FabricProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FabricProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFabricProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FabricProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FabricProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
