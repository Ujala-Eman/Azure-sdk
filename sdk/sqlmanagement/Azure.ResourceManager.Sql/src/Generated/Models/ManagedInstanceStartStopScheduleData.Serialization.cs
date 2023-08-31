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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceStartStopScheduleData : IUtf8JsonSerializable, IModelJsonSerializable<ManagedInstanceStartStopScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedInstanceStartStopScheduleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedInstanceStartStopScheduleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TimeZoneId))
            {
                writer.WritePropertyName("timeZoneId"u8);
                writer.WriteStringValue(TimeZoneId);
            }
            if (Optional.IsCollectionDefined(ScheduleList))
            {
                writer.WritePropertyName("scheduleList"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleList)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SqlScheduleItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ManagedInstanceStartStopScheduleData DeserializeManagedInstanceStartStopScheduleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<string> timeZoneId = default;
            Optional<IList<SqlScheduleItem>> scheduleList = default;
            Optional<string> nextRunAction = default;
            Optional<string> nextExecutionTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeZoneId"u8))
                        {
                            timeZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scheduleList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SqlScheduleItem> array = new List<SqlScheduleItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SqlScheduleItem.DeserializeSqlScheduleItem(item));
                            }
                            scheduleList = array;
                            continue;
                        }
                        if (property0.NameEquals("nextRunAction"u8))
                        {
                            nextRunAction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nextExecutionTime"u8))
                        {
                            nextExecutionTime = property0.Value.GetString();
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
            return new ManagedInstanceStartStopScheduleData(id, name, type, systemData.Value, description.Value, timeZoneId.Value, Optional.ToList(scheduleList), nextRunAction.Value, nextExecutionTime.Value, rawData);
        }

        ManagedInstanceStartStopScheduleData IModelJsonSerializable<ManagedInstanceStartStopScheduleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceStartStopScheduleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedInstanceStartStopScheduleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedInstanceStartStopScheduleData IModelSerializable<ManagedInstanceStartStopScheduleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedInstanceStartStopScheduleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedInstanceStartStopScheduleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedInstanceStartStopScheduleData"/> to convert. </param>
        public static implicit operator RequestContent(ManagedInstanceStartStopScheduleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedInstanceStartStopScheduleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedInstanceStartStopScheduleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedInstanceStartStopScheduleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
