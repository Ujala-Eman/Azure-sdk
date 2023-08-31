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
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class VectorSearchAlgorithmConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<VectorSearchAlgorithmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VectorSearchAlgorithmConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VectorSearchAlgorithmConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        internal static VectorSearchAlgorithmConfiguration DeserializeVectorSearchAlgorithmConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "hnsw": return HnswVectorSearchAlgorithmConfiguration.DeserializeHnswVectorSearchAlgorithmConfiguration(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string name = default;
            string kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownVectorSearchAlgorithmConfiguration(name, kind, rawData);
        }

        VectorSearchAlgorithmConfiguration IModelJsonSerializable<VectorSearchAlgorithmConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorSearchAlgorithmConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VectorSearchAlgorithmConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VectorSearchAlgorithmConfiguration IModelSerializable<VectorSearchAlgorithmConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVectorSearchAlgorithmConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VectorSearchAlgorithmConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VectorSearchAlgorithmConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(VectorSearchAlgorithmConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VectorSearchAlgorithmConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VectorSearchAlgorithmConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVectorSearchAlgorithmConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
