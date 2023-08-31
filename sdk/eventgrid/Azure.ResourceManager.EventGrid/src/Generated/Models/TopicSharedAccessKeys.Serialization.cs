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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class TopicSharedAccessKeys : IUtf8JsonSerializable, IModelJsonSerializable<TopicSharedAccessKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TopicSharedAccessKeys>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TopicSharedAccessKeys>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Key1))
            {
                writer.WritePropertyName("key1"u8);
                writer.WriteStringValue(Key1);
            }
            if (Optional.IsDefined(Key2))
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(Key2);
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

        internal static TopicSharedAccessKeys DeserializeTopicSharedAccessKeys(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key1 = default;
            Optional<string> key2 = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TopicSharedAccessKeys(key1.Value, key2.Value, rawData);
        }

        TopicSharedAccessKeys IModelJsonSerializable<TopicSharedAccessKeys>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTopicSharedAccessKeys(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TopicSharedAccessKeys>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TopicSharedAccessKeys IModelSerializable<TopicSharedAccessKeys>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTopicSharedAccessKeys(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TopicSharedAccessKeys model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TopicSharedAccessKeys(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTopicSharedAccessKeys(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
