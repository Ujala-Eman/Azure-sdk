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
    public partial class IaasVmProtectedItem : IUtf8JsonSerializable, IJsonModel<IaasVmProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmProtectedItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && VirtualMachineId != null)
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (ProtectionStatus != null)
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (ProtectionState.HasValue)
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (options.Format != "W" && HealthStatus.HasValue)
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus.Value.ToString());
            }
            if (!(HealthDetails is ChangeTrackingList<IaasVmHealthDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("healthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in HealthDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(KpisHealths is ChangeTrackingDictionary<string, KpiResourceHealthDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("kpisHealths"u8);
                writer.WriteStartObject();
                foreach (var item in KpisHealths)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (LastBackupStatus != null)
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
            }
            if (options.Format != "W" && LastBackupOn.HasValue)
            {
                writer.WritePropertyName("lastBackupTime"u8);
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (options.Format != "W" && ProtectedItemDataId != null)
            {
                writer.WritePropertyName("protectedItemDataId"u8);
                writer.WriteStringValue(ProtectedItemDataId);
            }
            if (ExtendedInfo != null)
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (ExtendedProperties != null)
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteObjectValue(ExtendedProperties);
            }
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (options.Format != "W" && BackupManagementType.HasValue)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (options.Format != "W" && WorkloadType.HasValue)
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
            }
            if (ContainerName != null)
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (LastRecoverOn.HasValue)
            {
                writer.WritePropertyName("lastRecoveryPoint"u8);
                writer.WriteStringValue(LastRecoverOn.Value, "O");
            }
            if (BackupSetName != null)
            {
                writer.WritePropertyName("backupSetName"u8);
                writer.WriteStringValue(BackupSetName);
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (DeferredDeletedOn.HasValue)
            {
                writer.WritePropertyName("deferredDeleteTimeInUTC"u8);
                writer.WriteStringValue(DeferredDeletedOn.Value, "O");
            }
            if (IsScheduledForDeferredDelete.HasValue)
            {
                writer.WritePropertyName("isScheduledForDeferredDelete"u8);
                writer.WriteBooleanValue(IsScheduledForDeferredDelete.Value);
            }
            if (DeferredDeleteTimeRemaining != null)
            {
                writer.WritePropertyName("deferredDeleteTimeRemaining"u8);
                writer.WriteStringValue(DeferredDeleteTimeRemaining);
            }
            if (IsDeferredDeleteScheduleUpcoming.HasValue)
            {
                writer.WritePropertyName("isDeferredDeleteScheduleUpcoming"u8);
                writer.WriteBooleanValue(IsDeferredDeleteScheduleUpcoming.Value);
            }
            if (IsRehydrate.HasValue)
            {
                writer.WritePropertyName("isRehydrate"u8);
                writer.WriteBooleanValue(IsRehydrate.Value);
            }
            if (!(ResourceGuardOperationRequests is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsArchiveEnabled.HasValue)
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (PolicyName != null)
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (SoftDeleteRetentionPeriodInDays.HasValue)
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (options.Format != "W" && VaultId != null)
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
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

        IaasVmProtectedItem IJsonModel<IaasVmProtectedItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmProtectedItem(document.RootElement, options);
        }

        internal static IaasVmProtectedItem DeserializeIaasVmProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectedItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectedItem.DeserializeIaasClassicComputeVmProtectedItem(element, options);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectedItem.DeserializeIaasComputeVmProtectedItem(element, options);
                }
            }
            Optional<string> friendlyName = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> protectionStatus = default;
            Optional<BackupProtectionState> protectionState = default;
            Optional<IaasVmProtectedItemHealthStatus> healthStatus = default;
            Optional<IList<IaasVmHealthDetails>> healthDetails = default;
            Optional<IDictionary<string, KpiResourceHealthDetails>> kpisHealths = default;
            Optional<string> lastBackupStatus = default;
            Optional<DateTimeOffset> lastBackupTime = default;
            Optional<string> protectedItemDataId = default;
            Optional<IaasVmProtectedItemExtendedInfo> extendedInfo = default;
            Optional<IaasVmBackupExtendedProperties> extendedProperties = default;
            string protectedItemType = "AzureIaaSVMProtectedItem";
            Optional<BackupManagementType> backupManagementType = default;
            Optional<BackupDataSourceType> workloadType = default;
            Optional<string> containerName = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<DateTimeOffset> lastRecoveryPoint = default;
            Optional<string> backupSetName = default;
            Optional<BackupCreateMode> createMode = default;
            Optional<DateTimeOffset> deferredDeleteTimeInUTC = default;
            Optional<bool> isScheduledForDeferredDelete = default;
            Optional<string> deferredDeleteTimeRemaining = default;
            Optional<bool> isDeferredDeleteScheduleUpcoming = default;
            Optional<bool> isRehydrate = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isArchiveEnabled = default;
            Optional<string> policyName = default;
            Optional<int> softDeleteRetentionPeriodInDays = default;
            Optional<string> vaultId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthStatus = new IaasVmProtectedItemHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IaasVmHealthDetails> array = new List<IaasVmHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IaasVmHealthDetails.DeserializeIaasVmHealthDetails(item, options));
                    }
                    healthDetails = array;
                    continue;
                }
                if (property.NameEquals("kpisHealths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, KpiResourceHealthDetails> dictionary = new Dictionary<string, KpiResourceHealthDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, KpiResourceHealthDetails.DeserializeKpiResourceHealthDetails(property0.Value, options));
                    }
                    kpisHealths = dictionary;
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastBackupTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastBackupTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("protectedItemDataId"u8))
                {
                    protectedItemDataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = IaasVmProtectedItemExtendedInfo.DeserializeIaasVmProtectedItemExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedProperties = IaasVmBackupExtendedProperties.DeserializeIaasVmBackupExtendedProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
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
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupSetName"u8))
                {
                    backupSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new BackupCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deferredDeleteTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isScheduledForDeferredDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isScheduledForDeferredDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeRemaining"u8))
                {
                    deferredDeleteTimeRemaining = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDeferredDeleteScheduleUpcoming"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeferredDeleteScheduleUpcoming = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRehydrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRehydrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmProtectedItem(protectedItemType, Optional.ToNullable(backupManagementType), Optional.ToNullable(workloadType), containerName.Value, sourceResourceId.Value, policyId.Value, Optional.ToNullable(lastRecoveryPoint), backupSetName.Value, Optional.ToNullable(createMode), Optional.ToNullable(deferredDeleteTimeInUTC), Optional.ToNullable(isScheduledForDeferredDelete), deferredDeleteTimeRemaining.Value, Optional.ToNullable(isDeferredDeleteScheduleUpcoming), Optional.ToNullable(isRehydrate), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isArchiveEnabled), policyName.Value, Optional.ToNullable(softDeleteRetentionPeriodInDays), vaultId.Value, serializedAdditionalRawData, friendlyName.Value, virtualMachineId.Value, protectionStatus.Value, Optional.ToNullable(protectionState), Optional.ToNullable(healthStatus), Optional.ToList(healthDetails), Optional.ToDictionary(kpisHealths), lastBackupStatus.Value, Optional.ToNullable(lastBackupTime), protectedItemDataId.Value, extendedInfo.Value, extendedProperties.Value);
        }

        BinaryData IPersistableModel<IaasVmProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        IaasVmProtectedItem IPersistableModel<IaasVmProtectedItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmProtectedItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IaasVmProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmProtectedItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
