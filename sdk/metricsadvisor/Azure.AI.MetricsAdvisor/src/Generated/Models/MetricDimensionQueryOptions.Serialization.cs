// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricDimensionQueryOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dimensionName");
            writer.WriteStringValue(DimensionName);
            if (Optional.IsDefined(DimensionValueFilter))
            {
                writer.WritePropertyName("dimensionValueFilter");
                writer.WriteStringValue(DimensionValueFilter);
            }
            writer.WriteEndObject();
        }
    }
}
