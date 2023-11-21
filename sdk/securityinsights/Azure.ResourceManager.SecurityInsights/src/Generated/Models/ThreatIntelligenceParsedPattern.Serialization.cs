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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceParsedPattern : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceParsedPattern>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceParsedPattern>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreatIntelligenceParsedPattern>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceParsedPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ThreatIntelligenceParsedPattern)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PatternTypeKey))
            {
                writer.WritePropertyName("patternTypeKey"u8);
                writer.WriteStringValue(PatternTypeKey);
            }
            if (Optional.IsCollectionDefined(PatternTypeValues))
            {
                writer.WritePropertyName("patternTypeValues"u8);
                writer.WriteStartArray();
                foreach (var item in PatternTypeValues)
                {
                    writer.WriteObjectValue(item);
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

        ThreatIntelligenceParsedPattern IJsonModel<ThreatIntelligenceParsedPattern>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceParsedPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ThreatIntelligenceParsedPattern)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceParsedPattern(document.RootElement, options);
        }

        internal static ThreatIntelligenceParsedPattern DeserializeThreatIntelligenceParsedPattern(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> patternTypeKey = default;
            Optional<IList<ThreatIntelligenceParsedPatternTypeValue>> patternTypeValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patternTypeKey"u8))
                {
                    patternTypeKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("patternTypeValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceParsedPatternTypeValue> array = new List<ThreatIntelligenceParsedPatternTypeValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceParsedPatternTypeValue.DeserializeThreatIntelligenceParsedPatternTypeValue(item));
                    }
                    patternTypeValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreatIntelligenceParsedPattern(patternTypeKey.Value, Optional.ToList(patternTypeValues), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceParsedPattern>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceParsedPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ThreatIntelligenceParsedPattern)} does not support '{options.Format}' format.");
            }
        }

        ThreatIntelligenceParsedPattern IPersistableModel<ThreatIntelligenceParsedPattern>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceParsedPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceParsedPattern(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ThreatIntelligenceParsedPattern)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceParsedPattern>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
