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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UserManagedHttpsContent : IUtf8JsonSerializable, IJsonModel<UserManagedHttpsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserManagedHttpsContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<UserManagedHttpsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<UserManagedHttpsContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<UserManagedHttpsContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("certificateSourceParameters"u8);
            writer.WriteObjectValue(CertificateSourceParameters);
            writer.WritePropertyName("certificateSource"u8);
            writer.WriteStringValue(CertificateSource.ToString());
            writer.WritePropertyName("protocolType"u8);
            writer.WriteStringValue(ProtocolType.ToString());
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
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

        UserManagedHttpsContent IJsonModel<UserManagedHttpsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserManagedHttpsContent(document.RootElement, options);
        }

        internal static UserManagedHttpsContent DeserializeUserManagedHttpsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyVaultCertificateSource certificateSourceParameters = default;
            CertificateSource certificateSource = default;
            SecureDeliveryProtocolType protocolType = default;
            Optional<CdnMinimumTlsVersion> minimumTlsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateSourceParameters"u8))
                {
                    certificateSourceParameters = KeyVaultCertificateSource.DeserializeKeyVaultCertificateSource(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSource"u8))
                {
                    certificateSource = new CertificateSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolType"u8))
                {
                    protocolType = new SecureDeliveryProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToCdnMinimumTlsVersion();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UserManagedHttpsContent(certificateSource, protocolType, Optional.ToNullable(minimumTlsVersion), serializedAdditionalRawData, certificateSourceParameters);
        }

        BinaryData IPersistableModel<UserManagedHttpsContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UserManagedHttpsContent IPersistableModel<UserManagedHttpsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UserManagedHttpsContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUserManagedHttpsContent(document.RootElement, options);
        }

        string IPersistableModel<UserManagedHttpsContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
