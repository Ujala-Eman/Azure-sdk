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

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class SentimentTaskResult : IUtf8JsonSerializable, IJsonModel<SentimentTaskResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SentimentTaskResult>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SentimentTaskResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            writer.WriteObjectValue(Results);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        SentimentTaskResult IJsonModel<SentimentTaskResult>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SentimentTaskResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSentimentTaskResult(document.RootElement, options);
        }

        internal static SentimentTaskResult DeserializeSentimentTaskResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SentimentResponse results = default;
            AnalyzeTextTaskResultsKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = SentimentResponse.DeserializeSentimentResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SentimentTaskResult(kind, serializedAdditionalRawData, results);
        }

        BinaryData IModel<SentimentTaskResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SentimentTaskResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SentimentTaskResult IModel<SentimentTaskResult>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SentimentTaskResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSentimentTaskResult(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SentimentTaskResult>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
