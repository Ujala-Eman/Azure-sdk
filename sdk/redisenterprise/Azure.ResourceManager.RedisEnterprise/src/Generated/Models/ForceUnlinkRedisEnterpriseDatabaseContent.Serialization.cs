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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class ForceUnlinkRedisEnterpriseDatabaseContent : IUtf8JsonSerializable, IModelJsonSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("ids"u8);
            writer.WriteStartArray();
            foreach (var item in Ids)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        internal static ForceUnlinkRedisEnterpriseDatabaseContent DeserializeForceUnlinkRedisEnterpriseDatabaseContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> ids = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ids"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ids = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ForceUnlinkRedisEnterpriseDatabaseContent(ids, rawData);
        }

        ForceUnlinkRedisEnterpriseDatabaseContent IModelJsonSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeForceUnlinkRedisEnterpriseDatabaseContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ForceUnlinkRedisEnterpriseDatabaseContent IModelSerializable<ForceUnlinkRedisEnterpriseDatabaseContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeForceUnlinkRedisEnterpriseDatabaseContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ForceUnlinkRedisEnterpriseDatabaseContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ForceUnlinkRedisEnterpriseDatabaseContent"/> to convert. </param>
        public static implicit operator RequestContent(ForceUnlinkRedisEnterpriseDatabaseContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ForceUnlinkRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ForceUnlinkRedisEnterpriseDatabaseContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeForceUnlinkRedisEnterpriseDatabaseContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
