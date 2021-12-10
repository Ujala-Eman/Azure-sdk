// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class TriggerPropertiesAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence");
                writer.WriteObjectValue(Recurrence);
            }
            if (Optional.IsDefined(RecurrenceInterval))
            {
                writer.WritePropertyName("recurrenceInterval");
                writer.WriteStringValue(RecurrenceInterval);
            }
            if (Optional.IsDefined(ScanLevel))
            {
                writer.WritePropertyName("scanLevel");
                writer.WriteStringValue(ScanLevel.Value.ToString());
            }
            if (Optional.IsDefined(IncrementalScanStartTime))
            {
                writer.WritePropertyName("incrementalScanStartTime");
                writer.WriteStringValue(IncrementalScanStartTime.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static TriggerPropertiesAutoGenerated DeserializeTriggerPropertiesAutoGenerated(JsonElement element)
        {
            Optional<TriggerPropertiesRecurrence> recurrence = default;
            Optional<string> recurrenceInterval = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            Optional<DateTimeOffset> lastScheduled = default;
            Optional<ScanLevelType> scanLevel = default;
            Optional<DateTimeOffset> incrementalScanStartTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recurrence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recurrence = TriggerPropertiesRecurrence.DeserializeTriggerPropertiesRecurrence(property.Value);
                    continue;
                }
                if (property.NameEquals("recurrenceInterval"))
                {
                    recurrenceInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastScheduled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastScheduled = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scanLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scanLevel = new ScanLevelType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incrementalScanStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    incrementalScanStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new TriggerPropertiesAutoGenerated(recurrence.Value, recurrenceInterval.Value, Optional.ToNullable(createdAt), Optional.ToNullable(lastModifiedAt), Optional.ToNullable(lastScheduled), Optional.ToNullable(scanLevel), Optional.ToNullable(incrementalScanStartTime));
        }
    }
}
