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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class HostnameConfiguration : IUtf8JsonSerializable, IJsonModel<HostnameConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostnameConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostnameConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostnameConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HostnameConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(HostnameType.ToString());
            writer.WritePropertyName("hostName"u8);
            writer.WriteStringValue(HostName);
            if (Optional.IsDefined(KeyVaultSecretUri))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultSecretUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId);
            }
            if (Optional.IsDefined(EncodedCertificate))
            {
                writer.WritePropertyName("encodedCertificate"u8);
                writer.WriteStringValue(EncodedCertificate);
            }
            if (Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword"u8);
                writer.WriteStringValue(CertificatePassword);
            }
            if (Optional.IsDefined(IsDefaultSslBindingEnabled))
            {
                writer.WritePropertyName("defaultSslBinding"u8);
                writer.WriteBooleanValue(IsDefaultSslBindingEnabled.Value);
            }
            if (Optional.IsDefined(IsClientCertificateNegotiationEnabled))
            {
                writer.WritePropertyName("negotiateClientCertificate"u8);
                writer.WriteBooleanValue(IsClientCertificateNegotiationEnabled.Value);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsDefined(CertificateSource))
            {
                writer.WritePropertyName("certificateSource"u8);
                writer.WriteStringValue(CertificateSource.Value.ToString());
            }
            if (Optional.IsDefined(CertificateStatus))
            {
                writer.WritePropertyName("certificateStatus"u8);
                writer.WriteStringValue(CertificateStatus.Value.ToString());
            }
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

        HostnameConfiguration IJsonModel<HostnameConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostnameConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HostnameConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostnameConfiguration(document.RootElement, options);
        }

        internal static HostnameConfiguration DeserializeHostnameConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HostnameType type = default;
            string hostName = default;
            Optional<Uri> keyVaultId = default;
            Optional<string> identityClientId = default;
            Optional<string> encodedCertificate = default;
            Optional<string> certificatePassword = default;
            Optional<bool> defaultSslBinding = default;
            Optional<bool> negotiateClientCertificate = default;
            Optional<CertificateInformation> certificate = default;
            Optional<CertificateSource> certificateSource = default;
            Optional<CertificateStatus> certificateStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new HostnameType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedCertificate"u8))
                {
                    encodedCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"u8))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultSslBinding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultSslBinding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("negotiateClientCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negotiateClientCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = CertificateInformation.DeserializeCertificateInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateStatus = new CertificateStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostnameConfiguration(type, hostName, keyVaultId.Value, identityClientId.Value, encodedCertificate.Value, certificatePassword.Value, Optional.ToNullable(defaultSslBinding), Optional.ToNullable(negotiateClientCertificate), certificate.Value, Optional.ToNullable(certificateSource), Optional.ToNullable(certificateStatus), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostnameConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostnameConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(HostnameConfiguration)} does not support '{options.Format}' format.");
            }
        }

        HostnameConfiguration IPersistableModel<HostnameConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostnameConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostnameConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(HostnameConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostnameConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
