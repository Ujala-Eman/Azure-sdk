// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class TriggerRun
    {
        internal static TriggerRun DeserializeTriggerRun(JsonElement element)
        {
            Optional<string> triggerRunId = default;
            Optional<string> triggerName = default;
            Optional<string> triggerType = default;
            Optional<DateTimeOffset> triggerRunTimestamp = default;
            Optional<TriggerRunStatus> status = default;
            Optional<string> message = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            Optional<IReadOnlyDictionary<string, string>> triggeredPipelines = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("triggerRunId"))
                {
                    triggerRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerName"))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerType"))
                {
                    triggerType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerRunTimestamp"))
                {
                    triggerRunTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TriggerRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("triggeredPipelines"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    triggeredPipelines = dictionary;
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TriggerRun(triggerRunId.HasValue ? triggerRunId.Value : null, triggerName.HasValue ? triggerName.Value : null, triggerType.HasValue ? triggerType.Value : null, triggerRunTimestamp.HasValue ? triggerRunTimestamp.Value : (DateTimeOffset?)null, status.HasValue ? status.Value : (TriggerRunStatus?)null, message.HasValue ? message.Value : null, new ChangeTrackingDictionary<string, string>(properties), new ChangeTrackingDictionary<string, string>(triggeredPipelines), additionalProperties);
        }
    }
}
