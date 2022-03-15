// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolPerformanceLevelCapability
    {
        internal static ElasticPoolPerformanceLevelCapability DeserializeElasticPoolPerformanceLevelCapability(JsonElement element)
        {
            Optional<PerformanceLevelCapability> performanceLevel = default;
            Optional<SqlSku> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<int> maxDatabaseCount = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedMaxSizes = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedPerDatabaseMaxSizes = default;
            Optional<IReadOnlyList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>> supportedPerDatabaseMaxPerformanceLevels = default;
            Optional<bool> zoneRedundant = default;
            Optional<IReadOnlyList<MaintenanceConfigurationCapability>> supportedMaintenanceConfigurations = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("performanceLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("maxDatabaseCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxDatabaseCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedMaxSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("supportedPerDatabaseMaxSizes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedPerDatabaseMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("supportedPerDatabaseMaxPerformanceLevels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> array = new List<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolPerDatabaseMaxPerformanceLevelCapability.DeserializeElasticPoolPerDatabaseMaxPerformanceLevelCapability(item));
                    }
                    supportedPerDatabaseMaxPerformanceLevels = array;
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
                if (property.NameEquals("supportedMaintenanceConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MaintenanceConfigurationCapability> array = new List<MaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceConfigurationCapability.DeserializeMaintenanceConfigurationCapability(item));
                    }
                    supportedMaintenanceConfigurations = array;
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
            return new ElasticPoolPerformanceLevelCapability(performanceLevel.Value, sku.Value, Optional.ToList(supportedLicenseTypes), Optional.ToNullable(maxDatabaseCount), includedMaxSize.Value, Optional.ToList(supportedMaxSizes), Optional.ToList(supportedPerDatabaseMaxSizes), Optional.ToList(supportedPerDatabaseMaxPerformanceLevels), Optional.ToNullable(zoneRedundant), Optional.ToList(supportedMaintenanceConfigurations), Optional.ToNullable(status), reason.Value);
        }
    }
}
