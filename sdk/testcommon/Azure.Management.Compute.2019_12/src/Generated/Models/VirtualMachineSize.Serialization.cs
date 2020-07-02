// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineSize
    {
        internal static VirtualMachineSize DeserializeVirtualMachineSize(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> numberOfCores = default;
            Optional<int> osDiskSizeInMB = default;
            Optional<int> resourceDiskSizeInMB = default;
            Optional<int> memoryInMB = default;
            Optional<int> maxDataDiskCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfCores"))
                {
                    numberOfCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osDiskSizeInMB"))
                {
                    osDiskSizeInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceDiskSizeInMB"))
                {
                    resourceDiskSizeInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryInMB"))
                {
                    memoryInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"))
                {
                    maxDataDiskCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new VirtualMachineSize(name.HasValue ? name.Value : null, numberOfCores.HasValue ? numberOfCores.Value : (int?)null, osDiskSizeInMB.HasValue ? osDiskSizeInMB.Value : (int?)null, resourceDiskSizeInMB.HasValue ? resourceDiskSizeInMB.Value : (int?)null, memoryInMB.HasValue ? memoryInMB.Value : (int?)null, maxDataDiskCount.HasValue ? maxDataDiskCount.Value : (int?)null);
        }
    }
}
