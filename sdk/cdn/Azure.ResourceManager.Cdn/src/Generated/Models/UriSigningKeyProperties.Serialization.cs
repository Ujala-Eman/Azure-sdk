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
    public partial class UriSigningKeyProperties : IUtf8JsonSerializable, IJsonModel<UriSigningKeyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UriSigningKeyProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<UriSigningKeyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<UriSigningKeyProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<UriSigningKeyProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyId"u8);
            writer.WriteStringValue(KeyId);
            writer.WritePropertyName("secretSource"u8);
            JsonSerializer.Serialize(writer, SecretSource);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteStringValue(SecretVersion);
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

        UriSigningKeyProperties IJsonModel<UriSigningKeyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriSigningKeyProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUriSigningKeyProperties(document.RootElement, options);
        }

        internal static UriSigningKeyProperties DeserializeUriSigningKeyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyId = default;
            WritableSubResource secretSource = default;
            Optional<string> secretVersion = default;
            SecretType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
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
            return new UriSigningKeyProperties(type, serializedAdditionalRawData, keyId, secretSource, secretVersion.Value);
        }

        BinaryData IPersistableModel<UriSigningKeyProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriSigningKeyProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UriSigningKeyProperties IPersistableModel<UriSigningKeyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriSigningKeyProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUriSigningKeyProperties(document.RootElement, options);
        }

        string IPersistableModel<UriSigningKeyProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
