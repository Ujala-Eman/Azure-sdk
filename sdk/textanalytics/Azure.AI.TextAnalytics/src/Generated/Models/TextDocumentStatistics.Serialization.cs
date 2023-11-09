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

namespace Azure.AI.TextAnalytics
{
    public partial struct TextDocumentStatistics : IUtf8JsonSerializable, IJsonModel<TextDocumentStatistics>, IJsonModel<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextDocumentStatistics>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<TextDocumentStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("charactersCount"u8);
            writer.WriteNumberValue(CharacterCount);
            writer.WritePropertyName("transactionsCount"u8);
            writer.WriteNumberValue(TransactionCount);
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

        TextDocumentStatistics IJsonModel<TextDocumentStatistics>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextDocumentStatistics(document.RootElement, options);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TextDocumentStatistics>)this).Write(writer, options);

        object IJsonModel<object>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TextDocumentStatistics>)this).Read(ref reader, options);

        internal static TextDocumentStatistics DeserializeTextDocumentStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            int charactersCount = default;
            int transactionsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("charactersCount"u8))
                {
                    charactersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TextDocumentStatistics(charactersCount, transactionsCount, serializedAdditionalRawData);
        }

        BinaryData IModel<TextDocumentStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentStatistics)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TextDocumentStatistics IModel<TextDocumentStatistics>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTextDocumentStatistics(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<TextDocumentStatistics>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        BinaryData IModel<object>.Write(ModelReaderWriterOptions options) => ((IModel<TextDocumentStatistics>)this).Write(options);

        object IModel<object>.Read(BinaryData data, ModelReaderWriterOptions options) => ((IModel<TextDocumentStatistics>)this).Read(data, options);

        ModelReaderWriterFormat IModel<object>.GetWireFormat(ModelReaderWriterOptions options) => ((IModel<TextDocumentStatistics>)this).GetWireFormat(options);
    }
}
