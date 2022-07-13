// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBBaseMetric
    {
        internal static CosmosDBBaseMetric DeserializeCosmosDBBaseMetric(JsonElement element)
        {
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> timeGrain = default;
            Optional<CosmosDBMetricUnitType> unit = default;
            Optional<CosmosDBMetricName> name = default;
            Optional<IReadOnlyList<CosmosDBMetricValue>> metricValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeGrain"))
                {
                    timeGrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = new CosmosDBMetricUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = CosmosDBMetricName.DeserializeCosmosDBMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("metricValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBMetricValue> array = new List<CosmosDBMetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBMetricValue.DeserializeCosmosDBMetricValue(item));
                    }
                    metricValues = array;
                    continue;
                }
            }
            return new CosmosDBBaseMetric(Optional.ToNullable(startTime), Optional.ToNullable(endTime), timeGrain.Value, Optional.ToNullable(unit), name.Value, Optional.ToList(metricValues));
        }
    }
}
