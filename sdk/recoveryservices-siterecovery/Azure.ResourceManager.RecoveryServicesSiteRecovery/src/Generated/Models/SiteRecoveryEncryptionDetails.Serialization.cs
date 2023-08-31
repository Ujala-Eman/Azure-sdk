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
    public partial class SiteRecoveryEncryptionDetails : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryEncryptionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryEncryptionDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryEncryptionDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KekState))
            {
                writer.WritePropertyName("kekState"u8);
                writer.WriteStringValue(KekState);
            }
            if (Optional.IsDefined(KekCertThumbprint))
            {
                writer.WritePropertyName("kekCertThumbprint"u8);
                writer.WriteStringValue(KekCertThumbprint);
            }
            if (Optional.IsDefined(KekCertExpireOn))
            {
                writer.WritePropertyName("kekCertExpiryDate"u8);
                writer.WriteStringValue(KekCertExpireOn.Value, "O");
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

        internal static SiteRecoveryEncryptionDetails DeserializeSiteRecoveryEncryptionDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kekState = default;
            Optional<string> kekCertThumbprint = default;
            Optional<DateTimeOffset> kekCertExpireOn = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kekState"u8))
                {
                    kekState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekCertThumbprint"u8))
                {
                    kekCertThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kekCertExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekCertExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryEncryptionDetails(kekState.Value, kekCertThumbprint.Value, Optional.ToNullable(kekCertExpireOn), rawData);
        }

        SiteRecoveryEncryptionDetails IModelJsonSerializable<SiteRecoveryEncryptionDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryEncryptionDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryEncryptionDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryEncryptionDetails IModelSerializable<SiteRecoveryEncryptionDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryEncryptionDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryEncryptionDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryEncryptionDetails"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryEncryptionDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryEncryptionDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryEncryptionDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryEncryptionDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
