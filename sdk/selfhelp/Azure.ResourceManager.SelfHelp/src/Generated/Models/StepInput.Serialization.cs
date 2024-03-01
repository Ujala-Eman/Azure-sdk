// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class StepInput : IUtf8JsonSerializable, IJsonModel<StepInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StepInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StepInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StepInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StepInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (QuestionId != null)
            {
                writer.WritePropertyName("questionId"u8);
                writer.WriteStringValue(QuestionId);
            }
            if (QuestionType != null)
            {
                writer.WritePropertyName("questionType"u8);
                writer.WriteStringValue(QuestionType);
            }
            if (QuestionContent != null)
            {
                writer.WritePropertyName("questionContent"u8);
                writer.WriteStringValue(QuestionContent);
            }
            if (QuestionContentType.HasValue)
            {
                writer.WritePropertyName("questionContentType"u8);
                writer.WriteStringValue(QuestionContentType.Value.ToString());
            }
            if (ResponseHint != null)
            {
                writer.WritePropertyName("responseHint"u8);
                writer.WriteStringValue(ResponseHint);
            }
            if (RecommendedOption != null)
            {
                writer.WritePropertyName("recommendedOption"u8);
                writer.WriteStringValue(RecommendedOption);
            }
            if (SelectedOptionValue != null)
            {
                writer.WritePropertyName("selectedOptionValue"u8);
                writer.WriteStringValue(SelectedOptionValue);
            }
            if (ResponseValidationProperties != null)
            {
                writer.WritePropertyName("responseValidationProperties"u8);
                writer.WriteObjectValue(ResponseValidationProperties);
            }
            if (!(ResponseOptions is ChangeTrackingList<ResponseConfig> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("responseOptions"u8);
                writer.WriteStartArray();
                foreach (var item in ResponseOptions)
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

        StepInput IJsonModel<StepInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StepInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StepInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStepInput(document.RootElement, options);
        }

        internal static StepInput DeserializeStepInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string questionId = default;
            string questionType = default;
            string questionContent = default;
            QuestionContentType? questionContentType = default;
            string responseHint = default;
            string recommendedOption = default;
            string selectedOptionValue = default;
            ResponseValidationProperties responseValidationProperties = default;
            IReadOnlyList<ResponseConfig> responseOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("questionId"u8))
                {
                    questionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionType"u8))
                {
                    questionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionContent"u8))
                {
                    questionContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionContentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    questionContentType = new QuestionContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("responseHint"u8))
                {
                    responseHint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedOption"u8))
                {
                    recommendedOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedOptionValue"u8))
                {
                    selectedOptionValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responseValidationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseValidationProperties = ResponseValidationProperties.DeserializeResponseValidationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("responseOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseConfig> array = new List<ResponseConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResponseConfig.DeserializeResponseConfig(item, options));
                    }
                    responseOptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StepInput(
                questionId,
                questionType,
                questionContent,
                questionContentType,
                responseHint,
                recommendedOption,
                selectedOptionValue,
                responseValidationProperties,
                responseOptions ?? new ChangeTrackingList<ResponseConfig>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StepInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StepInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StepInput)} does not support '{options.Format}' format.");
            }
        }

        StepInput IPersistableModel<StepInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StepInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStepInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StepInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StepInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
