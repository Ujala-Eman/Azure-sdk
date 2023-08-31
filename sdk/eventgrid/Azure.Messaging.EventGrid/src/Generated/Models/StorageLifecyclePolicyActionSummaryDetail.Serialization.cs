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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageLifecyclePolicyActionSummaryDetail : IUtf8JsonSerializable, IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TotalObjectsCount))
            {
                writer.WritePropertyName("totalObjectsCount"u8);
                writer.WriteNumberValue(TotalObjectsCount.Value);
            }
            if (Optional.IsDefined(SuccessCount))
            {
                writer.WritePropertyName("successCount"u8);
                writer.WriteNumberValue(SuccessCount.Value);
            }
            if (Optional.IsDefined(ErrorList))
            {
                writer.WritePropertyName("errorList"u8);
                writer.WriteStringValue(ErrorList);
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

        internal static StorageLifecyclePolicyActionSummaryDetail DeserializeStorageLifecyclePolicyActionSummaryDetail(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalObjectsCount = default;
            Optional<long> successCount = default;
            Optional<string> errorList = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalObjectsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalObjectsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("successCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errorList"u8))
                {
                    errorList = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageLifecyclePolicyActionSummaryDetail(Optional.ToNullable(totalObjectsCount), Optional.ToNullable(successCount), errorList.Value, rawData);
        }

        StorageLifecyclePolicyActionSummaryDetail IModelJsonSerializable<StorageLifecyclePolicyActionSummaryDetail>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageLifecyclePolicyActionSummaryDetail(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageLifecyclePolicyActionSummaryDetail>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageLifecyclePolicyActionSummaryDetail IModelSerializable<StorageLifecyclePolicyActionSummaryDetail>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageLifecyclePolicyActionSummaryDetail(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StorageLifecyclePolicyActionSummaryDetail model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StorageLifecyclePolicyActionSummaryDetail(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageLifecyclePolicyActionSummaryDetail(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
