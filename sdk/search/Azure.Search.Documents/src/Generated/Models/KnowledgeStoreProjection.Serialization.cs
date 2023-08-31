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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStoreProjection : IUtf8JsonSerializable, IModelJsonSerializable<KnowledgeStoreProjection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KnowledgeStoreProjection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KnowledgeStoreProjection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tables))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KnowledgeStoreTableProjectionSelector>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Objects))
            {
                writer.WritePropertyName("objects"u8);
                writer.WriteStartArray();
                foreach (var item in Objects)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KnowledgeStoreObjectProjectionSelector>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<KnowledgeStoreFileProjectionSelector>)item).Serialize(writer, options);
                    }
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

        internal static KnowledgeStoreProjection DeserializeKnowledgeStoreProjection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<KnowledgeStoreTableProjectionSelector>> tables = default;
            Optional<IList<KnowledgeStoreObjectProjectionSelector>> objects = default;
            Optional<IList<KnowledgeStoreFileProjectionSelector>> files = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KnowledgeStoreTableProjectionSelector> array = new List<KnowledgeStoreTableProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreTableProjectionSelector.DeserializeKnowledgeStoreTableProjectionSelector(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("objects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KnowledgeStoreObjectProjectionSelector> array = new List<KnowledgeStoreObjectProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreObjectProjectionSelector.DeserializeKnowledgeStoreObjectProjectionSelector(item));
                    }
                    objects = array;
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KnowledgeStoreFileProjectionSelector> array = new List<KnowledgeStoreFileProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreFileProjectionSelector.DeserializeKnowledgeStoreFileProjectionSelector(item));
                    }
                    files = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KnowledgeStoreProjection(Optional.ToList(tables), Optional.ToList(objects), Optional.ToList(files), rawData);
        }

        KnowledgeStoreProjection IModelJsonSerializable<KnowledgeStoreProjection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKnowledgeStoreProjection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KnowledgeStoreProjection>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KnowledgeStoreProjection IModelSerializable<KnowledgeStoreProjection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKnowledgeStoreProjection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KnowledgeStoreProjection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KnowledgeStoreProjection"/> to convert. </param>
        public static implicit operator RequestContent(KnowledgeStoreProjection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KnowledgeStoreProjection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KnowledgeStoreProjection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKnowledgeStoreProjection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
