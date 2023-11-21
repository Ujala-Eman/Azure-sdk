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
    public partial class InMageRcmFailbackReplicationDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFailbackReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFailbackReplicationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFailbackReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageRcmFailbackReplicationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(InternalIdentifier))
            {
                writer.WritePropertyName("internalIdentifier"u8);
                writer.WriteStringValue(InternalIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureVirtualMachineId))
            {
                writer.WritePropertyName("azureVirtualMachineId"u8);
                writer.WriteStringValue(AzureVirtualMachineId);
            }
            if (options.Format != "W" && Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (options.Format != "W" && Optional.IsDefined(ReprotectAgentId))
            {
                writer.WritePropertyName("reprotectAgentId"u8);
                writer.WriteStringValue(ReprotectAgentId);
            }
            if (options.Format != "W" && Optional.IsDefined(ReprotectAgentName))
            {
                writer.WritePropertyName("reprotectAgentName"u8);
                writer.WriteStringValue(ReprotectAgentName);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(LogStorageAccountId))
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetVCenterId))
            {
                writer.WritePropertyName("targetvCenterId"u8);
                writer.WriteStringValue(TargetVCenterId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetDataStoreName))
            {
                writer.WritePropertyName("targetDataStoreName"u8);
                writer.WriteStringValue(TargetDataStoreName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationProgressPercentage))
            {
                writer.WritePropertyName("initialReplicationProgressPercentage"u8);
                writer.WriteNumberValue(InitialReplicationProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationProcessedBytes))
            {
                writer.WritePropertyName("initialReplicationProcessedBytes"u8);
                writer.WriteNumberValue(InitialReplicationProcessedBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationTransferredBytes))
            {
                writer.WritePropertyName("initialReplicationTransferredBytes"u8);
                writer.WriteNumberValue(InitialReplicationTransferredBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InitialReplicationProgressHealth))
            {
                writer.WritePropertyName("initialReplicationProgressHealth"u8);
                writer.WriteStringValue(InitialReplicationProgressHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncProgressPercentage))
            {
                writer.WritePropertyName("resyncProgressPercentage"u8);
                writer.WriteNumberValue(ResyncProgressPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncProcessedBytes))
            {
                writer.WritePropertyName("resyncProcessedBytes"u8);
                writer.WriteNumberValue(ResyncProcessedBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncTransferredBytes))
            {
                writer.WritePropertyName("resyncTransferredBytes"u8);
                writer.WriteNumberValue(ResyncTransferredBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncProgressHealth))
            {
                writer.WritePropertyName("resyncProgressHealth"u8);
                writer.WriteStringValue(ResyncProgressHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteStringValue(ResyncRequired);
            }
            if (options.Format != "W" && Optional.IsDefined(ResyncState))
            {
                writer.WritePropertyName("resyncState"u8);
                writer.WriteStringValue(ResyncState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ProtectedDisks))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MobilityAgentDetails))
            {
                writer.WritePropertyName("mobilityAgentDetails"u8);
                writer.WriteObjectValue(MobilityAgentDetails);
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastPlannedFailoverStartOn))
            {
                writer.WritePropertyName("lastPlannedFailoverStartTime"u8);
                writer.WriteStringValue(LastPlannedFailoverStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastPlannedFailoverStatus))
            {
                writer.WritePropertyName("lastPlannedFailoverStatus"u8);
                writer.WriteStringValue(LastPlannedFailoverStatus.Value.ToString());
            }
            if (Optional.IsDefined(DiscoveredVmDetails))
            {
                writer.WritePropertyName("discoveredVmDetails"u8);
                writer.WriteObjectValue(DiscoveredVmDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUsedPolicyId))
            {
                writer.WritePropertyName("lastUsedPolicyId"u8);
                writer.WriteStringValue(LastUsedPolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUsedPolicyFriendlyName))
            {
                writer.WritePropertyName("lastUsedPolicyFriendlyName"u8);
                writer.WriteStringValue(LastUsedPolicyFriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsAgentRegistrationSuccessfulAfterFailover))
            {
                writer.WritePropertyName("isAgentRegistrationSuccessfulAfterFailover"u8);
                writer.WriteBooleanValue(IsAgentRegistrationSuccessfulAfterFailover.Value);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageRcmFailbackReplicationDetails IJsonModel<InMageRcmFailbackReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InMageRcmFailbackReplicationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackReplicationDetails(document.RootElement, options);
        }

        internal static InMageRcmFailbackReplicationDetails DeserializeInMageRcmFailbackReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> internalIdentifier = default;
            Optional<ResourceIdentifier> azureVirtualMachineId = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> reprotectAgentId = default;
            Optional<string> reprotectAgentName = default;
            Optional<string> osType = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<string> targetvCenterId = default;
            Optional<string> targetDataStoreName = default;
            Optional<string> targetVmName = default;
            Optional<int> initialReplicationProgressPercentage = default;
            Optional<long> initialReplicationProcessedBytes = default;
            Optional<long> initialReplicationTransferredBytes = default;
            Optional<VmReplicationProgressHealth> initialReplicationProgressHealth = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<long> resyncProcessedBytes = default;
            Optional<long> resyncTransferredBytes = default;
            Optional<VmReplicationProgressHealth> resyncProgressHealth = default;
            Optional<string> resyncRequired = default;
            Optional<SiteRecoveryResyncState> resyncState = default;
            Optional<IReadOnlyList<InMageRcmFailbackProtectedDiskDetails>> protectedDisks = default;
            Optional<InMageRcmFailbackMobilityAgentDetails> mobilityAgentDetails = default;
            Optional<IReadOnlyList<InMageRcmFailbackNicDetails>> vmNics = default;
            Optional<DateTimeOffset> lastPlannedFailoverStartTime = default;
            Optional<PlannedFailoverStatus> lastPlannedFailoverStatus = default;
            Optional<InMageRcmFailbackDiscoveredProtectedVmDetails> discoveredVmDetails = default;
            Optional<ResourceIdentifier> lastUsedPolicyId = default;
            Optional<string> lastUsedPolicyFriendlyName = default;
            Optional<bool> isAgentRegistrationSuccessfulAfterFailover = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internalIdentifier"u8))
                {
                    internalIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentId"u8))
                {
                    reprotectAgentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentName"u8))
                {
                    reprotectAgentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
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
                if (property.NameEquals("targetvCenterId"u8))
                {
                    targetvCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDataStoreName"u8))
                {
                    targetDataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialReplicationProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialReplicationProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProcessedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncTransferredBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncProgressHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncState = new SiteRecoveryResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmFailbackProtectedDiskDetails> array = new List<InMageRcmFailbackProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackProtectedDiskDetails.DeserializeInMageRcmFailbackProtectedDiskDetails(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("mobilityAgentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mobilityAgentDetails = InMageRcmFailbackMobilityAgentDetails.DeserializeInMageRcmFailbackMobilityAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmFailbackNicDetails> array = new List<InMageRcmFailbackNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackNicDetails.DeserializeInMageRcmFailbackNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPlannedFailoverStatus = new PlannedFailoverStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("discoveredVmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveredVmDetails = InMageRcmFailbackDiscoveredProtectedVmDetails.DeserializeInMageRcmFailbackDiscoveredProtectedVmDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUsedPolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyFriendlyName"u8))
                {
                    lastUsedPolicyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAgentRegistrationSuccessfulAfterFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAgentRegistrationSuccessfulAfterFailover = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFailbackReplicationDetails(instanceType, serializedAdditionalRawData, internalIdentifier.Value, azureVirtualMachineId.Value, multiVmGroupName.Value, reprotectAgentId.Value, reprotectAgentName.Value, osType.Value, logStorageAccountId.Value, targetvCenterId.Value, targetDataStoreName.Value, targetVmName.Value, Optional.ToNullable(initialReplicationProgressPercentage), Optional.ToNullable(initialReplicationProcessedBytes), Optional.ToNullable(initialReplicationTransferredBytes), Optional.ToNullable(initialReplicationProgressHealth), Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTransferredBytes), Optional.ToNullable(resyncProgressHealth), resyncRequired.Value, Optional.ToNullable(resyncState), Optional.ToList(protectedDisks), mobilityAgentDetails.Value, Optional.ToList(vmNics), Optional.ToNullable(lastPlannedFailoverStartTime), Optional.ToNullable(lastPlannedFailoverStatus), discoveredVmDetails.Value, lastUsedPolicyId.Value, lastUsedPolicyFriendlyName.Value, Optional.ToNullable(isAgentRegistrationSuccessfulAfterFailover));
        }

        BinaryData IPersistableModel<InMageRcmFailbackReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageRcmFailbackReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmFailbackReplicationDetails IPersistableModel<InMageRcmFailbackReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFailbackReplicationDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InMageRcmFailbackReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFailbackReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
