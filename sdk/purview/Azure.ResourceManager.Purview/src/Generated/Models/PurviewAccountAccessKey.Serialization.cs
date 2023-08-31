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

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountAccessKey : IUtf8JsonSerializable, IModelJsonSerializable<PurviewAccountAccessKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PurviewAccountAccessKey>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PurviewAccountAccessKey>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AtlasKafkaPrimaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaPrimaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaPrimaryEndpoint);
            }
            if (Optional.IsDefined(AtlasKafkaSecondaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaSecondaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaSecondaryEndpoint);
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

        internal static PurviewAccountAccessKey DeserializePurviewAccountAccessKey(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> atlasKafkaPrimaryEndpoint = default;
            Optional<string> atlasKafkaSecondaryEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("atlasKafkaPrimaryEndpoint"u8))
                {
                    atlasKafkaPrimaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("atlasKafkaSecondaryEndpoint"u8))
                {
                    atlasKafkaSecondaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PurviewAccountAccessKey(atlasKafkaPrimaryEndpoint.Value, atlasKafkaSecondaryEndpoint.Value, rawData);
        }

        PurviewAccountAccessKey IModelJsonSerializable<PurviewAccountAccessKey>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewAccountAccessKey(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PurviewAccountAccessKey>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PurviewAccountAccessKey IModelSerializable<PurviewAccountAccessKey>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePurviewAccountAccessKey(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PurviewAccountAccessKey"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PurviewAccountAccessKey"/> to convert. </param>
        public static implicit operator RequestContent(PurviewAccountAccessKey model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PurviewAccountAccessKey"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PurviewAccountAccessKey(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePurviewAccountAccessKey(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
