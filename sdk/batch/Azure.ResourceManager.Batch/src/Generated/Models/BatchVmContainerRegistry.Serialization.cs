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

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmContainerRegistry : IUtf8JsonSerializable, IJsonModel<BatchVmContainerRegistry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchVmContainerRegistry>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BatchVmContainerRegistry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BatchVmContainerRegistry>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BatchVmContainerRegistry>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(RegistryServer))
            {
                writer.WritePropertyName("registryServer"u8);
                writer.WriteStringValue(RegistryServer);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identityReference"u8);
                writer.WriteObjectValue(Identity);
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

        BatchVmContainerRegistry IJsonModel<BatchVmContainerRegistry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchVmContainerRegistry)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmContainerRegistry(document.RootElement, options);
        }

        internal static BatchVmContainerRegistry DeserializeBatchVmContainerRegistry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> registryServer = default;
            Optional<ComputeNodeIdentityReference> identityReference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryServer"u8))
                {
                    registryServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchVmContainerRegistry(username.Value, password.Value, registryServer.Value, identityReference.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchVmContainerRegistry>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchVmContainerRegistry)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BatchVmContainerRegistry IPersistableModel<BatchVmContainerRegistry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BatchVmContainerRegistry)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBatchVmContainerRegistry(document.RootElement, options);
        }

        string IPersistableModel<BatchVmContainerRegistry>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
