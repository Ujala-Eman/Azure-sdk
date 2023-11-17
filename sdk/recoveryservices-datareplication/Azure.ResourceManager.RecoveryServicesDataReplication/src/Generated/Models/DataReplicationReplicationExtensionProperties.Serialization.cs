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

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationReplicationExtensionProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationReplicationExtensionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationReplicationExtensionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataReplicationReplicationExtensionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DataReplicationReplicationExtensionProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DataReplicationReplicationExtensionProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
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

        DataReplicationReplicationExtensionProperties IJsonModel<DataReplicationReplicationExtensionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationReplicationExtensionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationReplicationExtensionProperties(document.RootElement, options);
        }

        internal static DataReplicationReplicationExtensionProperties DeserializeDataReplicationReplicationExtensionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataReplicationProvisioningState> provisioningState = default;
            ReplicationExtensionModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataReplicationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = ReplicationExtensionModelCustomProperties.DeserializeReplicationExtensionModelCustomProperties(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationReplicationExtensionProperties(Optional.ToNullable(provisioningState), customProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationReplicationExtensionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationReplicationExtensionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DataReplicationReplicationExtensionProperties IPersistableModel<DataReplicationReplicationExtensionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DataReplicationReplicationExtensionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDataReplicationReplicationExtensionProperties(document.RootElement, options);
        }

        string IPersistableModel<DataReplicationReplicationExtensionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
