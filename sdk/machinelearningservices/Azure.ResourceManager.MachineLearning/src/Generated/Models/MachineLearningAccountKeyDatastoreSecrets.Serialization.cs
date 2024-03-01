// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAccountKeyDatastoreSecrets : IUtf8JsonSerializable, IJsonModel<MachineLearningAccountKeyDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAccountKeyDatastoreSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningAccountKeyDatastoreSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Key != null)
            {
                if (Key != null)
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
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

        MachineLearningAccountKeyDatastoreSecrets IJsonModel<MachineLearningAccountKeyDatastoreSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAccountKeyDatastoreSecrets(document.RootElement, options);
        }

        internal static MachineLearningAccountKeyDatastoreSecrets DeserializeMachineLearningAccountKeyDatastoreSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            SecretsType secretsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAccountKeyDatastoreSecrets(secretsType, serializedAdditionalRawData, key);
        }

        BinaryData IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreSecrets)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningAccountKeyDatastoreSecrets IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAccountKeyDatastoreSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAccountKeyDatastoreSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAccountKeyDatastoreSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
