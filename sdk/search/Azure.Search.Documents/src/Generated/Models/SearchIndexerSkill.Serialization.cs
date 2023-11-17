// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerSkill : IUtf8JsonSerializable, IJsonModel<SearchIndexerSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchIndexerSkill>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchIndexerSkill>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SearchIndexerSkill>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SearchIndexerSkill>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SearchIndexerSkill IJsonModel<SearchIndexerSkill>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexerSkill(document.RootElement, options);
        }

        internal static SearchIndexerSkill DeserializeSearchIndexerSkill(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Skills.Custom.WebApiSkill": return WebApiSkill.DeserializeWebApiSkill(element);
                    case "#Microsoft.Skills.Text.CustomEntityLookupSkill": return CustomEntityLookupSkill.DeserializeCustomEntityLookupSkill(element);
                    case "#Microsoft.Skills.Text.EntityRecognitionSkill": return EntityRecognitionSkill.DeserializeEntityRecognitionSkill(element);
                    case "#Microsoft.Skills.Text.KeyPhraseExtractionSkill": return KeyPhraseExtractionSkill.DeserializeKeyPhraseExtractionSkill(element);
                    case "#Microsoft.Skills.Text.LanguageDetectionSkill": return LanguageDetectionSkill.DeserializeLanguageDetectionSkill(element);
                    case "#Microsoft.Skills.Text.MergeSkill": return MergeSkill.DeserializeMergeSkill(element);
                    case "#Microsoft.Skills.Text.PIIDetectionSkill": return PiiDetectionSkill.DeserializePiiDetectionSkill(element);
                    case "#Microsoft.Skills.Text.SentimentSkill": return SentimentSkill.DeserializeSentimentSkill(element);
                    case "#Microsoft.Skills.Text.SplitSkill": return SplitSkill.DeserializeSplitSkill(element);
                    case "#Microsoft.Skills.Text.TranslationSkill": return TextTranslationSkill.DeserializeTextTranslationSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityLinkingSkill": return EntityLinkingSkill.DeserializeEntityLinkingSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityRecognitionSkill": return EntityRecognitionSkillV3.DeserializeEntityRecognitionSkillV3(element);
                    case "#Microsoft.Skills.Text.V3.SentimentSkill": return SentimentSkillV3.DeserializeSentimentSkillV3(element);
                    case "#Microsoft.Skills.Util.ConditionalSkill": return ConditionalSkill.DeserializeConditionalSkill(element);
                    case "#Microsoft.Skills.Util.DocumentExtractionSkill": return DocumentExtractionSkill.DeserializeDocumentExtractionSkill(element);
                    case "#Microsoft.Skills.Util.ShaperSkill": return ShaperSkill.DeserializeShaperSkill(element);
                    case "#Microsoft.Skills.Vision.ImageAnalysisSkill": return ImageAnalysisSkill.DeserializeImageAnalysisSkill(element);
                    case "#Microsoft.Skills.Vision.OcrSkill": return OcrSkill.DeserializeOcrSkill(element);
                }
            }
            return UnknownSearchIndexerSkill.DeserializeUnknownSearchIndexerSkill(element);
        }

        BinaryData IPersistableModel<SearchIndexerSkill>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerSkill)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SearchIndexerSkill IPersistableModel<SearchIndexerSkill>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SearchIndexerSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSearchIndexerSkill(document.RootElement, options);
        }

        string IPersistableModel<SearchIndexerSkill>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
