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

namespace Azure.ResourceManager.ResourceConnector.Models
{
    public partial class ApplianceSshKey : IUtf8JsonSerializable, IJsonModel<ApplianceSshKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplianceSshKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplianceSshKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplianceSshKey>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplianceSshKey>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Certificate))
                {
                    writer.WritePropertyName("certificate"u8);
                    writer.WriteStringValue(Certificate);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreationTimeStamp))
                {
                    writer.WritePropertyName("creationTimeStamp"u8);
                    writer.WriteNumberValue(CreationTimeStamp.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ExpirationTimeStamp))
                {
                    writer.WritePropertyName("expirationTimeStamp"u8);
                    writer.WriteNumberValue(ExpirationTimeStamp.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PrivateKey))
                {
                    writer.WritePropertyName("privateKey"u8);
                    writer.WriteStringValue(PrivateKey);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PublicKey))
                {
                    writer.WritePropertyName("publicKey"u8);
                    writer.WriteStringValue(PublicKey);
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

        ApplianceSshKey IJsonModel<ApplianceSshKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceSshKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplianceSshKey(document.RootElement, options);
        }

        internal static ApplianceSshKey DeserializeApplianceSshKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            Optional<long> creationTimeStamp = default;
            Optional<long> expirationTimeStamp = default;
            Optional<string> privateKey = default;
            Optional<string> publicKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTimeStamp = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expirationTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTimeStamp = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplianceSshKey(certificate.Value, Optional.ToNullable(creationTimeStamp), Optional.ToNullable(expirationTimeStamp), privateKey.Value, publicKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplianceSshKey>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceSshKey)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplianceSshKey IPersistableModel<ApplianceSshKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceSshKey)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplianceSshKey(document.RootElement, options);
        }

        string IPersistableModel<ApplianceSshKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
