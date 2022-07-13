// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class VmSizeProperty
    {
        internal static VmSizeProperty DeserializeVmSizeProperty(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> cores = default;
            Optional<string> dataDiskStorageTier = default;
            Optional<string> label = default;
            Optional<long> maxDataDiskCount = default;
            Optional<long> memoryInMb = default;
            Optional<bool> supportedByVirtualMachines = default;
            Optional<bool> supportedByWebWorkerRoles = default;
            Optional<long> virtualMachineResourceDiskSizeInMb = default;
            Optional<long> webWorkerResourceDiskSizeInMb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cores"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataDiskStorageTier"))
                {
                    dataDiskStorageTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxDataDiskCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedByVirtualMachines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportedByVirtualMachines = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedByWebWorkerRoles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportedByWebWorkerRoles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualMachineResourceDiskSizeInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    virtualMachineResourceDiskSizeInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("webWorkerResourceDiskSizeInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    webWorkerResourceDiskSizeInMb = property.Value.GetInt64();
                    continue;
                }
            }
            return new VmSizeProperty(name.Value, Optional.ToNullable(cores), dataDiskStorageTier.Value, label.Value, Optional.ToNullable(maxDataDiskCount), Optional.ToNullable(memoryInMb), Optional.ToNullable(supportedByVirtualMachines), Optional.ToNullable(supportedByWebWorkerRoles), Optional.ToNullable(virtualMachineResourceDiskSizeInMb), Optional.ToNullable(webWorkerResourceDiskSizeInMb));
        }
    }
}
