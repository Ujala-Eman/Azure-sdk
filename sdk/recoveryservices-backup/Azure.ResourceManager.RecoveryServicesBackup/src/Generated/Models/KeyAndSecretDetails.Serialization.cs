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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class KeyAndSecretDetails : IUtf8JsonSerializable, IJsonModel<KeyAndSecretDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyAndSecretDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyAndSecretDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<KeyAndSecretDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<KeyAndSecretDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KekDetails))
            {
                writer.WritePropertyName("kekDetails"u8);
                writer.WriteObjectValue(KekDetails);
            }
            if (Optional.IsDefined(BekDetails))
            {
                writer.WritePropertyName("bekDetails"u8);
                writer.WriteObjectValue(BekDetails);
            }
            if (Optional.IsDefined(EncryptionMechanism))
            {
                writer.WritePropertyName("encryptionMechanism"u8);
                writer.WriteStringValue(EncryptionMechanism);
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

        KeyAndSecretDetails IJsonModel<KeyAndSecretDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyAndSecretDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyAndSecretDetails(document.RootElement, options);
        }

        internal static KeyAndSecretDetails DeserializeKeyAndSecretDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KekDetails> kekDetails = default;
            Optional<BekDetails> bekDetails = default;
            Optional<string> encryptionMechanism = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kekDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekDetails = KekDetails.DeserializeKekDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("bekDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bekDetails = BekDetails.DeserializeBekDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionMechanism"u8))
                {
                    encryptionMechanism = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeyAndSecretDetails(kekDetails.Value, bekDetails.Value, encryptionMechanism.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyAndSecretDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyAndSecretDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KeyAndSecretDetails IPersistableModel<KeyAndSecretDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyAndSecretDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKeyAndSecretDetails(document.RootElement, options);
        }

        string IPersistableModel<KeyAndSecretDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
