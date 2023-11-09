// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonCountEvent : IUtf8JsonSerializable, IJsonModel<SpatialAnalysisPersonCountEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpatialAnalysisPersonCountEvent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SpatialAnalysisPersonCountEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Trigger))
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger.Value.ToString());
            }
            if (Optional.IsDefined(OutputFrequency))
            {
                writer.WritePropertyName("outputFrequency"u8);
                writer.WriteStringValue(OutputFrequency);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteStringValue(Threshold);
            }
            if (Optional.IsDefined(Focus))
            {
                writer.WritePropertyName("focus"u8);
                writer.WriteStringValue(Focus.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SpatialAnalysisPersonCountEvent IJsonModel<SpatialAnalysisPersonCountEvent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SpatialAnalysisPersonCountEvent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpatialAnalysisPersonCountEvent(document.RootElement, options);
        }

        internal static SpatialAnalysisPersonCountEvent DeserializeSpatialAnalysisPersonCountEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SpatialAnalysisPersonCountEventTrigger> trigger = default;
            Optional<string> outputFrequency = default;
            Optional<string> threshold = default;
            Optional<SpatialAnalysisOperationFocus> focus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trigger = new SpatialAnalysisPersonCountEventTrigger(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputFrequency"u8))
                {
                    outputFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("focus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    focus = new SpatialAnalysisOperationFocus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SpatialAnalysisPersonCountEvent(threshold.Value, Optional.ToNullable(focus), serializedAdditionalRawData, Optional.ToNullable(trigger), outputFrequency.Value);
        }

        BinaryData IModel<SpatialAnalysisPersonCountEvent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SpatialAnalysisPersonCountEvent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SpatialAnalysisPersonCountEvent IModel<SpatialAnalysisPersonCountEvent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SpatialAnalysisPersonCountEvent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSpatialAnalysisPersonCountEvent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SpatialAnalysisPersonCountEvent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
