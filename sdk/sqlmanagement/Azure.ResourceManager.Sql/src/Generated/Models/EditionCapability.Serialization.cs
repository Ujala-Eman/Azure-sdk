// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace SqlManagementClient.Models
{
    public partial class EditionCapability
    {
        internal static EditionCapability DeserializeEditionCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<ServiceObjectiveCapability>> supportedServiceLevelObjectives = default;
            Optional<bool> zoneRedundant = default;
            Optional<ReadScaleCapability> readScale = default;
            Optional<IReadOnlyList<StorageCapability>> supportedStorageCapabilities = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedServiceLevelObjectives"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceObjectiveCapability> array = new List<ServiceObjectiveCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceObjectiveCapability.DeserializeServiceObjectiveCapability(item));
                    }
                    supportedServiceLevelObjectives = array;
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("readScale"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readScale = ReadScaleCapability.DeserializeReadScaleCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedStorageCapabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StorageCapability> array = new List<StorageCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageCapability.DeserializeStorageCapability(item));
                    }
                    supportedStorageCapabilities = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new EditionCapability(name.Value, Optional.ToList(supportedServiceLevelObjectives), Optional.ToNullable(zoneRedundant), readScale.Value, Optional.ToList(supportedStorageCapabilities), Optional.ToNullable(status), reason.Value);
        }
    }
}
