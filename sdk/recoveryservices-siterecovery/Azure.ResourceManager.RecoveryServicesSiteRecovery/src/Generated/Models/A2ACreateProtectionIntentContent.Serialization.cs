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
    public partial class A2ACreateProtectionIntentContent : IUtf8JsonSerializable, IJsonModel<A2ACreateProtectionIntentContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ACreateProtectionIntentContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ACreateProtectionIntentContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<A2ACreateProtectionIntentContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<A2ACreateProtectionIntentContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fabricObjectId"u8);
            writer.WriteStringValue(FabricObjectId);
            writer.WritePropertyName("primaryLocation"u8);
            writer.WriteStringValue(PrimaryLocation);
            writer.WritePropertyName("recoveryLocation"u8);
            writer.WriteStringValue(RecoveryLocation);
            writer.WritePropertyName("recoverySubscriptionId"u8);
            writer.WriteStringValue(RecoverySubscriptionId);
            writer.WritePropertyName("recoveryAvailabilityType"u8);
            writer.WriteStringValue(RecoveryAvailabilityType.ToString());
            if (Optional.IsDefined(ProtectionProfileCustomContent))
            {
                writer.WritePropertyName("protectionProfileCustomInput"u8);
                writer.WriteObjectValue(ProtectionProfileCustomContent);
            }
            writer.WritePropertyName("recoveryResourceGroupId"u8);
            writer.WriteStringValue(RecoveryResourceGroupId);
            if (Optional.IsDefined(PrimaryStagingStorageAccountCustomContent))
            {
                writer.WritePropertyName("primaryStagingStorageAccountCustomInput"u8);
                writer.WriteObjectValue(PrimaryStagingStorageAccountCustomContent);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetCustomContent))
            {
                writer.WritePropertyName("recoveryAvailabilitySetCustomInput"u8);
                writer.WriteObjectValue(RecoveryAvailabilitySetCustomContent);
            }
            if (Optional.IsDefined(RecoveryVirtualNetworkCustomContent))
            {
                writer.WritePropertyName("recoveryVirtualNetworkCustomInput"u8);
                writer.WriteObjectValue(RecoveryVirtualNetworkCustomContent);
            }
            if (Optional.IsDefined(RecoveryProximityPlacementGroupCustomContent))
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupCustomInput"u8);
                writer.WriteObjectValue(RecoveryProximityPlacementGroupCustomContent);
            }
            if (Optional.IsDefined(AutoProtectionOfDataDisk))
            {
                writer.WritePropertyName("autoProtectionOfDataDisk"u8);
                writer.WriteStringValue(AutoProtectionOfDataDisk.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmManagedDisks))
            {
                writer.WritePropertyName("vmManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (Optional.IsDefined(MultiVmGroupId))
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (Optional.IsDefined(RecoveryBootDiagStorageAccount))
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccount"u8);
                writer.WriteObjectValue(RecoveryBootDiagStorageAccount);
            }
            if (Optional.IsDefined(DiskEncryptionInfo))
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                writer.WritePropertyName("agentAutoUpdateStatus"u8);
                writer.WriteStringValue(AgentAutoUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                writer.WritePropertyName("automationAccountAuthenticationType"u8);
                writer.WriteStringValue(AutomationAccountAuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountArmId))
            {
                writer.WritePropertyName("automationAccountArmId"u8);
                writer.WriteStringValue(AutomationAccountArmId);
            }
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

        A2ACreateProtectionIntentContent IJsonModel<A2ACreateProtectionIntentContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACreateProtectionIntentContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ACreateProtectionIntentContent(document.RootElement, options);
        }

        internal static A2ACreateProtectionIntentContent DeserializeA2ACreateProtectionIntentContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier fabricObjectId = default;
            AzureLocation primaryLocation = default;
            AzureLocation recoveryLocation = default;
            string recoverySubscriptionId = default;
            A2ARecoveryAvailabilityType recoveryAvailabilityType = default;
            Optional<ProtectionProfileCustomDetails> protectionProfileCustomContent = default;
            ResourceIdentifier recoveryResourceGroupId = default;
            Optional<StorageAccountCustomDetails> primaryStagingStorageAccountCustomContent = default;
            Optional<RecoveryAvailabilitySetCustomDetails> recoveryAvailabilitySetCustomContent = default;
            Optional<RecoveryVirtualNetworkCustomDetails> recoveryVirtualNetworkCustomContent = default;
            Optional<RecoveryProximityPlacementGroupCustomDetails> recoveryProximityPlacementGroupCustomContent = default;
            Optional<AutoProtectionOfDataDisk> autoProtectionOfDataDisk = default;
            Optional<IList<A2AProtectionIntentDiskDetails>> vmDisks = default;
            Optional<IList<A2AProtectionIntentManagedDiskDetails>> vmManagedDisks = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> multiVmGroupId = default;
            Optional<StorageAccountCustomDetails> recoveryBootDiagStorageAccount = default;
            Optional<SiteRecoveryDiskEncryptionInfo> diskEncryptionInfo = default;
            Optional<string> recoveryAvailabilityZone = default;
            Optional<SiteRecoveryAgentAutoUpdateStatus> agentAutoUpdateStatus = default;
            Optional<AutomationAccountAuthenticationType> automationAccountAuthenticationType = default;
            Optional<ResourceIdentifier> automationAccountArmId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricObjectId"u8))
                {
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryLocation"u8))
                {
                    primaryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryLocation"u8))
                {
                    recoveryLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoverySubscriptionId"u8))
                {
                    recoverySubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityType"u8))
                {
                    recoveryAvailabilityType = new A2ARecoveryAvailabilityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionProfileCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionProfileCustomContent = ProtectionProfileCustomDetails.DeserializeProtectionProfileCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryStagingStorageAccountCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingStorageAccountCustomContent = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetCustomContent = RecoveryAvailabilitySetCustomDetails.DeserializeRecoveryAvailabilitySetCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryVirtualNetworkCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVirtualNetworkCustomContent = RecoveryVirtualNetworkCustomDetails.DeserializeRecoveryVirtualNetworkCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryProximityPlacementGroupCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroupCustomContent = RecoveryProximityPlacementGroupCustomDetails.DeserializeRecoveryProximityPlacementGroupCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("autoProtectionOfDataDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoProtectionOfDataDisk = new AutoProtectionOfDataDisk(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AProtectionIntentDiskDetails> array = new List<A2AProtectionIntentDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AProtectionIntentDiskDetails.DeserializeA2AProtectionIntentDiskDetails(item));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("vmManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AProtectionIntentManagedDiskDetails> array = new List<A2AProtectionIntentManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AProtectionIntentManagedDiskDetails.DeserializeA2AProtectionIntentManagedDiskDetails(item));
                    }
                    vmManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryBootDiagStorageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryBootDiagStorageAccount = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityZone"u8))
                {
                    recoveryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentAutoUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentAutoUpdateStatus = new SiteRecoveryAgentAutoUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountAuthenticationType = new AutomationAccountAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountArmId = new ResourceIdentifier(property.Value.GetString());
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
            return new A2ACreateProtectionIntentContent(instanceType, serializedAdditionalRawData, fabricObjectId, primaryLocation, recoveryLocation, recoverySubscriptionId, recoveryAvailabilityType, protectionProfileCustomContent.Value, recoveryResourceGroupId, primaryStagingStorageAccountCustomContent.Value, recoveryAvailabilitySetCustomContent.Value, recoveryVirtualNetworkCustomContent.Value, recoveryProximityPlacementGroupCustomContent.Value, Optional.ToNullable(autoProtectionOfDataDisk), Optional.ToList(vmDisks), Optional.ToList(vmManagedDisks), multiVmGroupName.Value, multiVmGroupId.Value, recoveryBootDiagStorageAccount.Value, diskEncryptionInfo.Value, recoveryAvailabilityZone.Value, Optional.ToNullable(agentAutoUpdateStatus), Optional.ToNullable(automationAccountAuthenticationType), automationAccountArmId.Value);
        }

        BinaryData IPersistableModel<A2ACreateProtectionIntentContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACreateProtectionIntentContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        A2ACreateProtectionIntentContent IPersistableModel<A2ACreateProtectionIntentContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACreateProtectionIntentContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeA2ACreateProtectionIntentContent(document.RootElement, options);
        }

        string IPersistableModel<A2ACreateProtectionIntentContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
