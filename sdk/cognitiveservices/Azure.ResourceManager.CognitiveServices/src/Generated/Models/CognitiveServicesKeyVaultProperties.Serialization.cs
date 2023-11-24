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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<CognitiveServicesKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CognitiveServicesKeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CognitiveServicesKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CognitiveServicesKeyVaultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId.Value);
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

        CognitiveServicesKeyVaultProperties IJsonModel<CognitiveServicesKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CognitiveServicesKeyVaultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesKeyVaultProperties(document.RootElement, options);
        }

        internal static CognitiveServicesKeyVaultProperties DeserializeCognitiveServicesKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            Optional<Uri> keyVaultUri = default;
            Optional<Guid> identityClientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityClientId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CognitiveServicesKeyVaultProperties(keyName.Value, keyVersion.Value, keyVaultUri.Value, Optional.ToNullable(identityClientId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CognitiveServicesKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CognitiveServicesKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        CognitiveServicesKeyVaultProperties IPersistableModel<CognitiveServicesKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCognitiveServicesKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CognitiveServicesKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CognitiveServicesKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
