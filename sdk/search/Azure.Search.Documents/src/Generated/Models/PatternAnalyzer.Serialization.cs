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
    public partial class PatternAnalyzer : IUtf8JsonSerializable, IModelJsonSerializable<PatternAnalyzer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PatternAnalyzer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PatternAnalyzer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternAnalyzer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LowerCaseTerms))
            {
                writer.WritePropertyName("lowercase"u8);
                writer.WriteBooleanValue(LowerCaseTerms.Value);
            }
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(FlagsInternal))
            {
                writer.WritePropertyName("flags"u8);
                writer.WriteStringValue(FlagsInternal);
            }
            if (Optional.IsCollectionDefined(Stopwords))
            {
                writer.WritePropertyName("stopwords"u8);
                writer.WriteStartArray();
                foreach (var item in Stopwords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        internal static PatternAnalyzer DeserializePatternAnalyzer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> lowercase = default;
            Optional<string> pattern = default;
            Optional<string> flags = default;
            Optional<IList<string>> stopwords = default;
            string odataType = default;
            string name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lowercase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowercase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pattern"u8))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flags"u8))
                {
                    flags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stopwords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    stopwords = array;
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
            return new PatternAnalyzer(odataType, name, Optional.ToNullable(lowercase), pattern.Value, flags.Value, Optional.ToList(stopwords), rawData);
        }

        PatternAnalyzer IModelJsonSerializable<PatternAnalyzer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternAnalyzer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePatternAnalyzer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PatternAnalyzer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternAnalyzer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PatternAnalyzer IModelSerializable<PatternAnalyzer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PatternAnalyzer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePatternAnalyzer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PatternAnalyzer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PatternAnalyzer"/> to convert. </param>
        public static implicit operator RequestContent(PatternAnalyzer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PatternAnalyzer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PatternAnalyzer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePatternAnalyzer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
