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
    public partial class SamplingOptions : IUtf8JsonSerializable, IJsonModel<SamplingOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SamplingOptions>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SamplingOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SkipSamplesWithoutAnnotation))
            {
                writer.WritePropertyName("skipSamplesWithoutAnnotation"u8);
                writer.WriteStringValue(SkipSamplesWithoutAnnotation);
            }
            if (Optional.IsDefined(MaximumSamplesPerSecond))
            {
                writer.WritePropertyName("maximumSamplesPerSecond"u8);
                writer.WriteStringValue(MaximumSamplesPerSecond);
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

        SamplingOptions IJsonModel<SamplingOptions>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SamplingOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSamplingOptions(document.RootElement, options);
        }

        internal static SamplingOptions DeserializeSamplingOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> skipSamplesWithoutAnnotation = default;
            Optional<string> maximumSamplesPerSecond = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipSamplesWithoutAnnotation"u8))
                {
                    skipSamplesWithoutAnnotation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumSamplesPerSecond"u8))
                {
                    maximumSamplesPerSecond = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SamplingOptions(skipSamplesWithoutAnnotation.Value, maximumSamplesPerSecond.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SamplingOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SamplingOptions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SamplingOptions IModel<SamplingOptions>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SamplingOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSamplingOptions(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SamplingOptions>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
