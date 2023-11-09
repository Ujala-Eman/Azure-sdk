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
    [JsonConverter(typeof(ActivityRunConverter))]
    public partial class ActivityRun : IUtf8JsonSerializable, IJsonModel<ActivityRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActivityRun>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ActivityRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PipelineName))
                {
                    writer.WritePropertyName("pipelineName"u8);
                    writer.WriteStringValue(PipelineName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PipelineRunId))
                {
                    writer.WritePropertyName("pipelineRunId"u8);
                    writer.WriteStringValue(PipelineRunId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityName))
                {
                    writer.WritePropertyName("activityName"u8);
                    writer.WriteStringValue(ActivityName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityType))
                {
                    writer.WritePropertyName("activityType"u8);
                    writer.WriteStringValue(ActivityType);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityRunId))
                {
                    writer.WritePropertyName("activityRunId"u8);
                    writer.WriteStringValue(ActivityRunId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LinkedServiceName))
                {
                    writer.WritePropertyName("linkedServiceName"u8);
                    writer.WriteStringValue(LinkedServiceName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityRunStart))
                {
                    writer.WritePropertyName("activityRunStart"u8);
                    writer.WriteStringValue(ActivityRunStart.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ActivityRunEnd))
                {
                    writer.WritePropertyName("activityRunEnd"u8);
                    writer.WriteStringValue(ActivityRunEnd.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DurationInMs))
                {
                    writer.WritePropertyName("durationInMs"u8);
                    writer.WriteNumberValue(DurationInMs.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Input))
                {
                    writer.WritePropertyName("input"u8);
                    writer.WriteObjectValue(Input);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Output))
                {
                    writer.WritePropertyName("output"u8);
                    writer.WriteObjectValue(Output);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Error))
                {
                    writer.WritePropertyName("error"u8);
                    writer.WriteObjectValue(Error);
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        ActivityRun IJsonModel<ActivityRun>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityRun)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActivityRun(document.RootElement, options);
        }

        internal static ActivityRun DeserializeActivityRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pipelineName = default;
            Optional<string> pipelineRunId = default;
            Optional<string> activityName = default;
            Optional<string> activityType = default;
            Optional<string> activityRunId = default;
            Optional<string> linkedServiceName = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> activityRunStart = default;
            Optional<DateTimeOffset> activityRunEnd = default;
            Optional<int> durationInMs = default;
            Optional<object> input = default;
            Optional<object> output = default;
            Optional<object> error = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    pipelineRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityName"u8))
                {
                    activityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityType"u8))
                {
                    activityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunId"u8))
                {
                    activityRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityRunEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityRun(pipelineName.Value, pipelineRunId.Value, activityName.Value, activityType.Value, activityRunId.Value, linkedServiceName.Value, status.Value, Optional.ToNullable(activityRunStart), Optional.ToNullable(activityRunEnd), Optional.ToNullable(durationInMs), input.Value, output.Value, error.Value, additionalProperties);
        }

        BinaryData IModel<ActivityRun>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityRun)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ActivityRun IModel<ActivityRun>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityRun)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeActivityRun(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ActivityRun>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class ActivityRunConverter : JsonConverter<ActivityRun>
        {
            public override void Write(Utf8JsonWriter writer, ActivityRun model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ActivityRun Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityRun(document.RootElement);
            }
        }
    }
}
