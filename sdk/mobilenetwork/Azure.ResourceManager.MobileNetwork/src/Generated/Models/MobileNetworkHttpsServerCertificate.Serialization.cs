// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkHttpsServerCertificate : IUtf8JsonSerializable, IJsonModel<MobileNetworkHttpsServerCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkHttpsServerCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MobileNetworkHttpsServerCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkHttpsServerCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkHttpsServerCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("certificateUrl"u8);
            writer.WriteStringValue(CertificateUri.AbsoluteUri);
            if (options.Format != "W" && Optional.IsDefined(Provisioning))
            {
                writer.WritePropertyName("provisioning"u8);
                writer.WriteObjectValue(Provisioning);
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

        MobileNetworkHttpsServerCertificate IJsonModel<MobileNetworkHttpsServerCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkHttpsServerCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkHttpsServerCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkHttpsServerCertificate(document.RootElement, options);
        }

        internal static MobileNetworkHttpsServerCertificate DeserializeMobileNetworkHttpsServerCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri certificateUrl = default;
            MobileNetworkCertificateProvisioning provisioning = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"u8))
                {
                    certificateUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioning = MobileNetworkCertificateProvisioning.DeserializeMobileNetworkCertificateProvisioning(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MobileNetworkHttpsServerCertificate(certificateUrl, provisioning, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MobileNetworkHttpsServerCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkHttpsServerCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkHttpsServerCertificate)} does not support '{options.Format}' format.");
            }
        }

        MobileNetworkHttpsServerCertificate IPersistableModel<MobileNetworkHttpsServerCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkHttpsServerCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMobileNetworkHttpsServerCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkHttpsServerCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkHttpsServerCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
