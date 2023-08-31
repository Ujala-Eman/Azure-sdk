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
    public partial class SiteRecoveryProtectionContainerCreateOrUpdateContent : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryCreateProtectionContainerProperties>)Properties).Serialize(writer, options);
                }
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

        internal static SiteRecoveryProtectionContainerCreateOrUpdateContent DeserializeSiteRecoveryProtectionContainerCreateOrUpdateContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryCreateProtectionContainerProperties> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SiteRecoveryCreateProtectionContainerProperties.DeserializeSiteRecoveryCreateProtectionContainerProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryProtectionContainerCreateOrUpdateContent(properties.Value, rawData);
        }

        SiteRecoveryProtectionContainerCreateOrUpdateContent IModelJsonSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProtectionContainerCreateOrUpdateContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryProtectionContainerCreateOrUpdateContent IModelSerializable<SiteRecoveryProtectionContainerCreateOrUpdateContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryProtectionContainerCreateOrUpdateContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryProtectionContainerCreateOrUpdateContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryProtectionContainerCreateOrUpdateContent"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryProtectionContainerCreateOrUpdateContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryProtectionContainerCreateOrUpdateContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryProtectionContainerCreateOrUpdateContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryProtectionContainerCreateOrUpdateContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
