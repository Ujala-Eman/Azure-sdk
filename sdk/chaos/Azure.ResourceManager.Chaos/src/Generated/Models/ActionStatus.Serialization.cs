// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ActionStatus
    {
        internal static ActionStatus DeserializeActionStatus(JsonElement element)
        {
            Optional<string> actionName = default;
            Optional<string> actionId = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<IReadOnlyList<ExperimentExecutionActionTargetDetailsProperties>> targets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionName"))
                {
                    actionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionId"))
                {
                    actionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("targets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ExperimentExecutionActionTargetDetailsProperties> array = new List<ExperimentExecutionActionTargetDetailsProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExperimentExecutionActionTargetDetailsProperties.DeserializeExperimentExecutionActionTargetDetailsProperties(item));
                    }
                    targets = array;
                    continue;
                }
            }
            return new ActionStatus(actionName.Value, actionId.Value, status.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToList(targets));
        }
    }
}
