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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementServiceBackupRestoreContent : IUtf8JsonSerializable, IJsonModel<ApiManagementServiceBackupRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementServiceBackupRestoreContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApiManagementServiceBackupRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApiManagementServiceBackupRestoreContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApiManagementServiceBackupRestoreContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccount"u8);
            writer.WriteStringValue(StorageAccount);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("backupName"u8);
            writer.WriteStringValue(BackupName);
            if (Optional.IsDefined(AccessType))
            {
                writer.WritePropertyName("accessType"u8);
                writer.WriteStringValue(AccessType.Value.ToString());
            }
            if (Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteStringValue(AccessKey);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
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

        ApiManagementServiceBackupRestoreContent IJsonModel<ApiManagementServiceBackupRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementServiceBackupRestoreContent(document.RootElement, options);
        }

        internal static ApiManagementServiceBackupRestoreContent DeserializeApiManagementServiceBackupRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageAccount = default;
            string containerName = default;
            string backupName = default;
            Optional<StorageAccountAccessType> accessType = default;
            Optional<string> accessKey = default;
            Optional<string> clientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccount"u8))
                {
                    storageAccount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupName"u8))
                {
                    backupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessType = new StorageAccountAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessKey"u8))
                {
                    accessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementServiceBackupRestoreContent(storageAccount, containerName, backupName, Optional.ToNullable(accessType), accessKey.Value, clientId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementServiceBackupRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApiManagementServiceBackupRestoreContent IPersistableModel<ApiManagementServiceBackupRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementServiceBackupRestoreContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApiManagementServiceBackupRestoreContent(document.RootElement, options);
        }

        string IPersistableModel<ApiManagementServiceBackupRestoreContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
