// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmReplicationDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageRcmReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageRcmReplicationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageRcmReplicationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmReplicationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType);
            }
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(TargetResourceGroupId))
            {
                writer.WritePropertyName("targetResourceGroupId"u8);
                writer.WriteStringValue(TargetResourceGroupId);
            }
            if (Optional.IsDefined(TargetLocation))
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(TargetBootDiagnosticsStorageAccountId))
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId"u8);
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsCollectionDefined(ProtectedDisks))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<InMageRcmProtectedDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MobilityAgentDetails))
            {
                writer.WritePropertyName("mobilityAgentDetails"u8);
                if (MobilityAgentDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InMageRcmMobilityAgentDetails>)MobilityAgentDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(LastAgentUpgradeErrorDetails))
            {
                writer.WritePropertyName("lastAgentUpgradeErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in LastAgentUpgradeErrorDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<InMageRcmLastAgentUpgradeErrorDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AgentUpgradeBlockingErrorDetails))
            {
                writer.WritePropertyName("agentUpgradeBlockingErrorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AgentUpgradeBlockingErrorDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<InMageRcmAgentUpgradeBlockingErrorDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<InMageRcmNicDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiscoveredVmDetails))
            {
                writer.WritePropertyName("discoveredVmDetails"u8);
                if (DiscoveredVmDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InMageRcmDiscoveredProtectedVmDetails>)DiscoveredVmDetails).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static InMageRcmReplicationDetails DeserializeInMageRcmReplicationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> internalIdentifier = default;
            Optional<string> fabricDiscoveryMachineId = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> discoveryType = default;
            Optional<Guid> processServerId = default;
            Optional<int> processorCoreCount = default;
            Optional<double> allocatedMemoryInMB = default;
            Optional<string> processServerName = default;
            Optional<string> runAsAccountId = default;
            Optional<string> osType = default;
            Optional<string> firmwareType = default;
            Optional<IPAddress> primaryNicIPAddress = default;
            Optional<string> targetGeneration = default;
            Optional<string> licenseType = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<string> targetVmName = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> targetResourceGroupId = default;
            Optional<string> targetLocation = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<ResourceIdentifier> targetBootDiagnosticsStorageAccountId = default;
            Optional<ResourceIdentifier> targetNetworkId = default;
            Optional<ResourceIdentifier> testNetworkId = default;
            Optional<ResourceIdentifier> failoverRecoveryPointId = default;
            Optional<DateTimeOffset> lastRecoveryPointReceived = default;
            Optional<long> lastRpoInSeconds = default;
            Optional<DateTimeOffset> lastRpoCalculatedTime = default;
            Optional<ResourceIdentifier> lastRecoveryPointId = default;
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
            Optional<MobilityAgentUpgradeState> agentUpgradeState = default;
            Optional<string> lastAgentUpgradeType = default;
            Optional<string> agentUpgradeJobId = default;
            Optional<string> agentUpgradeAttemptToVersion = default;
            Optional<IReadOnlyList<InMageRcmProtectedDiskDetails>> protectedDisks = default;
            Optional<string> isLastUpgradeSuccessful = default;
            Optional<bool> isAgentRegistrationSuccessfulAfterFailover = default;
            Optional<InMageRcmMobilityAgentDetails> mobilityAgentDetails = default;
            Optional<IReadOnlyList<InMageRcmLastAgentUpgradeErrorDetails>> lastAgentUpgradeErrorDetails = default;
            Optional<IReadOnlyList<InMageRcmAgentUpgradeBlockingErrorDetails>> agentUpgradeBlockingErrorDetails = default;
            Optional<IReadOnlyList<InMageRcmNicDetails>> vmNics = default;
            Optional<InMageRcmDiscoveredProtectedVmDetails> discoveredVmDetails = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internalIdentifier"u8))
                {
                    internalIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricDiscoveryMachineId"u8))
                {
                    fabricDiscoveryMachineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryType"u8))
                {
                    discoveryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("processorCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocatedMemoryInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocatedMemoryInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("processServerName"u8))
                {
                    processServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareType"u8))
                {
                    firmwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryNicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryNicIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetGeneration"u8))
                {
                    targetGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetBootDiagnosticsStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBootDiagnosticsStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointReceived = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("agentUpgradeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentUpgradeState = new MobilityAgentUpgradeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastAgentUpgradeType"u8))
                {
                    lastAgentUpgradeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentUpgradeJobId"u8))
                {
                    agentUpgradeJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentUpgradeAttemptToVersion"u8))
                {
                    agentUpgradeAttemptToVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmProtectedDiskDetails> array = new List<InMageRcmProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmProtectedDiskDetails.DeserializeInMageRcmProtectedDiskDetails(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("isLastUpgradeSuccessful"u8))
                {
                    isLastUpgradeSuccessful = property.Value.GetString();
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
                if (property.NameEquals("mobilityAgentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mobilityAgentDetails = InMageRcmMobilityAgentDetails.DeserializeInMageRcmMobilityAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastAgentUpgradeErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmLastAgentUpgradeErrorDetails> array = new List<InMageRcmLastAgentUpgradeErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmLastAgentUpgradeErrorDetails.DeserializeInMageRcmLastAgentUpgradeErrorDetails(item));
                    }
                    lastAgentUpgradeErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("agentUpgradeBlockingErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmAgentUpgradeBlockingErrorDetails> array = new List<InMageRcmAgentUpgradeBlockingErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmAgentUpgradeBlockingErrorDetails.DeserializeInMageRcmAgentUpgradeBlockingErrorDetails(item));
                    }
                    agentUpgradeBlockingErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmNicDetails> array = new List<InMageRcmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmNicDetails.DeserializeInMageRcmNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("discoveredVmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discoveredVmDetails = InMageRcmDiscoveredProtectedVmDetails.DeserializeInMageRcmDiscoveredProtectedVmDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageRcmReplicationDetails(instanceType, internalIdentifier.Value, fabricDiscoveryMachineId.Value, multiVmGroupName.Value, discoveryType.Value, Optional.ToNullable(processServerId), Optional.ToNullable(processorCoreCount), Optional.ToNullable(allocatedMemoryInMB), processServerName.Value, runAsAccountId.Value, osType.Value, firmwareType.Value, primaryNicIPAddress.Value, targetGeneration.Value, licenseType.Value, storageAccountId.Value, targetVmName.Value, targetVmSize.Value, targetResourceGroupId.Value, targetLocation.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, targetBootDiagnosticsStorageAccountId.Value, targetNetworkId.Value, testNetworkId.Value, failoverRecoveryPointId.Value, Optional.ToNullable(lastRecoveryPointReceived), Optional.ToNullable(lastRpoInSeconds), Optional.ToNullable(lastRpoCalculatedTime), lastRecoveryPointId.Value, Optional.ToNullable(initialReplicationProgressPercentage), Optional.ToNullable(initialReplicationProcessedBytes), Optional.ToNullable(initialReplicationTransferredBytes), Optional.ToNullable(initialReplicationProgressHealth), Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTransferredBytes), Optional.ToNullable(resyncProgressHealth), resyncRequired.Value, Optional.ToNullable(resyncState), Optional.ToNullable(agentUpgradeState), lastAgentUpgradeType.Value, agentUpgradeJobId.Value, agentUpgradeAttemptToVersion.Value, Optional.ToList(protectedDisks), isLastUpgradeSuccessful.Value, Optional.ToNullable(isAgentRegistrationSuccessfulAfterFailover), mobilityAgentDetails.Value, Optional.ToList(lastAgentUpgradeErrorDetails), Optional.ToList(agentUpgradeBlockingErrorDetails), Optional.ToList(vmNics), discoveredVmDetails.Value, rawData);
        }

        InMageRcmReplicationDetails IModelJsonSerializable<InMageRcmReplicationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmReplicationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageRcmReplicationDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmReplicationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageRcmReplicationDetails IModelSerializable<InMageRcmReplicationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<InMageRcmReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageRcmReplicationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InMageRcmReplicationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InMageRcmReplicationDetails"/> to convert. </param>
        public static implicit operator RequestContent(InMageRcmReplicationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InMageRcmReplicationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InMageRcmReplicationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageRcmReplicationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
