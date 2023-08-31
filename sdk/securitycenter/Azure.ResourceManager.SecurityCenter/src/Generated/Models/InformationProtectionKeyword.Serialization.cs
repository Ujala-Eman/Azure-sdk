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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class InformationProtectionKeyword : IUtf8JsonSerializable, IModelJsonSerializable<InformationProtectionKeyword>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InformationProtectionKeyword>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InformationProtectionKeyword>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Pattern))
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteBooleanValue(Custom.Value);
            }
            if (Optional.IsDefined(CanBeNumeric))
            {
                writer.WritePropertyName("canBeNumeric"u8);
                writer.WriteBooleanValue(CanBeNumeric.Value);
            }
            if (Optional.IsDefined(Excluded))
            {
                writer.WritePropertyName("excluded"u8);
                writer.WriteBooleanValue(Excluded.Value);
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

        internal static InformationProtectionKeyword DeserializeInformationProtectionKeyword(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pattern = default;
            Optional<bool> custom = default;
            Optional<bool> canBeNumeric = default;
            Optional<bool> excluded = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"u8))
                {
                    pattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("canBeNumeric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canBeNumeric = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("excluded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excluded = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InformationProtectionKeyword(pattern.Value, Optional.ToNullable(custom), Optional.ToNullable(canBeNumeric), Optional.ToNullable(excluded), rawData);
        }

        InformationProtectionKeyword IModelJsonSerializable<InformationProtectionKeyword>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInformationProtectionKeyword(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InformationProtectionKeyword>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InformationProtectionKeyword IModelSerializable<InformationProtectionKeyword>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInformationProtectionKeyword(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InformationProtectionKeyword"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InformationProtectionKeyword"/> to convert. </param>
        public static implicit operator RequestContent(InformationProtectionKeyword model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InformationProtectionKeyword"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InformationProtectionKeyword(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInformationProtectionKeyword(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
