// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MixedReality.Models
{
    public partial class MixedRealityAccountKeyRegenerateContent : IUtf8JsonSerializable, IJsonModel<MixedRealityAccountKeyRegenerateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MixedRealityAccountKeyRegenerateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MixedRealityAccountKeyRegenerateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedRealityAccountKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedRealityAccountKeyRegenerateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Serial.HasValue)
            {
                writer.WritePropertyName("serial"u8);
                writer.WriteNumberValue((int)Serial.Value);
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

        MixedRealityAccountKeyRegenerateContent IJsonModel<MixedRealityAccountKeyRegenerateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedRealityAccountKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedRealityAccountKeyRegenerateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMixedRealityAccountKeyRegenerateContent(document.RootElement, options);
        }

        internal static MixedRealityAccountKeyRegenerateContent DeserializeMixedRealityAccountKeyRegenerateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MixedRealityAccountKeySerial? serial = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serial = property.Value.GetInt32().ToMixedRealityAccountKeySerial();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MixedRealityAccountKeyRegenerateContent(serial, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MixedRealityAccountKeyRegenerateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedRealityAccountKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MixedRealityAccountKeyRegenerateContent)} does not support '{options.Format}' format.");
            }
        }

        MixedRealityAccountKeyRegenerateContent IPersistableModel<MixedRealityAccountKeyRegenerateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedRealityAccountKeyRegenerateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMixedRealityAccountKeyRegenerateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MixedRealityAccountKeyRegenerateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MixedRealityAccountKeyRegenerateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
