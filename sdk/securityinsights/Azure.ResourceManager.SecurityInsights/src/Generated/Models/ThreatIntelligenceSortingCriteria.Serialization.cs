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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceSortingCriteria : IUtf8JsonSerializable, IModelJsonSerializable<ThreatIntelligenceSortingCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ThreatIntelligenceSortingCriteria>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ThreatIntelligenceSortingCriteria>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ItemKey))
            {
                writer.WritePropertyName("itemKey"u8);
                writer.WriteStringValue(ItemKey);
            }
            if (Optional.IsDefined(SortOrder))
            {
                writer.WritePropertyName("sortOrder"u8);
                writer.WriteStringValue(SortOrder.Value.ToString());
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

        internal static ThreatIntelligenceSortingCriteria DeserializeThreatIntelligenceSortingCriteria(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> itemKey = default;
            Optional<ThreatIntelligenceSortingOrder> sortOrder = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("itemKey"u8))
                {
                    itemKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sortOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sortOrder = new ThreatIntelligenceSortingOrder(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ThreatIntelligenceSortingCriteria(itemKey.Value, Optional.ToNullable(sortOrder), rawData);
        }

        ThreatIntelligenceSortingCriteria IModelJsonSerializable<ThreatIntelligenceSortingCriteria>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceSortingCriteria(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ThreatIntelligenceSortingCriteria>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ThreatIntelligenceSortingCriteria IModelSerializable<ThreatIntelligenceSortingCriteria>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeThreatIntelligenceSortingCriteria(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ThreatIntelligenceSortingCriteria"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ThreatIntelligenceSortingCriteria"/> to convert. </param>
        public static implicit operator RequestContent(ThreatIntelligenceSortingCriteria model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ThreatIntelligenceSortingCriteria"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ThreatIntelligenceSortingCriteria(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeThreatIntelligenceSortingCriteria(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
