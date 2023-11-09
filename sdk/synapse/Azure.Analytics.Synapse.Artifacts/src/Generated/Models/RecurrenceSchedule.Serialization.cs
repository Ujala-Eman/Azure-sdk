// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RecurrenceScheduleConverter))]
    public partial class RecurrenceSchedule : IUtf8JsonSerializable, IJsonModel<RecurrenceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecurrenceSchedule>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RecurrenceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Minutes))
            {
                writer.WritePropertyName("minutes"u8);
                writer.WriteStartArray();
                foreach (var item in Minutes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Hours))
            {
                writer.WritePropertyName("hours"u8);
                writer.WriteStartArray();
                foreach (var item in Hours)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WeekDays))
            {
                writer.WritePropertyName("weekDays"u8);
                writer.WriteStartArray();
                foreach (var item in WeekDays)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthDays))
            {
                writer.WritePropertyName("monthDays"u8);
                writer.WriteStartArray();
                foreach (var item in MonthDays)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthlyOccurrences))
            {
                writer.WritePropertyName("monthlyOccurrences"u8);
                writer.WriteStartArray();
                foreach (var item in MonthlyOccurrences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        RecurrenceSchedule IJsonModel<RecurrenceSchedule>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecurrenceSchedule(document.RootElement, options);
        }

        internal static RecurrenceSchedule DeserializeRecurrenceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<int>> minutes = default;
            Optional<IList<int>> hours = default;
            Optional<IList<DayOfWeek>> weekDays = default;
            Optional<IList<int>> monthDays = default;
            Optional<IList<RecurrenceScheduleOccurrence>> monthlyOccurrences = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    minutes = array;
                    continue;
                }
                if (property.NameEquals("hours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    hours = array;
                    continue;
                }
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DayOfWeek> array = new List<DayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDayOfWeek());
                    }
                    weekDays = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    monthDays = array;
                    continue;
                }
                if (property.NameEquals("monthlyOccurrences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecurrenceScheduleOccurrence> array = new List<RecurrenceScheduleOccurrence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecurrenceScheduleOccurrence.DeserializeRecurrenceScheduleOccurrence(item));
                    }
                    monthlyOccurrences = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RecurrenceSchedule(Optional.ToList(minutes), Optional.ToList(hours), Optional.ToList(weekDays), Optional.ToList(monthDays), Optional.ToList(monthlyOccurrences), additionalProperties);
        }

        BinaryData IModel<RecurrenceSchedule>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecurrenceSchedule IModel<RecurrenceSchedule>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecurrenceSchedule)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecurrenceSchedule(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RecurrenceSchedule>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class RecurrenceScheduleConverter : JsonConverter<RecurrenceSchedule>
        {
            public override void Write(Utf8JsonWriter writer, RecurrenceSchedule model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RecurrenceSchedule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRecurrenceSchedule(document.RootElement);
            }
        }
    }
}
