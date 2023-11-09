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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSshKeyPair : IUtf8JsonSerializable, IJsonModel<SapSshKeyPair>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSshKeyPair>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SapSshKeyPair>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey"u8);
                writer.WriteStringValue(PublicKey);
            }
            if (Optional.IsDefined(PrivateKey))
            {
                writer.WritePropertyName("privateKey"u8);
                writer.WriteStringValue(PrivateKey);
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

        SapSshKeyPair IJsonModel<SapSshKeyPair>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSshKeyPair)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSshKeyPair(document.RootElement, options);
        }

        internal static SapSshKeyPair DeserializeSapSshKeyPair(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> publicKey = default;
            Optional<string> privateKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapSshKeyPair(publicKey.Value, privateKey.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<SapSshKeyPair>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSshKeyPair)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SapSshKeyPair IModel<SapSshKeyPair>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSshKeyPair)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSapSshKeyPair(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SapSshKeyPair>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
