// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppLoginInfo : IUtf8JsonSerializable, IJsonModel<WebAppLoginInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppLoginInfo>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WebAppLoginInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteObjectValue(Routes);
            }
            if (Optional.IsDefined(TokenStore))
            {
                writer.WritePropertyName("tokenStore"u8);
                writer.WriteObjectValue(TokenStore);
            }
            if (Optional.IsDefined(PreserveUrlFragmentsForLogins))
            {
                writer.WritePropertyName("preserveUrlFragmentsForLogins"u8);
                writer.WriteBooleanValue(PreserveUrlFragmentsForLogins.Value);
            }
            if (Optional.IsCollectionDefined(AllowedExternalRedirectUrls))
            {
                writer.WritePropertyName("allowedExternalRedirectUrls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedExternalRedirectUrls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CookieExpiration))
            {
                writer.WritePropertyName("cookieExpiration"u8);
                writer.WriteObjectValue(CookieExpiration);
            }
            if (Optional.IsDefined(Nonce))
            {
                writer.WritePropertyName("nonce"u8);
                writer.WriteObjectValue(Nonce);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        WebAppLoginInfo IJsonModel<WebAppLoginInfo>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppLoginInfo(document.RootElement, options);
        }

        internal static WebAppLoginInfo DeserializeWebAppLoginInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LoginRoutes> routes = default;
            Optional<AppServiceTokenStore> tokenStore = default;
            Optional<bool> preserveUrlFragmentsForLogins = default;
            Optional<IList<string>> allowedExternalRedirectUrls = default;
            Optional<WebAppCookieExpiration> cookieExpiration = default;
            Optional<LoginFlowNonceSettings> nonce = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routes = LoginRoutes.DeserializeLoginRoutes(property.Value);
                    continue;
                }
                if (property.NameEquals("tokenStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tokenStore = AppServiceTokenStore.DeserializeAppServiceTokenStore(property.Value);
                    continue;
                }
                if (property.NameEquals("preserveUrlFragmentsForLogins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUrlFragmentsForLogins = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedExternalRedirectUrls"u8))
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
                    allowedExternalRedirectUrls = array;
                    continue;
                }
                if (property.NameEquals("cookieExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cookieExpiration = WebAppCookieExpiration.DeserializeWebAppCookieExpiration(property.Value);
                    continue;
                }
                if (property.NameEquals("nonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonce = LoginFlowNonceSettings.DeserializeLoginFlowNonceSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppLoginInfo(routes.Value, tokenStore.Value, Optional.ToNullable(preserveUrlFragmentsForLogins), Optional.ToList(allowedExternalRedirectUrls), cookieExpiration.Value, nonce.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<WebAppLoginInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WebAppLoginInfo IModel<WebAppLoginInfo>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebAppLoginInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWebAppLoginInfo(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WebAppLoginInfo>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
