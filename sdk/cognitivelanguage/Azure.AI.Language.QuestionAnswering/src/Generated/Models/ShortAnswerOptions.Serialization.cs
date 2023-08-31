// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class ShortAnswerOptions : IUtf8JsonSerializable, IModelJsonSerializable<ShortAnswerOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ShortAnswerOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ShortAnswerOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("enable"u8);
            writer.WriteBooleanValue(Enable);
            if (Optional.IsDefined(ConfidenceThreshold))
            {
                writer.WritePropertyName("confidenceScoreThreshold"u8);
                writer.WriteNumberValue(ConfidenceThreshold.Value);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("topAnswersWithSpan"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ShortAnswerOptions DeserializeShortAnswerOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enable = default;
            Optional<double> confidenceScoreThreshold = default;
            Optional<int> topAnswersWithSpan = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("confidenceScoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScoreThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("topAnswersWithSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topAnswersWithSpan = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ShortAnswerOptions(enable, Optional.ToNullable(confidenceScoreThreshold), Optional.ToNullable(topAnswersWithSpan), rawData);
        }

        ShortAnswerOptions IModelJsonSerializable<ShortAnswerOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeShortAnswerOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ShortAnswerOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ShortAnswerOptions IModelSerializable<ShortAnswerOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeShortAnswerOptions(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ShortAnswerOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ShortAnswerOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeShortAnswerOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
