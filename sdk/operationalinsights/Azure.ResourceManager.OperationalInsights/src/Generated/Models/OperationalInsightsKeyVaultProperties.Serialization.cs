// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<OperationalInsightsKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsKeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsKeyVaultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyRsaSize))
            {
                writer.WritePropertyName("keyRsaSize"u8);
                writer.WriteNumberValue(KeyRsaSize.Value);
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

        OperationalInsightsKeyVaultProperties IJsonModel<OperationalInsightsKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsKeyVaultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsKeyVaultProperties(document.RootElement, options);
        }

        internal static OperationalInsightsKeyVaultProperties DeserializeOperationalInsightsKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri keyVaultUri = default;
            string keyName = default;
            string keyVersion = default;
            int? keyRsaSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyRsaSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyRsaSize = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsKeyVaultProperties(keyVaultUri, keyName, keyVersion, keyRsaSize, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsKeyVaultProperties IPersistableModel<OperationalInsightsKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
