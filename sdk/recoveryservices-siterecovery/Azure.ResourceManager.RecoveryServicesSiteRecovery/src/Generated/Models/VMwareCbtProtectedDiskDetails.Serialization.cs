// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectedDiskDetails : IUtf8JsonSerializable, IJsonModel<VMwareCbtProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtProtectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtProtectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DiskId != null)
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (options.Format != "W" && DiskName != null)
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (DiskType.HasValue)
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (options.Format != "W" && DiskPath != null)
            {
                writer.WritePropertyName("diskPath"u8);
                writer.WriteStringValue(DiskPath);
            }
            if (options.Format != "W" && IsOSDisk != null)
            {
                writer.WritePropertyName("isOSDisk"u8);
                writer.WriteStringValue(IsOSDisk);
            }
            if (options.Format != "W" && CapacityInBytes.HasValue)
            {
                writer.WritePropertyName("capacityInBytes"u8);
                writer.WriteNumberValue(CapacityInBytes.Value);
            }
            if (options.Format != "W" && LogStorageAccountId != null)
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (options.Format != "W" && LogStorageAccountSasSecretName != null)
            {
                writer.WritePropertyName("logStorageAccountSasSecretName"u8);
                writer.WriteStringValue(LogStorageAccountSasSecretName);
            }
            if (options.Format != "W" && DiskEncryptionSetId != null)
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (options.Format != "W" && SeedManagedDiskId != null)
            {
                writer.WritePropertyName("seedManagedDiskId"u8);
                writer.WriteStringValue(SeedManagedDiskId);
            }
            if (options.Format != "W" && SeedBlobUri != null)
            {
                writer.WritePropertyName("seedBlobUri"u8);
                writer.WriteStringValue(SeedBlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && TargetManagedDiskId != null)
            {
                writer.WritePropertyName("targetManagedDiskId"u8);
                writer.WriteStringValue(TargetManagedDiskId);
            }
            if (options.Format != "W" && TargetBlobUri != null)
            {
                writer.WritePropertyName("targetBlobUri"u8);
                writer.WriteStringValue(TargetBlobUri.AbsoluteUri);
            }
            if (TargetDiskName != null)
            {
                writer.WritePropertyName("targetDiskName"u8);
                writer.WriteStringValue(TargetDiskName);
            }
            if (options.Format != "W" && GatewayOperationDetails != null)
            {
                writer.WritePropertyName("gatewayOperationDetails"u8);
                writer.WriteObjectValue(GatewayOperationDetails);
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

        VMwareCbtProtectedDiskDetails IJsonModel<VMwareCbtProtectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtProtectedDiskDetails(document.RootElement, options);
        }

        internal static VMwareCbtProtectedDiskDetails DeserializeVMwareCbtProtectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string diskName = default;
            SiteRecoveryDiskAccountType? diskType = default;
            string diskPath = default;
            string isOSDisk = default;
            long? capacityInBytes = default;
            ResourceIdentifier logStorageAccountId = default;
            string logStorageAccountSasSecretName = default;
            ResourceIdentifier diskEncryptionSetId = default;
            string seedManagedDiskId = default;
            Uri seedBlobUri = default;
            string targetManagedDiskId = default;
            Uri targetBlobUri = default;
            string targetDiskName = default;
            GatewayOperationDetails gatewayOperationDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskPath"u8))
                {
                    diskPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logStorageAccountSasSecretName"u8))
                {
                    logStorageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seedBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetManagedDiskId"u8))
                {
                    targetManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskName"u8))
                {
                    targetDiskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gatewayOperationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayOperationDetails = GatewayOperationDetails.DeserializeGatewayOperationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtProtectedDiskDetails(
                diskId,
                diskName,
                diskType,
                diskPath,
                isOSDisk,
                capacityInBytes,
                logStorageAccountId,
                logStorageAccountSasSecretName,
                diskEncryptionSetId,
                seedManagedDiskId,
                seedBlobUri,
                targetManagedDiskId,
                targetBlobUri,
                targetDiskName,
                gatewayOperationDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareCbtProtectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtProtectedDiskDetails IPersistableModel<VMwareCbtProtectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtProtectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtProtectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
