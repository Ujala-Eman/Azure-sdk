// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelReference))
            {
                writer.WritePropertyName("channelReference"u8);
                writer.WriteStringValue(ChannelReference);
            }
            if (Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
            }
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                writer.WritePropertyName("classificationPolicyId"u8);
                writer.WriteStringValue(ClassificationPolicyId);
            }
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(DispositionCode))
            {
                writer.WritePropertyName("dispositionCode"u8);
                writer.WriteStringValue(DispositionCode);
            }
            if (Optional.IsCollectionDefined(RequestedWorkerSelectors))
            {
                writer.WritePropertyName("requestedWorkerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequestedWorkerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStartObject();
                foreach (var item in Notes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(MatchingMode))
            {
                writer.WritePropertyName("matchingMode"u8);
                writer.WriteObjectValue(MatchingMode);
            }
            writer.WriteEndObject();
        }

        internal static RouterJob DeserializeRouterJob(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> channelReference = default;
            Optional<RouterJobStatus> status = default;
            Optional<DateTimeOffset> enqueuedAt = default;
            Optional<string> channelId = default;
            Optional<string> classificationPolicyId = default;
            Optional<string> queueId = default;
            Optional<int> priority = default;
            Optional<string> dispositionCode = default;
            Optional<IList<RouterWorkerSelector>> requestedWorkerSelectors = default;
            Optional<IReadOnlyList<RouterWorkerSelector>> attachedWorkerSelectors = default;
            Optional<IDictionary<string, object>> labels = default;
            Optional<IReadOnlyDictionary<string, RouterJobAssignment>> assignments = default;
            Optional<IDictionary<string, object>> tags = default;
            Optional<IDictionary<string, string>> notes = default;
            Optional<DateTimeOffset> scheduledAt = default;
            Optional<JobMatchingMode> matchingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RouterJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enqueuedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enqueuedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classificationPolicyId"u8))
                {
                    classificationPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dispositionCode"u8))
                {
                    dispositionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    requestedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("attachedWorkerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouterWorkerSelector> array = new List<RouterWorkerSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterWorkerSelector.DeserializeRouterWorkerSelector(item));
                    }
                    attachedWorkerSelectors = array;
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("assignments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RouterJobAssignment> dictionary = new Dictionary<string, RouterJobAssignment>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RouterJobAssignment.DeserializeRouterJobAssignment(property0.Value));
                    }
                    assignments = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("notes"u8))
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
                    notes = dictionary;
                    continue;
                }
                if (property.NameEquals("scheduledAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("matchingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchingMode = JobMatchingMode.DeserializeJobMatchingMode(property.Value);
                    continue;
                }
            }
            return new RouterJob(id.Value, channelReference.Value, Optional.ToNullable(status), Optional.ToNullable(enqueuedAt), channelId.Value, classificationPolicyId.Value, queueId.Value, Optional.ToNullable(priority), dispositionCode.Value, Optional.ToList(requestedWorkerSelectors), Optional.ToList(attachedWorkerSelectors), Optional.ToDictionary(labels), Optional.ToDictionary(assignments), Optional.ToDictionary(tags), Optional.ToDictionary(notes), Optional.ToNullable(scheduledAt), matchingMode.Value);
        }
    }
}
