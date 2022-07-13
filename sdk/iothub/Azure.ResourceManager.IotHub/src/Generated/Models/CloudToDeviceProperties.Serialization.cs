// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class CloudToDeviceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount");
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(DefaultTtlAsIso8601))
            {
                writer.WritePropertyName("defaultTtlAsIso8601");
                writer.WriteStringValue(DefaultTtlAsIso8601.Value, "P");
            }
            if (Optional.IsDefined(Feedback))
            {
                writer.WritePropertyName("feedback");
                writer.WriteObjectValue(Feedback);
            }
            writer.WriteEndObject();
        }

        internal static CloudToDeviceProperties DeserializeCloudToDeviceProperties(JsonElement element)
        {
            Optional<int> maxDeliveryCount = default;
            Optional<TimeSpan> defaultTtlAsIso8601 = default;
            Optional<FeedbackProperties> feedback = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxDeliveryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultTtlAsIso8601"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultTtlAsIso8601 = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("feedback"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    feedback = FeedbackProperties.DeserializeFeedbackProperties(property.Value);
                    continue;
                }
            }
            return new CloudToDeviceProperties(Optional.ToNullable(maxDeliveryCount), Optional.ToNullable(defaultTtlAsIso8601), feedback.Value);
        }
    }
}
