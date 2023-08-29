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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RangeBasedItemLevelRestoreCriteria : IUtf8JsonSerializable, IModelJsonSerializable<RangeBasedItemLevelRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RangeBasedItemLevelRestoreCriteria>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RangeBasedItemLevelRestoreCriteria>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RangeBasedItemLevelRestoreCriteria>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MinMatchingValue))
            {
                writer.WritePropertyName("minMatchingValue"u8);
                writer.WriteStringValue(MinMatchingValue);
            }
            if (Optional.IsDefined(MaxMatchingValue))
            {
                writer.WritePropertyName("maxMatchingValue"u8);
                writer.WriteStringValue(MaxMatchingValue);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static RangeBasedItemLevelRestoreCriteria DeserializeRangeBasedItemLevelRestoreCriteria(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> minMatchingValue = default;
            Optional<string> maxMatchingValue = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minMatchingValue"u8))
                {
                    minMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxMatchingValue"u8))
                {
                    maxMatchingValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RangeBasedItemLevelRestoreCriteria(objectType, minMatchingValue.Value, maxMatchingValue.Value, rawData);
        }

        RangeBasedItemLevelRestoreCriteria IModelJsonSerializable<RangeBasedItemLevelRestoreCriteria>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RangeBasedItemLevelRestoreCriteria>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRangeBasedItemLevelRestoreCriteria(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RangeBasedItemLevelRestoreCriteria>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RangeBasedItemLevelRestoreCriteria>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RangeBasedItemLevelRestoreCriteria IModelSerializable<RangeBasedItemLevelRestoreCriteria>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RangeBasedItemLevelRestoreCriteria>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRangeBasedItemLevelRestoreCriteria(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RangeBasedItemLevelRestoreCriteria model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RangeBasedItemLevelRestoreCriteria(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRangeBasedItemLevelRestoreCriteria(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
