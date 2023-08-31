// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Resources.Models
{
    [JsonConverter(typeof(ExtendedLocationConverter))]
    public partial class ExtendedLocation : IUtf8JsonSerializable, IModelJsonSerializable<ExtendedLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExtendedLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExtendedLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExtendedLocationType.Value.ToString());
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static ExtendedLocation DeserializeExtendedLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocationType> type = default;
            Optional<string> name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ExtendedLocationType(property.Value.GetString());
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
            return new ExtendedLocation(Optional.ToNullable(type), name.Value, rawData);
        }

        ExtendedLocation IModelJsonSerializable<ExtendedLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExtendedLocation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExtendedLocation IModelSerializable<ExtendedLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExtendedLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExtendedLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExtendedLocation"/> to convert. </param>
        public static implicit operator RequestContent(ExtendedLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExtendedLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExtendedLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExtendedLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ExtendedLocationConverter : JsonConverter<ExtendedLocation>
        {
            public override void Write(Utf8JsonWriter writer, ExtendedLocation model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExtendedLocation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExtendedLocation(document.RootElement);
            }
        }
    }
}
