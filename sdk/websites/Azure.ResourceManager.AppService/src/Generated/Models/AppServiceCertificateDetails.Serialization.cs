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
    public partial class AppServiceCertificateDetails : IUtf8JsonSerializable, IJsonModel<AppServiceCertificateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceCertificateDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AppServiceCertificateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Version))
                {
                    writer.WritePropertyName("version"u8);
                    writer.WriteNumberValue(Version.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SerialNumber))
                {
                    writer.WritePropertyName("serialNumber"u8);
                    writer.WriteStringValue(SerialNumber);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ThumbprintString))
                {
                    writer.WritePropertyName("thumbprint"u8);
                    writer.WriteStringValue(ThumbprintString);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Subject))
                {
                    writer.WritePropertyName("subject"u8);
                    writer.WriteStringValue(Subject);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(NotBefore))
                {
                    writer.WritePropertyName("notBefore"u8);
                    writer.WriteStringValue(NotBefore.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(NotAfter))
                {
                    writer.WritePropertyName("notAfter"u8);
                    writer.WriteStringValue(NotAfter.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SignatureAlgorithm))
                {
                    writer.WritePropertyName("signatureAlgorithm"u8);
                    writer.WriteStringValue(SignatureAlgorithm);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Issuer))
                {
                    writer.WritePropertyName("issuer"u8);
                    writer.WriteStringValue(Issuer);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RawData))
                {
                    writer.WritePropertyName("rawData"u8);
                    writer.WriteStringValue(RawData);
                }
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

        AppServiceCertificateDetails IJsonModel<AppServiceCertificateDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceCertificateDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceCertificateDetails(document.RootElement, options);
        }

        internal static AppServiceCertificateDetails DeserializeAppServiceCertificateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> version = default;
            Optional<string> serialNumber = default;
            Optional<string> thumbprint = default;
            Optional<string> subject = default;
            Optional<DateTimeOffset> notBefore = default;
            Optional<DateTimeOffset> notAfter = default;
            Optional<string> signatureAlgorithm = default;
            Optional<string> issuer = default;
            Optional<string> rawData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notBefore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBefore = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("notAfter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notAfter = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("signatureAlgorithm"u8))
                {
                    signatureAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rawData"u8))
                {
                    rawData = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceCertificateDetails(Optional.ToNullable(version), serialNumber.Value, thumbprint.Value, subject.Value, Optional.ToNullable(notBefore), Optional.ToNullable(notAfter), signatureAlgorithm.Value, issuer.Value, rawData.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<AppServiceCertificateDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceCertificateDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppServiceCertificateDetails IModel<AppServiceCertificateDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppServiceCertificateDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppServiceCertificateDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AppServiceCertificateDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
