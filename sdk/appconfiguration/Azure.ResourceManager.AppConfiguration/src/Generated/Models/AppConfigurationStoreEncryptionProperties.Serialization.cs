// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    internal partial class AppConfigurationStoreEncryptionProperties : IUtf8JsonSerializable, IJsonModel<AppConfigurationStoreEncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppConfigurationStoreEncryptionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppConfigurationStoreEncryptionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStoreEncryptionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultProperties))
            {
                if (KeyVaultProperties != null)
                {
                    writer.WritePropertyName("keyVaultProperties"u8);
                    writer.WriteObjectValue(KeyVaultProperties);
                }
                else
                {
                    writer.WriteNull("keyVaultProperties");
                }
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

        AppConfigurationStoreEncryptionProperties IJsonModel<AppConfigurationStoreEncryptionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppConfigurationStoreEncryptionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppConfigurationStoreEncryptionProperties(document.RootElement, options);
        }

        internal static AppConfigurationStoreEncryptionProperties DeserializeAppConfigurationStoreEncryptionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppConfigurationKeyVaultProperties> keyVaultProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultProperties = null;
                        continue;
                    }
                    keyVaultProperties = AppConfigurationKeyVaultProperties.DeserializeAppConfigurationKeyVaultProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppConfigurationStoreEncryptionProperties(keyVaultProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppConfigurationStoreEncryptionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStoreEncryptionProperties)} does not support '{options.Format}' format.");
            }
        }

        AppConfigurationStoreEncryptionProperties IPersistableModel<AppConfigurationStoreEncryptionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppConfigurationStoreEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppConfigurationStoreEncryptionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppConfigurationStoreEncryptionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppConfigurationStoreEncryptionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
