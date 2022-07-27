// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AutoPatchingSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek");
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaintenanceWindowStartingHour))
            {
                writer.WritePropertyName("maintenanceWindowStartingHour");
                writer.WriteNumberValue(MaintenanceWindowStartingHour.Value);
            }
            if (Optional.IsDefined(MaintenanceWindowDuration))
            {
                writer.WritePropertyName("maintenanceWindowDuration");
                writer.WriteNumberValue(MaintenanceWindowDuration.Value);
            }
            writer.WriteEndObject();
        }

        internal static AutoPatchingSettings DeserializeAutoPatchingSettings(JsonElement element)
        {
            Optional<bool> enable = default;
            Optional<AutoPatchingDayOfWeek> dayOfWeek = default;
            Optional<int> maintenanceWindowStartingHour = default;
            Optional<int> maintenanceWindowDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToAutoPatchingDayOfWeek();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowStartingHour"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maintenanceWindowStartingHour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maintenanceWindowDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maintenanceWindowDuration = property.Value.GetInt32();
                    continue;
                }
            }
            return new AutoPatchingSettings(Optional.ToNullable(enable), Optional.ToNullable(dayOfWeek), Optional.ToNullable(maintenanceWindowStartingHour), Optional.ToNullable(maintenanceWindowDuration));
        }
    }
}
