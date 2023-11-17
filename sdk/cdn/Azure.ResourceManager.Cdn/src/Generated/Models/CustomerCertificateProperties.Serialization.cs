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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CustomerCertificateProperties : IUtf8JsonSerializable, IJsonModel<CustomerCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomerCertificateProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<CustomerCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<CustomerCertificateProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<CustomerCertificateProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("secretSource"u8);
            JsonSerializer.Serialize(writer, SecretSource);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
            }
            if (Optional.IsDefined(UseLatestVersion))
            {
                writer.WritePropertyName("useLatestVersion"u8);
                writer.WriteBooleanValue(UseLatestVersion.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Subject))
                {
                    writer.WritePropertyName("subject"u8);
                    writer.WriteStringValue(Subject);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ExpiresOn))
                {
                    writer.WritePropertyName("expirationDate"u8);
                    writer.WriteStringValue(ExpiresOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CertificateAuthority))
                {
                    writer.WritePropertyName("certificateAuthority"u8);
                    writer.WriteStringValue(CertificateAuthority);
                }
            }
            if (Optional.IsCollectionDefined(SubjectAlternativeNames))
            {
                writer.WritePropertyName("subjectAlternativeNames"u8);
                writer.WriteStartArray();
                foreach (var item in SubjectAlternativeNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Thumbprint))
                {
                    writer.WritePropertyName("thumbprint"u8);
                    writer.WriteStringValue(Thumbprint);
                }
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SecretType.ToString());
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

        CustomerCertificateProperties IJsonModel<CustomerCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomerCertificateProperties(document.RootElement, options);
        }

        internal static CustomerCertificateProperties DeserializeCustomerCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource secretSource = default;
            Optional<string> secretVersion = default;
            Optional<bool> useLatestVersion = default;
            Optional<string> subject = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<string> certificateAuthority = default;
            Optional<IList<string>> subjectAlternativeNames = default;
            Optional<string> thumbprint = default;
            SecretType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretSource"u8))
                {
                    secretSource = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretVersion"u8))
                {
                    secretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useLatestVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useLatestVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("certificateAuthority"u8))
                {
                    certificateAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subjectAlternativeNames"u8))
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
                    subjectAlternativeNames = array;
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SecretType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomerCertificateProperties(type, serializedAdditionalRawData, secretSource, secretVersion.Value, Optional.ToNullable(useLatestVersion), subject.Value, Optional.ToNullable(expirationDate), certificateAuthority.Value, Optional.ToList(subjectAlternativeNames), thumbprint.Value);
        }

        BinaryData IPersistableModel<CustomerCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CustomerCertificateProperties IPersistableModel<CustomerCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomerCertificateProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCustomerCertificateProperties(document.RootElement, options);
        }

        string IPersistableModel<CustomerCertificateProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
