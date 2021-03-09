// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class DetectionSeriesQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime");
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime");
            writer.WriteStringValue(EndTime, "O");
            writer.WritePropertyName("series");
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
