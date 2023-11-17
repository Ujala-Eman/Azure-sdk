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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsEncryptionKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<AvsEncryptionKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsEncryptionKeyVaultProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AvsEncryptionKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvsEncryptionKeyVaultProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvsEncryptionKeyVaultProperties>)} interface");
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
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AutoDetectedKeyVersion))
                {
                    writer.WritePropertyName("autoDetectedKeyVersion"u8);
                    writer.WriteStringValue(AutoDetectedKeyVersion);
                }
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUrl"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(KeyState))
                {
                    writer.WritePropertyName("keyState"u8);
                    writer.WriteStringValue(KeyState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VersionType))
                {
                    writer.WritePropertyName("versionType"u8);
                    writer.WriteStringValue(VersionType.Value.ToString());
                }
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

        AvsEncryptionKeyVaultProperties IJsonModel<AvsEncryptionKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsEncryptionKeyVaultProperties(document.RootElement, options);
        }

        internal static AvsEncryptionKeyVaultProperties DeserializeAvsEncryptionKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            Optional<string> autoDetectedKeyVersion = default;
            Optional<Uri> keyVaultUrl = default;
            Optional<AvsEncryptionKeyStatus> keyState = default;
            Optional<AvsEncryptionVersionType> versionType = default;
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
                if (property.NameEquals("autoDetectedKeyVersion"u8))
                {
                    autoDetectedKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyState = new AvsEncryptionKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionType = new AvsEncryptionVersionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvsEncryptionKeyVaultProperties(keyName.Value, keyVersion.Value, autoDetectedKeyVersion.Value, keyVaultUrl.Value, Optional.ToNullable(keyState), Optional.ToNullable(versionType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsEncryptionKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvsEncryptionKeyVaultProperties IPersistableModel<AvsEncryptionKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvsEncryptionKeyVaultProperties(document.RootElement, options);
        }

        string IPersistableModel<AvsEncryptionKeyVaultProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
