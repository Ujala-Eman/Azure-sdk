// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class ServicePrincipalCertificateAuthInfo : IUtf8JsonSerializable, IJsonModel<ServicePrincipalCertificateAuthInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServicePrincipalCertificateAuthInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServicePrincipalCertificateAuthInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalCertificateAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServicePrincipalCertificateAuthInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            writer.WritePropertyName("certificate"u8);
            writer.WriteStringValue(Certificate);
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        ServicePrincipalCertificateAuthInfo IJsonModel<ServicePrincipalCertificateAuthInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalCertificateAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServicePrincipalCertificateAuthInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePrincipalCertificateAuthInfo(document.RootElement, options);
        }

        internal static ServicePrincipalCertificateAuthInfo DeserializeServicePrincipalCertificateAuthInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            Guid principalId = default;
            string certificate = default;
            LinkerAuthType authType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new LinkerAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServicePrincipalCertificateAuthInfo(authType, serializedAdditionalRawData, clientId, principalId, certificate);
        }

        BinaryData IPersistableModel<ServicePrincipalCertificateAuthInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalCertificateAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ServicePrincipalCertificateAuthInfo)} does not support '{options.Format}' format.");
            }
        }

        ServicePrincipalCertificateAuthInfo IPersistableModel<ServicePrincipalCertificateAuthInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServicePrincipalCertificateAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServicePrincipalCertificateAuthInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ServicePrincipalCertificateAuthInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServicePrincipalCertificateAuthInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
