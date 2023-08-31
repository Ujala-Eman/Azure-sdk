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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class HostnameConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<HostnameConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HostnameConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HostnameConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static HostnameConfiguration DeserializeHostnameConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

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
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HostnameConfiguration(type, hostName, keyVaultId.Value, identityClientId.Value, encodedCertificate.Value, certificatePassword.Value, Optional.ToNullable(defaultSslBinding), Optional.ToNullable(negotiateClientCertificate), certificate.Value, Optional.ToNullable(certificateSource), Optional.ToNullable(certificateStatus), rawData);
        }

        HostnameConfiguration IModelJsonSerializable<HostnameConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHostnameConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HostnameConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HostnameConfiguration IModelSerializable<HostnameConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHostnameConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HostnameConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HostnameConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHostnameConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
