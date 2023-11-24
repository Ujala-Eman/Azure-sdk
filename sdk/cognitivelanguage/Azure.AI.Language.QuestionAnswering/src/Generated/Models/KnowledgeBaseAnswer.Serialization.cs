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

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class KnowledgeBaseAnswer : IUtf8JsonSerializable, IJsonModel<KnowledgeBaseAnswer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KnowledgeBaseAnswer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KnowledgeBaseAnswer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeBaseAnswer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KnowledgeBaseAnswer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Questions))
            {
                writer.WritePropertyName("questions"u8);
                writer.WriteStartArray();
                foreach (var item in Questions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Answer))
            {
                writer.WritePropertyName("answer"u8);
                writer.WriteStringValue(Answer);
            }
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidenceScore"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (Optional.IsDefined(QnaId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(QnaId.Value);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Dialog))
            {
                writer.WritePropertyName("dialog"u8);
                writer.WriteObjectValue(Dialog);
            }
            if (Optional.IsDefined(ShortAnswer))
            {
                writer.WritePropertyName("answerSpan"u8);
                writer.WriteObjectValue(ShortAnswer);
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

        KnowledgeBaseAnswer IJsonModel<KnowledgeBaseAnswer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeBaseAnswer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(KnowledgeBaseAnswer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKnowledgeBaseAnswer(document.RootElement, options);
        }

        internal static KnowledgeBaseAnswer DeserializeKnowledgeBaseAnswer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> questions = default;
            Optional<string> answer = default;
            Optional<double> confidenceScore = default;
            Optional<int> id = default;
            Optional<string> source = default;
            Optional<IReadOnlyDictionary<string, string>> metadata = default;
            Optional<KnowledgeBaseAnswerDialog> dialog = default;
            Optional<AnswerSpan> answerSpan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("questions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    questions = array;
                    continue;
                }
                if (property.NameEquals("answer"u8))
                {
                    answer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("dialog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dialog = KnowledgeBaseAnswerDialog.DeserializeKnowledgeBaseAnswerDialog(property.Value);
                    continue;
                }
                if (property.NameEquals("answerSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answerSpan = AnswerSpan.DeserializeAnswerSpan(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KnowledgeBaseAnswer(Optional.ToList(questions), answer.Value, Optional.ToNullable(confidenceScore), Optional.ToNullable(id), source.Value, Optional.ToDictionary(metadata), dialog.Value, answerSpan.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KnowledgeBaseAnswer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeBaseAnswer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(KnowledgeBaseAnswer)} does not support '{options.Format}' format.");
            }
        }

        KnowledgeBaseAnswer IPersistableModel<KnowledgeBaseAnswer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KnowledgeBaseAnswer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKnowledgeBaseAnswer(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(KnowledgeBaseAnswer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KnowledgeBaseAnswer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
