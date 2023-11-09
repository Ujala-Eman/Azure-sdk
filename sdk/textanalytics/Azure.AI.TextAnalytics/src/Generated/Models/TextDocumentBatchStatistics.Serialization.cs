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
    public partial class TextDocumentBatchStatistics : IUtf8JsonSerializable, IJsonModel<TextDocumentBatchStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextDocumentBatchStatistics>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<TextDocumentBatchStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("documentsCount"u8);
            writer.WriteNumberValue(DocumentCount);
            writer.WritePropertyName("validDocumentsCount"u8);
            writer.WriteNumberValue(ValidDocumentCount);
            writer.WritePropertyName("erroneousDocumentsCount"u8);
            writer.WriteNumberValue(InvalidDocumentCount);
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

        TextDocumentBatchStatistics IJsonModel<TextDocumentBatchStatistics>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentBatchStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextDocumentBatchStatistics(document.RootElement, options);
        }

        internal static TextDocumentBatchStatistics DeserializeTextDocumentBatchStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int documentsCount = default;
            int validDocumentsCount = default;
            int erroneousDocumentsCount = default;
            long transactionsCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentsCount"u8))
                {
                    documentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("validDocumentsCount"u8))
                {
                    validDocumentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("erroneousDocumentsCount"u8))
                {
                    erroneousDocumentsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TextDocumentBatchStatistics(documentsCount, validDocumentsCount, erroneousDocumentsCount, transactionsCount, serializedAdditionalRawData);
        }

        BinaryData IModel<TextDocumentBatchStatistics>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentBatchStatistics)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TextDocumentBatchStatistics IModel<TextDocumentBatchStatistics>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TextDocumentBatchStatistics)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTextDocumentBatchStatistics(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<TextDocumentBatchStatistics>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
