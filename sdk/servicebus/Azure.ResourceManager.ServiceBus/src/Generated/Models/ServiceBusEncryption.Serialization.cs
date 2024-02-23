// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusEncryption : IUtf8JsonSerializable, IJsonModel<ServiceBusEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(KeyVaultProperties is ChangeTrackingList<ServiceBusKeyVaultProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteStartArray();
                foreach (var item in KeyVaultProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (KeySource.HasValue)
            {
                writer.WritePropertyName("keySource"u8);
                writer.WriteStringValue(KeySource.Value.ToString());
            }
            if (RequireInfrastructureEncryption.HasValue)
            {
                writer.WritePropertyName("requireInfrastructureEncryption"u8);
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
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

        ServiceBusEncryption IJsonModel<ServiceBusEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusEncryption(document.RootElement, options);
        }

        internal static ServiceBusEncryption DeserializeServiceBusEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ServiceBusKeyVaultProperties>> keyVaultProperties = default;
            Optional<ServiceBusEncryptionKeySource> keySource = default;
            Optional<bool> requireInfrastructureEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceBusKeyVaultProperties> array = new List<ServiceBusKeyVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceBusKeyVaultProperties.DeserializeServiceBusKeyVaultProperties(item, options));
                    }
                    keyVaultProperties = array;
                    continue;
                }
                if (property.NameEquals("keySource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keySource = new ServiceBusEncryptionKeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requireInfrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireInfrastructureEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusEncryption(Optional.ToList(keyVaultProperties), Optional.ToNullable(keySource), Optional.ToNullable(requireInfrastructureEncryption), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusEncryption)} does not support '{options.Format}' format.");
            }
        }

        ServiceBusEncryption IPersistableModel<ServiceBusEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
