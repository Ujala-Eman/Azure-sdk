// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Workloads;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    internal partial class MonitorListResult
    {
        internal static MonitorListResult DeserializeMonitorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<WorkloadMonitorData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WorkloadMonitorData> array = new List<WorkloadMonitorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkloadMonitorData.DeserializeWorkloadMonitorData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MonitorListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
