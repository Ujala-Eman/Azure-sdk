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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryApplyRecoveryPointContent : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryApplyRecoveryPointContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryApplyRecoveryPointContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryApplyRecoveryPointContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SiteRecoveryApplyRecoveryPointProperties>)Properties).Serialize(writer, options);
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

        internal static SiteRecoveryApplyRecoveryPointContent DeserializeSiteRecoveryApplyRecoveryPointContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SiteRecoveryApplyRecoveryPointProperties properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = SiteRecoveryApplyRecoveryPointProperties.DeserializeSiteRecoveryApplyRecoveryPointProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryApplyRecoveryPointContent(properties, rawData);
        }

        SiteRecoveryApplyRecoveryPointContent IModelJsonSerializable<SiteRecoveryApplyRecoveryPointContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryApplyRecoveryPointContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryApplyRecoveryPointContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryApplyRecoveryPointContent IModelSerializable<SiteRecoveryApplyRecoveryPointContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryApplyRecoveryPointContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryApplyRecoveryPointContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryApplyRecoveryPointContent"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryApplyRecoveryPointContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryApplyRecoveryPointContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryApplyRecoveryPointContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryApplyRecoveryPointContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
