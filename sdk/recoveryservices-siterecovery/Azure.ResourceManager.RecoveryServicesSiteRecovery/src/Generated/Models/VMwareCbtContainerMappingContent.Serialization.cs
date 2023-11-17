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
    public partial class VMwareCbtContainerMappingContent : IUtf8JsonSerializable, IJsonModel<VMwareCbtContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtContainerMappingContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtContainerMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<VMwareCbtContainerMappingContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<VMwareCbtContainerMappingContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            writer.WritePropertyName("storageAccountId"u8);
            writer.WriteStringValue(StorageAccountId);
            if (Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (Optional.IsDefined(ServiceBusConnectionStringSecretName))
            {
                writer.WritePropertyName("serviceBusConnectionStringSecretName"u8);
                writer.WriteStringValue(ServiceBusConnectionStringSecretName);
            }
            writer.WritePropertyName("targetLocation"u8);
            writer.WriteStringValue(TargetLocation);
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

        VMwareCbtContainerMappingContent IJsonModel<VMwareCbtContainerMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtContainerMappingContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtContainerMappingContent(document.RootElement, options);
        }

        internal static VMwareCbtContainerMappingContent DeserializeVMwareCbtContainerMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> keyVaultId = default;
            Optional<Uri> keyVaultUri = default;
            ResourceIdentifier storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<string> serviceBusConnectionStringSecretName = default;
            string targetLocation = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"u8))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
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
            return new VMwareCbtContainerMappingContent(instanceType, serializedAdditionalRawData, keyVaultId.Value, keyVaultUri.Value, storageAccountId, storageAccountSasSecretName.Value, serviceBusConnectionStringSecretName.Value, targetLocation);
        }

        BinaryData IPersistableModel<VMwareCbtContainerMappingContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtContainerMappingContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VMwareCbtContainerMappingContent IPersistableModel<VMwareCbtContainerMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtContainerMappingContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVMwareCbtContainerMappingContent(document.RootElement, options);
        }

        string IPersistableModel<VMwareCbtContainerMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
