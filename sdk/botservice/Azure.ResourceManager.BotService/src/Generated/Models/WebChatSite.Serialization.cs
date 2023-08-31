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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class WebChatSite : IUtf8JsonSerializable, IModelJsonSerializable<WebChatSite>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebChatSite>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebChatSite>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WebChatSite>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WritePropertyName("siteName"u8);
            writer.WriteStringValue(SiteName);
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(IsEndpointParametersEnabled))
            {
                writer.WritePropertyName("isEndpointParametersEnabled"u8);
                writer.WriteBooleanValue(IsEndpointParametersEnabled.Value);
            }
            if (Optional.IsDefined(IsDetailedLoggingEnabled))
            {
                writer.WritePropertyName("isDetailedLoggingEnabled"u8);
                writer.WriteBooleanValue(IsDetailedLoggingEnabled.Value);
            }
            if (Optional.IsDefined(IsBlockUserUploadEnabled))
            {
                if (IsBlockUserUploadEnabled != null)
                {
                    writer.WritePropertyName("isBlockUserUploadEnabled"u8);
                    writer.WriteBooleanValue(IsBlockUserUploadEnabled.Value);
                }
                else
                {
                    writer.WriteNull("isBlockUserUploadEnabled");
                }
            }
            if (Optional.IsDefined(IsNoStorageEnabled))
            {
                writer.WritePropertyName("isNoStorageEnabled"u8);
                writer.WriteBooleanValue(IsNoStorageEnabled.Value);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(IsV1Enabled))
            {
                writer.WritePropertyName("isV1Enabled"u8);
                writer.WriteBooleanValue(IsV1Enabled.Value);
            }
            if (Optional.IsDefined(IsV3Enabled))
            {
                writer.WritePropertyName("isV3Enabled"u8);
                writer.WriteBooleanValue(IsV3Enabled.Value);
            }
            if (Optional.IsDefined(IsSecureSiteEnabled))
            {
                writer.WritePropertyName("isSecureSiteEnabled"u8);
                writer.WriteBooleanValue(IsSecureSiteEnabled.Value);
            }
            if (Optional.IsCollectionDefined(TrustedOrigins))
            {
                writer.WritePropertyName("trustedOrigins"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedOrigins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsWebChatSpeechEnabled))
            {
                writer.WritePropertyName("isWebChatSpeechEnabled"u8);
                writer.WriteBooleanValue(IsWebChatSpeechEnabled.Value);
            }
            if (Optional.IsDefined(IsWebchatPreviewEnabled))
            {
                writer.WritePropertyName("isWebchatPreviewEnabled"u8);
                writer.WriteBooleanValue(IsWebchatPreviewEnabled.Value);
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

        internal static WebChatSite DeserializeWebChatSite(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> tenantId = default;
            Optional<string> siteId = default;
            string siteName = default;
            Optional<string> key = default;
            Optional<string> key2 = default;
            bool isEnabled = default;
            Optional<bool> isTokenEnabled = default;
            Optional<bool> isEndpointParametersEnabled = default;
            Optional<bool> isDetailedLoggingEnabled = default;
            Optional<bool?> isBlockUserUploadEnabled = default;
            Optional<bool> isNoStorageEnabled = default;
            Optional<ETag> eTag = default;
            Optional<string> appId = default;
            Optional<bool> isV1Enabled = default;
            Optional<bool> isV3Enabled = default;
            Optional<bool> isSecureSiteEnabled = default;
            Optional<IList<string>> trustedOrigins = default;
            Optional<bool> isWebChatSpeechEnabled = default;
            Optional<bool> isWebchatPreviewEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("siteId"u8))
                {
                    siteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTokenEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTokenEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEndpointParametersEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEndpointParametersEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDetailedLoggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDetailedLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBlockUserUploadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isBlockUserUploadEnabled = null;
                        continue;
                    }
                    isBlockUserUploadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNoStorageEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNoStorageEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isV1Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV1Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isV3Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV3Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSecureSiteEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSecureSiteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trustedOrigins"u8))
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
                    trustedOrigins = array;
                    continue;
                }
                if (property.NameEquals("isWebChatSpeechEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebChatSpeechEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isWebchatPreviewEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebchatPreviewEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebChatSite(Optional.ToNullable(tenantId), siteId.Value, siteName, key.Value, key2.Value, isEnabled, Optional.ToNullable(isTokenEnabled), Optional.ToNullable(isEndpointParametersEnabled), Optional.ToNullable(isDetailedLoggingEnabled), Optional.ToNullable(isBlockUserUploadEnabled), Optional.ToNullable(isNoStorageEnabled), Optional.ToNullable(eTag), appId.Value, Optional.ToNullable(isV1Enabled), Optional.ToNullable(isV3Enabled), Optional.ToNullable(isSecureSiteEnabled), Optional.ToList(trustedOrigins), Optional.ToNullable(isWebChatSpeechEnabled), Optional.ToNullable(isWebchatPreviewEnabled), rawData);
        }

        WebChatSite IModelJsonSerializable<WebChatSite>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WebChatSite>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebChatSite(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebChatSite>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WebChatSite>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebChatSite IModelSerializable<WebChatSite>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WebChatSite>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebChatSite(doc.RootElement, options);
        }

        public static implicit operator RequestContent(WebChatSite model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator WebChatSite(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebChatSite(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
