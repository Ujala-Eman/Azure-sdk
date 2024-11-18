// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    public partial class EvaluationSummary : IUtf8JsonSerializable, IJsonModel<EvaluationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EvaluationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EvaluationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluationSummary)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("entitiesEvaluation"u8);
            writer.WriteObjectValue(EntitiesEvaluation, options);
            writer.WritePropertyName("intentsEvaluation"u8);
            writer.WriteObjectValue(IntentsEvaluation, options);
            if (Optional.IsDefined(EvaluationOptions))
            {
                writer.WritePropertyName("evaluationOptions"u8);
                writer.WriteObjectValue(EvaluationOptions, options);
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

        EvaluationSummary IJsonModel<EvaluationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEvaluationSummary(document.RootElement, options);
        }

        internal static EvaluationSummary DeserializeEvaluationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntitiesEvaluationSummary entitiesEvaluation = default;
            IntentsEvaluationSummary intentsEvaluation = default;
            EvaluationConfig evaluationOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entitiesEvaluation"u8))
                {
                    entitiesEvaluation = EntitiesEvaluationSummary.DeserializeEntitiesEvaluationSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("intentsEvaluation"u8))
                {
                    intentsEvaluation = IntentsEvaluationSummary.DeserializeIntentsEvaluationSummary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("evaluationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationOptions = EvaluationConfig.DeserializeEvaluationConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EvaluationSummary(entitiesEvaluation, intentsEvaluation, evaluationOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EvaluationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EvaluationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        EvaluationSummary IPersistableModel<EvaluationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEvaluationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EvaluationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EvaluationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EvaluationSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEvaluationSummary(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
