// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class WebChatSite : IUtf8JsonSerializable, IJsonModel<WebChatSite>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebChatSite>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<WebChatSite>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<WebChatSite>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<WebChatSite>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SiteId))
                {
                    writer.WritePropertyName("siteId"u8);
                    writer.WriteStringValue(SiteId);
                }
            }
            writer.WritePropertyName("siteName"u8);
            writer.WriteStringValue(SiteName);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Key))
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Key2))
                {
                    writer.WritePropertyName("key2"u8);
                    writer.WriteStringValue(Key2);
                }
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsTokenEnabled))
                {
                    writer.WritePropertyName("isTokenEnabled"u8);
                    writer.WriteBooleanValue(IsTokenEnabled.Value);
                }
            }
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
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        WebChatSite IJsonModel<WebChatSite>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebChatSite)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebChatSite(document.RootElement, options);
        }

        internal static WebChatSite DeserializeWebChatSite(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebChatSite(Optional.ToNullable(tenantId), siteId.Value, siteName, key.Value, key2.Value, isEnabled, Optional.ToNullable(isTokenEnabled), Optional.ToNullable(isEndpointParametersEnabled), Optional.ToNullable(isDetailedLoggingEnabled), Optional.ToNullable(isBlockUserUploadEnabled), Optional.ToNullable(isNoStorageEnabled), Optional.ToNullable(eTag), appId.Value, Optional.ToNullable(isV1Enabled), Optional.ToNullable(isV3Enabled), Optional.ToNullable(isSecureSiteEnabled), Optional.ToList(trustedOrigins), Optional.ToNullable(isWebChatSpeechEnabled), Optional.ToNullable(isWebchatPreviewEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebChatSite>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebChatSite)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WebChatSite IPersistableModel<WebChatSite>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebChatSite)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWebChatSite(document.RootElement, options);
        }

        string IPersistableModel<WebChatSite>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
