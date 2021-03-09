// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class SeriesResultList
    {
        internal static SeriesResultList DeserializeSeriesResultList(JsonElement element)
        {
            IReadOnlyList<MetricEnrichedSeriesData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<MetricEnrichedSeriesData> array = new List<MetricEnrichedSeriesData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricEnrichedSeriesData.DeserializeMetricEnrichedSeriesData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SeriesResultList(value);
        }
    }
}
