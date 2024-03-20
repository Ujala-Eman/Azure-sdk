// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MetricFeedbackFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            if (Optional.IsDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter"u8);
                writer.WriteObjectValue(DimensionFilter);
            }
            if (Optional.IsDefined(FeedbackType))
            {
                writer.WritePropertyName("feedbackType"u8);
                writer.WriteStringValue(FeedbackType.Value.ToString());
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime.Value, "O");
            }
            if (Optional.IsDefined(TimeMode))
            {
                writer.WritePropertyName("timeMode"u8);
                writer.WriteStringValue(TimeMode.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
