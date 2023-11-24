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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformContentCertificateProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformContentCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformContentCertificateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformContentCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformContentCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppPlatformContentCertificateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CertificatePropertiesType);
            if (options.Format != "W" && Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (options.Format != "W" && Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && Optional.IsDefined(IssuedOn))
            {
                writer.WritePropertyName("issuedDate"u8);
                writer.WriteStringValue(IssuedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ActivateOn))
            {
                writer.WritePropertyName("activateDate"u8);
                writer.WriteStringValue(ActivateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DnsNames))
            {
                writer.WritePropertyName("dnsNames"u8);
                writer.WriteStartArray();
                foreach (var item in DnsNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AppPlatformContentCertificateProperties IJsonModel<AppPlatformContentCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformContentCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AppPlatformContentCertificateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformContentCertificateProperties(document.RootElement, options);
        }

        internal static AppPlatformContentCertificateProperties DeserializeAppPlatformContentCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> content = default;
            string type = default;
            Optional<string> thumbprint = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issuedDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<DateTimeOffset> activateDate = default;
            Optional<string> subjectName = default;
            Optional<IReadOnlyList<string>> dnsNames = default;
            Optional<AppPlatformCertificateProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuedDate = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("activateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activateDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNames"u8))
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
                    dnsNames = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformCertificateProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformContentCertificateProperties(type, thumbprint.Value, issuer.Value, Optional.ToNullable(issuedDate), Optional.ToNullable(expirationDate), Optional.ToNullable(activateDate), subjectName.Value, Optional.ToList(dnsNames), Optional.ToNullable(provisioningState), serializedAdditionalRawData, content.Value);
        }

        BinaryData IPersistableModel<AppPlatformContentCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformContentCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AppPlatformContentCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformContentCertificateProperties IPersistableModel<AppPlatformContentCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformContentCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformContentCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AppPlatformContentCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformContentCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
