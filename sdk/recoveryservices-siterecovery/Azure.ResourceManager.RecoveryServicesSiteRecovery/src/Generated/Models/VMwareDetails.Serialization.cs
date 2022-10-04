// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareDetails
    {
        internal static VMwareDetails DeserializeVMwareDetails(JsonElement element)
        {
            Optional<IReadOnlyList<ProcessServer>> processServers = default;
            Optional<IReadOnlyList<MasterTargetServer>> masterTargetServers = default;
            Optional<IReadOnlyList<RunAsAccount>> runAsAccounts = default;
            Optional<string> replicationPairCount = default;
            Optional<string> processServerCount = default;
            Optional<string> agentCount = default;
            Optional<string> protectedServers = default;
            Optional<string> systemLoad = default;
            Optional<string> systemLoadStatus = default;
            Optional<string> cpuLoad = default;
            Optional<string> cpuLoadStatus = default;
            Optional<long> totalMemoryInBytes = default;
            Optional<long> availableMemoryInBytes = default;
            Optional<string> memoryUsageStatus = default;
            Optional<long> totalSpaceInBytes = default;
            Optional<long> availableSpaceInBytes = default;
            Optional<string> spaceUsageStatus = default;
            Optional<string> webLoad = default;
            Optional<string> webLoadStatus = default;
            Optional<string> databaseServerLoad = default;
            Optional<string> databaseServerLoadStatus = default;
            Optional<string> csServiceStatus = default;
            Optional<string> ipAddress = default;
            Optional<string> agentVersion = default;
            Optional<string> hostName = default;
            Optional<DateTimeOffset> lastHeartbeat = default;
            Optional<string> versionStatus = default;
            Optional<DateTimeOffset> sslCertExpiryDate = default;
            Optional<int> sslCertExpiryRemainingDays = default;
            Optional<string> psTemplateVersion = default;
            Optional<DateTimeOffset> agentExpiryDate = default;
            Optional<VersionDetails> agentVersionDetails = default;
            Optional<IReadOnlyList<InMageFabricSwitchProviderBlockingErrorDetails>> switchProviderBlockingErrorDetails = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProcessServer> array = new List<ProcessServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProcessServer.DeserializeProcessServer(item));
                    }
                    processServers = array;
                    continue;
                }
                if (property.NameEquals("masterTargetServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MasterTargetServer> array = new List<MasterTargetServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MasterTargetServer.DeserializeMasterTargetServer(item));
                    }
                    masterTargetServers = array;
                    continue;
                }
                if (property.NameEquals("runAsAccounts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RunAsAccount> array = new List<RunAsAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunAsAccount.DeserializeRunAsAccount(item));
                    }
                    runAsAccounts = array;
                    continue;
                }
                if (property.NameEquals("replicationPairCount"))
                {
                    replicationPairCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerCount"))
                {
                    processServerCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentCount"))
                {
                    agentCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedServers"))
                {
                    protectedServers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoad"))
                {
                    systemLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemLoadStatus"))
                {
                    systemLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoad"))
                {
                    cpuLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuLoadStatus"))
                {
                    cpuLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalMemoryInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableMemoryInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryUsageStatus"))
                {
                    memoryUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSpaceInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableSpaceInBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availableSpaceInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceUsageStatus"))
                {
                    spaceUsageStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webLoad"))
                {
                    webLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webLoadStatus"))
                {
                    webLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseServerLoad"))
                {
                    databaseServerLoad = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseServerLoadStatus"))
                {
                    databaseServerLoadStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("csServiceStatus"))
                {
                    csServiceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionStatus"))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslCertExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslCertExpiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sslCertExpiryRemainingDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslCertExpiryRemainingDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("psTemplateVersion"))
                {
                    psTemplateVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentExpiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersionDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    agentVersionDetails = VersionDetails.DeserializeVersionDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("switchProviderBlockingErrorDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InMageFabricSwitchProviderBlockingErrorDetails> array = new List<InMageFabricSwitchProviderBlockingErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageFabricSwitchProviderBlockingErrorDetails.DeserializeInMageFabricSwitchProviderBlockingErrorDetails(item));
                    }
                    switchProviderBlockingErrorDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareDetails(instanceType, Optional.ToList(processServers), Optional.ToList(masterTargetServers), Optional.ToList(runAsAccounts), replicationPairCount.Value, processServerCount.Value, agentCount.Value, protectedServers.Value, systemLoad.Value, systemLoadStatus.Value, cpuLoad.Value, cpuLoadStatus.Value, Optional.ToNullable(totalMemoryInBytes), Optional.ToNullable(availableMemoryInBytes), memoryUsageStatus.Value, Optional.ToNullable(totalSpaceInBytes), Optional.ToNullable(availableSpaceInBytes), spaceUsageStatus.Value, webLoad.Value, webLoadStatus.Value, databaseServerLoad.Value, databaseServerLoadStatus.Value, csServiceStatus.Value, ipAddress.Value, agentVersion.Value, hostName.Value, Optional.ToNullable(lastHeartbeat), versionStatus.Value, Optional.ToNullable(sslCertExpiryDate), Optional.ToNullable(sslCertExpiryRemainingDays), psTemplateVersion.Value, Optional.ToNullable(agentExpiryDate), agentVersionDetails.Value, Optional.ToList(switchProviderBlockingErrorDetails));
        }
    }
}
