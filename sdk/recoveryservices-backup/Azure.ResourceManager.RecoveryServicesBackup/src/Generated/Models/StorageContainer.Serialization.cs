// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class StorageContainer : IUtf8JsonSerializable, IJsonModel<StorageContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (StorageAccountVersion != null)
            {
                writer.WritePropertyName("storageAccountVersion"u8);
                writer.WriteStringValue(StorageAccountVersion);
            }
            if (ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (ProtectedItemCount.HasValue)
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (AcquireStorageAccountLock.HasValue)
            {
                writer.WritePropertyName("acquireStorageAccountLock"u8);
                writer.WriteStringValue(AcquireStorageAccountLock.Value.ToString());
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (BackupManagementType.HasValue)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (RegistrationStatus != null)
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (HealthStatus != null)
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (ProtectableObjectType != null)
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
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

        StorageContainer IJsonModel<StorageContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageContainer(document.RootElement, options);
        }

        internal static StorageContainer DeserializeStorageContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<string> storageAccountVersion = default;
            Optional<string> resourceGroup = default;
            Optional<long> protectedItemCount = default;
            Optional<AcquireStorageAccountLock> acquireStorageAccountLock = default;
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountVersion"u8))
                {
                    storageAccountVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("acquireStorageAccountLock"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acquireStorageAccountLock = new AcquireStorageAccountLock(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData, sourceResourceId.Value, storageAccountVersion.Value, resourceGroup.Value, Optional.ToNullable(protectedItemCount), Optional.ToNullable(acquireStorageAccountLock));
        }

        BinaryData IPersistableModel<StorageContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageContainer)} does not support '{options.Format}' format.");
            }
        }

        StorageContainer IPersistableModel<StorageContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
