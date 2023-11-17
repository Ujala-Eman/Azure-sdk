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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownEnableMigrationProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<EnableMigrationProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnableMigrationProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EnableMigrationProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EnableMigrationProviderSpecificContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EnableMigrationProviderSpecificContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        EnableMigrationProviderSpecificContent IJsonModel<EnableMigrationProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EnableMigrationProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownEnableMigrationProviderSpecificContent(document.RootElement, options);
        }

        internal static UnknownEnableMigrationProviderSpecificContent DeserializeUnknownEnableMigrationProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownEnableMigrationProviderSpecificContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EnableMigrationProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EnableMigrationProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EnableMigrationProviderSpecificContent IPersistableModel<EnableMigrationProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EnableMigrationProviderSpecificContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUnknownEnableMigrationProviderSpecificContent(document.RootElement, options);
        }

        string IPersistableModel<EnableMigrationProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
