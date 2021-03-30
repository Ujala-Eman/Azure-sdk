// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ActivityRunConverter))]
    public partial class ActivityRun
    {
        internal static ActivityRun DeserializeActivityRun(JsonElement element)
        {
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
                if (property.NameEquals("pipelineName"))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"))
                {
                    pipelineRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityName"))
                {
                    activityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityType"))
                {
                    activityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunId"))
                {
                    activityRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunStart"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activityRunStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityRunEnd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    activityRunEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("input"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    input = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    output = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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

        internal partial class ActivityRunConverter : JsonConverter<ActivityRun>
        {
            public override void Write(Utf8JsonWriter writer, ActivityRun model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ActivityRun Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityRun(document.RootElement);
            }
        }
    }
}
