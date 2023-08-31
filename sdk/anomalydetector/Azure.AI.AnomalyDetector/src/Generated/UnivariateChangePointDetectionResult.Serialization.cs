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

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateChangePointDetectionResult : IUtf8JsonSerializable, IModelJsonSerializable<UnivariateChangePointDetectionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UnivariateChangePointDetectionResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UnivariateChangePointDetectionResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IsChangePoint))
            {
                writer.WritePropertyName("isChangePoint"u8);
                writer.WriteStartArray();
                foreach (var item in IsChangePoint)
                {
                    writer.WriteBooleanValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConfidenceScores))
            {
                writer.WritePropertyName("confidenceScores"u8);
                writer.WriteStartArray();
                foreach (var item in ConfidenceScores)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        internal static UnivariateChangePointDetectionResult DeserializeUnivariateChangePointDetectionResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> period = default;
            Optional<IReadOnlyList<bool>> isChangePoint = default;
            Optional<IReadOnlyList<float>> confidenceScores = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isChangePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<bool> array = new List<bool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBoolean());
                    }
                    isChangePoint = array;
                    continue;
                }
                if (property.NameEquals("confidenceScores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    confidenceScores = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnivariateChangePointDetectionResult(Optional.ToNullable(period), Optional.ToList(isChangePoint), Optional.ToList(confidenceScores), rawData);
        }

        UnivariateChangePointDetectionResult IModelJsonSerializable<UnivariateChangePointDetectionResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnivariateChangePointDetectionResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UnivariateChangePointDetectionResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UnivariateChangePointDetectionResult IModelSerializable<UnivariateChangePointDetectionResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUnivariateChangePointDetectionResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(UnivariateChangePointDetectionResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator UnivariateChangePointDetectionResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUnivariateChangePointDetectionResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
