// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    internal partial class UnknownLexicalNormalizer : IUtf8JsonSerializable, IModelJsonSerializable<LexicalNormalizer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LexicalNormalizer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LexicalNormalizer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static LexicalNormalizer DeserializeUnknownLexicalNormalizer(JsonElement element, ModelSerializerOptions options = default) => DeserializeLexicalNormalizer(element, options);

        LexicalNormalizer IModelJsonSerializable<LexicalNormalizer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownLexicalNormalizer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LexicalNormalizer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LexicalNormalizer IModelSerializable<LexicalNormalizer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLexicalNormalizer(doc.RootElement, options);
        }
    }
}
