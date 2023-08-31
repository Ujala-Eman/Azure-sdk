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
    public partial class PatternReplaceCharFilter : IUtf8JsonSerializable, IModelJsonSerializable<PatternReplaceCharFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PatternReplaceCharFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PatternReplaceCharFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternReplaceCharFilter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("pattern"u8);
            writer.WriteStringValue(Pattern);
            writer.WritePropertyName("replacement"u8);
            writer.WriteStringValue(Replacement);
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

        internal static PatternReplaceCharFilter DeserializePatternReplaceCharFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string pattern = default;
            string replacement = default;
            string odataType = default;
            string name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"u8))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replacement"u8))
                {
                    replacement = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PatternReplaceCharFilter(odataType, name, pattern, replacement, rawData);
        }

        PatternReplaceCharFilter IModelJsonSerializable<PatternReplaceCharFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternReplaceCharFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePatternReplaceCharFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PatternReplaceCharFilter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternReplaceCharFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PatternReplaceCharFilter IModelSerializable<PatternReplaceCharFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternReplaceCharFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePatternReplaceCharFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PatternReplaceCharFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PatternReplaceCharFilter"/> to convert. </param>
        public static implicit operator RequestContent(PatternReplaceCharFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PatternReplaceCharFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PatternReplaceCharFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePatternReplaceCharFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
