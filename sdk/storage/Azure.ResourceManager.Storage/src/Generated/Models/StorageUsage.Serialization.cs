// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageUsage
    {
        internal static StorageUsage DeserializeStorageUsage(JsonElement element)
        {
            Optional<UsageUnit> unit = default;
            Optional<int> currentValue = default;
            Optional<int> limit = default;
            Optional<UsageName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = property.Value.GetString().ToUsageUnit();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = UsageName.DeserializeUsageName(property.Value);
                    continue;
                }
            }
            return new StorageUsage(Optional.ToNullable(unit), Optional.ToNullable(currentValue), Optional.ToNullable(limit), name.Value);
        }
    }
}
