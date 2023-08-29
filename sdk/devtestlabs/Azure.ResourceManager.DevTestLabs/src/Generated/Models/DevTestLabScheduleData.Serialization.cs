// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabScheduleData : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabScheduleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabScheduleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(TaskType))
            {
                writer.WritePropertyName("taskType"u8);
                writer.WriteStringValue(TaskType);
            }
            if (Optional.IsDefined(WeeklyRecurrence))
            {
                writer.WritePropertyName("weeklyRecurrence"u8);
                writer.WriteObjectValue(WeeklyRecurrence);
            }
            if (Optional.IsDefined(DailyRecurrence))
            {
                writer.WritePropertyName("dailyRecurrence"u8);
                writer.WriteObjectValue(DailyRecurrence);
            }
            if (Optional.IsDefined(HourlyRecurrence))
            {
                writer.WritePropertyName("hourlyRecurrence"u8);
                writer.WriteObjectValue(HourlyRecurrence);
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsDefined(NotificationSettings))
            {
                writer.WritePropertyName("notificationSettings"u8);
                writer.WriteObjectValue(NotificationSettings);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabScheduleData DeserializeDevTestLabScheduleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevTestLabEnableStatus> status = default;
            Optional<string> taskType = default;
            Optional<DevTestLabWeekDetails> weeklyRecurrence = default;
            Optional<DayDetails> dailyRecurrence = default;
            Optional<HourDetails> hourlyRecurrence = default;
            Optional<string> timeZoneId = default;
            Optional<DevTestLabNotificationSettings> notificationSettings = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> targetResourceId = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new DevTestLabEnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("taskType"u8))
                        {
                            taskType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weeklyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weeklyRecurrence = DevTestLabWeekDetails.DeserializeDevTestLabWeekDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dailyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dailyRecurrence = DayDetails.DeserializeDayDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hourlyRecurrence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hourlyRecurrence = HourDetails.DeserializeHourDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("notificationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationSettings = DevTestLabNotificationSettings.DeserializeDevTestLabNotificationSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            targetResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabScheduleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(status), taskType.Value, weeklyRecurrence.Value, dailyRecurrence.Value, hourlyRecurrence.Value, timeZoneId.Value, notificationSettings.Value, Optional.ToNullable(createdDate), targetResourceId.Value, provisioningState.Value, Optional.ToNullable(uniqueIdentifier), rawData);
        }

        DevTestLabScheduleData IModelJsonSerializable<DevTestLabScheduleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabScheduleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabScheduleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabScheduleData IModelSerializable<DevTestLabScheduleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabScheduleData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DevTestLabScheduleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DevTestLabScheduleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabScheduleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
